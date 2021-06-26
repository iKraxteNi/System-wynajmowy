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
        ClassFunctionDB fn = new ClassFunctionDB();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            
            query =("select Login, Hasło from TabPracownicy where Login = '" + textBoxLogin.Text + "' and Hasło = '" + textBoxPass.Text + "'");
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {


                labelWronePass.Visible = false;
                this.Hide();
                MainForm main = new MainForm();
                main.Show();

            }
            
            else
            {

                labelWronePass.Visible = true;
                textBoxLogin.Clear();
                textBoxPass.Clear();
            }
            
            
        }
    }
}
