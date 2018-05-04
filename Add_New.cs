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
    public partial class Add_New : Form
    {
        public Add_New()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicaldb mdb = new Medicaldb();
            mdb.ID = tb_ID.Text;
            mdb.Book = tb_Name.Text;
            mdb.Author = tb_Author.Text;
            mdb.Traid = comboBox1.Text;
            
                mdb.createnewuser(mdb);
                MessageBox.Show("Book Inserted");
            tb_ID.Text = " ";
            tb_Name.Text = " ";
            tb_Author.Text = "";
            comboBox1.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
