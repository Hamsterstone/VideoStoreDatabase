﻿using System;
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

        public Form1()
        {
            InitializeComponent();
            LoadDatabase();
        }

        //load first view
        public void LoadDatabase()
        {
            dgvMovies.DataSource = null;
            dgvCustomers.DataSource = null;
            dgvRentals.DataSource = null;
            try
            {
                dgvMovies.DataSource = myDatabase.FillDatatable("Movies");
                dgvMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvCustomers.DataSource = myDatabase.FillDatatable("Customer");
                dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvRentals.DataSource = myDatabase.RentalDataSelect("NOTAll");
                dgvRentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //load views on tab click
        private void TabClick(object sender, EventArgs e)
        {
        }

        //search boxes:
        //flick to tab 
        public void SearchBoxClicked(object sender, EventArgs e)
        {
            TextBox fakeTextBox = sender as TextBox;
            if (fakeTextBox.Name == "txtFindMovie")
            {
                tabControl1.SelectedTab = tabPageMovies;
                txtFindMovie.Focus();
            }
            else if (fakeTextBox.Name == "txtFindCustomer")
            {
                tabControl1.SelectedTab = tabPageCustomers;
                txtFindCustomer.Focus();
            }
        }

        //search for text as typed in --database method?
        public void SearchBoxTyping(object sender, EventArgs e)
        {
            TextBox fakeTextBox = sender as TextBox;
            //dgvMovies.DataSource = null;
            try
            {
                switch (fakeTextBox.Name)
                {
                    case "txtFindMovie":

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

        public void RentalSelect(object sender, EventArgs e)
        {
            RadioButton fakeRadioButton = sender as RadioButton;
            if (fakeRadioButton.Name == "rbtRentalCurrent")
            {
                switch (rbtRentalCurrent.Checked)
                {
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
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView fakeDataGridView = sender as DataGridView;
            //these are the cell clicks for the values in the row that you click on
            try
            {
                if (sender == dgvMovies)
                {

                    //if you are clicking on a row and not outside it
                    if (e.RowIndex >= 0)
                    {
                        txtMovieID.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtMovieRating.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtMovieTitle.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtMovieYear.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtMovieRentalCost.Text = "$"+Convert.ToString(RentalCalculator(txtMovieYear.Text));
                        //fakeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtMovieCopies.Text = fakeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                        txtMoviePlot.Text = fakeDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                        txtMovieGenres.Text = fakeDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                        
                    }
                }else if (sender == dgvCustomers)
                {
                    if (e.RowIndex >= 0)
                    {
                        txtCustID.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtCustFirstname.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtCustLastname.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtCustAddress.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtCustPhone.Text = fakeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                        
                    }
                }else if (sender == dgvRentals)
                {
                    if (e.RowIndex >= 0)
                    {

                        txtMovieID.Text = "";
                        txtMovieRating.Text = "";
                        txtMovieYear.Text = "";
                        txtMovieRentalCost.Text = "";
                        txtMovieCopies.Text = "";
                        txtMoviePlot.Text = "";
                        txtMovieGenres.Text = "";
                        txtCustID.Text = "";
                        txtCustAddress.Text = "";
                        txtCustPhone.Text = "";
                        

                        txtRentalID.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtCustFirstname.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtCustLastname.Text = fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtMovieTitle.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtRentalDateRented.Text = fakeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtRentalDateReturned.Text = fakeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //new rental: pass date,movieID and CustID to DB method

        public void btnIssueRental_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.SelectionStart.ToShortDateString() != monthCalendar1.SelectionEnd.ToShortDateString())
            {
                MessageBox.Show("Select a single date.");

            }
            else
            {
                DateTime date = monthCalendar1.SelectionStart;
                int movieID = Convert.ToInt32(txtMovieID.Text);
                int customerID = Convert.ToInt32(txtCustID.Text);
                //Note: Make sure you pass movieID&CustomerID in the right order or everything goes pear shaped.
                myDatabase.CreateNewRental(movieID, customerID, date);
                LoadDatabase();
            }
        }

        //return rental: pass rental ID and date to db method
        public void btnReturnRental_Click(object sender, EventArgs e)
        {
            DataGridView fakeDataGridView = dgvRentals;
            if (monthCalendar1.SelectionStart.ToShortDateString() != monthCalendar1.SelectionEnd.ToShortDateString())
            {
                MessageBox.Show("Select a single date.");

            }
            else
            {
                DateTime date = monthCalendar1.SelectionStart;
                int rentalID = Convert.ToInt32(fakeDataGridView.Rows[fakeDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());//not working, need selected row index
                myDatabase.ReturnRental(rentalID, date);
                LoadDatabase();
            }
        }

        private void btnAdminOnOff_Click(object sender, EventArgs e)
        {
            if (btnDeleteCustomer.Enabled == false) {
                using (Form passwordForm = new PasswordForm())
                {//REENABLE FOR FULL PROGRAM
                   // if (passwordForm.ShowDialog() == DialogResult.OK)
                    {

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

            }else if (btnDeleteCustomer.Enabled == true)
            {//REENABLE FOR FULL PROGRAM
               // DialogResult dialogResult = MessageBox.Show("", "Turn off Admin controls?", MessageBoxButtons.YesNo);
               // if (dialogResult == DialogResult.Yes)
                {
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

        public int RentalCalculator(string movieYear)
        {
            int year = 0;
            try
            {
                year = int.Parse(movieYear);
               // MessageBox.Show(Convert.ToString(year));
            }
            catch
            {
                MessageBox.Show("Nope");
            }
            int rentCost=0;
            if (DateTime.Now.Year - year > 5)
            {
                rentCost = 2;
            }
            else rentCost = 5;
            return rentCost;
        }
        //edit movie click: open new form to add/update/delete movies.
        //edit customers as above
        private void btnAdminButton_Click(object sender, EventArgs e)
        {
            Button fakeButton = sender as Button;
            string[] data = new[]
            {
                txtCustID.Text, txtCustFirstname.Text, txtCustLastname.Text, txtCustAddress.Text, txtCustPhone.Text,
                txtCustDOB.Text, txtMovieID.Text, txtMovieTitle.Text, txtMovieYear.Text, txtMoviePlot.Text,
                txtMovieRating.Text, txtMovieCopies.Text, txtMovieGenres.Text, txtMovieRentalCost.Text, txtRentalID.Text,
                txtRentalDateRented.Text, txtRentalDateReturned.Text
            };


            Dictionary<string, string> dictData = new Dictionary<string, string>();
            
            dictData.Add("CustID",txtCustID.Text);
            dictData.Add("CustFirstname", txtCustFirstname.Text);
            dictData.Add("CustLastname", txtCustLastname.Text);
            dictData.Add("CustAddress", txtCustAddress.Text);
            dictData.Add("CustPhone", txtCustPhone.Text);
            dictData.Add("CustDOB", txtCustDOB.Text);
            dictData.Add("MovieID", txtMovieID.Text);
            dictData.Add("MovieTitle", txtMovieTitle.Text);
            dictData.Add("MovieYear", txtMovieYear.Text);
            dictData.Add("MoviePlot", txtMoviePlot.Text);
            dictData.Add("MovieRating", txtMovieRating.Text);
            dictData.Add("MovieCopies", txtMovieCopies.Text);
            dictData.Add("MovieGenres", txtMovieGenres.Text);
            dictData.Add("MovieRentalCost", txtMovieRentalCost.Text);
            dictData.Add("RentalID", txtRentalID.Text);
            dictData.Add("RentalDateRented", txtRentalDateRented.Text);
            dictData.Add("RentalDateReturned", txtRentalDateReturned.Text);



            string buttonName = fakeButton.Text;

            myDatabase.AdminTools(dictData,buttonName);
            LoadDatabase();
        }
        
    }
}
