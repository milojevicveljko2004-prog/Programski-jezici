namespace PjSeptembar2025Zad3
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
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.upDownRanking = new System.Windows.Forms.NumericUpDown();
            this.dateTimeDatumRodj = new System.Windows.Forms.DateTimePicker();
            this.upDownBrTitula = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAllRound = new System.Windows.Forms.RadioButton();
            this.btnServe = new System.Windows.Forms.RadioButton();
            this.btnBaseline = new System.Windows.Forms.RadioButton();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.checkBoxPenzionisan = new System.Windows.Forms.CheckBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.upDownRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownBrTitula)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ranking:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum rodjenja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Broj titula:";
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Location = new System.Drawing.Point(172, 57);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(180, 22);
            this.txtBoxIme.TabIndex = 5;
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Location = new System.Drawing.Point(173, 110);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(180, 22);
            this.txtBoxPrezime.TabIndex = 6;
            // 
            // upDownRanking
            // 
            this.upDownRanking.Location = new System.Drawing.Point(173, 167);
            this.upDownRanking.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownRanking.Name = "upDownRanking";
            this.upDownRanking.Size = new System.Drawing.Size(179, 22);
            this.upDownRanking.TabIndex = 7;
            this.upDownRanking.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimeDatumRodj
            // 
            this.dateTimeDatumRodj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDatumRodj.Location = new System.Drawing.Point(173, 220);
            this.dateTimeDatumRodj.Name = "dateTimeDatumRodj";
            this.dateTimeDatumRodj.Size = new System.Drawing.Size(200, 22);
            this.dateTimeDatumRodj.TabIndex = 8;
            // 
            // upDownBrTitula
            // 
            this.upDownBrTitula.Location = new System.Drawing.Point(166, 273);
            this.upDownBrTitula.Maximum = new decimal(new int[] {
            109,
            0,
            0,
            0});
            this.upDownBrTitula.Name = "upDownBrTitula";
            this.upDownBrTitula.Size = new System.Drawing.Size(186, 22);
            this.upDownBrTitula.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAllRound);
            this.groupBox1.Controls.Add(this.btnServe);
            this.groupBox1.Controls.Add(this.btnBaseline);
            this.groupBox1.Location = new System.Drawing.Point(41, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 77);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stil igre";
            // 
            // btnAllRound
            // 
            this.btnAllRound.AutoSize = true;
            this.btnAllRound.Location = new System.Drawing.Point(271, 36);
            this.btnAllRound.Name = "btnAllRound";
            this.btnAllRound.Size = new System.Drawing.Size(80, 20);
            this.btnAllRound.TabIndex = 2;
            this.btnAllRound.TabStop = true;
            this.btnAllRound.Text = "All round";
            this.btnAllRound.UseVisualStyleBackColor = true;
            // 
            // btnServe
            // 
            this.btnServe.AutoSize = true;
            this.btnServe.Location = new System.Drawing.Point(116, 36);
            this.btnServe.Name = "btnServe";
            this.btnServe.Size = new System.Drawing.Size(129, 20);
            this.btnServe.TabIndex = 1;
            this.btnServe.TabStop = true;
            this.btnServe.Text = "Serve and volley";
            this.btnServe.UseVisualStyleBackColor = true;
            // 
            // btnBaseline
            // 
            this.btnBaseline.AutoSize = true;
            this.btnBaseline.Location = new System.Drawing.Point(16, 36);
            this.btnBaseline.Name = "btnBaseline";
            this.btnBaseline.Size = new System.Drawing.Size(81, 20);
            this.btnBaseline.TabIndex = 0;
            this.btnBaseline.TabStop = true;
            this.btnBaseline.Text = "Baseline";
            this.btnBaseline.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(41, 407);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(118, 29);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // checkBoxPenzionisan
            // 
            this.checkBoxPenzionisan.AutoSize = true;
            this.checkBoxPenzionisan.Location = new System.Drawing.Point(290, 407);
            this.checkBoxPenzionisan.Name = "checkBoxPenzionisan";
            this.checkBoxPenzionisan.Size = new System.Drawing.Size(102, 20);
            this.checkBoxPenzionisan.TabIndex = 15;
            this.checkBoxPenzionisan.Text = "Penzionisan";
            this.checkBoxPenzionisan.UseVisualStyleBackColor = true;
            this.checkBoxPenzionisan.CheckedChanged += new System.EventHandler(this.checkBoxPenzionisan_CheckedChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(4, 446);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(600, 116);
            this.listBox.TabIndex = 16;
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 28);
            this.menuStrip1.TabIndex = 17;
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
            this.snimiToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.snimiToolStripMenuItem.Text = "Snimi";
            this.snimiToolStripMenuItem.Click += new System.EventHandler(this.snimiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 577);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.checkBoxPenzionisan);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.upDownBrTitula);
            this.Controls.Add(this.dateTimeDatumRodj);
            this.Controls.Add(this.upDownRanking);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.txtBoxIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.upDownRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownBrTitula)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.NumericUpDown upDownRanking;
        private System.Windows.Forms.DateTimePicker dateTimeDatumRodj;
        private System.Windows.Forms.NumericUpDown upDownBrTitula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnAllRound;
        private System.Windows.Forms.RadioButton btnServe;
        private System.Windows.Forms.RadioButton btnBaseline;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.CheckBox checkBoxPenzionisan;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snimiToolStripMenuItem;
    }
}

