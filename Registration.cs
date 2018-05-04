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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicaldb mdb = new Medicaldb();
            mdb.Username = tb_Username.Text;
            if (tb_Password.Text == tb_ConfirmPwd.Text)
            {
                mdb.Password = tb_Password.Text;
            }
            mdb.Name = tb_Name.Text;
            mdb.Email = tb_Email.Text;

            if (tb_Password.Text == tb_ConfirmPwd.Text)
            {
                mdb.register(mdb);
                MessageBox.Show("User created");
                tb_Username.Text= "";
                tb_Password.Text = "";
                tb_ConfirmPwd.Text = "";
                tb_Name.Text = "";
                tb_Email.Text = "";

            }
            else
            {
                MessageBox.Show("Error 404!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
