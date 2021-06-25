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
        ClassFunctionDB fn = new ClassFunctionDB();
        String query;

        int s;
        int kid;
        int eid;
        int w;

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
               
       
                string dateTimeZ = dateTimePickerDZ.Value.Year.ToString() + "-" + dateTimePickerDZ.Value.Month.ToString() + "-" + dateTimePickerDZ.Value.Day.ToString();
                string dateTimeW = textBoxdata.Text;

                query =("Insert into TabZwrotu ( [Kid], [Imię i Nazwisko.], [Nazwa ], [Nr.Katalogowy], [Data-Wynajmu],  [IloscZ], [Data Zwrotu] ) values ( '" + kid + "','" + textBoxSk.Text + "','" + textBoxSs.Text + "','" + textBoxnr.Text + "','"+dateTimeW+"' , '" + textBoxEid.Text + "','" + dateTimeZ + "' ) ");
                fn.setData(query, "Zwrócono");


                query = "delete from TabWynajmu where IdW =" + w + "";
                fn.setData(query,"");

                UpdateIlosc();

                diagdataW();
                diagdataZ();
                clearAll();


            }
            
        }

        private void dataGridView1W_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                if (dataGridView1W.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                textBoxEid.Text = dataGridView1W.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxKid.Text = dataGridView1W.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxnr.Text = dataGridView1W.Rows[e.RowIndex].Cells[3].Value.ToString();
               textBoxSk.Text = dataGridView1W.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxSs.Text = dataGridView1W.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxdata.Text = dataGridView1W.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxIle.Text = dataGridView1W.Rows[e.RowIndex].Cells[6].Value.ToString();
                kid = int.Parse(dataGridView1W.Rows[e.RowIndex].Cells[0].Value.ToString());
                eid = int.Parse(dataGridView1W.Rows[e.RowIndex].Cells[4].Value.ToString());
                w = int.Parse(dataGridView1W.Rows[e.RowIndex].Cells[7].Value.ToString());

            }

            }
            catch (Exception)
            {

                textBoxEid.Text = "x";
            }
           
        }

        private void dataGridView2Z_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
               if (dataGridView2Z.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                textBoxWZID.Text = dataGridView2Z.Rows[e.RowIndex].Cells[0].Value.ToString();

            }

            }
            catch (Exception)
            {

                textBoxWZID.Text = "x";
            }
           

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            if (textBoxWZID.Text == "")
            {
                MessageBox.Show("Wybierz z tabeli klikając na wiersz");

            }
            else
            {
                s = int.Parse(textBoxWZID.Text);
                query = "delete from TabZwrotu where IdZ =" + s + "";
                fn.setData(query, "Usunięto");

                diagdataW();
                diagdataZ();
                clearAll();

            }
            

        }

        public void diagdataW()
        {
            

            query = "select * from TabWynajmu";
            DataSet ds = fn.GetData(query);
            dataGridView1W.DataSource = ds.Tables[0];
           
        }
        public void diagdataZ()
        {
            

            query = "select * from TabZwrotu";
            DataSet ds = fn.GetData(query);
            dataGridView2Z.DataSource = ds.Tables[0];

            
        }
        private void UpdateIlosc()
        {

            int zile, ile, upile;
           
            query = "select * from TabSprzet where EId =" + eid + "";
            DataSet ds = fn.GetData(query);
            ile = Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());

            zile = Convert.ToInt32(textBoxIle.Text);

            zile = int.Parse(textBoxIle.Text);
            upile = ile + zile;
            query = "update TabSprzet set ilosc =  " + upile + " where EId= " + textBoxEid.Text + "";
            fn.setData(query, "Dane zostały zaktualizowane");








            
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
