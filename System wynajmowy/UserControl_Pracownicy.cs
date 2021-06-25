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
    public partial class UserControl_Pracownicy : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\KraxteN\Documents\Equipment rental system DB.mdf;Integrated Security = True; Connect Timeout = 30");

        public UserControl_Pracownicy()
        {
            InitializeComponent();
        }

        public void diagdata()
        {
            
            con.Open();
            string query = "select * from TabPracownicy";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            
        }

        private void buttonRejestracji_Click(object sender, EventArgs e)
        {
            
            if (textBoxName.Text == "" || textBoxNrfon.Text == "" || textBoxLogin.Text == "" || textBoxHaslo.Text == "" || textBoxHaslop.Text == "" || textBoxIDd.Text == "" || textBoxAdres.Text == "")
            {
                MessageBox.Show("Nie wypełniono wszystkich pól");
            }
            else
            {
                if (textBoxHaslo.Text != textBoxHaslop.Text)
                {
                    MessageBox.Show("Podane hasła się różnią");
                }
                else
                {
                    String name = textBoxName.Text;
                    String mobile = textBoxNrfon.Text;
                    String id = textBoxIDd.Text;
                    String adress = textBoxAdres.Text;
                    String datau = dateTimePickerDU.Text;
                    String haslo = textBoxHaslo.Text;
                    String login = textBoxLogin.Text;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into TabPracownicy ( [Imię i Nazwisko], [Nr. telefonu], [ID dowodu], Adres, Login, Hasło, [Data urodzenia]) values ( '" + name + "','" + mobile + "','" + id + "','" + adress + "','" + login + "','" + haslo + "','" + datau + "' )", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Zarejestrowano użytkownika");
                    con.Close();

                    diagdata();

                    clearAll();
                }
            }

           

        }

        public void clearAll()
        {
            textBoxHaslo.Clear();
            textBoxHaslop.Clear();
            textBoxAdres.Clear();
            textBoxIDd.Clear();
            textBoxNrfon.Clear();
            textBoxName.Clear();
            textBoxLogin.Clear();
            textBox1.Clear();
        }

        private void UserControl_Pracownicy_Load(object sender, EventArgs e)
        {
            diagdata();

            clearAll();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Wybierz pracownika z tabeli klikając na niego");

            }
            else
            {
                con.Open();
                string query = "delete from TabPracownicy where Id =" + ids + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usunięto");
                con.Close();

                diagdata();

                clearAll();

            }
            
        }
        int ids;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textBoxNrfon.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    textBoxIDd.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    textBoxAdres.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    //dateTimePickerDU.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString() ;
                    textBoxHaslo.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    textBoxLogin.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


                    ids = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                }

            }
        }

        private void buttonEdycji_Click(object sender, EventArgs e)
        {
           
            if (textBoxName.Text == "" || textBoxNrfon.Text == "" || textBoxLogin.Text == "" || textBoxHaslo.Text == "" || textBoxHaslop.Text == "" || textBoxIDd.Text == "" || textBoxAdres.Text == "")
            {
                MessageBox.Show("Nie wypełniono wszystkich pól");
            }
            else
            {
                if (textBoxHaslo.Text != textBoxHaslop.Text)
                {
                    MessageBox.Show("Podane hasła się różnią");
                }
                else
                {
                    String name = textBoxName.Text;
                    String mobile = textBoxNrfon.Text;
                    String id = textBoxIDd.Text;
                    String adress = textBoxAdres.Text;
                    String datau = dateTimePickerDU.Text;
                    String haslo = textBoxHaslo.Text;
                    String login = textBoxLogin.Text;
                    con.Open();
                    string query = "update TabPracownicy set [Imię i Nazwisko]='" + name + "', [Nr. telefonu]='" + mobile + "', [ID dowodu]='" + id + "', Adres='" + adress + "', Login='" + login + "', Hasło='" + haslo + "', [Data urodzenia]='" + datau + "' where Id =" + ids + " ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dane zostały zaktualizowane");
                    con.Close();

                    diagdata();

                    clearAll();


                }
            }
            
        }
    }
}


