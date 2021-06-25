using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Formats;
using System.Windows.Forms;

namespace System_wynajmowy
{
    class ClassFunctionDB
    {
        protected SqlConnection GetConnection() // płączenie z bazą 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\KraxteN\Documents\Equipment rental system DB.mdf; Integrated Security = True; Connect Timeout = 30";
            return con;
        }

        public DataSet GetData(String query) // pobieranie danych z bazy 
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query, String message) // dodawanie usuwanie updeitownie
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("'" + message + "'", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
