using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace System_wynajmowy
{
    public partial class UserControl_Pracownicy : UserControl
    {
        ClassFunctionDB fn = new ClassFunctionDB();
        String query;

        public UserControl_Pracownicy()
        {
            InitializeComponent();
        }

        public void diagdata()
        {
            
            
            query = "select * from TabPracownicy";
            
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];

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
                    String haslo = textBoxHaslo.Text;
                    String login = textBoxLogin.Text;
                   
                    query = "Insert into TabPracownicy ( [Imię i Nazwisko], [Nr. telefonu], [ID dowodu], Adres, Login, Hasło, [Data urodzenia]) values ( '" + name + "','" + mobile + "','" + id + "','" + adress + "','" + login + "','" + haslo + "' )";
                    
                    fn.setData(query, "Zarejestrowano użytkownika");
                    

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
                
                 query = "delete from TabPracownicy where Id =" + ids + "";
               
                fn.setData(query, "Usunięto");

                diagdata();

                clearAll();

            }
            
        }
        int ids;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textBoxNrfon.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    textBoxIDd.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    textBoxAdres.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    textBoxHaslo.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    textBoxLogin.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


                    ids = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                }

                }
                catch (Exception)
                {
                    textBox1.Text = "x";
                    
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
                    
                    String haslo = textBoxHaslo.Text;
                    String login = textBoxLogin.Text;
                   
                    query = "update TabPracownicy set [Imię i Nazwisko]='" + name + "', [Nr. telefonu]='" + mobile + "', [ID dowodu]='" + id + "', Adres='" + adress + "', Login='" + login + "', Hasło='" + haslo + "' where Id =" + ids + " ";
                    
                    fn.setData(query, "Dane zostały zaktualizowane"); ;

                    diagdata();

                    clearAll();


                }
            }
            
        }
    }
}


