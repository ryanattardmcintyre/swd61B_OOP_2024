namespace PresentationDesktopApp
{
    partial class frmLibraryManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpListOfBooks = new System.Windows.Forms.GroupBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAddBook = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.txtIsbnToDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpAddReservation = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.btnReserveBook = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpReserveFrom = new System.Windows.Forms.DateTimePicker();
            this.txtIsbnToReserve = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpHistory = new System.Windows.Forms.GroupBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.grpListOfBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpAddBook.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.grpAddReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.grpHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListOfBooks
            // 
            this.grpListOfBooks.Controls.Add(this.dgvBooks);
            this.grpListOfBooks.Location = new System.Drawing.Point(29, 52);
            this.grpListOfBooks.Name = "grpListOfBooks";
            this.grpListOfBooks.Size = new System.Drawing.Size(600, 547);
            this.grpListOfBooks.TabIndex = 0;
            this.grpListOfBooks.TabStop = false;
            this.grpListOfBooks.Text = "Books";
            this.grpListOfBooks.Visible = false;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(60, 45);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 29;
            this.dgvBooks.Size = new System.Drawing.Size(483, 484);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.SelectionChanged += new System.EventHandler(this.dgvBooks_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.reservationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToLoginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // goBackToLoginToolStripMenuItem
            // 
            this.goBackToLoginToolStripMenuItem.Name = "goBackToLoginToolStripMenuItem";
            this.goBackToLoginToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.goBackToLoginToolStripMenuItem.Text = "Go Back to Login";
            this.goBackToLoginToolStripMenuItem.Click += new System.EventHandler(this.goBackToLoginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.historyToolStripMenuItem});
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // grpAddBook
            // 
            this.grpAddBook.Controls.Add(this.btnAddBook);
            this.grpAddBook.Controls.Add(this.cmbCategory);
            this.grpAddBook.Controls.Add(this.label5);
            this.grpAddBook.Controls.Add(this.txtYear);
            this.grpAddBook.Controls.Add(this.label4);
            this.grpAddBook.Controls.Add(this.txtAuthor);
            this.grpAddBook.Controls.Add(this.label3);
            this.grpAddBook.Controls.Add(this.txtTitle);
            this.grpAddBook.Controls.Add(this.label2);
            this.grpAddBook.Controls.Add(this.txtIsbn);
            this.grpAddBook.Controls.Add(this.label1);
            this.grpAddBook.Location = new System.Drawing.Point(668, 62);
            this.grpAddBook.Name = "grpAddBook";
            this.grpAddBook.Size = new System.Drawing.Size(495, 330);
            this.grpAddBook.TabIndex = 2;
            this.grpAddBook.TabStop = false;
            this.grpAddBook.Text = "Adding a Book";
            this.grpAddBook.Visible = false;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(321, 283);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(94, 29);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(147, 228);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(268, 28);
            this.cmbCategory.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Category";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(147, 176);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(268, 27);
            this.txtYear.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Year";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(147, 131);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(268, 27);
            this.txtAuthor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(147, 84);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(268, 27);
            this.txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(147, 39);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(268, 27);
            this.txtIsbn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isbn";
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.btnDeleteBook);
            this.grpDelete.Controls.Add(this.txtIsbnToDelete);
            this.grpDelete.Controls.Add(this.label6);
            this.grpDelete.Location = new System.Drawing.Point(669, 415);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(494, 166);
            this.grpDelete.TabIndex = 3;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete a Book";
            this.grpDelete.Visible = false;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Enabled = false;
            this.btnDeleteBook.Location = new System.Drawing.Point(283, 109);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(131, 29);
            this.btnDeleteBook.TabIndex = 4;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // txtIsbnToDelete
            // 
            this.txtIsbnToDelete.Location = new System.Drawing.Point(146, 55);
            this.txtIsbnToDelete.Name = "txtIsbnToDelete";
            this.txtIsbnToDelete.Size = new System.Drawing.Size(268, 27);
            this.txtIsbnToDelete.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Isbn";
            // 
            // grpAddReservation
            // 
            this.grpAddReservation.Controls.Add(this.label9);
            this.grpAddReservation.Controls.Add(this.nudDays);
            this.grpAddReservation.Controls.Add(this.btnReserveBook);
            this.grpAddReservation.Controls.Add(this.label8);
            this.grpAddReservation.Controls.Add(this.dtpReserveFrom);
            this.grpAddReservation.Controls.Add(this.txtIsbnToReserve);
            this.grpAddReservation.Controls.Add(this.label7);
            this.grpAddReservation.Location = new System.Drawing.Point(669, 630);
            this.grpAddReservation.Name = "grpAddReservation";
            this.grpAddReservation.Size = new System.Drawing.Size(600, 281);
            this.grpAddReservation.TabIndex = 4;
            this.grpAddReservation.TabStop = false;
            this.grpAddReservation.Text = "Add a reservation";
            this.grpAddReservation.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "How Many Days";
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(206, 167);
            this.nudDays.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(268, 27);
            this.nudDays.TabIndex = 9;
            this.nudDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnReserveBook
            // 
            this.btnReserveBook.Location = new System.Drawing.Point(318, 229);
            this.btnReserveBook.Name = "btnReserveBook";
            this.btnReserveBook.Size = new System.Drawing.Size(156, 29);
            this.btnReserveBook.TabIndex = 8;
            this.btnReserveBook.Text = "Reserve a Book";
            this.btnReserveBook.UseVisualStyleBackColor = true;
            this.btnReserveBook.Click += new System.EventHandler(this.btnReserveBook_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Reserve From Date";
            // 
            // dtpReserveFrom
            // 
            this.dtpReserveFrom.Location = new System.Drawing.Point(206, 112);
            this.dtpReserveFrom.Name = "dtpReserveFrom";
            this.dtpReserveFrom.Size = new System.Drawing.Size(270, 27);
            this.dtpReserveFrom.TabIndex = 6;
            // 
            // txtIsbnToReserve
            // 
            this.txtIsbnToReserve.Location = new System.Drawing.Point(206, 50);
            this.txtIsbnToReserve.Name = "txtIsbnToReserve";
            this.txtIsbnToReserve.Size = new System.Drawing.Size(270, 27);
            this.txtIsbnToReserve.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Isbn";
            // 
            // grpHistory
            // 
            this.grpHistory.Controls.Add(this.dgvHistory);
            this.grpHistory.Location = new System.Drawing.Point(28, 637);
            this.grpHistory.Name = "grpHistory";
            this.grpHistory.Size = new System.Drawing.Size(601, 377);
            this.grpHistory.TabIndex = 5;
            this.grpHistory.TabStop = false;
            this.grpHistory.Text = "History Of Reservations";
            this.grpHistory.Visible = false;
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(34, 48);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 29;
            this.dgvHistory.Size = new System.Drawing.Size(510, 298);
            this.dgvHistory.TabIndex = 0;
            // 
            // frmLibraryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 1026);
            this.Controls.Add(this.grpHistory);
            this.Controls.Add(this.grpAddReservation);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpAddBook);
            this.Controls.Add(this.grpListOfBooks);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLibraryManagement";
            this.Text = "frmLibraryManagement";
            this.Load += new System.EventHandler(this.frmLibraryManagement_Load);
            this.grpListOfBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpAddBook.ResumeLayout(false);
            this.grpAddBook.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.grpAddReservation.ResumeLayout(false);
            this.grpAddReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.grpHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpListOfBooks;
        private DataGridView dgvBooks;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem goBackToLoginToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem reservationsToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem1;
        private GroupBox grpAddBook;
        private TextBox txtIsbn;
        private Label label1;
        private Button btnAddBook;
        private ComboBox cmbCategory;
        private Label label5;
        private TextBox txtYear;
        private Label label4;
        private TextBox txtAuthor;
        private Label label3;
        private TextBox txtTitle;
        private Label label2;
        private ToolStripMenuItem historyToolStripMenuItem;
        private GroupBox grpDelete;
        private Button btnDeleteBook;
        private TextBox txtIsbnToDelete;
        private Label label6;
        private GroupBox grpAddReservation;
        private Button btnReserveBook;
        private Label label8;
        private DateTimePicker dtpReserveFrom;
        private TextBox txtIsbnToReserve;
        private Label label7;
        private Label label9;
        private NumericUpDown nudDays;
        private GroupBox grpHistory;
        private DataGridView dgvHistory;
    }
}