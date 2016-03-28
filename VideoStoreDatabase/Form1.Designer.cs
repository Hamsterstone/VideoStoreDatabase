namespace VideoStoreDatabase
{
    partial class Form1
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
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMovies = new System.Windows.Forms.TabPage();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tabPageRentals = new System.Windows.Forms.TabPage();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.txtFindCustomer = new System.Windows.Forms.TextBox();
            this.txtFindMovie = new System.Windows.Forms.TextBox();
            this.lblFindMovie = new System.Windows.Forms.Label();
            this.lblFindCustomer = new System.Windows.Forms.Label();
            this.gbxRentalSelect = new System.Windows.Forms.GroupBox();
            this.rbtRentalAll = new System.Windows.Forms.RadioButton();
            this.rbtRentalCurrent = new System.Windows.Forms.RadioButton();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.btnEditCustomers = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtCustDOB = new System.Windows.Forms.TextBox();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.txtMovieYear = new System.Windows.Forms.TextBox();
            this.txtMoviePlot = new System.Windows.Forms.TextBox();
            this.txtMovieRating = new System.Windows.Forms.TextBox();
            this.txtMovieCopies = new System.Windows.Forms.TextBox();
            this.txtMovieGenres = new System.Windows.Forms.TextBox();
            this.txtMovieRentalCost = new System.Windows.Forms.TextBox();
            this.btnEditMovies = new System.Windows.Forms.Button();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustAddress = new System.Windows.Forms.Label();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.lblCustDOB = new System.Windows.Forms.Label();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblMovieYear = new System.Windows.Forms.Label();
            this.lblMoviePlot = new System.Windows.Forms.Label();
            this.lblMovieRating = new System.Windows.Forms.Label();
            this.lblMovieCopies = new System.Windows.Forms.Label();
            this.lblMovieGenres = new System.Windows.Forms.Label();
            this.lblMovieRentCost = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageMovies.SuspendLayout();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabPageRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.gbxRentalSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMovies
            // 
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(0, 0);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.Size = new System.Drawing.Size(730, 321);
            this.dgvMovies.TabIndex = 0;
            this.dgvMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMovies);
            this.tabControl1.Controls.Add(this.tabPageCustomers);
            this.tabControl1.Controls.Add(this.tabPageRentals);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 347);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageMovies
            // 
            this.tabPageMovies.Controls.Add(this.dgvMovies);
            this.tabPageMovies.Location = new System.Drawing.Point(4, 22);
            this.tabPageMovies.Name = "tabPageMovies";
            this.tabPageMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovies.Size = new System.Drawing.Size(730, 321);
            this.tabPageMovies.TabIndex = 0;
            this.tabPageMovies.Text = "Movies";
            this.tabPageMovies.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.dgvCustomers);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomers.Size = new System.Drawing.Size(730, 321);
            this.tabPageCustomers.TabIndex = 1;
            this.tabPageCustomers.Text = "Customers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(730, 321);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // tabPageRentals
            // 
            this.tabPageRentals.Controls.Add(this.dgvRentals);
            this.tabPageRentals.Location = new System.Drawing.Point(4, 22);
            this.tabPageRentals.Name = "tabPageRentals";
            this.tabPageRentals.Size = new System.Drawing.Size(730, 321);
            this.tabPageRentals.TabIndex = 2;
            this.tabPageRentals.Text = "Rentals";
            this.tabPageRentals.UseVisualStyleBackColor = true;
            // 
            // dgvRentals
            // 
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Location = new System.Drawing.Point(0, 0);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.Size = new System.Drawing.Size(730, 321);
            this.dgvRentals.TabIndex = 1;
            // 
            // txtFindCustomer
            // 
            this.txtFindCustomer.Location = new System.Drawing.Point(647, 388);
            this.txtFindCustomer.Name = "txtFindCustomer";
            this.txtFindCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtFindCustomer.TabIndex = 2;
            this.txtFindCustomer.Click += new System.EventHandler(this.SearchBoxClicked);
            this.txtFindCustomer.TextChanged += new System.EventHandler(this.SearchBoxTyping);
            // 
            // txtFindMovie
            // 
            this.txtFindMovie.Location = new System.Drawing.Point(647, 362);
            this.txtFindMovie.Name = "txtFindMovie";
            this.txtFindMovie.Size = new System.Drawing.Size(100, 20);
            this.txtFindMovie.TabIndex = 3;
            this.txtFindMovie.Click += new System.EventHandler(this.SearchBoxClicked);
            this.txtFindMovie.TextChanged += new System.EventHandler(this.SearchBoxTyping);
            // 
            // lblFindMovie
            // 
            this.lblFindMovie.AutoSize = true;
            this.lblFindMovie.Location = new System.Drawing.Point(565, 362);
            this.lblFindMovie.Name = "lblFindMovie";
            this.lblFindMovie.Size = new System.Drawing.Size(59, 13);
            this.lblFindMovie.TabIndex = 4;
            this.lblFindMovie.Text = "Find Movie";
            // 
            // lblFindCustomer
            // 
            this.lblFindCustomer.AutoSize = true;
            this.lblFindCustomer.Location = new System.Drawing.Point(565, 388);
            this.lblFindCustomer.Name = "lblFindCustomer";
            this.lblFindCustomer.Size = new System.Drawing.Size(74, 13);
            this.lblFindCustomer.TabIndex = 5;
            this.lblFindCustomer.Text = "Find Customer";
            // 
            // gbxRentalSelect
            // 
            this.gbxRentalSelect.Controls.Add(this.rbtRentalAll);
            this.gbxRentalSelect.Controls.Add(this.rbtRentalCurrent);
            this.gbxRentalSelect.Location = new System.Drawing.Point(568, 414);
            this.gbxRentalSelect.Name = "gbxRentalSelect";
            this.gbxRentalSelect.Size = new System.Drawing.Size(179, 63);
            this.gbxRentalSelect.TabIndex = 6;
            this.gbxRentalSelect.TabStop = false;
            this.gbxRentalSelect.Text = "Rented Movies";
            // 
            // rbtRentalAll
            // 
            this.rbtRentalAll.AutoSize = true;
            this.rbtRentalAll.Location = new System.Drawing.Point(6, 42);
            this.rbtRentalAll.Name = "rbtRentalAll";
            this.rbtRentalAll.Size = new System.Drawing.Size(75, 17);
            this.rbtRentalAll.TabIndex = 1;
            this.rbtRentalAll.Text = "All Rentals";
            this.rbtRentalAll.UseVisualStyleBackColor = true;
            this.rbtRentalAll.CheckedChanged += new System.EventHandler(this.RentalSelect);
            // 
            // rbtRentalCurrent
            // 
            this.rbtRentalCurrent.AutoSize = true;
            this.rbtRentalCurrent.Checked = true;
            this.rbtRentalCurrent.Location = new System.Drawing.Point(6, 19);
            this.rbtRentalCurrent.Name = "rbtRentalCurrent";
            this.rbtRentalCurrent.Size = new System.Drawing.Size(98, 17);
            this.rbtRentalCurrent.TabIndex = 0;
            this.rbtRentalCurrent.TabStop = true;
            this.rbtRentalCurrent.Text = "Current Rentals";
            this.rbtRentalCurrent.UseVisualStyleBackColor = true;
            this.rbtRentalCurrent.CheckedChanged += new System.EventHandler(this.RentalSelect);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.ForeColor = System.Drawing.Color.Red;
            this.btnIssueMovie.Location = new System.Drawing.Point(574, 483);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(65, 55);
            this.btnIssueMovie.TabIndex = 7;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = true;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueRental_Click);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.Color.Teal;
            this.btnReturnMovie.Location = new System.Drawing.Point(657, 483);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(65, 55);
            this.btnReturnMovie.TabIndex = 8;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnRental_Click);
            // 
            // btnEditCustomers
            // 
            this.btnEditCustomers.Location = new System.Drawing.Point(12, 365);
            this.btnEditCustomers.Name = "btnEditCustomers";
            this.btnEditCustomers.Size = new System.Drawing.Size(88, 23);
            this.btnEditCustomers.TabIndex = 9;
            this.btnEditCustomers.Text = "Edit Customers";
            this.btnEditCustomers.UseVisualStyleBackColor = true;
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(12, 407);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(32, 20);
            this.txtCustID.TabIndex = 10;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(50, 407);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(118, 20);
            this.txtCustName.TabIndex = 11;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(174, 407);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(150, 20);
            this.txtCustAddress.TabIndex = 12;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(330, 407);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(100, 20);
            this.txtCustPhone.TabIndex = 13;
            // 
            // txtCustDOB
            // 
            this.txtCustDOB.Location = new System.Drawing.Point(436, 407);
            this.txtCustDOB.Name = "txtCustDOB";
            this.txtCustDOB.Size = new System.Drawing.Size(100, 20);
            this.txtCustDOB.TabIndex = 14;
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(12, 476);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(32, 20);
            this.txtMovieID.TabIndex = 15;
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(50, 476);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(118, 20);
            this.txtMovieTitle.TabIndex = 16;
            // 
            // txtMovieYear
            // 
            this.txtMovieYear.Location = new System.Drawing.Point(174, 476);
            this.txtMovieYear.Name = "txtMovieYear";
            this.txtMovieYear.Size = new System.Drawing.Size(67, 20);
            this.txtMovieYear.TabIndex = 17;
            // 
            // txtMoviePlot
            // 
            this.txtMoviePlot.Location = new System.Drawing.Point(247, 476);
            this.txtMoviePlot.Name = "txtMoviePlot";
            this.txtMoviePlot.Size = new System.Drawing.Size(289, 20);
            this.txtMoviePlot.TabIndex = 18;
            // 
            // txtMovieRating
            // 
            this.txtMovieRating.Location = new System.Drawing.Point(12, 515);
            this.txtMovieRating.Name = "txtMovieRating";
            this.txtMovieRating.Size = new System.Drawing.Size(100, 20);
            this.txtMovieRating.TabIndex = 19;
            // 
            // txtMovieCopies
            // 
            this.txtMovieCopies.Location = new System.Drawing.Point(118, 515);
            this.txtMovieCopies.Name = "txtMovieCopies";
            this.txtMovieCopies.Size = new System.Drawing.Size(100, 20);
            this.txtMovieCopies.TabIndex = 20;
            // 
            // txtMovieGenres
            // 
            this.txtMovieGenres.Location = new System.Drawing.Point(224, 515);
            this.txtMovieGenres.Name = "txtMovieGenres";
            this.txtMovieGenres.Size = new System.Drawing.Size(100, 20);
            this.txtMovieGenres.TabIndex = 21;
            // 
            // txtMovieRentalCost
            // 
            this.txtMovieRentalCost.Location = new System.Drawing.Point(330, 515);
            this.txtMovieRentalCost.Name = "txtMovieRentalCost";
            this.txtMovieRentalCost.Size = new System.Drawing.Size(100, 20);
            this.txtMovieRentalCost.TabIndex = 22;
            // 
            // btnEditMovies
            // 
            this.btnEditMovies.Location = new System.Drawing.Point(12, 433);
            this.btnEditMovies.Name = "btnEditMovies";
            this.btnEditMovies.Size = new System.Drawing.Size(88, 23);
            this.btnEditMovies.TabIndex = 23;
            this.btnEditMovies.Text = "Edit Movies";
            this.btnEditMovies.UseVisualStyleBackColor = true;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(9, 391);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(39, 13);
            this.lblCustID.TabIndex = 24;
            this.lblCustID.Text = "CustID";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(47, 391);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(35, 13);
            this.lblCustName.TabIndex = 25;
            this.lblCustName.Text = "Name";
            // 
            // lblCustAddress
            // 
            this.lblCustAddress.AutoSize = true;
            this.lblCustAddress.Location = new System.Drawing.Point(171, 391);
            this.lblCustAddress.Name = "lblCustAddress";
            this.lblCustAddress.Size = new System.Drawing.Size(45, 13);
            this.lblCustAddress.TabIndex = 26;
            this.lblCustAddress.Text = "Address";
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Location = new System.Drawing.Point(327, 391);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(38, 13);
            this.lblCustPhone.TabIndex = 27;
            this.lblCustPhone.Text = "Phone";
            // 
            // lblCustDOB
            // 
            this.lblCustDOB.AutoSize = true;
            this.lblCustDOB.Location = new System.Drawing.Point(433, 391);
            this.lblCustDOB.Name = "lblCustDOB";
            this.lblCustDOB.Size = new System.Drawing.Size(30, 13);
            this.lblCustDOB.TabIndex = 28;
            this.lblCustDOB.Text = "DOB";
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Location = new System.Drawing.Point(9, 460);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(18, 13);
            this.lblMovieID.TabIndex = 29;
            this.lblMovieID.Text = "ID";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(47, 460);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(27, 13);
            this.lblMovieTitle.TabIndex = 30;
            this.lblMovieTitle.Text = "Title";
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Location = new System.Drawing.Point(171, 460);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(29, 13);
            this.lblMovieYear.TabIndex = 31;
            this.lblMovieYear.Text = "Year";
            // 
            // lblMoviePlot
            // 
            this.lblMoviePlot.AutoSize = true;
            this.lblMoviePlot.Location = new System.Drawing.Point(244, 460);
            this.lblMoviePlot.Name = "lblMoviePlot";
            this.lblMoviePlot.Size = new System.Drawing.Size(25, 13);
            this.lblMoviePlot.TabIndex = 32;
            this.lblMoviePlot.Text = "Plot";
            // 
            // lblMovieRating
            // 
            this.lblMovieRating.AutoSize = true;
            this.lblMovieRating.Location = new System.Drawing.Point(9, 499);
            this.lblMovieRating.Name = "lblMovieRating";
            this.lblMovieRating.Size = new System.Drawing.Size(38, 13);
            this.lblMovieRating.TabIndex = 33;
            this.lblMovieRating.Text = "Rating";
            // 
            // lblMovieCopies
            // 
            this.lblMovieCopies.AutoSize = true;
            this.lblMovieCopies.Location = new System.Drawing.Point(115, 499);
            this.lblMovieCopies.Name = "lblMovieCopies";
            this.lblMovieCopies.Size = new System.Drawing.Size(39, 13);
            this.lblMovieCopies.TabIndex = 34;
            this.lblMovieCopies.Text = "Copies";
            // 
            // lblMovieGenres
            // 
            this.lblMovieGenres.AutoSize = true;
            this.lblMovieGenres.Location = new System.Drawing.Point(221, 499);
            this.lblMovieGenres.Name = "lblMovieGenres";
            this.lblMovieGenres.Size = new System.Drawing.Size(41, 13);
            this.lblMovieGenres.TabIndex = 35;
            this.lblMovieGenres.Text = "Genres";
            // 
            // lblMovieRentCost
            // 
            this.lblMovieRentCost.AutoSize = true;
            this.lblMovieRentCost.Location = new System.Drawing.Point(327, 499);
            this.lblMovieRentCost.Name = "lblMovieRentCost";
            this.lblMovieRentCost.Size = new System.Drawing.Size(62, 13);
            this.lblMovieRentCost.TabIndex = 36;
            this.lblMovieRentCost.Text = "Rental Cost";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(759, 373);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 559);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblMovieRentCost);
            this.Controls.Add(this.lblMovieGenres);
            this.Controls.Add(this.lblMovieCopies);
            this.Controls.Add(this.lblMovieRating);
            this.Controls.Add(this.lblMoviePlot);
            this.Controls.Add(this.lblMovieYear);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.lblCustDOB);
            this.Controls.Add(this.lblCustPhone);
            this.Controls.Add(this.lblCustAddress);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.btnEditMovies);
            this.Controls.Add(this.txtMovieRentalCost);
            this.Controls.Add(this.txtMovieGenres);
            this.Controls.Add(this.txtMovieCopies);
            this.Controls.Add(this.txtMovieRating);
            this.Controls.Add(this.txtMoviePlot);
            this.Controls.Add(this.txtMovieYear);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.txtCustDOB);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.btnEditCustomers);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.btnIssueMovie);
            this.Controls.Add(this.gbxRentalSelect);
            this.Controls.Add(this.lblFindCustomer);
            this.Controls.Add(this.lblFindMovie);
            this.Controls.Add(this.txtFindMovie);
            this.Controls.Add(this.txtFindCustomer);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMovies.ResumeLayout(false);
            this.tabPageCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabPageRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.gbxRentalSelect.ResumeLayout(false);
            this.gbxRentalSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMovies;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TabPage tabPageRentals;
        private System.Windows.Forms.TextBox txtFindCustomer;
        private System.Windows.Forms.TextBox txtFindMovie;
        private System.Windows.Forms.Label lblFindMovie;
        private System.Windows.Forms.Label lblFindCustomer;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.GroupBox gbxRentalSelect;
        private System.Windows.Forms.RadioButton rbtRentalAll;
        private System.Windows.Forms.RadioButton rbtRentalCurrent;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button btnEditCustomers;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustDOB;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.TextBox txtMovieYear;
        private System.Windows.Forms.TextBox txtMoviePlot;
        private System.Windows.Forms.TextBox txtMovieRating;
        private System.Windows.Forms.TextBox txtMovieCopies;
        private System.Windows.Forms.TextBox txtMovieGenres;
        private System.Windows.Forms.TextBox txtMovieRentalCost;
        private System.Windows.Forms.Button btnEditMovies;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustAddress;
        private System.Windows.Forms.Label lblCustPhone;
        private System.Windows.Forms.Label lblCustDOB;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblMovieYear;
        private System.Windows.Forms.Label lblMoviePlot;
        private System.Windows.Forms.Label lblMovieRating;
        private System.Windows.Forms.Label lblMovieCopies;
        private System.Windows.Forms.Label lblMovieGenres;
        private System.Windows.Forms.Label lblMovieRentCost;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

