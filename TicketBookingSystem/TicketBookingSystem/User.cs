using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TicketBookingSystem
{
    abstract class User
    {

        public int ID;
        public string userName;
        public string password;
        public string forName;
        public string surName;
        public string address;
        public string phoneNumber;
        public string email;
        public bool staff;



        //public abstract User(int id, string user, string pass, string forname, string surname);

        public abstract void Login(string user, string pass, bool staff);
        //public abstract void Logout();
        public abstract void AddUser(string user, string pass, string forname, string surname, string address, string phoneNumber, string email);
        public abstract void DeleteUser();
        public abstract void DisplayProfile();
        public abstract void GetUserInfo();
        //public abstract void BrowsePlays();

    }



    class Customer : User
    {
        //int customerID;

        

        

        public override void AddUser(string user, string pass, string forname, string surname, string address, string phoneNumber, string email)
        {

            //id = customerID;
            //add = address;
            


            //needs to write to database 
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);

            OleDbCommand myCommand = new OleDbCommand("INSERT INTO User (Forename, Surname, Username, [Password], PhoneNumber, Address, Email) VALUES (?, ?, ?, ?, ?, ?, ?)", myConnection);

            myCommand.Parameters.AddWithValue("@Forname", forname);
            myCommand.Parameters.AddWithValue("@Surname", surname);
            myCommand.Parameters.AddWithValue("@Username", user);
            myCommand.Parameters.AddWithValue("@Password", pass);
            myCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            myCommand.Parameters.AddWithValue("@Address", address);
            myCommand.Parameters.AddWithValue("@Email", email);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }

        public override void DeleteUser()
        {
            //delete row from database
        }

        public override void DisplayProfile()
        {
            //show details from database or local variables
        }

        public override void Login(string user, string pass, bool staff)
        {
            //search database for password and username and if staff or not 
        }

        public override void GetUserInfo()
        {
            //read from database 
        }

        public void ViewOrderHistory()
        {

        }

        public void EditPersonalDetails()
        {

        }

    }

    class Staff : User
    {
        //int staffID;



        public override void AddUser(string user, string pass, string forname, string surname, string address, string phoneNumber, string email)
        {
            //id = staffID;
        }

        public override void DeleteUser()
        {

        }

        public override void DisplayProfile()
        {

        }

        public override void GetUserInfo()
        {

        }

        public override void Login(string user, string pass, bool staff)
        {

        }

        public void DeleteReviews()
        {

        }

        public void AddPlay()
        {

        }

        public void EditPlay()
        {

        }

        public void DeletePlay()
        {

        }


    }
}
