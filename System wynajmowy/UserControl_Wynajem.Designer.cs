
namespace System_wynajmowy
{
    partial class UserControl_Wynajem
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerDW = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxnr = new System.Windows.Forms.TextBox();
            this.textBoxSs = new System.Windows.Forms.TextBox();
            this.buttonRejestracji = new System.Windows.Forms.Button();
            this.dataGridView1k = new System.Windows.Forms.DataGridView();
            this.textBoxKid = new System.Windows.Forms.TextBox();
            this.textBoxSk = new System.Windows.Forms.TextBox();
            this.dataGridView2s = new System.Windows.Forms.DataGridView();
            this.textBoxEid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxIlość = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2s)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wynajem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "SZUKAJ - Imię i Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "KID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(41, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data rozpoczęcia ";
            // 
            // dateTimePickerDW
            // 
            this.dateTimePickerDW.CalendarMonthBackground = System.Drawing.Color.Orange;
            this.dateTimePickerDW.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDW.Location = new System.Drawing.Point(41, 392);
            this.dateTimePickerDW.Name = "dateTimePickerDW";
            this.dateTimePickerDW.Size = new System.Drawing.Size(275, 27);
            this.dateTimePickerDW.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(41, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nr.Katalogowy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(41, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "SZUKAJ- Nazwa Sprzętu";
            // 
            // textBoxnr
            // 
            this.textBoxnr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxnr.Location = new System.Drawing.Point(41, 258);
            this.textBoxnr.Name = "textBoxnr";
            this.textBoxnr.ReadOnly = true;
            this.textBoxnr.Size = new System.Drawing.Size(275, 27);
            this.textBoxnr.TabIndex = 27;
            // 
            // textBoxSs
            // 
            this.textBoxSs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSs.Location = new System.Drawing.Point(41, 203);
            this.textBoxSs.Name = "textBoxSs";
            this.textBoxSs.Size = new System.Drawing.Size(275, 27);
            this.textBoxSs.TabIndex = 26;
            this.textBoxSs.TextChanged += new System.EventHandler(this.textBoxSs_TextChanged);
            // 
            // buttonRejestracji
            // 
            this.buttonRejestracji.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonRejestracji.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRejestracji.Location = new System.Drawing.Point(93, 438);
            this.buttonRejestracji.Name = "buttonRejestracji";
            this.buttonRejestracji.Size = new System.Drawing.Size(184, 36);
            this.buttonRejestracji.TabIndex = 31;
            this.buttonRejestracji.Text = "Wynajmnij";
            this.buttonRejestracji.UseVisualStyleBackColor = false;
            this.buttonRejestracji.Click += new System.EventHandler(this.buttonRejestracji_Click);
            // 
            // dataGridView1k
            // 
            this.dataGridView1k.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1k.Location = new System.Drawing.Point(536, 74);
            this.dataGridView1k.Name = "dataGridView1k";
            this.dataGridView1k.RowTemplate.Height = 25;
            this.dataGridView1k.Size = new System.Drawing.Size(732, 196);
            this.dataGridView1k.TabIndex = 32;
            this.dataGridView1k.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1k_CellContentClick);
            // 
            // textBoxKid
            // 
            this.textBoxKid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKid.ForeColor = System.Drawing.Color.Black;
            this.textBoxKid.Location = new System.Drawing.Point(41, 150);
            this.textBoxKid.Name = "textBoxKid";
            this.textBoxKid.ReadOnly = true;
            this.textBoxKid.Size = new System.Drawing.Size(275, 27);
            this.textBoxKid.TabIndex = 40;
            // 
            // textBoxSk
            // 
            this.textBoxSk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSk.Location = new System.Drawing.Point(41, 97);
            this.textBoxSk.Name = "textBoxSk";
            this.textBoxSk.Size = new System.Drawing.Size(275, 27);
            this.textBoxSk.TabIndex = 41;
            this.textBoxSk.TextChanged += new System.EventHandler(this.textBoxSk_TextChanged);
            // 
            // dataGridView2s
            // 
            this.dataGridView2s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2s.Location = new System.Drawing.Point(536, 278);
            this.dataGridView2s.Name = "dataGridView2s";
            this.dataGridView2s.RowTemplate.Height = 25;
            this.dataGridView2s.Size = new System.Drawing.Size(732, 196);
            this.dataGridView2s.TabIndex = 42;
            this.dataGridView2s.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2s_CellContentClick);
            // 
            // textBoxEid
            // 
            this.textBoxEid.Location = new System.Drawing.Point(3, 459);
            this.textBoxEid.Name = "textBoxEid";
            this.textBoxEid.ReadOnly = true;
            this.textBoxEid.Size = new System.Drawing.Size(26, 23);
            this.textBoxEid.TabIndex = 43;
            this.textBoxEid.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(455, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 30);
            this.label4.TabIndex = 44;
            this.label4.Text = "Klienci";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(455, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 30);
            this.label5.TabIndex = 45;
            this.label5.Text = "Sprzęt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(41, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "Ilość";
            // 
            // textBoxIlość
            // 
            this.textBoxIlość.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIlość.Location = new System.Drawing.Point(41, 315);
            this.textBoxIlość.Name = "textBoxIlość";
            this.textBoxIlość.ReadOnly = true;
            this.textBoxIlość.Size = new System.Drawing.Size(275, 27);
            this.textBoxIlość.TabIndex = 46;
            // 
            // UserControl_Wynajem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(132)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxIlość);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEid);
            this.Controls.Add(this.dataGridView2s);
            this.Controls.Add(this.textBoxSk);
            this.Controls.Add(this.textBoxKid);
            this.Controls.Add(this.dataGridView1k);
            this.Controls.Add(this.buttonRejestracji);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxnr);
            this.Controls.Add(this.textBoxSs);
            this.Controls.Add(this.dateTimePickerDW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Wynajem";
            this.Size = new System.Drawing.Size(1286, 485);
            this.Load += new System.EventHandler(this.UserControl_Wynajem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2s)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Button buttonRejestracji;
        private System.Windows.Forms.DataGridView dataGridView1k;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxnr;
        private System.Windows.Forms.TextBox textBoxSs;
        private System.Windows.Forms.TextBox textBoxKid;
        private System.Windows.Forms.TextBox textBoxSk;
        private System.Windows.Forms.DataGridView dataGridView2s;
        private System.Windows.Forms.TextBox textBoxEid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxIlość;
    }
}
