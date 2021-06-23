
namespace System_wynajmowy
{
    partial class UserControl_equipment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDodawanieE = new System.Windows.Forms.Button();
            this.buttonDeleteE = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.textBoxIProducent = new System.Windows.Forms.TextBox();
            this.buttonEdycjiE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNrKatalogowy = new System.Windows.Forms.TextBox();
            this.textBoxNameE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIlość = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(537, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(737, 394);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // buttonDodawanieE
            // 
            this.buttonDodawanieE.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDodawanieE.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDodawanieE.Location = new System.Drawing.Point(93, 376);
            this.buttonDodawanieE.Name = "buttonDodawanieE";
            this.buttonDodawanieE.Size = new System.Drawing.Size(184, 36);
            this.buttonDodawanieE.TabIndex = 46;
            this.buttonDodawanieE.Text = "Dodaj";
            this.buttonDodawanieE.UseVisualStyleBackColor = false;
            this.buttonDodawanieE.Click += new System.EventHandler(this.buttonDodawanieE_Click);
            // 
            // buttonDeleteE
            // 
            this.buttonDeleteE.BackColor = System.Drawing.Color.Coral;
            this.buttonDeleteE.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteE.Location = new System.Drawing.Point(425, 121);
            this.buttonDeleteE.Name = "buttonDeleteE";
            this.buttonDeleteE.Size = new System.Drawing.Size(106, 36);
            this.buttonDeleteE.TabIndex = 45;
            this.buttonDeleteE.Text = "Usuń";
            this.buttonDeleteE.UseVisualStyleBackColor = false;
            this.buttonDeleteE.Click += new System.EventHandler(this.buttonDeleteE_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(41, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Cena/dzień";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(41, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Producent";
            // 
            // textBoxCena
            // 
            this.textBoxCena.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCena.Location = new System.Drawing.Point(41, 260);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(300, 27);
            this.textBoxCena.TabIndex = 42;
            // 
            // textBoxIProducent
            // 
            this.textBoxIProducent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIProducent.Location = new System.Drawing.Point(41, 205);
            this.textBoxIProducent.Name = "textBoxIProducent";
            this.textBoxIProducent.Size = new System.Drawing.Size(300, 27);
            this.textBoxIProducent.TabIndex = 41;
            // 
            // buttonEdycjiE
            // 
            this.buttonEdycjiE.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonEdycjiE.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdycjiE.Location = new System.Drawing.Point(425, 77);
            this.buttonEdycjiE.Name = "buttonEdycjiE";
            this.buttonEdycjiE.Size = new System.Drawing.Size(106, 36);
            this.buttonEdycjiE.TabIndex = 40;
            this.buttonEdycjiE.Text = "Edytuj";
            this.buttonEdycjiE.UseVisualStyleBackColor = false;
            this.buttonEdycjiE.Click += new System.EventHandler(this.buttonEdycjiE_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nr. Katalogowy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nazwa";
            // 
            // textBoxNrKatalogowy
            // 
            this.textBoxNrKatalogowy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNrKatalogowy.Location = new System.Drawing.Point(41, 152);
            this.textBoxNrKatalogowy.Name = "textBoxNrKatalogowy";
            this.textBoxNrKatalogowy.Size = new System.Drawing.Size(300, 27);
            this.textBoxNrKatalogowy.TabIndex = 35;
            // 
            // textBoxNameE
            // 
            this.textBoxNameE.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNameE.Location = new System.Drawing.Point(41, 97);
            this.textBoxNameE.Name = "textBoxNameE";
            this.textBoxNameE.Size = new System.Drawing.Size(300, 27);
            this.textBoxNameE.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Edycja sprzętu";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(392, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(27, 27);
            this.textBox1.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ilość";
            // 
            // textBoxIlość
            // 
            this.textBoxIlość.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIlość.Location = new System.Drawing.Point(41, 316);
            this.textBoxIlość.Name = "textBoxIlość";
            this.textBoxIlość.Size = new System.Drawing.Size(300, 27);
            this.textBoxIlość.TabIndex = 49;
            // 
            // UserControl_equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(132)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIlość);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDodawanieE);
            this.Controls.Add(this.buttonDeleteE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.textBoxIProducent);
            this.Controls.Add(this.buttonEdycjiE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNrKatalogowy);
            this.Controls.Add(this.textBoxNameE);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_equipment";
            this.Size = new System.Drawing.Size(1286, 485);
            this.Load += new System.EventHandler(this.UserControl_equipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodawanieE;
        private System.Windows.Forms.Button buttonDeleteE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.TextBox textBoxIProducent;
        private System.Windows.Forms.Button buttonEdycjiE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNrKatalogowy;
        private System.Windows.Forms.TextBox textBoxNameE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIlość;
    }
}
