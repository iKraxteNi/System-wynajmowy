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
    public partial class UserControl_equipment : UserControl
    {
        ClassFunctionDB fn = new ClassFunctionDB();
        String query;

        public UserControl_equipment()
        {
            InitializeComponent();
        }

        public void diagdata()
        {
            query = "select * from TabSprzet";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];

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
                
                
                query = ("Insert into TabSprzet ( [Nr.Katalogowy], [Nazwa], [Producent], [Cena/dzień],  [Ilosc] ) values ( '" + id + "','" + name + "','" + prod + "'," + cena + "," + ilosc + " )");
                fn.setData(query, "Dodano nowy sprzęt");
               

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
                
                query = "delete from TabSprzet where EId =" + ids + "";
                fn.setData(query, "Usunięto");
               

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





                
                query = "update TabSprzet set [Nazwa]='" + name + "', [Nr.Katalogowy]='" + id + "', [Cena/dzień]='" + cena + "', [Producent]='" + prod + "', [Ilosc]= '"+ilosc+"' where EId =" + ids + " ";
                fn.setData(query, "Dane zostały zaktualizowane");
              

                diagdata();

                clearAll();



            }

        }

        private void UserControl_equipment_Load(object sender, EventArgs e)
        {

            diagdata();

            

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



                    ids = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());

                }

            }
        }

        private void UserControl_equipment_VisibleChanged(object sender, EventArgs e)
        {
            diagdata();
        }
    }
        
}
