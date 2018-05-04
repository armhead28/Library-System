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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicaldbDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.medicaldbDataSet.Book);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
