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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New NU = new Add_New();
            NU.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View NU = new View();
            NU.Show();
        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update NU = new Update();
            
            NU.Show();
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete NU = new Delete();
            
            NU.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lo = new Login();
            lo.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search se = new Search();
            se.Show();
        }
    }
}
