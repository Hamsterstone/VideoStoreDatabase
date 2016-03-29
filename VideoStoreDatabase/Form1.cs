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
            dgvMovies.DataSource = null;
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
                        txtMovieRentalCost.Text = fakeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtMovieCopies.Text = fakeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                        txtMoviePlot.Text = fakeDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                        txtMovieGenres.Text = fakeDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    }
                }else if (sender == dgvCustomers)
                {
                    if (e.RowIndex >= 0)
                    {
                        txtCustID.Text = fakeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtCustName.Text = fakeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtCustName.Text += fakeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtCustAddress.Text = fakeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtCustPhone.Text = fakeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                        
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
        //edit movie click: open new form to add/update/delete movies.
        //edit customers as above
    }
}
