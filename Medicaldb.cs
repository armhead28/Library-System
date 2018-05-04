using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MedicalData
{
    class Medicaldb
    {
        
        public string Username
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public string Usertype
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
        public string Book
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
        public string Traid
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }

        public bool Authenticated(Medicaldb mdb)
        {
            string query = string.Format("select * from Login  where Username='{0}' and Password='{1}'", mdb.Username, mdb.Password);
            Business_logic BL = new Business_logic();
            OleDbDataReader rec = BL.SelectQuery(query);
            if (rec.Read())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void createnewuser(Medicaldb mdb)
        {
            string query = String.Format("Insert into Book values('{0}','{1}','{2}','{3}')", mdb.ID, mdb.Book, mdb.Author, mdb.Traid);
            Business_logic BL = new Business_logic();
            BL.NonQuery(query);
        }
        public void fillcombobox(ComboBox CB)
        {
            string query = String.Format("Select ID from Book");
            Business_logic BL = new Business_logic();
            OleDbDataReader rec = BL.SelectQuery(query);
            while (rec.Read())
            {
                CB.Items.Add(rec[0].ToString());
            }
        }
        public void deleteuser(Medicaldb mdb)
        {
            string query = String.Format("Delete from Book where ID='cb_delete.Text'");
            Business_logic BL = new Business_logic();
            BL.NonQuery(query);
        }
        public void changeBook(Medicaldb mdb)
        {
            string query = String.Format("UPDATE [Book] SET [Book]='{0}' , [Author]='{1}' and [Traid]='{2}' WHERE [ID]='comboBox1.Text'", mdb.Book, mdb.Author, mdb.Traid);
            Business_logic BL = new Business_logic();
            BL.NonQuery(query);
        }
        public void register(Medicaldb mdb)
        {
            string query = String.Format("Insert into Login values('{0}','{1}','{2}','{3}')", mdb.Username, mdb.Password, mdb.Name, mdb.Email);
            Business_logic BL = new Business_logic();
            BL.NonQuery(query);
        }
        public void getdatabysearch(DataGridView dg, String se)
        {
            Business_logic BL = new Business_logic();
            string query = "select * from Book where Author like ('%" + se + "%')";
            BL.filldataGrid(dg, query);
        }
        public void getdata(DataGridView dg)
        {
            Business_logic BL = new Business_logic();
            string query = "select * from Book";
            BL.filldataGrid(dg, query);
        }
    }
}
