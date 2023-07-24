using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_rental_system
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mother_Panel.Controls.Clear();
            Take_Reservation myForm = new Take_Reservation();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            Mother_Panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mother_Panel.Controls.Clear();
            Reservation_List myForm = new Reservation_List();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            Mother_Panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mother_Panel.Controls.Clear();
            Clients_Management myForm = new Clients_Management();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            Mother_Panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mother_Panel.Controls.Clear();
            Cars_Managment myForm = new Cars_Managment();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            Mother_Panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void btn_take_res_Click(object sender, EventArgs e)
        {
            Mother_Panel.Controls.Clear();
            Take_Reservation myForm = new Take_Reservation();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            Mother_Panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            Mother_Panel.Controls.Clear();
            Reservation_List myForm = new Reservation_List();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            Mother_Panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void btn_reservation_Click_1(object sender, EventArgs e)
        {
            Mother_Panel.Controls.Clear();
            Reservation_List myForm = new Reservation_List();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            Mother_Panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            Mother_Panel.Controls.Clear();
            Clients_Management myForm = new Clients_Management();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            Mother_Panel.Controls.Add(myForm);
            myForm.Show();
        }

        private void btn_cars_management_Click(object sender, EventArgs e)
        {
            Mother_Panel.Controls.Clear();
            Cars_Managment myForm = new Cars_Managment();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            Mother_Panel.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
