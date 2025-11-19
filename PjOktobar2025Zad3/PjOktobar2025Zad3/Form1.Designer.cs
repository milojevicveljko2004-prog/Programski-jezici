namespace PjOktobar2025Zad3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxNaziv = new System.Windows.Forms.TextBox();
            this.txtBoxVrsta = new System.Windows.Forms.TextBox();
            this.numUpDownVisina = new System.Windows.Forms.NumericUpDown();
            this.numUpDownTezina = new System.Windows.Forms.NumericUpDown();
            this.dateTimeDatumRodj = new System.Windows.Forms.DateTimePicker();
            this.numUpDownKolicinaMesa = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBiljojed = new System.Windows.Forms.RadioButton();
            this.btnMesojed = new System.Windows.Forms.RadioButton();
            this.btnSvastojed = new System.Windows.Forms.RadioButton();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownVisina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTezina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownKolicinaMesa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrsta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Visina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tezina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum rodjenja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kolicina mesa:";
            // 
            // txtBoxNaziv
            // 
            this.txtBoxNaziv.Location = new System.Drawing.Point(188, 48);
            this.txtBoxNaziv.Name = "txtBoxNaziv";
            this.txtBoxNaziv.Size = new System.Drawing.Size(174, 22);
            this.txtBoxNaziv.TabIndex = 6;
            // 
            // txtBoxVrsta
            // 
            this.txtBoxVrsta.Location = new System.Drawing.Point(188, 101);
            this.txtBoxVrsta.Name = "txtBoxVrsta";
            this.txtBoxVrsta.Size = new System.Drawing.Size(174, 22);
            this.txtBoxVrsta.TabIndex = 7;
            // 
            // numUpDownVisina
            // 
            this.numUpDownVisina.DecimalPlaces = 2;
            this.numUpDownVisina.Location = new System.Drawing.Point(188, 149);
            this.numUpDownVisina.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numUpDownVisina.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numUpDownVisina.Name = "numUpDownVisina";
            this.numUpDownVisina.Size = new System.Drawing.Size(174, 22);
            this.numUpDownVisina.TabIndex = 8;
            this.numUpDownVisina.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // numUpDownTezina
            // 
            this.numUpDownTezina.DecimalPlaces = 3;
            this.numUpDownTezina.Location = new System.Drawing.Point(188, 197);
            this.numUpDownTezina.Maximum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.numUpDownTezina.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            196608});
            this.numUpDownTezina.Name = "numUpDownTezina";
            this.numUpDownTezina.Size = new System.Drawing.Size(174, 22);
            this.numUpDownTezina.TabIndex = 9;
            this.numUpDownTezina.Value = new decimal(new int[] {
            2,
            0,
            0,
            196608});
            // 
            // dateTimeDatumRodj
            // 
            this.dateTimeDatumRodj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDatumRodj.Location = new System.Drawing.Point(188, 249);
            this.dateTimeDatumRodj.Name = "dateTimeDatumRodj";
            this.dateTimeDatumRodj.Size = new System.Drawing.Size(200, 22);
            this.dateTimeDatumRodj.TabIndex = 10;
            // 
            // numUpDownKolicinaMesa
            // 
            this.numUpDownKolicinaMesa.DecimalPlaces = 1;
            this.numUpDownKolicinaMesa.Location = new System.Drawing.Point(188, 383);
            this.numUpDownKolicinaMesa.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownKolicinaMesa.Name = "numUpDownKolicinaMesa";
            this.numUpDownKolicinaMesa.Size = new System.Drawing.Size(174, 22);
            this.numUpDownKolicinaMesa.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSvastojed);
            this.groupBox1.Controls.Add(this.btnMesojed);
            this.groupBox1.Controls.Add(this.btnBiljojed);
            this.groupBox1.Location = new System.Drawing.Point(66, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 81);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nacin ishrane";
            // 
            // btnBiljojed
            // 
            this.btnBiljojed.AutoSize = true;
            this.btnBiljojed.Location = new System.Drawing.Point(6, 31);
            this.btnBiljojed.Name = "btnBiljojed";
            this.btnBiljojed.Size = new System.Drawing.Size(73, 20);
            this.btnBiljojed.TabIndex = 0;
            this.btnBiljojed.TabStop = true;
            this.btnBiljojed.Text = "Biljojed";
            this.btnBiljojed.UseVisualStyleBackColor = true;
            this.btnBiljojed.CheckedChanged += new System.EventHandler(this.btnBiljojed_CheckedChanged);
            // 
            // btnMesojed
            // 
            this.btnMesojed.AutoSize = true;
            this.btnMesojed.Location = new System.Drawing.Point(122, 31);
            this.btnMesojed.Name = "btnMesojed";
            this.btnMesojed.Size = new System.Drawing.Size(81, 20);
            this.btnMesojed.TabIndex = 1;
            this.btnMesojed.TabStop = true;
            this.btnMesojed.Text = "Mesojed";
            this.btnMesojed.UseVisualStyleBackColor = true;
            // 
            // btnSvastojed
            // 
            this.btnSvastojed.AutoSize = true;
            this.btnSvastojed.Location = new System.Drawing.Point(243, 31);
            this.btnSvastojed.Name = "btnSvastojed";
            this.btnSvastojed.Size = new System.Drawing.Size(89, 20);
            this.btnSvastojed.TabIndex = 2;
            this.btnSvastojed.TabStop = true;
            this.btnSvastojed.Text = "Svastojed";
            this.btnSvastojed.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 459);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(491, 132);
            this.listBox.TabIndex = 13;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(63, 418);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(101, 32);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 606);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numUpDownKolicinaMesa);
            this.Controls.Add(this.dateTimeDatumRodj);
            this.Controls.Add(this.numUpDownTezina);
            this.Controls.Add(this.numUpDownVisina);
            this.Controls.Add(this.txtBoxVrsta);
            this.Controls.Add(this.txtBoxNaziv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Zoo vrt";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownVisina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTezina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownKolicinaMesa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxNaziv;
        private System.Windows.Forms.TextBox txtBoxVrsta;
        private System.Windows.Forms.NumericUpDown numUpDownVisina;
        private System.Windows.Forms.NumericUpDown numUpDownTezina;
        private System.Windows.Forms.DateTimePicker dateTimeDatumRodj;
        private System.Windows.Forms.NumericUpDown numUpDownKolicinaMesa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnSvastojed;
        private System.Windows.Forms.RadioButton btnMesojed;
        private System.Windows.Forms.RadioButton btnBiljojed;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnDodaj;
    }
}

