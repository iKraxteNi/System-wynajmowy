using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace System_wynajmowy
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\KraxteN\Documents\Equipment rental system DB.mdf;Integrated Security = True; Connect Timeout = 30");

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            /*
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TabPracownicy where Login= '" + textBoxLogin.Text + "' and Hasło= '" + textBoxPass.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
               
           { 
 */ 
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
/*
            }
            
            else
            {
                MessageBox.Show("Złe dane logowania");
            }
            con.Close();
            */
        }
    }
}
