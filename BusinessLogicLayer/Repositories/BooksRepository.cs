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
        public IQueryable<Book> GetBooks()
        {
            return _context.Books;
        }

        public IQueryable<Book> GetBooks(string keyword)
        { 
        }

        public IQueryable<Book> GetBooks(int categoryId)
        { }


        public Book GetBook(int isbn) { }

        public IQueryable<Book> SortBooks(IQueryable<Book> books) { }

        public IQueryable<Book> GetBooks(int yearFrom, int yearTo)
        { }
    }
}
