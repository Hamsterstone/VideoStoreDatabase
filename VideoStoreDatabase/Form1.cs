using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoStoreDatabase
{
    public partial class Form1 : Form
    {
        Database myDatabase = new Database();
        Dictionary<string, int> ratingDictionary=new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
            LoadDatabase();
            PopulateRatingDictionary();
        }

        //Method fills the datagridviews 
        public void LoadDatabase()
        {
            //clear the datagridviews
            dgvMovies.DataSource = null;
            dgvCustomers.DataSource = null;
            dgvRentals.DataSource = null;
            try
            {
                //call Database.FillDatatable method, passing the table to be filled, send that data to the datatable
                dgvMovies.DataSource = myDatabase.FillDatatable("Movies");
                //size the datatable columns to the data sent (works about half the time)
                dgvMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvCustomers.DataSource = myDatabase.FillDatatable("Customer");
                dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                //call RentalSelect method to fill the Rental Datatable
                RentalSelect();
                //dgvRentals.DataSource = myDatabase.RentalDataSelect("NOTAll");
                //dgvRentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //method to fill the rating dictionary to keep it out of the fields area, should only be called once at form load
        public void PopulateRatingDictionary()
        {
            ratingDictionary.Add("Approved", 0);//(database rating listing, age to check against)
            ratingDictionary.Add("G", 0);
            ratingDictionary.Add("N/A", 18);
            ratingDictionary.Add("NC-17", 18);
            ratingDictionary.Add("Not Rated", 18);
            ratingDictionary.Add("PG", 0);
            ratingDictionary.Add("PG-13", 13);
            ratingDictionary.Add("R", 18);
            ratingDictionary.Add("TV-14", 14);
            ratingDictionary.Add("TV-MA", 16);
            ratingDictionary.Add("TV-PG", 0);
            ratingDictionary.Add("Unrated", 18);
            ratingDictionary.Add("X", 18);
            ratingDictionary.Add("M", 16);
        }

       

        //method called then a searchbox is clicked to flick to tab 
        public void SearchBoxClicked(object sender, EventArgs e)
        {

            TextBox fakeTextBox = sender as TextBox;
            if (fakeTextBox.Name == "txtFindMovie")
            {
                //switch to the right tab
                tabControl1.SelectedTab = tabPageMovies;
                //put the cursor focus back in the search textbox
                txtFindMovie.Focus();
            }
            else if (fakeTextBox.Name == "txtFindCustomer")
            {
                tabControl1.SelectedTab = tabPageCustomers;
                txtFindCustomer.Focus();
            }
        }

        //method to search for text as typed into the search textboxes
        public void SearchBoxTyping(object sender, EventArgs e)
        {
            TextBox fakeTextBox = sender as TextBox;
            try
            {

                switch (fakeTextBox.Name)
                {
                    case "txtFindMovie":
                        //fill the appropriate datatable with the Database.SearchForItem method sending the table name and search string
                        dgvMovies.DataSource = myDatabase.SearchForItem("Movies", txtFindMovie.Text);
                        dgvMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;
                    case "txtFindCustomer":
                        dgvCustomers.DataSource = myDatabase.SearchForItem("Customer", txtFindCustomer.Text);
                        dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //method called when rental select radiobutton is clicked
        public void RentalSelect_Clicked(object sender, EventArgs e)
        {
            //run rentalselect method. Kept seperate so LoadDatabase can also call RentalSelect without passing object or eventargs
            RentalSelect();
        }

        //Method that decides what data to display in the Rentals tab datagridview
        public void RentalSelect()
        {
            //is the "Current Rentals" radiobutton checked?
            switch (rbtRentalCurrent.Checked)
            {
                //fill with the appropriate return from Database.RentalDataSelect method
                case true:
                    dgvRentals.DataSource = myDatabase.RentalDataSelect("NOTAll");
                    dgvRentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    break;
                case false:
                    dgvRentals.DataSource = myDatabase.RentalDataSelect("All");
                    dgvRentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    break;
            }
        }

        //method called when a Movies/Customers/Rental cell is clicked
        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView fakeDataGridView = sender as DataGridView;
            try
            {
                
                //work out which datagridview is sending the cell click
                //could be tidied into switch/cases
                if (sender == dgvMovies)
                {

                    //if you are clicking on a row and not outside it
                    if (e.RowIndex >= 0)
                    {
                        //fill the text boxes with from the datatable
                        lblMovieIDActual.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtMovieRating.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtMovieTitle.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtMovieYear.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtMovieRentalCost.Text = "$"+Convert.ToString(RentalCalculator(txtMovieYear.Text));//special case, calculated external to the database/datatable
                        txtMovieCopies.Text = fakeDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                        txtMoviePlot.Text = fakeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtMovieGenres.Text = fakeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                        
                    }
                }else if (sender == dgvCustomers)
                {
                    if (e.RowIndex >= 0)
                    {
                        lblCustIDActual.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtCustFirstname.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtCustLastname.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtCustAddress.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtCustPhone.Text = fakeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtCustDOB.Text= fakeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

                    }
                }else if (sender == dgvRentals)
                {
                    if (e.RowIndex >= 0)
                    {
                        //blank the unnecessary textboxes
                        lblMovieIDActual.Text = "";
                        txtMovieRating.Text = "";
                        txtMovieYear.Text = "";
                        txtMovieRentalCost.Text = "";
                        txtMovieCopies.Text = "";
                        txtMoviePlot.Text = "";
                        txtMovieGenres.Text = "";
                        lblCustIDActual.Text = "";
                        txtCustAddress.Text = "";
                        txtCustPhone.Text = "";
                        

                        lblRentalIDActual.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtCustFirstname.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtCustLastname.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtMovieTitle.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtRentalDateRented.Text = DateTime.Parse( fakeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString()).ToShortDateString();
                        //checks for empty field in rental return date to avoid downstream exceptions
                        if(fakeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString()!="")
                        { txtRentalDateReturned.Text = DateTime.Parse(fakeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString()).ToShortDateString();}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //method called when the IssueRental button is clicked
        //new rental: pass date,movieID and CustID to DB method
        public void btnIssueRental_Click(object sender, EventArgs e)
        {
            //ensure only one date is selected on the calendar
            if (monthCalendar1.SelectionStart.ToShortDateString() != monthCalendar1.SelectionEnd.ToShortDateString())
            {
                MessageBox.Show("Select a single date.");

            }
            else
            {
                //call OkToRent to ensure movie is allowed to be rented to this customer
                if (OkToRent()==false)
                {
                    MessageBox.Show("Rental Denied");
                }
                //if ok to rent
                else
                {
                    //create the data to pass
                    DateTime date = monthCalendar1.SelectionStart;
                    int movieID = Convert.ToInt32(lblMovieIDActual.Text);
                    int customerID = Convert.ToInt32(lblCustIDActual.Text);
                    //Pass the data to the Database.CreateNewRental method. Note: Make sure you pass movieID&CustomerID in the right order or everything goes pear shaped.
                    myDatabase.CreateNewRental(movieID, customerID, date);
                    LoadDatabase();
                }
            }
        }

        public bool OkToRent()
        {
            //Check there is a valid DOB to check and call IsOldEnough method with customer DOB and movie rating
            if (txtCustDOB.Text != "" && IsOldEnough(DateTime.Parse(txtCustDOB.Text), txtMovieRating.Text) == false)
            {
                //Warn operator movie may be inapropriate for customer and ask to confirm/deny rental
                DialogResult dialogResult = MessageBox.Show("Allow rental?",
                    "WARNING: Customer may be too young to rent this movie.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //on override
                    return true;
                }
                //on override denied
                return false;
            }
            //on IsOldEnough passed (or no DOB)
            return true;
        }
        //method to compare customer DOB vs movie rating
        public bool IsOldEnough(DateTime dob, string rating)
        {
            //find customer's age from DOB
            TimeSpan ageTimespan = DateTime.Now.Subtract(dob);
            int age = ageTimespan.Days/365;
            //find age from rating dictionary
            int ratingAge = ratingDictionary[rating];
            //return whether old enough to rent movie
            if (age > ratingAge)
            {
                return true;
            }
            return false;
        }
        //method called when Return Rental button clicked,passes rental ID and date to db method
        public void btnReturnRental_Click(object sender, EventArgs e)
        {

            DataGridView fakeDataGridView = dgvRentals;
            //check only a single date is selected
            if (monthCalendar1.SelectionStart.ToShortDateString() != monthCalendar1.SelectionEnd.ToShortDateString())
            {
                MessageBox.Show("Select a single date.");

            }
            


                else
                {
                    DateTime date = monthCalendar1.SelectionStart;
                    int rentalID = Convert.ToInt32(lblRentalIDActual.Text);
                //int rentalID = Convert.ToInt32(fakeDataGridView.Rows[fakeDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());--old way before lblRentalIDActual existed
                //call Database.ReturnRental, passing rentalID and date
                myDatabase.ReturnRental(rentalID, date);
                //refresh the datagridviews
                LoadDatabase();
                }
            
        }

        //method called when the Admin Tools button is clicked
        private void btnAdminOnOff_Click(object sender, EventArgs e)
        {
            //if the buttons are turned off
            if (btnDeleteCustomer.Enabled == false) {
                
                using (Form passwordForm = new PasswordForm())
                {//if the password returns OK --RE-ENABLE FOR FULL PROGRAM
                   // if (passwordForm.ShowDialog() == DialogResult.OK)
                    {
                        //enable the admin buttons
                        btnAddCustomer.Enabled = true;
                        btnUpdateCustomer.Enabled = true;
                        btnDeleteCustomer.Enabled = true;
                        btnAddMovie.Enabled = true;
                        btnUpdateMovie.Enabled = true;
                        btnDeleteMovie.Enabled = true;
                        btnUpdateRental.Enabled = true;
                        btnDeleteRental.Enabled = true;
                    }
                }
                //if the buttons are turned on
            }else if (btnDeleteCustomer.Enabled == true)
            {//check whether to disable admin buttons--RE-ENABLE FOR FULL PROGRAM
               // DialogResult dialogResult = MessageBox.Show("", "Turn off Admin controls?", MessageBoxButtons.YesNo);
               // if (dialogResult == DialogResult.Yes)
                {
                    //disable the buttons
                    btnAddCustomer.Enabled = false;
                    btnUpdateCustomer.Enabled = false;
                    btnDeleteCustomer.Enabled = false;
                    btnAddMovie.Enabled = false;
                    btnUpdateMovie.Enabled = false;
                    btnDeleteMovie.Enabled = false;
                    btnUpdateRental.Enabled = false;
                    btnDeleteRental.Enabled = false;
                }
               
            }



            
        }
        //method called to calculate the rental cost
        public int RentalCalculator(string movieYear)
        {
            int year = 0;
            int rentCost = 0;
            //check the movie year is valid
            try
            {
                year = int.Parse(movieYear);
            }
            catch
            {
                MessageBox.Show("Year format not supported");
            }
            //calculate and return the rental
            if (DateTime.Now.Year - year > 5)
            {
                rentCost = 2;
            }
            else rentCost = 5;
            return rentCost;
        }

        //method called when an Admin button is clicked
        private void btnAdminButton_Click(object sender, EventArgs e)
        {
            Button fakeButton = sender as Button;
            
            //Old way of collecting the data
            //string[] data = new[]
            //{
            //    lulCustIDActual.Text, txtCustFirstname.Text, txtCustLastname.Text, txtCustAddress.Text, txtCustPhone.Text,
            //    txtCustDOB.Text, lulMovieIDActual.Text, txtMovieTitle.Text, txtMovieYear.Text, txtMoviePlot.Text,
            //    txtMovieRating.Text, txtMovieCopies.Text, txtMovieGenres.Text, txtMovieRentalCost.Text, lulRentalIDActual.Text,
            //    txtRentalDateRented.Text, txtRentalDateReturned.Text
            //};

            //collect all Customer/Movie/Rental data from the form
            Dictionary<string, string> dictData = new Dictionary<string, string>();
            dictData.Add("CustID",lblCustIDActual.Text);
            dictData.Add("CustFirstname", txtCustFirstname.Text);
            dictData.Add("CustLastname", txtCustLastname.Text);
            dictData.Add("CustAddress", txtCustAddress.Text);
            dictData.Add("CustPhone", txtCustPhone.Text);
            dictData.Add("CustDOB", txtCustDOB.Text);
            dictData.Add("MovieID", lblMovieIDActual.Text);
            dictData.Add("MovieTitle", txtMovieTitle.Text);
            dictData.Add("MovieYear", txtMovieYear.Text);
            dictData.Add("MoviePlot", txtMoviePlot.Text);
            dictData.Add("MovieRating", txtMovieRating.Text);
            dictData.Add("MovieCopies", txtMovieCopies.Text);
            dictData.Add("MovieGenres", txtMovieGenres.Text);
            dictData.Add("MovieRentalCost", txtMovieRentalCost.Text);
            dictData.Add("RentalID", lblRentalIDActual.Text);
            dictData.Add("RentalDateRented", txtRentalDateRented.Text);
            dictData.Add("RentalDateReturned", txtRentalDateReturned.Text);



            string buttonName = fakeButton.Text;
            //pass the form data and buton clicked to the Database.AdminTools method
            myDatabase.AdminTools(dictData,buttonName);
            //refresh the datagridviews
            LoadDatabase();
        }
        //method called when a Reports radiobutton is clicked
        public void ReportSelect_Clicked(object sender, EventArgs e)
        {
            //find the radiobutton name
            RadioButton fakeRadioButton=sender as RadioButton;
            string name = fakeRadioButton.Name;
            //pass the name to the ReportSelect method
            ReportSelect(name);
        }
        //method to populate the reports tab datagridview
        public void ReportSelect(string name)
        {
            dgvReports.DataSource = null;

            switch (name)
            {
                case "rbtMostPopMovie":
                    //populate the reports datagridview with the Database.reportSelect method.
                    dgvReports.DataSource = myDatabase.ReportSelect("MostPopMov");
                    dgvReports.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    break;
                case "rbtRentalsByCust":
                    dgvReports.DataSource = myDatabase.ReportSelect("CustMostRent");
                    dgvReports.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    break;

            }
        }
       
    }
}
