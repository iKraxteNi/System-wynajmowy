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
    public partial class UserControl_Wynajem : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\KraxteN\Documents\Equipment rental system DB.mdf;Integrated Security = True; Connect Timeout = 30");
        public UserControl_Wynajem()
        {
            InitializeComponent();
        }

        /* private void FillClientDate()
         {
             con.Open();
             string query = "select * from TabKlient where KId ="+textBoxKid.Text+"";
             SqlCommand cmd = new SqlCommand(query, con);
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(query, con);
             da.Fill(dt);
             foreach(DataRow dr in dt.Rows)
             {

             }
             con.Close();
         }
        */
         
        public void diagdata()
        {
           con.Open();
            string query = "select * from TabKlient";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1k.DataSource = ds.Tables[0];
            con.Close();
  
        }
        public void diagdatas()
        {

            con.Open();
            string query = "select * from TabSprzet";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1k.DataSource = ds.Tables[0];
            con.Close();

        }
        private void buttonRejestracji_Click(object sender, EventArgs e)
        {

            if (textBoxKid.Text == "" || textBoxEid.Text == "" || textBoxIlość.Text == "" || textBoxIlość.Text == "0")
            {
                MessageBox.Show("Nie wypełniono wszystkich pól");
            }
            else
            {
                int ilew;
                int ile;

                ilew = int.Parse(textBoxIlość.Text);
                con.Open();
                string query = "select * from TabSprzet where EId =" + eid + "";
                SqlCommand cmd1 = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ile = Convert.ToInt32(dr["ile"].ToString());

                    if (ile < ilew)
                    {
                        MessageBox.Show("Nie ma tyle na sprzętu stanie");
                    }
                    else
                    {
                        string dateTimeW = dateTimePickerDW.Value.Day.ToString() + "/" + dateTimePickerDW.Value.Month.ToString() + "/" + dateTimePickerDW.Value.Year.ToString();
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Insert into TabWynajmu values ( '" + kid + "','" + textBoxSk.Text + "','" + textBoxSs.Text + "','" + textBoxnr.Text + "','" + textBoxEid + "','" + dateTimeW + "',"+textBoxIlość+" )", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Wynajęto");
                        con.Close();

                        UpdateIlosc();

                        diagdata();

                        clearAll();


                    }

                }






            }

        }


        private void UpdateIlosc()
        {
            
            int ile, newile;
            con.Open();
            string query = "select * from TabSprzet where EId =" + eid + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ile = Convert.ToInt32(dr["ile"].ToString());
                int ilew = int.Parse(textBoxIlość.Text);
                newile = ile - ilew;
                string query1 = "update TabSprzet set ilosc =  " + newile + " where EId= " + textBoxEid.Text + "";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
            }





            con.Close();
            
        }

        int kid;
        int eid;

        private void dataGridView1k_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1k.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                textBoxSk.Text = dataGridView1k.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxKid.Text = dataGridView1k.Rows[e.RowIndex].Cells[0].Value.ToString();

                kid = int.Parse(dataGridView1k.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

        }



        private void dataGridView2s_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1k.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                textBoxSs.Text = dataGridView1k.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxnr.Text = dataGridView1k.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxEid.Text = dataGridView1k.Rows[e.RowIndex].Cells[6].Value.ToString();

                kid = int.Parse(dataGridView1k.Rows[e.RowIndex].Cells[6].Value.ToString());
            }
        }



        private void textBoxSk_TextChanged(object sender, EventArgs e)
        {
            
            con.Open();
            string query = "Select TabKlient.KId, TabKlient.Imię i Nazwisko., TabKlient.Nr. telefonu.,TabKlient.ID dowodu.,TabKlient.Adres. from TabKlient where [Imię i Nazwisko.] like'" + textBoxSk.Text + "%' ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1k.DataSource = ds.Tables[0];
            con.Close();
            
        }

        private void textBoxSs_TextChanged(object sender, EventArgs e)
        {
            
            con.Open();
            string query = "Select TabSprzet.Nr.Katalogowy, TabSprzet.Nazwa, TabSprzet.Producent, TabSprzet.Cena/dzień, TabSprzet.Ilość, TabSprzet.EId from TabSprzet where [Nazwa] like'" + textBoxSk.Text + "%' ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView2s.DataSource = ds.Tables[0];
            con.Close();
            
        }

        private void UserControl_Wynajem_Load(object sender, EventArgs e)
        {
            diagdata();
            diagdatas();

        }

        private void clearAll()
        {

            textBoxEid.Clear();
            textBoxKid.Clear();
            textBoxnr.Clear();
            textBoxSk.Clear();
            textBoxSs.Clear();
        }
    }



}
