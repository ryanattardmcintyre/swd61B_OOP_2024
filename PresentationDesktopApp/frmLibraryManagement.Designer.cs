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
            this.grpListOfBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListOfBooks
            // 
            this.grpListOfBooks.Controls.Add(this.dgvBooks);
            this.grpListOfBooks.Location = new System.Drawing.Point(67, 12);
            this.grpListOfBooks.Name = "grpListOfBooks";
            this.grpListOfBooks.Size = new System.Drawing.Size(600, 547);
            this.grpListOfBooks.TabIndex = 0;
            this.grpListOfBooks.TabStop = false;
            this.grpListOfBooks.Text = "Books";
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
            // 
            // frmLibraryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 655);
            this.Controls.Add(this.grpListOfBooks);
            this.Name = "frmLibraryManagement";
            this.Text = "frmLibraryManagement";
            this.Load += new System.EventHandler(this.frmLibraryManagement_Load);
            this.grpListOfBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpListOfBooks;
        private DataGridView dgvBooks;
    }
}