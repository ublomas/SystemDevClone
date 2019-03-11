using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TicketBookingSystem
{
    public partial class BasketForm : Form
    {
        public BasketForm()
        {
            InitializeComponent();

            string LoginUsername = "User";
            object[] meta = new object[1];
            bool read = true;
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = C:\Users\user\Desktop\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT * FROM [Basket] WHERE [UserID] = @Username", myConnection);

            myCommand.Parameters.AddWithValue("@Username", LoginUsername);

            OleDbDataReader reader = myCommand.ExecuteReader();

            if (reader.Read() == true)
            {
                do
                {
                    int NumberOfColums = reader.GetValues(meta);
                    int NumberOfRows = reader.GetValues(meta);
                    string play = reader.GetString(1);
                    int quantity = reader.GetInt32(3);
                    string TicketType = reader.GetString(6);

                    {
                        for (int j = 0; j < NumberOfRows; j++)
                            if (TicketType == "<div>Standard</div>")
                            {
                                numericUpDown1.Value += quantity;
                            }
                            else if (TicketType == "<div>Child</div>")
                            {
                                numericUpDown2.Value += quantity;
                            } 
                            else if (TicketType == "<div>OAP</div>")
                            {
                                numericUpDown3.Value += quantity;
                            }
                    }

                    Console.WriteLine();
                    read = reader.Read();
                } while (read == true);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Stand = Convert.ToInt32(numericUpDown1.Value);
            int Child = Convert.ToInt32(numericUpDown2.Value);
            int OAP = Convert.ToInt32(numericUpDown3.Value);

            if (TotalBox.Text == "")
            {
                int Total = (Stand * 8) + (Child * 3) + (OAP * 4);
                TotalBox.Text += Total;
            }
            else
            {
                TotalBox.Text = "";
                int Total = (Stand * 8) + (Child * 3) + (OAP * 4);
                TotalBox.Text += Total;
            }
        }
    }
}

