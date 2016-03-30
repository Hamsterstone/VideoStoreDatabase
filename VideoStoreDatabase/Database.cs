﻿using System;
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
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        private SqlDataAdapter myDataAdapter = new SqlDataAdapter();

        public Database()
        {
            string connectionString =
                @"Data Source=TREAD\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True";
            connection.ConnectionString = connectionString;
            command.Connection = connection;
        }

        public DataTable FillDatatable(string table)
        {
            DataTable myDataTable = new DataTable();

            SqlCommand myCommand = connection.CreateCommand();
            myCommand.Connection = connection;
            myCommand.CommandText = "ShowAllFrom";
            myCommand.CommandType = CommandType.StoredProcedure;
              myCommand.Parameters.AddWithValue("@ViewName", table);
            using (myDataAdapter = new SqlDataAdapter(myCommand))
            {
                connection.Open();
                myDataAdapter.Fill(myDataTable);
                connection.Close();
            }
            return myDataTable;





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
            //}
        }

        public DataTable SearchForItem(string table, string item)
        {
            DataTable myDataTable = new DataTable();

            SqlCommand myCommand = connection.CreateCommand();
            myCommand.Connection = connection;

            if (table == "Movies")
            {
                myCommand.CommandText = "FindFromMovies";
            }else if(table== "Customer")


            { myCommand.CommandText = "FindFromCustomer";
                    
            }
           


           // myCommand.CommandText = "ShowAllFrom";
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@Find", item);
            using (myDataAdapter = new SqlDataAdapter(myCommand))
            {
                connection.Open();
                myDataAdapter.Fill(myDataTable);
                connection.Close();
            }
            return myDataTable;

            
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
            //}
        }

        public DataTable RentalDataSelect(string select)
        {
            DataTable myDataTable = new DataTable();

            SqlCommand myCommand = connection.CreateCommand();
            myCommand.Connection = connection;

            if (select == "NOTAll")
            {
                myCommand.CommandText = "ShowAllFrom";
                myCommand.Parameters.AddWithValue("@ViewName", "CurrentRentals");
            }
            else if (select == "All")


            {
                myCommand.CommandText = "ShowAllFrom";
                myCommand.Parameters.AddWithValue("@ViewName", "AllRentals");
            }



            // myCommand.CommandText = "ShowAllFrom";
            myCommand.CommandType = CommandType.StoredProcedure;
           // myCommand.Parameters.AddWithValue("@Find", item);
            using (myDataAdapter = new SqlDataAdapter(myCommand))
            {
                connection.Open();
                myDataAdapter.Fill(myDataTable);
                connection.Close();
            }
            return myDataTable;



            //DataTable myDataTable = new DataTable();


            ////TO DO: Remove all sql queries and replace with procedure calls.
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
            //}
        }
     //rental return if returndate==null then returndate = date. make date field for debug, note date to be system date.
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

        } //}
        //rental issue, take movieID, CustID, date(see above) create new rental.
        public void CreateNewRental(int movieID, int customerID, DateTime date)
        {
            try
            {
                SqlCommand myCommand = connection.CreateCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = "CreateRental";
                myCommand.CommandType=CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@MovieIDFK", movieID);
                myCommand.Parameters.AddWithValue("@CustomerIDFK", customerID);
                myCommand.Parameters.AddWithValue("@DateRented", date);
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
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
                

            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
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
