using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBookingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Account accountForm = new Account();
            accountForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string user = Userlabel.Text;
            string play = PlayTitle.Text;
            string ticketType = (sender as Button).Text;
            int cost = Convert.ToInt32(Standardlabel.Text);
            int quantity = Convert.ToInt32(NUD1.Value);
            DateTime date = PlayDate.SelectionRange.Start;


            ChosenPlays chosenPlays = new ChosenPlays();
            chosenPlays.AddToOrder(user, play, cost, quantity, date, ticketType);
            MessageBox.Show("Item Added");
        }


        private void Child_Click(object sender, EventArgs e)
        {
            string user = Userlabel.Text;
            string play = PlayTitle.Text;
            string ticketType = (sender as Button).Text;
            int cost = Convert.ToInt32(Childlabel.Text);
            int quantity = Convert.ToInt32(NUD2.Value);
            DateTime date = PlayDate.SelectionRange.Start;


            ChosenPlays chosenPlays = new ChosenPlays();
            chosenPlays.AddToOrder(user, play, cost, quantity, date, ticketType);
            MessageBox.Show("Item Added");
        }

        private void Elderly_Click(object sender, EventArgs e)
        {
            string user = Userlabel.Text;
            string play = PlayTitle.Text;
            string ticketType = (sender as Button).Text;
            int cost = Convert.ToInt32(OAPlabel.Text);
            int quantity = Convert.ToInt32(NUD3.Value);
            DateTime date = PlayDate.SelectionRange.Start;


            ChosenPlays chosenPlays = new ChosenPlays();
            chosenPlays.AddToOrder(user, play, cost, quantity, date, ticketType);
            MessageBox.Show("Item Added");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            BasketForm basketForm = new BasketForm();
            basketForm.ShowDialog();
        }
    }
}
