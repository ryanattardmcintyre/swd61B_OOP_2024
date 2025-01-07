using BusinessLogicLayer.DataContext;
using BusinessLogicLayer.Repositories;
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
            //fetch all books
            BooksRepository booksRepository = new BooksRepository(_context);

            var list = booksRepository.GetBooks().ToList() ;

            dgvBooks.DataSource = list; //binding the (tabular/structured) data with the datagridview
           
        }
    }
}
