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
            this.btnAdminOnOff = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtCustFirstname = new System.Windows.Forms.TextBox();
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
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCustFirstname = new System.Windows.Forms.Label();
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
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnDeleteRental = new System.Windows.Forms.Button();
            this.btnUpdateRental = new System.Windows.Forms.Button();
            this.lblRentalDateReturned = new System.Windows.Forms.Label();
            this.txtRentalDateReturned = new System.Windows.Forms.TextBox();
            this.lblRentalDateRented = new System.Windows.Forms.Label();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.txtRentalDateRented = new System.Windows.Forms.TextBox();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.lblCustLastname = new System.Windows.Forms.Label();
            this.txtCustLastname = new System.Windows.Forms.TextBox();
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
            this.dgvRentals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // txtFindCustomer
            // 
            this.txtFindCustomer.Location = new System.Drawing.Point(841, 390);
            this.txtFindCustomer.Name = "txtFindCustomer";
            this.txtFindCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtFindCustomer.TabIndex = 2;
            this.txtFindCustomer.Click += new System.EventHandler(this.SearchBoxClicked);
            this.txtFindCustomer.TextChanged += new System.EventHandler(this.SearchBoxTyping);
            // 
            // txtFindMovie
            // 
            this.txtFindMovie.Location = new System.Drawing.Point(841, 364);
            this.txtFindMovie.Name = "txtFindMovie";
            this.txtFindMovie.Size = new System.Drawing.Size(100, 20);
            this.txtFindMovie.TabIndex = 3;
            this.txtFindMovie.Click += new System.EventHandler(this.SearchBoxClicked);
            this.txtFindMovie.TextChanged += new System.EventHandler(this.SearchBoxTyping);
            // 
            // lblFindMovie
            // 
            this.lblFindMovie.AutoSize = true;
            this.lblFindMovie.Location = new System.Drawing.Point(759, 364);
            this.lblFindMovie.Name = "lblFindMovie";
            this.lblFindMovie.Size = new System.Drawing.Size(59, 13);
            this.lblFindMovie.TabIndex = 4;
            this.lblFindMovie.Text = "Find Movie";
            // 
            // lblFindCustomer
            // 
            this.lblFindCustomer.AutoSize = true;
            this.lblFindCustomer.Location = new System.Drawing.Point(759, 390);
            this.lblFindCustomer.Name = "lblFindCustomer";
            this.lblFindCustomer.Size = new System.Drawing.Size(74, 13);
            this.lblFindCustomer.TabIndex = 5;
            this.lblFindCustomer.Text = "Find Customer";
            // 
            // gbxRentalSelect
            // 
            this.gbxRentalSelect.Controls.Add(this.rbtRentalAll);
            this.gbxRentalSelect.Controls.Add(this.rbtRentalCurrent);
            this.gbxRentalSelect.Location = new System.Drawing.Point(762, 416);
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
            this.btnIssueMovie.Location = new System.Drawing.Point(768, 485);
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
            this.btnReturnMovie.Location = new System.Drawing.Point(851, 485);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(65, 55);
            this.btnReturnMovie.TabIndex = 8;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnRental_Click);
            // 
            // btnAdminOnOff
            // 
            this.btnAdminOnOff.Location = new System.Drawing.Point(759, 34);
            this.btnAdminOnOff.Name = "btnAdminOnOff";
            this.btnAdminOnOff.Size = new System.Drawing.Size(312, 27);
            this.btnAdminOnOff.TabIndex = 9;
            this.btnAdminOnOff.Text = "AdminTools";
            this.btnAdminOnOff.UseVisualStyleBackColor = true;
            this.btnAdminOnOff.Click += new System.EventHandler(this.btnAdminOnOff_Click);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(12, 383);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(44, 20);
            this.txtCustID.TabIndex = 10;
            // 
            // txtCustFirstname
            // 
            this.txtCustFirstname.Location = new System.Drawing.Point(62, 383);
            this.txtCustFirstname.Name = "txtCustFirstname";
            this.txtCustFirstname.Size = new System.Drawing.Size(118, 20);
            this.txtCustFirstname.TabIndex = 11;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(310, 383);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(150, 20);
            this.txtCustAddress.TabIndex = 12;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(466, 383);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(100, 20);
            this.txtCustPhone.TabIndex = 13;
            // 
            // txtCustDOB
            // 
            this.txtCustDOB.Location = new System.Drawing.Point(572, 383);
            this.txtCustDOB.Name = "txtCustDOB";
            this.txtCustDOB.Size = new System.Drawing.Size(100, 20);
            this.txtCustDOB.TabIndex = 14;
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(12, 432);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(44, 20);
            this.txtMovieID.TabIndex = 15;
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(62, 432);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(118, 20);
            this.txtMovieTitle.TabIndex = 16;
            // 
            // txtMovieYear
            // 
            this.txtMovieYear.Location = new System.Drawing.Point(186, 432);
            this.txtMovieYear.Name = "txtMovieYear";
            this.txtMovieYear.Size = new System.Drawing.Size(67, 20);
            this.txtMovieYear.TabIndex = 17;
            // 
            // txtMoviePlot
            // 
            this.txtMoviePlot.Location = new System.Drawing.Point(259, 432);
            this.txtMoviePlot.Name = "txtMoviePlot";
            this.txtMoviePlot.Size = new System.Drawing.Size(289, 20);
            this.txtMoviePlot.TabIndex = 18;
            // 
            // txtMovieRating
            // 
            this.txtMovieRating.Location = new System.Drawing.Point(12, 474);
            this.txtMovieRating.Name = "txtMovieRating";
            this.txtMovieRating.Size = new System.Drawing.Size(112, 20);
            this.txtMovieRating.TabIndex = 19;
            // 
            // txtMovieCopies
            // 
            this.txtMovieCopies.Location = new System.Drawing.Point(130, 474);
            this.txtMovieCopies.Name = "txtMovieCopies";
            this.txtMovieCopies.Size = new System.Drawing.Size(100, 20);
            this.txtMovieCopies.TabIndex = 20;
            // 
            // txtMovieGenres
            // 
            this.txtMovieGenres.Location = new System.Drawing.Point(236, 474);
            this.txtMovieGenres.Name = "txtMovieGenres";
            this.txtMovieGenres.Size = new System.Drawing.Size(100, 20);
            this.txtMovieGenres.TabIndex = 21;
            // 
            // txtMovieRentalCost
            // 
            this.txtMovieRentalCost.Location = new System.Drawing.Point(342, 474);
            this.txtMovieRentalCost.Name = "txtMovieRentalCost";
            this.txtMovieRentalCost.Size = new System.Drawing.Size(100, 20);
            this.txtMovieRentalCost.TabIndex = 22;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(9, 367);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(39, 13);
            this.lblCustID.TabIndex = 24;
            this.lblCustID.Text = "CustID";
            // 
            // lblCustFirstname
            // 
            this.lblCustFirstname.AutoSize = true;
            this.lblCustFirstname.Location = new System.Drawing.Point(59, 367);
            this.lblCustFirstname.Name = "lblCustFirstname";
            this.lblCustFirstname.Size = new System.Drawing.Size(52, 13);
            this.lblCustFirstname.TabIndex = 25;
            this.lblCustFirstname.Text = "Firstname";
            // 
            // lblCustAddress
            // 
            this.lblCustAddress.AutoSize = true;
            this.lblCustAddress.Location = new System.Drawing.Point(307, 367);
            this.lblCustAddress.Name = "lblCustAddress";
            this.lblCustAddress.Size = new System.Drawing.Size(45, 13);
            this.lblCustAddress.TabIndex = 26;
            this.lblCustAddress.Text = "Address";
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Location = new System.Drawing.Point(463, 367);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(38, 13);
            this.lblCustPhone.TabIndex = 27;
            this.lblCustPhone.Text = "Phone";
            // 
            // lblCustDOB
            // 
            this.lblCustDOB.AutoSize = true;
            this.lblCustDOB.Location = new System.Drawing.Point(569, 367);
            this.lblCustDOB.Name = "lblCustDOB";
            this.lblCustDOB.Size = new System.Drawing.Size(30, 13);
            this.lblCustDOB.TabIndex = 28;
            this.lblCustDOB.Text = "DOB";
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Location = new System.Drawing.Point(9, 416);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(47, 13);
            this.lblMovieID.TabIndex = 29;
            this.lblMovieID.Text = "MovieID";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(59, 416);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(27, 13);
            this.lblMovieTitle.TabIndex = 30;
            this.lblMovieTitle.Text = "Title";
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Location = new System.Drawing.Point(183, 416);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(29, 13);
            this.lblMovieYear.TabIndex = 31;
            this.lblMovieYear.Text = "Year";
            // 
            // lblMoviePlot
            // 
            this.lblMoviePlot.AutoSize = true;
            this.lblMoviePlot.Location = new System.Drawing.Point(256, 416);
            this.lblMoviePlot.Name = "lblMoviePlot";
            this.lblMoviePlot.Size = new System.Drawing.Size(25, 13);
            this.lblMoviePlot.TabIndex = 32;
            this.lblMoviePlot.Text = "Plot";
            // 
            // lblMovieRating
            // 
            this.lblMovieRating.AutoSize = true;
            this.lblMovieRating.Location = new System.Drawing.Point(9, 458);
            this.lblMovieRating.Name = "lblMovieRating";
            this.lblMovieRating.Size = new System.Drawing.Size(38, 13);
            this.lblMovieRating.TabIndex = 33;
            this.lblMovieRating.Text = "Rating";
            // 
            // lblMovieCopies
            // 
            this.lblMovieCopies.AutoSize = true;
            this.lblMovieCopies.Location = new System.Drawing.Point(127, 458);
            this.lblMovieCopies.Name = "lblMovieCopies";
            this.lblMovieCopies.Size = new System.Drawing.Size(39, 13);
            this.lblMovieCopies.TabIndex = 34;
            this.lblMovieCopies.Text = "Copies";
            // 
            // lblMovieGenres
            // 
            this.lblMovieGenres.AutoSize = true;
            this.lblMovieGenres.Location = new System.Drawing.Point(233, 458);
            this.lblMovieGenres.Name = "lblMovieGenres";
            this.lblMovieGenres.Size = new System.Drawing.Size(41, 13);
            this.lblMovieGenres.TabIndex = 35;
            this.lblMovieGenres.Text = "Genres";
            // 
            // lblMovieRentCost
            // 
            this.lblMovieRentCost.AutoSize = true;
            this.lblMovieRentCost.Location = new System.Drawing.Point(339, 458);
            this.lblMovieRentCost.Name = "lblMovieRentCost";
            this.lblMovieRentCost.Size = new System.Drawing.Size(62, 13);
            this.lblMovieRentCost.TabIndex = 36;
            this.lblMovieRentCost.Text = "Rental Cost";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(758, 193);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 37;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Enabled = false;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(972, 67);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteCustomer.TabIndex = 71;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnAdminButton_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Enabled = false;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(857, 67);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(109, 23);
            this.btnUpdateCustomer.TabIndex = 70;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnAdminButton_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Enabled = false;
            this.btnAddCustomer.Location = new System.Drawing.Point(762, 67);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(88, 23);
            this.btnAddCustomer.TabIndex = 69;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAdminButton_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Enabled = false;
            this.btnDeleteMovie.Location = new System.Drawing.Point(972, 96);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteMovie.TabIndex = 74;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnAdminButton_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Enabled = false;
            this.btnUpdateMovie.Location = new System.Drawing.Point(857, 96);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(109, 23);
            this.btnUpdateMovie.TabIndex = 73;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnAdminButton_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Enabled = false;
            this.btnAddMovie.Location = new System.Drawing.Point(762, 96);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(88, 23);
            this.btnAddMovie.TabIndex = 72;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAdminButton_Click);
            // 
            // btnDeleteRental
            // 
            this.btnDeleteRental.Enabled = false;
            this.btnDeleteRental.Location = new System.Drawing.Point(972, 125);
            this.btnDeleteRental.Name = "btnDeleteRental";
            this.btnDeleteRental.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteRental.TabIndex = 85;
            this.btnDeleteRental.Text = "Delete Rental";
            this.btnDeleteRental.UseVisualStyleBackColor = true;
            this.btnDeleteRental.Click += new System.EventHandler(this.btnAdminButton_Click);
            // 
            // btnUpdateRental
            // 
            this.btnUpdateRental.Enabled = false;
            this.btnUpdateRental.Location = new System.Drawing.Point(857, 125);
            this.btnUpdateRental.Name = "btnUpdateRental";
            this.btnUpdateRental.Size = new System.Drawing.Size(109, 23);
            this.btnUpdateRental.TabIndex = 84;
            this.btnUpdateRental.Text = "Update Rental";
            this.btnUpdateRental.UseVisualStyleBackColor = true;
            this.btnUpdateRental.Click += new System.EventHandler(this.btnAdminButton_Click);
            // 
            // lblRentalDateReturned
            // 
            this.lblRentalDateReturned.AutoSize = true;
            this.lblRentalDateReturned.Location = new System.Drawing.Point(165, 504);
            this.lblRentalDateReturned.Name = "lblRentalDateReturned";
            this.lblRentalDateReturned.Size = new System.Drawing.Size(74, 13);
            this.lblRentalDateReturned.TabIndex = 97;
            this.lblRentalDateReturned.Text = "DateReturned";
            // 
            // txtRentalDateReturned
            // 
            this.txtRentalDateReturned.Location = new System.Drawing.Point(168, 520);
            this.txtRentalDateReturned.Name = "txtRentalDateReturned";
            this.txtRentalDateReturned.Size = new System.Drawing.Size(100, 20);
            this.txtRentalDateReturned.TabIndex = 96;
            // 
            // lblRentalDateRented
            // 
            this.lblRentalDateRented.AutoSize = true;
            this.lblRentalDateRented.Location = new System.Drawing.Point(59, 504);
            this.lblRentalDateRented.Name = "lblRentalDateRented";
            this.lblRentalDateRented.Size = new System.Drawing.Size(65, 13);
            this.lblRentalDateRented.TabIndex = 95;
            this.lblRentalDateRented.Text = "DateRented";
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Location = new System.Drawing.Point(9, 504);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(49, 13);
            this.lblRentalID.TabIndex = 91;
            this.lblRentalID.Text = "RentalID";
            // 
            // txtRentalDateRented
            // 
            this.txtRentalDateRented.Location = new System.Drawing.Point(62, 520);
            this.txtRentalDateRented.Name = "txtRentalDateRented";
            this.txtRentalDateRented.Size = new System.Drawing.Size(100, 20);
            this.txtRentalDateRented.TabIndex = 90;
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(12, 520);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(44, 20);
            this.txtRentalID.TabIndex = 86;
            // 
            // lblCustLastname
            // 
            this.lblCustLastname.AutoSize = true;
            this.lblCustLastname.Location = new System.Drawing.Point(183, 367);
            this.lblCustLastname.Name = "lblCustLastname";
            this.lblCustLastname.Size = new System.Drawing.Size(53, 13);
            this.lblCustLastname.TabIndex = 99;
            this.lblCustLastname.Text = "Lastname";
            // 
            // txtCustLastname
            // 
            this.txtCustLastname.Location = new System.Drawing.Point(186, 383);
            this.txtCustLastname.Name = "txtCustLastname";
            this.txtCustLastname.Size = new System.Drawing.Size(118, 20);
            this.txtCustLastname.TabIndex = 98;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 559);
            this.Controls.Add(this.lblCustLastname);
            this.Controls.Add(this.txtCustLastname);
            this.Controls.Add(this.lblRentalDateReturned);
            this.Controls.Add(this.txtRentalDateReturned);
            this.Controls.Add(this.lblRentalDateRented);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.txtRentalDateRented);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.btnDeleteRental);
            this.Controls.Add(this.btnUpdateRental);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
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
            this.Controls.Add(this.lblCustFirstname);
            this.Controls.Add(this.lblCustID);
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
            this.Controls.Add(this.txtCustFirstname);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.btnAdminOnOff);
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
        private System.Windows.Forms.Button btnAdminOnOff;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtCustFirstname;
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
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblCustFirstname;
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
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnDeleteRental;
        private System.Windows.Forms.Button btnUpdateRental;
        private System.Windows.Forms.Label lblRentalDateReturned;
        private System.Windows.Forms.TextBox txtRentalDateReturned;
        private System.Windows.Forms.Label lblRentalDateRented;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.TextBox txtRentalDateRented;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Label lblCustLastname;
        private System.Windows.Forms.TextBox txtCustLastname;
    }
}

