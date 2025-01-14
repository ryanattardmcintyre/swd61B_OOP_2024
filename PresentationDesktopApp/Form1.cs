using BusinessLogicLayer.DataContext;
using BusinessLogicLayer.Repositories;

namespace PresentationDesktopApp
{
    public partial class frmLogin : Form
    {

        //why did we amend the constructor to accept a parameter of type LibraryContext?
        //> reason is so that the instance of the database class is created in a central place which
        //  is the Main method inside the Program.cs and then through the constructor of
        //  ANY control/form that we will eventually create we can use always the same object i.e. db

        // Also we assigned the received object (with data) into a field, reason is so we can make calls
        // on that object from any method/event that we will create in this class

        // In other words, it is important that you keep your (data) instances central and intialized ONE time
        private LibraryContext _libraryContext;
        public frmLogin(LibraryContext context)
        {
            _libraryContext = context;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //event: which is a special method which is triggered when the end-user
        //       interacts (by clicking on the button) with the control
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //1. to create a MembersRepository instance -

            MembersRepository membersRepository = new MembersRepository(_libraryContext);

            //2. we need to call the Login method providing it with the captured username and password
            //   from the textboxes (in console we used to use Console.ReadLine());

            bool result = membersRepository.Login(txtUsername.Text, txtPassword.Text);
            if (result == true)
            {
                //MessageBox is a built-in control which cannot be found in the Toolbox, but it offers
                // you a modal popup on screen
                MessageBox.Show("Login was successful. Proceed.");

                //passing the _libraryContext passed from the Main, will keep consistency in using
                //the same database object

                frmLibraryManagement frmLibraryManagement = new frmLibraryManagement(_libraryContext, txtUsername.Text);
                frmLibraryManagement.Show();

            }
            else
            {
                MessageBox.Show("Access Denied");
            }


        }
    }
}