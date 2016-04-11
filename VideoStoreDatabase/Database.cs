using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoStoreDatabase
{
    public class Database
    {
        //Create fields for database interactions
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        private SqlDataAdapter myDataAdapter = new SqlDataAdapter();

        //
        public Database()
        {
            //Define the connection parameters for database interactions
            string connectionString =
                @"Data Source=TREAD\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True";
            connection.ConnectionString = connectionString;
            command.Connection = connection;
        }
        //method called to fill a datatable
        public DataTable FillDatatable(string viewname)
        {
            //create a holder datatable
            DataTable myDataTable = new DataTable();
            //define attributes for Sqlcommand "command"
            command = connection.CreateCommand();
            command.Connection = connection;
            //call stored procedure
            command.CommandText = "ShowAllFrom";
            command.CommandType = CommandType.StoredProcedure;
            //define parameters sent to stored procedure
            command.Parameters.AddWithValue("@ViewName", viewname);
            using (myDataAdapter = new SqlDataAdapter(command))
            {
                //open the connection, fill the datatable and close the connection
                connection.Open();
                myDataAdapter.Fill(myDataTable);
                connection.Close();
            }
            //send the datatable to the calling method
            return myDataTable;




            /*//Obsolete code
            //string sqlQuery = @"SELECT * FROM " + table;
            //DataTable myDataTable = new DataTable();
            //using (myDataAdapter = new SqlDataAdapter(sqlQuery, connection))
            //{
            //   // MessageBox.Show(connection.ToString());
            //   // connection.Open();
            //    myDataAdapter.Fill(myDataTable);
            //   // connection.Close();
            //    //connection.Dispose();
            //    return myDataTable;
            //}*/
        }
        //method called to search for a specific item
        public DataTable SearchForItem(string table, string item)
        {
            //set up 
            DataTable myDataTable = new DataTable();
            SqlCommand myCommand = connection.CreateCommand();
            myCommand.Connection = connection;
            //decide which stored procedure to call
            if (table == "Movies")
            {
                myCommand.CommandText = "FindFromMovies";
            }
            else if (table == "Customer")


            {
                myCommand.CommandText = "FindFromCustomer";

            }
            
            myCommand.CommandType = CommandType.StoredProcedure;
            //define the parameters to send
            myCommand.Parameters.AddWithValue("@Find", item);
            //execute the sql query
            using (myDataAdapter = new SqlDataAdapter(myCommand))
            {
                connection.Open();
                myDataAdapter.Fill(myDataTable);
                connection.Close();
            }
            return myDataTable;




            /*//OBSOLETE CODE
            //string sqlQuery = null;
            //DataTable myDataTable = new DataTable();

            //switch (table)
            //{
            //    case "Movies":
            //        sqlQuery = @"SELECT * FROM " + table + " WHERE Title LIKE '%" + item + "%' ORDER by Title";
            //        //   DataTable myDataTable = new DataTable();
            //        using (myDataAdapter = new SqlDataAdapter(sqlQuery, connection))
            //        {
            //            connection.Open();
            //            myDataAdapter.Fill(myDataTable);
            //            connection.Close();
            //            return myDataTable;
            //        }
            //    case "Customer":
            //        sqlQuery = @"SELECT * FROM " + table + " WHERE LastName LIKE '" + item + "%' ORDER by LastName";
            //        //  DataTable myDataTable = new DataTable();
            //        using (myDataAdapter = new SqlDataAdapter(sqlQuery, connection))
            //        {
            //            connection.Open();
            //            myDataAdapter.Fill(myDataTable);
            //            connection.Close();
            //            return myDataTable;
            //        }
            //    default:
            //        MessageBox.Show("Oops! Database.SearchForItem");
            //        return null;
            //}*/
        }
        //method returns data when deciding whether to view all or current rentals
        public DataTable RentalDataSelect(string select)
        {
            //set up
            DataTable myDataTable = new DataTable();
            SqlCommand myCommand = connection.CreateCommand();
            myCommand.Connection = connection;
            //decide which parameters to send
            if (select == "NOTAll")
            {
               // myCommand.CommandText = "ShowAllFrom";
                myCommand.Parameters.AddWithValue("@ViewName", "CurrentRentals");
            }
            else if (select == "All")


            {
                //myCommand.CommandText = "ShowAllFrom";
                myCommand.Parameters.AddWithValue("@ViewName", "AllRentals");
            }



            myCommand.CommandText = "ShowAllFrom";//replace with Commandtext in each if selector if a different stored procedure gets called.
            myCommand.CommandType = CommandType.StoredProcedure;
            //execute the sql query
            using (myDataAdapter = new SqlDataAdapter(myCommand))
            {
                connection.Open();
                myDataAdapter.Fill(myDataTable);
                connection.Close();
            }
            return myDataTable;


           /* //OBSOLETE CODE
            //DataTable myDataTable = new DataTable();


            ////TO DO: Remove all sql queries and replace with procedure calls. done
            //string sqlQuery =
            //    @"SELECT dbo.RentedMovies.RMID, dbo.Customer.FirstName, dbo.Customer.LastName, dbo.Movies.Title, dbo.RentedMovies.DateRented, dbo.RentedMovies.DateReturned FROM dbo.Customer INNER JOIN dbo.RentedMovies ON dbo.Customer.CustID = dbo.RentedMovies.CustIDFK INNER JOIN dbo.Movies ON dbo.RentedMovies.MovieIDFK = dbo.Movies.MovieID";
            //string modifier = "";
            //if (select != "All")
            //{
            //    modifier = " WHERE(dbo.RentedMovies.DateReturned IS NULL)";
            //}

            //using (myDataAdapter = new SqlDataAdapter(sqlQuery + modifier, connection))
            //{

            //    connection.Open();
            //    myDataAdapter.Fill(myDataTable);
            //    connection.Close();
            //   // connection.Dispose();
            //    return myDataTable;
            //}*/
        }

        public void ReturnRental(int rentalID, DateTime date)
        {
            SqlCommand myCommand = connection.CreateCommand();
            myCommand.Connection = connection;
            myCommand.CommandText = "ReturnRental";
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@RentalID", rentalID);
            myCommand.Parameters.AddWithValue("@DateReturned", date);
            connection.Open();
            myCommand.ExecuteNonQuery();
            connection.Close();

            /*//OBSOLETE CODE
            // SqlCommand myCommand=new SqlCommand("UPDATE RentedMovies set DateReturned=@Date where RMID=@rentalID");
            // //using (
            // myCommand.Connection = connection;
            //// {
            //     if (myCommand.Connection.ConnectionString != string.Empty)
            //     {
            //        // myCommand.Parameters.AddWithValue("@MovieID", movieID);
            //     myCommand.Parameters.AddWithValue("@rentalID", rentalID);
            //     myCommand.Parameters.AddWithValue("@date", date);
            //     connection.Open();
            //     myCommand.ExecuteNonQuery();
            //     connection.Close();
            //  }
            // else
            // {
            //     MessageBox.Show("no connectionstring");

            // }

         //}*/
        }

        //rental issue, take movieID, CustID, date(see above) create new rental.
        public void CreateNewRental(int movieID, int customerID, DateTime date)
        {
            try
            {
                SqlCommand myCommand = connection.CreateCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = "CreateRental";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@MovieIDFK", movieID);
                myCommand.Parameters.AddWithValue("@CustomerIDFK", customerID);
                myCommand.Parameters.AddWithValue("@DateRented", date);
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();



               /* //OBSOLETE CODE
                //SqlCommand myCommand =
                //    new SqlCommand(
                //        @"INSERT INTO RentedMovies(MovieIDFK,CustIDFK,DateRented) VALUES(@movieID,@customerID,@date)");
                //    myCommand.Connection = connection;

                //    myCommand.Parameters.AddWithValue("@MovieID", movieID);
                //    myCommand.Parameters.AddWithValue("@CustomerID", customerID);
                //    myCommand.Parameters.AddWithValue("@date", date);
                //    connection.Open();
                //    myCommand.ExecuteNonQuery();
                //    connection.Close();
                */

            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void AdminTools(Dictionary<string, string> data, string action)
        {

            try
            {
                SqlCommand myCommand = connection.CreateCommand();
                myCommand.Connection = connection;
                switch (action)
                {
                    case "Add Movie":
                        myCommand.CommandText = "AdminAddMovie";
                        myCommand.Parameters.AddWithValue("@MovieTitleIn", data["MovieTitle"]);
                        myCommand.Parameters.AddWithValue("@MovieYearIn", data["MovieYear"]);
                        myCommand.Parameters.AddWithValue("@MoviePlotIn", data["MoviePlot"]);
                        myCommand.Parameters.AddWithValue("@MovieRatingIn", data["MovieRating"]);
                        myCommand.Parameters.AddWithValue("@MovieCopiesIn", data["MovieCopies"]);
                        myCommand.Parameters.AddWithValue("@MovieGenresIn", data["MovieGenres"]);
                        break;
                    case "Update Movie":
                        myCommand.CommandText = "AdminUpdateMovie";
                        myCommand.Parameters.AddWithValue("@MovieIDIn", data["MovieID"]);
                        myCommand.Parameters.AddWithValue("@MovieTitleIn", data["MovieTitle"]);
                        myCommand.Parameters.AddWithValue("@MovieYearIn", data["MovieYear"]);
                        myCommand.Parameters.AddWithValue("@MoviePlotIn", data["MoviePlot"]);
                        myCommand.Parameters.AddWithValue("@MovieRatingIn", data["MovieRating"]);
                        myCommand.Parameters.AddWithValue("@MovieCopiesIn", data["MovieCopies"]);
                        myCommand.Parameters.AddWithValue("@MovieGenresIn", data["MovieGenres"]);

                        break;
                    case "Delete Movie":
                        myCommand.CommandText = "AdminDelete";
                        myCommand.Parameters.AddWithValue("@TableNameIn", "Movies");
                        myCommand.Parameters.AddWithValue("@ColumnNameIn", "MovieID");
                        myCommand.Parameters.AddWithValue("@IDNumber", data["MovieID"]);

                        break;
                    case "Add Customer":
                        myCommand.CommandText = "AdminAddCustomer";
                        myCommand.Parameters.AddWithValue("@CustFirstnameIn", data["CustFirstname"]);
                        myCommand.Parameters.AddWithValue("@CustLastnameIn", data["CustLastname"]);
                        myCommand.Parameters.AddWithValue("@CustAddressIn", data["CustAddress"]);
                        myCommand.Parameters.AddWithValue("@CustPhoneIn", data["CustPhone"]);
                        myCommand.Parameters.AddWithValue("@CustDOBIn", data["CustDOB"]);
                        break;

                    case "Update Customer":
                        myCommand.CommandText = "AdminUpdateCustomer";
                        myCommand.Parameters.AddWithValue("@CustIDIn", data["CustID"]);
                        myCommand.Parameters.AddWithValue("@CustFirstnameIn", data["CustFirstname"]);
                        myCommand.Parameters.AddWithValue("@CustLastnameIn", data["CustLastname"]);
                        myCommand.Parameters.AddWithValue("@CustAddressIn", data["CustAddress"]);
                        myCommand.Parameters.AddWithValue("@CustPhoneIn", data["CustPhone"]);
                        myCommand.Parameters.AddWithValue("@CustDOBIn", data["CustDOB"]);

                        break;
                    case "Delete Customer":
                        myCommand.CommandText = "AdminDelete";
                        myCommand.Parameters.AddWithValue("@TableNameIn", "Customer");
                        myCommand.Parameters.AddWithValue("@ColumnNameIn", "CustID");
                        myCommand.Parameters.AddWithValue("@IDNumber", data["CustID"]);
                        break;

                    case "Update Rental":
                        myCommand.CommandText = "AdminUpdateRental";
                        myCommand.Parameters.AddWithValue("@RentalIDIn", data["RentalID"]);
                        myCommand.Parameters.AddWithValue("@RentalDateRentedIn",DateTime.Parse(data["RentalDateRented"]));
                        //avoids errors on empty data from RentalDateReturned
                        if (data["RentalDateReturned"]!="")
                        { myCommand.Parameters.AddWithValue("@RentalDateReturnedIn",DateTime.Parse(data["RentalDateReturned"]));}
                        break;

                    case "Delete Rental":
                        myCommand.CommandText = "AdminDelete";
                        myCommand.Parameters.AddWithValue("@TableNameIn", "RentedMovies");
                        myCommand.Parameters.AddWithValue("@ColumnNameIn", "RMID");
                        myCommand.Parameters.AddWithValue("@IDNumber", data["RentalID"]);

                        break;
                }







                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();


            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }









        }

        public DataTable ReportSelect(string select)
        {
            DataTable myDataTable = new DataTable();

            SqlCommand myCommand = connection.CreateCommand();
            myCommand.Connection = connection;

            if (select == "MostPopMov")
            {
               myCommand.Parameters.AddWithValue("@ViewName", "RentalByPopularity");
            }
            else if (select == "CustMostRent")


            {
               myCommand.Parameters.AddWithValue("@ViewName", "CustomersByNumOfRentals");
            }



             myCommand.CommandText = "ShowAllFrom";
            myCommand.CommandType = CommandType.StoredProcedure;
         
            using (myDataAdapter = new SqlDataAdapter(myCommand))
            {
                connection.Open();
                myDataAdapter.Fill(myDataTable);
                connection.Close();
            }
            return myDataTable;


        }
    

    //add custDOB for age check on rental? discuss with Gary

        public bool UnitTestConnection()
        {
            DataTable myDataTable = new DataTable();
            try
            {
                string sqlQuery = "SELECT * FROM Movies";
                myDataAdapter = new SqlDataAdapter(sqlQuery, connection);
                connection.Open();
                myDataAdapter.Fill(myDataTable);
                connection.Close();

                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }
        }
    }
}
