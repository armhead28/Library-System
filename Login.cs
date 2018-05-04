using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalData
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Username.Text = " ";
            tb_Password.Text = " ";
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Medicaldb mdb = new Medicaldb();
            mdb.Username = tb_Username.Text;
            mdb.Password = tb_Password.Text;
           
            if (mdb.Authenticated(mdb))
            {
                Home hform = new Home();
                
                hform.Show();
                //MessageBox.Show("login pass");
                this.Hide();

            }
            else
            {
                //Home hform = new Home();

                //hform.Show();
                MessageBox.Show("Error 404!!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration register = new Registration();
            register.Show();
        }
    }
}
