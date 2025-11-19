namespace PjApril2025Zad3
{
    partial class Form
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
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.numUpDownBroj = new System.Windows.Forms.NumericUpDown();
            this.dateTimeDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioBtnABA = new System.Windows.Forms.RadioButton();
            this.radioBtnEuroLeague = new System.Windows.Forms.RadioButton();
            this.radioBtnNBA = new System.Windows.Forms.RadioButton();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.checkBoxZauzet = new System.Windows.Forms.CheckBox();
            this.menuStripFajl = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBroj)).BeginInit();
            this.groupBox.SuspendLayout();
            this.menuStripFajl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum rodjenja:";
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Location = new System.Drawing.Point(179, 52);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(171, 22);
            this.txtBoxIme.TabIndex = 4;
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Location = new System.Drawing.Point(179, 101);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(171, 22);
            this.txtBoxPrezime.TabIndex = 5;
            // 
            // numUpDownBroj
            // 
            this.numUpDownBroj.Location = new System.Drawing.Point(179, 155);
            this.numUpDownBroj.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numUpDownBroj.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownBroj.Name = "numUpDownBroj";
            this.numUpDownBroj.Size = new System.Drawing.Size(171, 22);
            this.numUpDownBroj.TabIndex = 6;
            this.numUpDownBroj.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimeDatumRodjenja
            // 
            this.dateTimeDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDatumRodjenja.Location = new System.Drawing.Point(162, 323);
            this.dateTimeDatumRodjenja.Name = "dateTimeDatumRodjenja";
            this.dateTimeDatumRodjenja.Size = new System.Drawing.Size(200, 22);
            this.dateTimeDatumRodjenja.TabIndex = 7;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioBtnNBA);
            this.groupBox.Controls.Add(this.radioBtnEuroLeague);
            this.groupBox.Controls.Add(this.radioBtnABA);
            this.groupBox.Location = new System.Drawing.Point(49, 202);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(361, 73);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Liga";
            // 
            // radioBtnABA
            // 
            this.radioBtnABA.AutoSize = true;
            this.radioBtnABA.Location = new System.Drawing.Point(19, 31);
            this.radioBtnABA.Name = "radioBtnABA";
            this.radioBtnABA.Size = new System.Drawing.Size(55, 20);
            this.radioBtnABA.TabIndex = 0;
            this.radioBtnABA.TabStop = true;
            this.radioBtnABA.Text = "ABA";
            this.radioBtnABA.UseVisualStyleBackColor = true;
            // 
            // radioBtnEuroLeague
            // 
            this.radioBtnEuroLeague.AutoSize = true;
            this.radioBtnEuroLeague.Location = new System.Drawing.Point(117, 31);
            this.radioBtnEuroLeague.Name = "radioBtnEuroLeague";
            this.radioBtnEuroLeague.Size = new System.Drawing.Size(102, 20);
            this.radioBtnEuroLeague.TabIndex = 1;
            this.radioBtnEuroLeague.TabStop = true;
            this.radioBtnEuroLeague.Text = "EuroLeague";
            this.radioBtnEuroLeague.UseVisualStyleBackColor = true;
            // 
            // radioBtnNBA
            // 
            this.radioBtnNBA.AutoSize = true;
            this.radioBtnNBA.Location = new System.Drawing.Point(249, 31);
            this.radioBtnNBA.Name = "radioBtnNBA";
            this.radioBtnNBA.Size = new System.Drawing.Size(56, 20);
            this.radioBtnNBA.TabIndex = 2;
            this.radioBtnNBA.TabStop = true;
            this.radioBtnNBA.Text = "NBA";
            this.radioBtnNBA.UseVisualStyleBackColor = true;
            this.radioBtnNBA.CheckedChanged += new System.EventHandler(this.radioBtnNBA_CheckedChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 359);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(103, 31);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 406);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(467, 116);
            this.listBox.TabIndex = 10;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // checkBoxZauzet
            // 
            this.checkBoxZauzet.AutoSize = true;
            this.checkBoxZauzet.Location = new System.Drawing.Point(162, 281);
            this.checkBoxZauzet.Name = "checkBoxZauzet";
            this.checkBoxZauzet.Size = new System.Drawing.Size(69, 20);
            this.checkBoxZauzet.TabIndex = 11;
            this.checkBoxZauzet.Text = "Zauzet";
            this.checkBoxZauzet.UseVisualStyleBackColor = true;
            // 
            // menuStripFajl
            // 
            this.menuStripFajl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripFajl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem});
            this.menuStripFajl.Location = new System.Drawing.Point(0, 0);
            this.menuStripFajl.Name = "menuStripFajl";
            this.menuStripFajl.Size = new System.Drawing.Size(491, 28);
            this.menuStripFajl.TabIndex = 12;
            this.menuStripFajl.Text = "menuStrip1";
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
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 534);
            this.Controls.Add(this.checkBoxZauzet);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dateTimeDatumRodjenja);
            this.Controls.Add(this.numUpDownBroj);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.txtBoxIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripFajl);
            this.MainMenuStrip = this.menuStripFajl;
            this.Name = "Form";
            this.Text = "                                  Reprezentacija";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBroj)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.menuStripFajl.ResumeLayout(false);
            this.menuStripFajl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.NumericUpDown numUpDownBroj;
        private System.Windows.Forms.DateTimePicker dateTimeDatumRodjenja;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioBtnNBA;
        private System.Windows.Forms.RadioButton radioBtnEuroLeague;
        private System.Windows.Forms.RadioButton radioBtnABA;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.CheckBox checkBoxZauzet;
        private System.Windows.Forms.MenuStrip menuStripFajl;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snimiToolStripMenuItem;
    }
}

