namespace PjJun2025Zad3
{
    partial class FormPodaci
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
            this.labela = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVrstaGoriva = new System.Windows.Forms.Label();
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.lblDatumProizvodnje = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(71, 56);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(81, 16);
            this.labela.TabIndex = 0;
            this.labela.Text = "Proizvodjac:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum proizvodnje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrsta Goriva:";
            // 
            // lblVrstaGoriva
            // 
            this.lblVrstaGoriva.AutoSize = true;
            this.lblVrstaGoriva.Location = new System.Drawing.Point(220, 123);
            this.lblVrstaGoriva.Name = "lblVrstaGoriva";
            this.lblVrstaGoriva.Size = new System.Drawing.Size(44, 16);
            this.lblVrstaGoriva.TabIndex = 3;
            this.lblVrstaGoriva.Text = "label4";
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(220, 56);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(44, 16);
            this.lblProizvodjac.TabIndex = 4;
            this.lblProizvodjac.Text = "label5";
            // 
            // lblDatumProizvodnje
            // 
            this.lblDatumProizvodnje.AutoSize = true;
            this.lblDatumProizvodnje.Location = new System.Drawing.Point(220, 202);
            this.lblDatumProizvodnje.Name = "lblDatumProizvodnje";
            this.lblDatumProizvodnje.Size = new System.Drawing.Size(44, 16);
            this.lblDatumProizvodnje.TabIndex = 5;
            this.lblDatumProizvodnje.Text = "label6";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(142, 261);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 28);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormPodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 310);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblDatumProizvodnje);
            this.Controls.Add(this.lblProizvodjac);
            this.Controls.Add(this.lblVrstaGoriva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labela);
            this.Name = "FormPodaci";
            this.Text = "FormPodaci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVrstaGoriva;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.Label lblDatumProizvodnje;
        private System.Windows.Forms.Button btnOK;
    }
}