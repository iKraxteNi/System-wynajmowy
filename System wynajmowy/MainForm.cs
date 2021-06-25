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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userControl_equipment1.Visible = false;
            userControl_Klient1.Visible = false;
            userControl_Pracownicy1.Visible = false;
            userControl_Wynajem1.Visible = false;
            userControl_Zwrot1.Visible = false;
            

        }

        private void bX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bM_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int mouseX = 0;
        /// <summary>
        /// Parametr zawierający pozycję kursora.
        /// </summary>
        int mouseY = 0;
        /// <summary>
        /// Parametr zawierający pozycję kursora.
        /// </summary>
        int mouseinX = 0;
        /// <summary>
        /// Parametr zawierający pozycję kursora.
        /// </summary>
        int mouseinY = 0;
        /// <summary>
        /// Bool zawierający dane o tym czy przycisk myszy jest nacisnięty.
        /// </summary>
        bool mouseDown;
        /// <summary>
        /// Funkcja służaca do przesuwania całym oknem w przypadku przesuwania panelu.
        /// </summary>
        /// 
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }



        private void buttonS_Click(object sender, EventArgs e)
        {
            userControl_equipment1.Visible = true;
            userControl_equipment1.BringToFront();
            userControl_equipment1.diagdata();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            userControl_Klient1.Visible = true;
            userControl_Klient1.BringToFront();
            userControl_Klient1.diagdata();
            
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            userControl_Zwrot1.Visible = true;
            userControl_Zwrot1.BringToFront();
            userControl_Zwrot1.diagdataW();
            userControl_Zwrot1.diagdataZ();
        }

        private void buttonw_Click(object sender, EventArgs e)
        {
            userControl_Wynajem1.Visible = true;
            userControl_Wynajem1.BringToFront();
            userControl_Wynajem1.diagdata();
            userControl_Wynajem1.diagdatas();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            userControl_Pracownicy1.Visible = true;
            userControl_Pracownicy1.BringToFront();
            userControl_Pracownicy1.diagdata();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;

        }
    }
}
