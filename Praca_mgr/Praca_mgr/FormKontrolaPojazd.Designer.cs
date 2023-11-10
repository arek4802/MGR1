namespace Praca_mgr
{
    partial class FormKontrolaPojazd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKontrolaPojazd));
            this.btnAlert = new System.Windows.Forms.Button();
            this.dgvRezultatKontroli = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnWczytajZamowienie = new System.Windows.Forms.Button();
            this.cbZamowienie = new System.Windows.Forms.ComboBox();
            this.dgvPozytywne = new System.Windows.Forms.DataGridView();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.dgvvKontrolaJakosciKolejka = new System.Windows.Forms.DataGridView();
            this.dTPDataOd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cBRodzajKontrola = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBPracownik = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUwagi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chBoxWynik = new System.Windows.Forms.CheckBox();
            this.btnRezultat = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.txtCzynnosc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultatKontroli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPozytywne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvKontrolaJakosciKolejka)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlert
            // 
            this.btnAlert.BackColor = System.Drawing.Color.LightYellow;
            this.btnAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAlert.Location = new System.Drawing.Point(819, 16);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(344, 63);
            this.btnAlert.TabIndex = 137;
            this.btnAlert.Text = "POWIADOM O REALIZACJI";
            this.btnAlert.UseVisualStyleBackColor = false;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // dgvRezultatKontroli
            // 
            this.dgvRezultatKontroli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezultatKontroli.Location = new System.Drawing.Point(310, 475);
            this.dgvRezultatKontroli.Name = "dgvRezultatKontroli";
            this.dgvRezultatKontroli.Size = new System.Drawing.Size(349, 123);
            this.dgvRezultatKontroli.TabIndex = 135;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 13F);
            this.label12.Location = new System.Drawing.Point(306, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 21);
            this.label12.TabIndex = 134;
            this.label12.Text = "Rezultat kontroli:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 16F);
            this.label11.Location = new System.Drawing.Point(692, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(319, 25);
            this.label11.TabIndex = 133;
            this.label11.Text = "Czynności z pozytywną kontrolą";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 16F);
            this.label9.Location = new System.Drawing.Point(305, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 25);
            this.label9.TabIndex = 132;
            this.label9.Text = "Wybierz czynność na pojaździe:";
            // 
            // btnWczytajZamowienie
            // 
            this.btnWczytajZamowienie.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnWczytajZamowienie.Font = new System.Drawing.Font("Arial", 15F);
            this.btnWczytajZamowienie.Location = new System.Drawing.Point(310, 367);
            this.btnWczytajZamowienie.Name = "btnWczytajZamowienie";
            this.btnWczytajZamowienie.Size = new System.Drawing.Size(349, 37);
            this.btnWczytajZamowienie.TabIndex = 131;
            this.btnWczytajZamowienie.Text = "Wczytaj pojazd";
            this.btnWczytajZamowienie.UseVisualStyleBackColor = false;
            this.btnWczytajZamowienie.Click += new System.EventHandler(this.btnWczytajZamowienie_Click);
            // 
            // cbZamowienie
            // 
            this.cbZamowienie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbZamowienie.FormattingEnabled = true;
            this.cbZamowienie.Location = new System.Drawing.Point(310, 321);
            this.cbZamowienie.Name = "cbZamowienie";
            this.cbZamowienie.Size = new System.Drawing.Size(349, 25);
            this.cbZamowienie.TabIndex = 130;
            // 
            // dgvPozytywne
            // 
            this.dgvPozytywne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPozytywne.Location = new System.Drawing.Point(697, 221);
            this.dgvPozytywne.Name = "dgvPozytywne";
            this.dgvPozytywne.Size = new System.Drawing.Size(593, 290);
            this.dgvPozytywne.TabIndex = 129;
            // 
            // txtNazwa
            // 
            this.txtNazwa.Enabled = false;
            this.txtNazwa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwa.Location = new System.Drawing.Point(12, 54);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(212, 25);
            this.txtNazwa.TabIndex = 126;
            // 
            // dgvvKontrolaJakosciKolejka
            // 
            this.dgvvKontrolaJakosciKolejka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvKontrolaJakosciKolejka.Location = new System.Drawing.Point(310, 45);
            this.dgvvKontrolaJakosciKolejka.Name = "dgvvKontrolaJakosciKolejka";
            this.dgvvKontrolaJakosciKolejka.Size = new System.Drawing.Size(349, 259);
            this.dgvvKontrolaJakosciKolejka.TabIndex = 125;
            this.dgvvKontrolaJakosciKolejka.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvKontrolaJakosciKolejka_CellContentClick);
            // 
            // dTPDataOd
            // 
            this.dTPDataOd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dTPDataOd.Location = new System.Drawing.Point(12, 309);
            this.dTPDataOd.MinDate = new System.DateTime(2022, 10, 19, 9, 12, 39, 0);
            this.dTPDataOd.Name = "dTPDataOd";
            this.dTPDataOd.Size = new System.Drawing.Size(212, 20);
            this.dTPDataOd.TabIndex = 123;
            this.dTPDataOd.Value = new System.DateTime(2022, 10, 19, 9, 12, 39, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(23, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 121;
            this.label7.Text = "Data kontroli";
            // 
            // cBRodzajKontrola
            // 
            this.cBRodzajKontrola.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBRodzajKontrola.FormattingEnabled = true;
            this.cBRodzajKontrola.Location = new System.Drawing.Point(12, 255);
            this.cBRodzajKontrola.Name = "cBRodzajKontrola";
            this.cBRodzajKontrola.Size = new System.Drawing.Size(212, 25);
            this.cBRodzajKontrola.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(23, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 119;
            this.label5.Text = "Rodzaj kontroli";
            // 
            // cBPracownik
            // 
            this.cBPracownik.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBPracownik.FormattingEnabled = true;
            this.cBPracownik.Location = new System.Drawing.Point(12, 193);
            this.cBPracownik.Name = "cBPracownik";
            this.cBPracownik.Size = new System.Drawing.Size(212, 25);
            this.cBPracownik.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(23, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 117;
            this.label4.Text = "Pracownik";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(21, 501);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(212, 37);
            this.btnDodaj.TabIndex = 113;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 112;
            this.label1.Text = "Pojazd";
            // 
            // txtUwagi
            // 
            this.txtUwagi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUwagi.Location = new System.Drawing.Point(12, 371);
            this.txtUwagi.Name = "txtUwagi";
            this.txtUwagi.Size = new System.Drawing.Size(212, 25);
            this.txtUwagi.TabIndex = 139;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(23, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 138;
            this.label6.Text = "Uwagi";
            // 
            // chBoxWynik
            // 
            this.chBoxWynik.BackColor = System.Drawing.Color.Transparent;
            this.chBoxWynik.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chBoxWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBoxWynik.Location = new System.Drawing.Point(12, 405);
            this.chBoxWynik.Name = "chBoxWynik";
            this.chBoxWynik.Size = new System.Drawing.Size(280, 67);
            this.chBoxWynik.TabIndex = 141;
            this.chBoxWynik.Text = "Kontrola pozytywna";
            this.chBoxWynik.UseVisualStyleBackColor = false;
            // 
            // btnRezultat
            // 
            this.btnRezultat.BackColor = System.Drawing.Color.Thistle;
            this.btnRezultat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRezultat.BackgroundImage")));
            this.btnRezultat.Font = new System.Drawing.Font("Arial", 15F);
            this.btnRezultat.Image = ((System.Drawing.Image)(resources.GetObject("btnRezultat.Image")));
            this.btnRezultat.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRezultat.Location = new System.Drawing.Point(269, 564);
            this.btnRezultat.Name = "btnRezultat";
            this.btnRezultat.Size = new System.Drawing.Size(35, 34);
            this.btnRezultat.TabIndex = 142;
            this.btnRezultat.UseVisualStyleBackColor = false;
            this.btnRezultat.Click += new System.EventHandler(this.btnRezultat_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(21, 559);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(212, 37);
            this.btnOdswiez.TabIndex = 143;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // txtCzynnosc
            // 
            this.txtCzynnosc.Enabled = false;
            this.txtCzynnosc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCzynnosc.Location = new System.Drawing.Point(12, 120);
            this.txtCzynnosc.Name = "txtCzynnosc";
            this.txtCzynnosc.Size = new System.Drawing.Size(212, 25);
            this.txtCzynnosc.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 144;
            this.label2.Text = "Czynność montażowa";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15F);
            this.button1.Location = new System.Drawing.Point(893, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 37);
            this.button1.TabIndex = 146;
            this.button1.Text = "Magazyn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormKontrolaPojazd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1346, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCzynnosc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnRezultat);
            this.Controls.Add(this.chBoxWynik);
            this.Controls.Add(this.txtUwagi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAlert);
            this.Controls.Add(this.dgvRezultatKontroli);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnWczytajZamowienie);
            this.Controls.Add(this.cbZamowienie);
            this.Controls.Add(this.dgvPozytywne);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.dgvvKontrolaJakosciKolejka);
            this.Controls.Add(this.dTPDataOd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBRodzajKontrola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBPracownik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Name = "FormKontrolaPojazd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kontrola Jakości Pojazd";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultatKontroli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPozytywne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvKontrolaJakosciKolejka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlert;
        private System.Windows.Forms.DataGridView dgvRezultatKontroli;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnWczytajZamowienie;
        private System.Windows.Forms.ComboBox cbZamowienie;
        private System.Windows.Forms.DataGridView dgvPozytywne;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.DataGridView dgvvKontrolaJakosciKolejka;
        private System.Windows.Forms.DateTimePicker dTPDataOd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBRodzajKontrola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBPracownik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUwagi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chBoxWynik;
        private System.Windows.Forms.Button btnRezultat;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.TextBox txtCzynnosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}