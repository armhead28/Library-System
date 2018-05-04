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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Create_New_Load(object sender, EventArgs e)
        {
            Medicaldb mdb = new Medicaldb();
            mdb.fillcombobox(comboBox1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicaldb mdb = new Medicaldb();
            mdb.Book = tb_Name.Text;
            mdb.Author = tb_Author.Text;
            mdb.Traid = cb_update.Text;
            mdb.changeBook(mdb);
            MessageBox.Show("Book Updated");
            tb_Name.Text="";
            tb_Author.Text = "";
            cb_update.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
