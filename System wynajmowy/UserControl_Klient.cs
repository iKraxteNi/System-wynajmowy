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
    public partial class UserControl_Klient : UserControl
    {

        ClassFunctionDB fn = new ClassFunctionDB();
        String query;

        public UserControl_Klient()
        {
            InitializeComponent();
        }

        public void diagdata()
        {
            
            query = "select * from TabKlient";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
            
           
        }

        private void buttonRejestracji_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxNrfon.Text == ""  || textBoxIDd.Text == "" || textBoxAdres.Text == "")
            {
                MessageBox.Show("Nie wypełniono wszystkich pól");
            }
            else
            {
                
                    String name = textBoxName.Text;
                    String mobile = textBoxNrfon.Text;
                    String id = textBoxIDd.Text;
                    String adress = textBoxAdres.Text;
                    

                    
                    query = "Insert into TabKlient ( [Imię i Nazwisko.], [NrTelefonu.], [ID dowodu.], [Adres.]) values ( '" + name + "','" + mobile + "','" + id + "','" + adress + "' )";
                    fn.setData(query, "Zarejestrowano użytkownika");    

                    
                    

                diagdata();

                clearAll();
                
            }



        }

        public void clearAll()
        {

            textBoxAdres.Clear();
            textBoxIDd.Clear();
            textBoxNrfon.Clear();
            textBoxName.Clear();
            textBox1.Clear();
            
        }


        int ids;

     



        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Wybierz klienta z tabeli klikając na niego");

            }
            else
            {
                
                query = "delete from TabKlient where KId =" + ids + "";
                fn.setData(query, "Usunięto");
                

                diagdata();

                clearAll();

            }

        }

        private void buttonEdycji_Click_1(object sender, EventArgs e)
        {
                if (textBoxName.Text == "" || textBoxNrfon.Text == "" || textBoxIDd.Text == "" || textBoxAdres.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Nie wypełniono wszystkich pól");
                }
                else
                {

                    String name = textBoxName.Text;
                    String mobile = textBoxNrfon.Text;
                    String id = textBoxIDd.Text;
                    String adress = textBoxAdres.Text;
                    
                
                    
                     query = "update TabKlient set [Imię i Nazwisko.]='" + name + "', [NrTelefonu.]='" + mobile + "', [ID dowodu.]='" + id + "', [Adres.]='" + adress + "' where KId =" + ids + " ";
                    fn.setData(query, "Dane zostały zaktualizowane");
                    
                   

                    diagdata();

                    clearAll();



                }
            

        }

        private void UserControl_Klient_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textBoxNrfon.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    textBoxIDd.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    textBoxAdres.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();




                    ids = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                }

                }
                catch (Exception)
                {
                    textBox1.Text = "x";
                    
                } 

            }

        }

        private void UserControl_Klient_Load(object sender, EventArgs e)
        {
            diagdata();
            clearAll();
        }
    }
}

