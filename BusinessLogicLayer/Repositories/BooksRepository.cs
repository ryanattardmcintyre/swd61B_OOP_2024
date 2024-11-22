using BusinessLogicLayer.DataContext;
using CommonDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    //note: Repository classes will enables us to read or write data direction from/to the database

    public class BooksRepository
    {
        //the instance of LibraryContext will allow me to access the data via pre-coded built-in methods
        //in few words: _context is your database
        private LibraryContext _context;

        //the idea of having a constructor with a parameter (of the database) is to keep the instance of the database
        //centralized so we don't create redundant copies of the database, but we always consume/use the same instance
        //So using ONE Instance of the database throughout the entire class/ application avoid us situations where we have
        //duplicate records, missing records
        public BooksRepository(LibraryContext context) 
        {
            _context = context;
        }

        //CRUD = Create Read Update Delete

        //Read method
        //We are returning an IQueryable of Books which is like a List of Books however IQueryable is more efficient
        //because it doesnt return all the books instantly, but it will wait until we add .ToList to it
        //The IQueryable (in the background) prepares an sql statement to be executed and ultimately returns a list (of books)


        //static polymorphism - overload the methods in the same class i.e more than 1 method called the same however they vary
        //                      with the parameters
        //dynamic polymorphism - overriding the methods in the base classes
        public IQueryable<Book> GetBooks()
        {
            //advantages we gain with LINQ over using SQL
            //1. compiler assistance
            //2. we get to code much less
            //3. code is less complex

            //Linq - to- entities : Approach 1
            return _context.Books; //Select * From Books

            //(raw) LINQ // Approach 2
           /* var books = from b in _context.Books
                        select b;
            return books;
           */
        }

        public IQueryable<Book> GetBooks(string keyword)
        {   //always assume that _context (Which represents the database) has already been instantiated

            //Select * From Books Where Name like '%'+keyword+'%'

            // <identifier> lambda <condition>
            //approach 1
            return _context.Books.Where(b => b.Title.Contains(keyword)); //returns a List<Book> 

            //approach 2
            /*var books = from b in _context.Books
                        where b.Title.Contains(keyword)
                        select b;
            return books;
            */
        }

        public IQueryable<Book> GetBooks(int categoryId)
        {
            return _context.Books.Where(b => b.CategoryFK ==  categoryId);
        }


        public Book GetBook(int isbn) {

            return _context.Books.SingleOrDefault(b => b.Isbn == isbn);
            //note: method above can return also a null value if the isbn doesnt exist in the database
        }

        public IQueryable<Book> SortBooks(IQueryable<Book> books) {
            return books.OrderBy(b => b.Title);
        }

        public IQueryable<Book> GetBooks(int yearFrom, int yearTo)
        {
            return _context.Books.Where(b => b.Year >= yearFrom && b.Year <= yearTo);
        }


        //Add
        public void AddBook(Book book)
        {
            _context.Books.Add(book); //stopping here does not save the book permanently in the database
            _context.SaveChanges();

        }

        //Update
        public void UpdateBook(Book book)
        {
            var oldBook = GetBook(book.Isbn); //i'm expecting that the isbn is passed as well
            //in memory the oldBook is still pointing to the one saved in database

            //note: in this approach Isbn is not allowed to be changed/edited/updated
            if (oldBook != null) //there is some book to update
            {
                oldBook.Author = book.Author;
                oldBook.Title =   book.Title;
                oldBook.Year = book.Year;
                oldBook.CategoryFK = book.CategoryFK;
                _context.SaveChanges(); //changes are now updated even in the db

                //book instance (which is the parameter) will be lost after this method exits
                //garbage collector which goes through the variables created in memory and are idle and clears them
            }
        }
        //Delete
        public void DeleteBook(int isbn)
        {
            var bookToDelete = GetBook(isbn);
            if (bookToDelete != null) //because if book is null, there is no book to delete
            {
                _context.Books.Remove(bookToDelete);
                _context.SaveChanges(); //not applying the SaveChanges, it won't affect the database
            }
        }


    }
}
