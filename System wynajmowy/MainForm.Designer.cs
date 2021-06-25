
namespace System_wynajmowy
{

    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonw = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.bX = new System.Windows.Forms.Button();
            this.bM = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.buttonZ);
            this.panel1.Controls.Add(this.buttonP);
            this.panel1.Controls.Add(this.buttonw);
            this.panel1.Controls.Add(this.buttonK);
            this.panel1.Controls.Add(this.buttonS);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 125);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonZ
            // 
            this.buttonZ.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonZ.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonZ.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonZ.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonZ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonZ.Location = new System.Drawing.Point(539, 10);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(215, 78);
            this.buttonZ.TabIndex = 1;
            this.buttonZ.Text = "Zwrot";
            this.buttonZ.UseVisualStyleBackColor = false;
            this.buttonZ.Click += new System.EventHandler(this.buttonZ_Click);
            // 
            // buttonP
            // 
            this.buttonP.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonP.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonP.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonP.Location = new System.Drawing.Point(1042, 10);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(215, 78);
            this.buttonP.TabIndex = 3;
            this.buttonP.Text = "Pracownicy";
            this.buttonP.UseVisualStyleBackColor = false;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonw
            // 
            this.buttonw.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonw.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonw.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonw.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonw.Location = new System.Drawing.Point(789, 10);
            this.buttonw.Name = "buttonw";
            this.buttonw.Size = new System.Drawing.Size(215, 78);
            this.buttonw.TabIndex = 2;
            this.buttonw.Text = "Wynajem";
            this.buttonw.UseVisualStyleBackColor = false;
            this.buttonw.Click += new System.EventHandler(this.buttonw_Click);
            // 
            // buttonK
            // 
            this.buttonK.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonK.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonK.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonK.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonK.Location = new System.Drawing.Point(286, 10);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(215, 78);
            this.buttonK.TabIndex = 1;
            this.buttonK.Text = "Klient";
            this.buttonK.UseVisualStyleBackColor = false;
            this.buttonK.Click += new System.EventHandler(this.buttonK_Click);
            // 
            // buttonS
            // 
            this.buttonS.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonS.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonS.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonS.Location = new System.Drawing.Point(41, 9);
            this.buttonS.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(215, 78);
            this.buttonS.TabIndex = 0;
            this.buttonS.Text = "Sprzęt";
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // bX
            // 
            this.bX.BackColor = System.Drawing.Color.Orange;
            this.bX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bX.BackgroundImage")));
            this.bX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bX.Location = new System.Drawing.Point(1276, 7);
            this.bX.Name = "bX";
            this.bX.Size = new System.Drawing.Size(28, 28);
            this.bX.TabIndex = 2;
            this.bX.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bX.UseVisualStyleBackColor = false;
            this.bX.Click += new System.EventHandler(this.bX_Click);
            // 
            // bM
            // 
            this.bM.BackColor = System.Drawing.Color.DodgerBlue;
            this.bM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bM.BackgroundImage")));
            this.bM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bM.Location = new System.Drawing.Point(1276, 38);
            this.bM.Margin = new System.Windows.Forms.Padding(0);
            this.bM.Name = "bM";
            this.bM.Size = new System.Drawing.Size(28, 29);
            this.bM.TabIndex = 3;
            this.bM.UseVisualStyleBackColor = false;
            this.bM.Click += new System.EventHandler(this.bM_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControl_Zwrot1);
            this.panel2.Location = new System.Drawing.Point(12, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1288, 486);
            this.panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1313, 637);
            this.Controls.Add(this.bX);
            this.Controls.Add(this.bM);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonw;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button bX;
        private System.Windows.Forms.Button bM;



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private UserControl_equipment userControl_equipment1;
        private UserControl_Klient userControl_Klient1;
        private UserControl_Wynajem userControl_Wynajem1;
        private UserControl_Pracownicy userControl_Pracownicy1;
        private UserControl_Zwrot userControl_Zwrot1;
    }
}
