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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicaldb mdb = new Medicaldb();
            mdb.ID = cb_delete.Text;
            mdb.deleteuser(mdb);
            MessageBox.Show("Book Deleted");
            cb_delete.Text = "";
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            Medicaldb mdb = new Medicaldb();
            mdb.fillcombobox(cb_delete);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
