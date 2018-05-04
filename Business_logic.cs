using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace MedicalData
{
    class Business_logic
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        public void openConnection()
        {
            string constring = ConfigurationManager.ConnectionStrings["constr"].ToString();
            // String constring="Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|/mydb.accdb";
            cn = new OleDbConnection(constring);
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }
        public void CloseConnection()
        {
            if (cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }
        public OleDbDataReader SelectQuery(string query)
        {
            openConnection();
            cmd = new OleDbCommand(query, cn);
            OleDbDataReader rec = cmd.ExecuteReader();
            return rec;



        }
        public void NonQuery(string query)
        {
            openConnection();
            cmd = new OleDbCommand(query, cn);
            cmd.ExecuteNonQuery();
            // CloseConnection();
        }

        public void filldataGrid(System.Windows.Forms.DataGridView dg, String query)
        {
            openConnection();
            cmd = new OleDbCommand(query, cn);
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dg.DataSource = ds.Tables[0];


        }
    }
}
