
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
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonEnData = new System.Windows.Forms.Button();
            this.buttonCData = new System.Windows.Forms.Button();
            this.buttonRe = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.bX = new System.Windows.Forms.Button();
            this.bM = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.buttonR);
            this.panel1.Controls.Add(this.buttonEnData);
            this.panel1.Controls.Add(this.buttonCData);
            this.panel1.Controls.Add(this.buttonRe);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 125);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonR
            // 
            this.buttonR.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonR.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonR.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonR.Location = new System.Drawing.Point(539, 10);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(215, 78);
            this.buttonR.TabIndex = 1;
            this.buttonR.Text = "Zwrot";
            this.buttonR.UseVisualStyleBackColor = false;
            // 
            // buttonEnData
            // 
            this.buttonEnData.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonEnData.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonEnData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEnData.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEnData.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnData.Location = new System.Drawing.Point(1042, 10);
            this.buttonEnData.Name = "buttonEnData";
            this.buttonEnData.Size = new System.Drawing.Size(215, 78);
            this.buttonEnData.TabIndex = 3;
            this.buttonEnData.Text = "Pracownicy";
            this.buttonEnData.UseVisualStyleBackColor = false;
            // 
            // buttonCData
            // 
            this.buttonCData.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonCData.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonCData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCData.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCData.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCData.Location = new System.Drawing.Point(789, 10);
            this.buttonCData.Name = "buttonCData";
            this.buttonCData.Size = new System.Drawing.Size(215, 78);
            this.buttonCData.TabIndex = 2;
            this.buttonCData.Text = "Wynajem";
            this.buttonCData.UseVisualStyleBackColor = false;
            // 
            // buttonRe
            // 
            this.buttonRe.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonRe.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonRe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRe.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRe.Location = new System.Drawing.Point(286, 10);
            this.buttonRe.Name = "buttonRe";
            this.buttonRe.Size = new System.Drawing.Size(215, 78);
            this.buttonRe.TabIndex = 1;
            this.buttonRe.Text = "Klient";
            this.buttonRe.UseVisualStyleBackColor = false;
            // 
            // buttonRoom
            // 
            this.buttonRoom.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonRoom.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRoom.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.Location = new System.Drawing.Point(35, 9);
            this.buttonRoom.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(215, 78);
            this.buttonRoom.TabIndex = 0;
            this.buttonRoom.Text = "Sprzęt";
            this.buttonRoom.UseVisualStyleBackColor = false;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
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
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonEnData;
        private System.Windows.Forms.Button buttonCData;
        private System.Windows.Forms.Button buttonRe;
        private System.Windows.Forms.Button bX;
        private System.Windows.Forms.Button bM;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion


    }
}
