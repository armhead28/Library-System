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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Medicaldb mdb = new Medicaldb();

            mdb.getdatabysearch(dataGridView1, textBox1.Text);
        }

        private void Search_Load(object sender, EventArgs e)
        {
            Medicaldb mdb = new Medicaldb();
            mdb.getdata(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
