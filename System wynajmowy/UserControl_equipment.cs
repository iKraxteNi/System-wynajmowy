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
    public partial class UserControl_equipment : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\KraxteN\Documents\Equipment rental system DB.mdf;Integrated Security = True; Connect Timeout = 30");

        public UserControl_equipment()
        {
            InitializeComponent();
        }

        public void diagdata()
        {
            con.Open();
            string query = "select * from TabSprzet";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
           
        }

        private void buttonDodawanieE_Click(object sender, EventArgs e)
        {
            if (textBoxIProducent.Text == "" || textBoxNameE.Text == "" || textBoxNrKatalogowy.Text == "" ||  textBoxCena.Text == "" || textBoxIlość.Text =="")
            {
                MessageBox.Show("Nie wypełniono wszystkich pól");
            }
            else
            {

                String name = textBoxNameE.Text;
                int ilosc = int.Parse(textBoxIlość.Text);
                String id = textBoxNrKatalogowy.Text;
                String prod = textBoxIProducent.Text;
                float cena = float.Parse(textBoxCena.Text);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into TabSprzet ( [Nr.Katalogowy] [Nazwa] [Producent] [Cena/dzień] ] [Ilosc] ) values ( '" + id + "','" + name + "','" + prod + "','" + cena + "','" + ilosc + "' )", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dodano nowy sprzęt");
                con.Close();

                diagdata();

                clearAll();

            }
        }

        private void buttonDeleteE_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Wybierz sprzęt z tabeli klikając na niego");

            }
            else
            {
                con.Open();
                string query = "delete from TabSprzet where Id =" + ids + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usunięto");
                con.Close();

                diagdata();

                clearAll();

            }
        }

        int ids;

        private void buttonEdycjiE_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBoxIProducent.Text == "" || textBoxNameE.Text == "" || textBoxNrKatalogowy.Text == "" || textBoxCena.Text == "" || textBoxIlość.Text == "")
            {
                MessageBox.Show("Nie wypełniono wszystkich pól");
            }
            else
            {

                String name = textBoxNameE.Text;
                String id = textBoxNrKatalogowy.Text;
                int ilosc = int.Parse(textBoxIlość.Text);
                String prod = textBoxIProducent.Text;
                float cena = float.Parse(textBoxCena.Text);





                con.Open();
                string query = "update TabSprzet set [Nazwa]='" + name + "', [Nr.Katalogowy]='" + id + "', [Cena/dzień]='" + cena + "', [Producent]='" + prod + "', [Ilosc]= '"+ilosc+"' where Id =" + ids + " ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dane zostały zaktualizowane");
                con.Close();

                diagdata();

              clearAll();



            }

        }

        private void UserControl_equipment_Load(object sender, EventArgs e)
        {

            diagdata();

            clearAll();

        }

        public void clearAll()
        {
            textBoxNameE.Clear();
            textBoxIProducent.Clear();
            textBoxIlość.Clear();
            textBoxCena.Clear();
            textBoxNrKatalogowy.Clear();
            textBox1.Clear();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    textBoxNameE.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textBoxIProducent.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    textBoxCena.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    textBoxIlość.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    textBoxNrKatalogowy.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();



                    ids = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                }

            }
        }
    }
        
}
