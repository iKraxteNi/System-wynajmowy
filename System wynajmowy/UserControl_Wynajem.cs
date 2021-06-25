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
        ClassFunctionDB fn = new ClassFunctionDB();
        String query;
        
        public UserControl_Wynajem()
        {
            InitializeComponent();
        }

         
        public void diagdata()
        {
           
            query = "select * from TabKlient";
            DataSet ds = fn.GetData(query);
            
            dataGridView1k.DataSource = ds.Tables[0];
            
  
        }
        public void diagdatas()
        {

            query = "select * from TabSprzet";
            DataSet ds = fn.GetData(query);
            dataGridView2s.DataSource = ds.Tables[0];


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
                
                 query = "select * from TabSprzet where EId =" + eid + "";
                  DataSet ds = fn.GetData(query);

                    ile = Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());

 
                    if (ile < ilew)
                    {
                        MessageBox.Show("Nie ma tyle na sprzętu stanie");
                    }
                    else
                    {
                        string dateTimeW = dateTimePickerDW.Value.Year.ToString() + "-" + dateTimePickerDW.Value.Month.ToString() + "-" + dateTimePickerDW.Value.Day.ToString();

                        query =("Insert into TabWynajmu values ( '" + kid + "','" + textBoxSk.Text + "','" + textBoxSs.Text + "','" + textBoxnr.Text + "','" + textBoxEid.Text + "','" + dateTimeW + "','"+textBoxIlość.Text+"' )");
                        fn.setData(query, "Wynajęto");
                    

                        UpdateIlosc();

                        diagdata();

                        clearAll();


                    }

                






            }

        }


        private void UpdateIlosc()
        {
            
            int ile, newile;
            query = "select * from TabSprzet where EId =" + eid + "";
            DataSet ds = fn.GetData(query);

            ile =  Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());


            int ilew = int.Parse(textBoxIlość.Text);
                newile = ile - ilew;
                query = "update TabSprzet set ilosc =  " + newile + " where EId= " + textBoxEid.Text + "";
                 fn.setData(query, "Dane zostały zaktualizowane");



        }

        int kid;
        int eid;

        private void dataGridView1k_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1k.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                    textBoxKid.Text = dataGridView1k.Rows[e.RowIndex].Cells[0].Value.ToString();

                    kid = int.Parse(dataGridView1k.Rows[e.RowIndex].Cells[0].Value.ToString());

                    textBoxSk.Text = dataGridView1k.Rows[e.RowIndex].Cells[1].Value.ToString();

                }


            }
            catch (Exception)
            {

                textBoxKid.Text = "x";
            }
           
        }




        private void textBoxSk_TextChanged(object sender, EventArgs e)
        {
            

             query = "Select TabKlient.[KId], TabKlient.[Imię i Nazwisko.], TabKlient.[NrTelefonu.],TabKlient.[ID dowodu.],TabKlient.[Adres.] from TabKlient where [Imię i Nazwisko.] like'" + textBoxSk.Text + "%' ";
            DataSet ds = fn.GetData(query);
            dataGridView1k.DataSource = ds.Tables[0];

            
        }

        private void textBoxSs_TextChanged(object sender, EventArgs e)
        {
            

            query = "Select TabSprzet.[Nr.Katalogowy], TabSprzet.[Nazwa], TabSprzet.[Producent], TabSprzet.[Cena/dzień], TabSprzet.[Ilosc], TabSprzet.[EId] from TabSprzet where [Nazwa] like'" + textBoxSs.Text + "%' ";
            DataSet ds = fn.GetData(query);
            dataGridView2s.DataSource = ds.Tables[0];
            
        }

        private void UserControl_Wynajem_Load(object sender, EventArgs e)
        {
            diagdata();
            diagdatas();
            clearAll();

        }

        private void clearAll()
        {

            textBoxEid.Clear();
            textBoxKid.Clear();
            textBoxnr.Clear();
            textBoxSk.Clear();
            textBoxSs.Clear();
        }

        private void UserControl_Wynajem_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void textBoxIlość_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxIlość.Text, "  ^ [0-9]"))
            {
                textBoxIlość.Text = "";
            }
        }

        private void textBoxIlość_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void UserControl_Wynajem_Enter(object sender, EventArgs e)
        {
            diagdatas();
            diagdata();
        }

        private void dataGridView2s_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2s.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                textBoxnr.Text = dataGridView2s.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxEid.Text = dataGridView2s.Rows[e.RowIndex].Cells[5].Value.ToString();

                eid = int.Parse(dataGridView2s.Rows[e.RowIndex].Cells[5].Value.ToString());

                textBoxSs.Text = dataGridView2s.Rows[e.RowIndex].Cells[1].Value.ToString();
            }


            }
            catch (Exception)
            {
                textBoxEid.Text = "x";
                
            }
            
        }
    }



}
