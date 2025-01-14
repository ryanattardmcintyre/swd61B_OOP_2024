using BusinessLogicLayer.DataContext;
using BusinessLogicLayer.Repositories;
using CommonDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationDesktopApp
{
    public partial class frmLibraryManagement : Form
    {
        private LibraryContext _context;
        public frmLibraryManagement(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
            
        }

        private void frmLibraryManagement_Load(object sender, EventArgs e)
        {
            RefreshList();
           
            //binding to a comboBox
            CategoriesRepository categoriesRepository = new CategoriesRepository(_context);
            cmbCategory.DataSource = categoriesRepository.GetCategories();
            cmbCategory.DisplayMember = "Name"; //specifies which column to show to the user
            cmbCategory.ValueMember = "Id";  //specifies which column to consider when processing the chosen category


        }

        //a special method which is triggered upon clicking on the menu: list books
        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var ctrl in this.Controls) //foreach control in this form
            {
                if (ctrl.GetType() == typeof(GroupBox)) //if it is a GroupBox (and not anything else)
                {
                    ((GroupBox)ctrl).Visible = false; //typecasting/converting the ctrl into a GroupBox
                                                      //and hide it
                }
            }


            grpListOfBooks.Location = new Point(29, 52);
            grpListOfBooks.Visible = true; //unhide that groupbox and its contents
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in this.Controls) //foreach control in this form
            {
                if (ctrl.GetType() == typeof(GroupBox)) //if it is a GroupBox (and not anything else)
                {
                    ((GroupBox)ctrl).Visible = false; //typecasting/converting the ctrl into a GroupBox
                                                      //and hide it
                }
            }
            grpAddBook.Location = new Point(29, 52);
            grpAddBook.Visible = true; //unhide that groupbox and its contents
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Book myBook = new Book();
            myBook.Isbn = Convert.ToInt32(txtIsbn.Text);
            myBook.Title = txtTitle.Text;
            myBook.Author = txtAuthor.Text;
            myBook.Year = Convert.ToInt32(txtYear.Text);
            myBook.CategoryFK = Convert.ToInt32(cmbCategory.SelectedValue);

            //adding the book into the db
            BooksRepository booksRepository = new BooksRepository(_context);
            booksRepository.AddBook(myBook);

            MessageBox.Show("Book added successfully");
            //refreshing the listbox to display an updated list

            RefreshList();  
        }

        private void RefreshList()
        {
            BooksRepository booksRepository = new BooksRepository(_context); 
            var list = booksRepository.GetBooks().ToList();
            //binding to a DataGridView
            dgvBooks.DataSource = list; //binding the (tabular/structured) data with the datagridview
        }
    }
}
