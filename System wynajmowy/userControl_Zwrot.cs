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
    public partial class UserControl_Zwrot : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\KraxteN\Documents\Equipment rental system DB.mdf;Integrated Security = True; Connect Timeout = 30");

        int s;
        int kid;
        int eid;

        public UserControl_Zwrot()
        {
            InitializeComponent();
        }

        private void buttonRejestracji_Click(object sender, EventArgs e)
        {
            
            if (textBoxKid.Text == "" || textBoxEid.Text == "" || textBoxSk.Text == "" || textBoxSs.Text==""|| textBoxnr.Text=="" || textBoxIle.Text=="" )
            {
                MessageBox.Show("Nie wypełniono wszystkich pól");
            }
            else
            {
                int ilew;
                int ile;

                ilew = int.Parse(textBoxIle.Text);
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
                        string dateTimeW = dateTimePickerDZ.Value.Day.ToString() + "/" + dateTimePickerDZ.Value.Month.ToString() + "/" + dateTimePickerDZ.Value.Year.ToString();
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Insert into TabZwrotu values ( '" + kid + "','" + textBoxSk.Text + "','" + textBoxSs.Text + "','" + textBoxnr.Text + "','" + textBoxEid + "','" + dateTimeW + "' )", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Zwrócono");
                        con.Close();

                        UpdateIlosc();

                        diagdataW();
                        diagdataZ();
                        clearAll();


                    }

                }






            }
            
        }

        private void dataGridView1W_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1W.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                textBoxEid.Text = dataGridView1W.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxKid.Text = dataGridView1W.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxnr.Text = dataGridView1W.Rows[e.RowIndex].Cells[0].Value.ToString();
               textBoxSk.Text = dataGridView1W.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxSs.Text = dataGridView1W.Rows[e.RowIndex].Cells[0].Value.ToString();
               // textBoxWZID.Text = dataGridView1W.Rows[e.RowIndex].Cells[0].Value.ToString();
                kid = int.Parse(dataGridView1W.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
        }

        private void dataGridView2Z_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1W.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                textBoxWZID.Text = dataGridView1W.Rows[e.RowIndex].Cells[0].Value.ToString();


            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            if (textBoxWZID.Text == "")
            {
                MessageBox.Show("Wybierz z tabeli klikając na niego");

            }
            else
            {
                s = int.Parse(textBoxWZID.Text);
                con.Open();
                string query = "delete from TabZwrotu where Id =" + s + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usunięto");
                con.Close();

                diagdataW();
                diagdataZ();
                clearAll();

            }
            

        }

        public void diagdataW()
        {
            
            con.Open();
            string query = "select * from TabWynajmu";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1W.DataSource = ds.Tables[0];
            con.Close();
           
        }
        public void diagdataZ()
        {
            
            con.Open();
            string query = "select * from TabZwrotu";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView2Z.DataSource = ds.Tables[0];
            con.Close();
            
        }
        private void UpdateIlosc()
        {
            
            int zile, mile, upile;
            con.Open();
            string query = "select * from TabSprzet where EId =" + eid + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                mile = Convert.ToInt32(dr["mile"].ToString());
                zile = int.Parse(textBoxIle.Text);
                upile = zile + mile;
                string query1 = "update TabSprzet set ilosc =  " + upile + " where EId= " + textBoxEid.Text + "";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
            }





            con.Close();
            
        }
        
        private void clearAll()
        {

            textBoxEid.Clear();
            textBoxKid.Clear();
            textBoxWZID.Clear();
            textBoxSk.Clear();
            textBoxSs.Clear();
            textBoxnr.Clear();
        }
    }
}
