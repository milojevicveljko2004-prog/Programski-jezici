namespace PjJun2025Zad3
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
            this.txtBoxProizvodjac = new System.Windows.Forms.TextBox();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.cmbBoxVrstaGoriva = new System.Windows.Forms.ComboBox();
            this.numUpDownZapreminaMotora = new System.Windows.Forms.NumericUpDown();
            this.numUpDownKapacitetBaterije = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerDatumProizvodnje = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownZapreminaMotora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownKapacitetBaterije)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proizvodjac:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrsta goriva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zapremina motora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kapacitet baterije:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Datum proizvodnje:";
            // 
            // txtBoxProizvodjac
            // 
            this.txtBoxProizvodjac.Location = new System.Drawing.Point(171, 57);
            this.txtBoxProizvodjac.Name = "txtBoxProizvodjac";
            this.txtBoxProizvodjac.Size = new System.Drawing.Size(185, 22);
            this.txtBoxProizvodjac.TabIndex = 6;
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(171, 116);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(185, 22);
            this.txtBoxModel.TabIndex = 7;
            // 
            // cmbBoxVrstaGoriva
            // 
            this.cmbBoxVrstaGoriva.FormattingEnabled = true;
            this.cmbBoxVrstaGoriva.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Elektricni pogon"});
            this.cmbBoxVrstaGoriva.Location = new System.Drawing.Point(171, 174);
            this.cmbBoxVrstaGoriva.Name = "cmbBoxVrstaGoriva";
            this.cmbBoxVrstaGoriva.Size = new System.Drawing.Size(185, 24);
            this.cmbBoxVrstaGoriva.TabIndex = 8;
            this.cmbBoxVrstaGoriva.SelectedIndexChanged += new System.EventHandler(this.cmbBoxVrstaGoriva_SelectedIndexChanged);
            // 
            // numUpDownZapreminaMotora
            // 
            this.numUpDownZapreminaMotora.DecimalPlaces = 3;
            this.numUpDownZapreminaMotora.Location = new System.Drawing.Point(171, 224);
            this.numUpDownZapreminaMotora.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownZapreminaMotora.Name = "numUpDownZapreminaMotora";
            this.numUpDownZapreminaMotora.Size = new System.Drawing.Size(185, 22);
            this.numUpDownZapreminaMotora.TabIndex = 9;
            // 
            // numUpDownKapacitetBaterije
            // 
            this.numUpDownKapacitetBaterije.Location = new System.Drawing.Point(171, 273);
            this.numUpDownKapacitetBaterije.Name = "numUpDownKapacitetBaterije";
            this.numUpDownKapacitetBaterije.Size = new System.Drawing.Size(185, 22);
            this.numUpDownKapacitetBaterije.TabIndex = 10;
            // 
            // dateTimePickerDatumProizvodnje
            // 
            this.dateTimePickerDatumProizvodnje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDatumProizvodnje.Location = new System.Drawing.Point(171, 320);
            this.dateTimePickerDatumProizvodnje.Name = "dateTimePickerDatumProizvodnje";
            this.dateTimePickerDatumProizvodnje.Size = new System.Drawing.Size(185, 22);
            this.dateTimePickerDatumProizvodnje.TabIndex = 11;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(63, 363);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(96, 29);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 398);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(455, 100);
            this.listBox.TabIndex = 13;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snimiToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fajlToolStripMenuItem.Text = "Fajl";
            // 
            // snimiToolStripMenuItem
            // 
            this.snimiToolStripMenuItem.Name = "snimiToolStripMenuItem";
            this.snimiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.snimiToolStripMenuItem.Text = "Snimi";
            this.snimiToolStripMenuItem.Click += new System.EventHandler(this.snimiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 513);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dateTimePickerDatumProizvodnje);
            this.Controls.Add(this.numUpDownKapacitetBaterije);
            this.Controls.Add(this.numUpDownZapreminaMotora);
            this.Controls.Add(this.cmbBoxVrstaGoriva);
            this.Controls.Add(this.txtBoxModel);
            this.Controls.Add(this.txtBoxProizvodjac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "                                 Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownZapreminaMotora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownKapacitetBaterije)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtBoxProizvodjac;
        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.ComboBox cmbBoxVrstaGoriva;
        private System.Windows.Forms.NumericUpDown numUpDownZapreminaMotora;
        private System.Windows.Forms.NumericUpDown numUpDownKapacitetBaterije;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumProizvodnje;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snimiToolStripMenuItem;
    }
}

