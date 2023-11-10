namespace Praca_mgr
{
    partial class FormMontaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMontaz));
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpCzasDo = new System.Windows.Forms.DateTimePicker();
            this.dtpCzasOd = new System.Windows.Forms.DateTimePicker();
            this.btnAkceptuj = new System.Windows.Forms.Button();
            this.txtSzukanyProduktNazwa = new System.Windows.Forms.TextBox();
            this.txtSzukanyProduktID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbZamowienie = new System.Windows.Forms.ComboBox();
            this.dgvZamowienieSzczegol = new System.Windows.Forms.DataGridView();
            this.dgvCzynnosci = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWykonane = new System.Windows.Forms.DataGridView();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.dtpDataDo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataOd = new System.Windows.Forms.DateTimePicker();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCzynnosc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieSzczegol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzynnosci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWykonane)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 14F);
            this.label12.Location = new System.Drawing.Point(394, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 22);
            this.label12.TabIndex = 122;
            this.label12.Text = "Zakończone procesy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 14F);
            this.label11.Location = new System.Drawing.Point(393, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 22);
            this.label11.TabIndex = 121;
            this.label11.Text = "Wybierz czynność montażową";
            // 
            // dtpCzasDo
            // 
            this.dtpCzasDo.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpCzasDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCzasDo.Location = new System.Drawing.Point(247, 350);
            this.dtpCzasDo.Name = "dtpCzasDo";
            this.dtpCzasDo.Size = new System.Drawing.Size(118, 26);
            this.dtpCzasDo.TabIndex = 120;
            // 
            // dtpCzasOd
            // 
            this.dtpCzasOd.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpCzasOd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCzasOd.Location = new System.Drawing.Point(247, 263);
            this.dtpCzasOd.Name = "dtpCzasOd";
            this.dtpCzasOd.Size = new System.Drawing.Size(118, 26);
            this.dtpCzasOd.TabIndex = 119;
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAkceptuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAkceptuj.Location = new System.Drawing.Point(1162, 493);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(380, 37);
            this.btnAkceptuj.TabIndex = 115;
            this.btnAkceptuj.Text = "Akceptuj wybór";
            this.btnAkceptuj.UseVisualStyleBackColor = false;
            this.btnAkceptuj.Click += new System.EventHandler(this.btnAkceptuj_Click);
            // 
            // txtSzukanyProduktNazwa
            // 
            this.txtSzukanyProduktNazwa.Enabled = false;
            this.txtSzukanyProduktNazwa.Font = new System.Drawing.Font("Arial", 15F);
            this.txtSzukanyProduktNazwa.Location = new System.Drawing.Point(1269, 442);
            this.txtSzukanyProduktNazwa.Name = "txtSzukanyProduktNazwa";
            this.txtSzukanyProduktNazwa.Size = new System.Drawing.Size(273, 30);
            this.txtSzukanyProduktNazwa.TabIndex = 114;
            // 
            // txtSzukanyProduktID
            // 
            this.txtSzukanyProduktID.Enabled = false;
            this.txtSzukanyProduktID.Font = new System.Drawing.Font("Arial", 15F);
            this.txtSzukanyProduktID.Location = new System.Drawing.Point(1162, 442);
            this.txtSzukanyProduktID.Name = "txtSzukanyProduktID";
            this.txtSzukanyProduktID.Size = new System.Drawing.Size(46, 30);
            this.txtSzukanyProduktID.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(1264, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 25);
            this.label8.TabIndex = 112;
            this.label8.Text = "Numer VIN pojazdu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(1157, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 25);
            this.label7.TabIndex = 111;
            this.label7.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(1157, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(379, 25);
            this.label6.TabIndex = 110;
            this.label6.Text = "Przygotowanie procesu montażowego dla:";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSzukaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnSzukaj.Location = new System.Drawing.Point(1354, 42);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(217, 37);
            this.btnSzukaj.TabIndex = 109;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = false;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(1119, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 108;
            this.label5.Text = "Zamówienie:";
            // 
            // cbZamowienie
            // 
            this.cbZamowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbZamowienie.FormattingEnabled = true;
            this.cbZamowienie.Location = new System.Drawing.Point(1124, 85);
            this.cbZamowienie.Name = "cbZamowienie";
            this.cbZamowienie.Size = new System.Drawing.Size(447, 28);
            this.cbZamowienie.TabIndex = 107;
            // 
            // dgvZamowienieSzczegol
            // 
            this.dgvZamowienieSzczegol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienieSzczegol.Location = new System.Drawing.Point(1124, 119);
            this.dgvZamowienieSzczegol.Name = "dgvZamowienieSzczegol";
            this.dgvZamowienieSzczegol.Size = new System.Drawing.Size(447, 220);
            this.dgvZamowienieSzczegol.TabIndex = 106;
            this.dgvZamowienieSzczegol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZamowienieSzczegol_CellContentClick);
            // 
            // dgvCzynnosci
            // 
            this.dgvCzynnosci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzynnosci.Location = new System.Drawing.Point(397, 80);
            this.dgvCzynnosci.Name = "dgvCzynnosci";
            this.dgvCzynnosci.Size = new System.Drawing.Size(684, 259);
            this.dgvCzynnosci.TabIndex = 105;
            this.dgvCzynnosci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCzynnosci_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(26, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 104;
            this.label4.Text = "Data zakończenia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(26, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 103;
            this.label3.Text = "Data rozpoczęcia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 100;
            this.label1.Text = "Pracownik:";
            // 
            // dgvWykonane
            // 
            this.dgvWykonane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWykonane.Location = new System.Drawing.Point(398, 403);
            this.dgvWykonane.Name = "dgvWykonane";
            this.dgvWykonane.Size = new System.Drawing.Size(683, 177);
            this.dgvWykonane.TabIndex = 99;
            // 
            // cbPracownik
            // 
            this.cbPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(31, 103);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(334, 28);
            this.cbPracownik.TabIndex = 98;
            // 
            // dtpDataDo
            // 
            this.dtpDataDo.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDataDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataDo.Location = new System.Drawing.Point(31, 350);
            this.dtpDataDo.Name = "dtpDataDo";
            this.dtpDataDo.Size = new System.Drawing.Size(200, 26);
            this.dtpDataDo.TabIndex = 97;
            this.dtpDataDo.Value = new System.DateTime(2022, 10, 19, 8, 51, 31, 0);
            // 
            // dtpDataOd
            // 
            this.dtpDataOd.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDataOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataOd.Location = new System.Drawing.Point(31, 263);
            this.dtpDataOd.Name = "dtpDataOd";
            this.dtpDataOd.Size = new System.Drawing.Size(200, 26);
            this.dtpDataOd.TabIndex = 96;
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(31, 485);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(334, 37);
            this.btnOdswiez.TabIndex = 93;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(31, 430);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 92;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(27, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 124;
            this.label2.Text = "Czynność:";
            // 
            // txtCzynnosc
            // 
            this.txtCzynnosc.Enabled = false;
            this.txtCzynnosc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCzynnosc.Location = new System.Drawing.Point(31, 181);
            this.txtCzynnosc.Name = "txtCzynnosc";
            this.txtCzynnosc.Size = new System.Drawing.Size(334, 29);
            this.txtCzynnosc.TabIndex = 123;
            // 
            // FormMontaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1602, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCzynnosc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpCzasDo);
            this.Controls.Add(this.dtpCzasOd);
            this.Controls.Add(this.btnAkceptuj);
            this.Controls.Add(this.txtSzukanyProduktNazwa);
            this.Controls.Add(this.txtSzukanyProduktID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbZamowienie);
            this.Controls.Add(this.dgvZamowienieSzczegol);
            this.Controls.Add(this.dgvCzynnosci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWykonane);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.dtpDataDo);
            this.Controls.Add(this.dtpDataOd);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnDodaj);
            this.Name = "FormMontaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Montaż Pojazdu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieSzczegol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzynnosci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWykonane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpCzasDo;
        private System.Windows.Forms.DateTimePicker dtpCzasOd;
        private System.Windows.Forms.Button btnAkceptuj;
        private System.Windows.Forms.TextBox txtSzukanyProduktNazwa;
        private System.Windows.Forms.TextBox txtSzukanyProduktID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbZamowienie;
        private System.Windows.Forms.DataGridView dgvZamowienieSzczegol;
        private System.Windows.Forms.DataGridView dgvCzynnosci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWykonane;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.DateTimePicker dtpDataDo;
        private System.Windows.Forms.DateTimePicker dtpDataOd;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCzynnosc;
    }
}