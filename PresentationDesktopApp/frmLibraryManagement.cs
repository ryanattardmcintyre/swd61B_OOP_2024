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
        string _username;
        public frmLibraryManagement(LibraryContext context, string username)
        {
            InitializeComponent();
            _context = context;
            _username = username; //username will have some valid data after the actual user has logged in successfully from Form1
            
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

        private void goBackToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //this refers to the current instance of the control we are in i.e. Form2 (frmLibraryManagement)
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //this exists the entire application
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in this.Controls) //foreach control in this form
            {
                if (ctrl.GetType() == typeof(GroupBox)) //if it is a GroupBox (and not anything else)
                {
                    ((GroupBox)ctrl).Visible = false; //typecasting/converting the ctrl into a GroupBox
                                                      //and hide it
                }
            }
            grpDelete.Location = new Point(663, 62);
            grpDelete.Visible = true; //unhide that groupbox and its contents
            grpListOfBooks.Visible = true;

        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 1)
            {
                string isbn = dgvBooks.SelectedRows[0].Cells["Isbn"].Value.ToString();

                txtIsbnToDelete.Text = isbn;
                btnDeleteBook.Enabled = true;
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            BooksRepository booksRepository = new BooksRepository(_context);
            booksRepository.DeleteBook(Convert.ToInt32(txtIsbnToDelete.Text));

            MessageBox.Show("Deleted book successfully!");

            RefreshList();

            txtIsbnToDelete.Clear(); btnDeleteBook.Enabled = false;
        }

        private void btnReserveBook_Click(object sender, EventArgs e)
        {
            ReservationsRepository reservationsRepository = new ReservationsRepository(_context);

            Reservation myReservation = new Reservation();
            myReservation.BookFK = Convert.ToInt32(txtIsbnToReserve.Text);
            myReservation.From = dtpReserveFrom.Value;
            myReservation.Days = Convert.ToInt32(nudDays.Value);
            myReservation.UsernameFK = _username;

            reservationsRepository.AddReservation(myReservation);

            MessageBox.Show("Reservation placed successfully!");


        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in this.Controls) //foreach control in this form
            {
                if (ctrl.GetType() == typeof(GroupBox)) //if it is a GroupBox (and not anything else)
                {
                    ((GroupBox)ctrl).Visible = false; //typecasting/converting the ctrl into a GroupBox
                                                      //and hide it
                }
            }
            grpAddReservation.Location = new Point(663, 62);
            grpAddReservation.Visible = true; //unhide that groupbox and its contents
            grpListOfBooks.Visible = true;
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in this.Controls) //foreach control in this form
            {
                if (ctrl.GetType() == typeof(GroupBox)) //if it is a GroupBox (and not anything else)
                {
                    ((GroupBox)ctrl).Visible = false; //typecasting/converting the ctrl into a GroupBox
                                                      //and hide it
                }
            }

            grpHistory.Visible = true;
            grpHistory.Location = new Point(60, 45);

            //get the reservations

            ReservationsRepository reservationsRepository = new ReservationsRepository(_context);
            var list = reservationsRepository.GetReservations(_username);

            //to eliminate showing navigational properties
            var displayList = from r in list
                              select new
                              {
                                  Isbn = r.BookFK,
                                  Book = r.Book.Title,
                                  From = r.From.ToShortDateString(),
                                  To = r.From.AddDays(r.Days).ToShortDateString()
                              };

            dgvHistory.DataSource = displayList.ToList();
        }
    }
}
