namespace Praca_mgr
{
    partial class FormKontrolaJakosciPolprodukt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKontrolaJakosciPolprodukt));
            this.btnAlert = new System.Windows.Forms.Button();
            this.btnRezultat = new System.Windows.Forms.Button();
            this.txtKontrolaIlosc = new System.Windows.Forms.TextBox();
            this.dgvRezultatKontroli = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnWczytajZamowienie = new System.Windows.Forms.Button();
            this.cbZamowienie = new System.Windows.Forms.ComboBox();
            this.btnGeneruj = new System.Windows.Forms.Button();
            this.dgvPozytywne = new System.Windows.Forms.DataGridView();
            this.dTPCzasDo = new System.Windows.Forms.DateTimePicker();
            this.dTPCzasOd = new System.Windows.Forms.DateTimePicker();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.dgvvKontrolaJakosciKolejka = new System.Windows.Forms.DataGridView();
            this.dTPDataDo = new System.Windows.Forms.DateTimePicker();
            this.dTPDataOd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUwagi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBRodzajKontrola = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBPracownik = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvvKontrolaPolprodukt = new System.Windows.Forms.DataGridView();
            this.txtWartosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParametrPolprodukt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAkceptuj = new System.Windows.Forms.Button();
            this.dgvvParametrPolprodukt = new System.Windows.Forms.DataGridView();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultatKontroli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPozytywne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvKontrolaJakosciKolejka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvKontrolaPolprodukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvParametrPolprodukt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlert
            // 
            this.btnAlert.BackColor = System.Drawing.Color.LightYellow;
            this.btnAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAlert.Location = new System.Drawing.Point(944, 28);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(344, 63);
            this.btnAlert.TabIndex = 147;
            this.btnAlert.Text = "POWIADOM O REALIZACJI";
            this.btnAlert.UseVisualStyleBackColor = false;
            // 
            // btnRezultat
            // 
            this.btnRezultat.BackColor = System.Drawing.Color.Thistle;
            this.btnRezultat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRezultat.BackgroundImage")));
            this.btnRezultat.Font = new System.Drawing.Font("Arial", 15F);
            this.btnRezultat.Image = ((System.Drawing.Image)(resources.GetObject("btnRezultat.Image")));
            this.btnRezultat.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRezultat.Location = new System.Drawing.Point(284, 653);
            this.btnRezultat.Name = "btnRezultat";
            this.btnRezultat.Size = new System.Drawing.Size(35, 34);
            this.btnRezultat.TabIndex = 146;
            this.btnRezultat.UseVisualStyleBackColor = false;
            // 
            // txtKontrolaIlosc
            // 
            this.txtKontrolaIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtKontrolaIlosc.Location = new System.Drawing.Point(574, 517);
            this.txtKontrolaIlosc.Name = "txtKontrolaIlosc";
            this.txtKontrolaIlosc.Size = new System.Drawing.Size(100, 38);
            this.txtKontrolaIlosc.TabIndex = 145;
            // 
            // dgvRezultatKontroli
            // 
            this.dgvRezultatKontroli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezultatKontroli.Location = new System.Drawing.Point(325, 564);
            this.dgvRezultatKontroli.Name = "dgvRezultatKontroli";
            this.dgvRezultatKontroli.Size = new System.Drawing.Size(349, 123);
            this.dgvRezultatKontroli.TabIndex = 144;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 13F);
            this.label12.Location = new System.Drawing.Point(321, 540);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 21);
            this.label12.TabIndex = 143;
            this.label12.Text = "Rezultat kontroli:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 16F);
            this.label11.Location = new System.Drawing.Point(700, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(332, 25);
            this.label11.TabIndex = 142;
            this.label11.Text = "Półprodukty z pozytywną kontrolą";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 16F);
            this.label10.Location = new System.Drawing.Point(700, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 25);
            this.label10.TabIndex = 141;
            this.label10.Text = "Wybierz parametr:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 16F);
            this.label9.Location = new System.Drawing.Point(320, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 25);
            this.label9.TabIndex = 140;
            this.label9.Text = "Wybierz półprodukt:";
            // 
            // btnWczytajZamowienie
            // 
            this.btnWczytajZamowienie.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnWczytajZamowienie.Font = new System.Drawing.Font("Arial", 15F);
            this.btnWczytajZamowienie.Location = new System.Drawing.Point(325, 423);
            this.btnWczytajZamowienie.Name = "btnWczytajZamowienie";
            this.btnWczytajZamowienie.Size = new System.Drawing.Size(349, 37);
            this.btnWczytajZamowienie.TabIndex = 139;
            this.btnWczytajZamowienie.Text = "Wczytaj półprodukty";
            this.btnWczytajZamowienie.UseVisualStyleBackColor = false;
            // 
            // cbZamowienie
            // 
            this.cbZamowienie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbZamowienie.FormattingEnabled = true;
            this.cbZamowienie.Location = new System.Drawing.Point(325, 374);
            this.cbZamowienie.Name = "cbZamowienie";
            this.cbZamowienie.Size = new System.Drawing.Size(349, 25);
            this.cbZamowienie.TabIndex = 138;
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.BackColor = System.Drawing.Color.Khaki;
            this.btnGeneruj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnGeneruj.Location = new System.Drawing.Point(325, 474);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(349, 37);
            this.btnGeneruj.TabIndex = 137;
            this.btnGeneruj.Text = "Pomiar Maszyna";
            this.btnGeneruj.UseVisualStyleBackColor = false;
            // 
            // dgvPozytywne
            // 
            this.dgvPozytywne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPozytywne.Location = new System.Drawing.Point(705, 437);
            this.dgvPozytywne.Name = "dgvPozytywne";
            this.dgvPozytywne.Size = new System.Drawing.Size(593, 290);
            this.dgvPozytywne.TabIndex = 136;
            // 
            // dTPCzasDo
            // 
            this.dTPCzasDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPCzasDo.Location = new System.Drawing.Point(147, 423);
            this.dTPCzasDo.Name = "dTPCzasDo";
            this.dTPCzasDo.Size = new System.Drawing.Size(101, 20);
            this.dTPCzasDo.TabIndex = 135;
            // 
            // dTPCzasOd
            // 
            this.dTPCzasOd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPCzasOd.Location = new System.Drawing.Point(147, 361);
            this.dTPCzasOd.Name = "dTPCzasOd";
            this.dTPCzasOd.Size = new System.Drawing.Size(101, 20);
            this.dTPCzasOd.TabIndex = 134;
            // 
            // txtNazwa
            // 
            this.txtNazwa.Enabled = false;
            this.txtNazwa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwa.Location = new System.Drawing.Point(36, 68);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(212, 25);
            this.txtNazwa.TabIndex = 133;
            // 
            // dgvvKontrolaJakosciKolejka
            // 
            this.dgvvKontrolaJakosciKolejka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvKontrolaJakosciKolejka.Location = new System.Drawing.Point(325, 99);
            this.dgvvKontrolaJakosciKolejka.Name = "dgvvKontrolaJakosciKolejka";
            this.dgvvKontrolaJakosciKolejka.Size = new System.Drawing.Size(349, 259);
            this.dgvvKontrolaJakosciKolejka.TabIndex = 132;
            // 
            // dTPDataDo
            // 
            this.dTPDataDo.Location = new System.Drawing.Point(36, 423);
            this.dTPDataDo.Name = "dTPDataDo";
            this.dTPDataDo.Size = new System.Drawing.Size(101, 20);
            this.dTPDataDo.TabIndex = 131;
            // 
            // dTPDataOd
            // 
            this.dTPDataOd.Location = new System.Drawing.Point(36, 361);
            this.dTPDataOd.Name = "dTPDataOd";
            this.dTPDataOd.Size = new System.Drawing.Size(101, 20);
            this.dTPDataOd.TabIndex = 130;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(47, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 129;
            this.label8.Text = "Data do";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(47, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 128;
            this.label7.Text = "Data od";
            // 
            // txtUwagi
            // 
            this.txtUwagi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUwagi.Location = new System.Drawing.Point(36, 483);
            this.txtUwagi.Name = "txtUwagi";
            this.txtUwagi.Size = new System.Drawing.Size(212, 25);
            this.txtUwagi.TabIndex = 127;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(47, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 126;
            this.label6.Text = "Uwagi";
            // 
            // cBRodzajKontrola
            // 
            this.cBRodzajKontrola.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBRodzajKontrola.FormattingEnabled = true;
            this.cBRodzajKontrola.Location = new System.Drawing.Point(36, 308);
            this.cBRodzajKontrola.Name = "cBRodzajKontrola";
            this.cBRodzajKontrola.Size = new System.Drawing.Size(212, 25);
            this.cBRodzajKontrola.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(47, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 124;
            this.label5.Text = "Rodzaj kontroli";
            // 
            // cBPracownik
            // 
            this.cBPracownik.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBPracownik.FormattingEnabled = true;
            this.cBPracownik.Location = new System.Drawing.Point(36, 251);
            this.cBPracownik.Name = "cBPracownik";
            this.cBPracownik.Size = new System.Drawing.Size(212, 25);
            this.cBPracownik.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(47, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 122;
            this.label4.Text = "Pracownik";
            // 
            // dgvvKontrolaPolprodukt
            // 
            this.dgvvKontrolaPolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvKontrolaPolprodukt.Location = new System.Drawing.Point(1632, 395);
            this.dgvvKontrolaPolprodukt.Name = "dgvvKontrolaPolprodukt";
            this.dgvvKontrolaPolprodukt.Size = new System.Drawing.Size(25, 282);
            this.dgvvKontrolaPolprodukt.TabIndex = 121;
            this.dgvvKontrolaPolprodukt.Visible = false;
            // 
            // txtWartosc
            // 
            this.txtWartosc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWartosc.Location = new System.Drawing.Point(36, 183);
            this.txtWartosc.Name = "txtWartosc";
            this.txtWartosc.Size = new System.Drawing.Size(212, 25);
            this.txtWartosc.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(47, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 119;
            this.label3.Text = "Wartość";
            // 
            // txtParametrPolprodukt
            // 
            this.txtParametrPolprodukt.Enabled = false;
            this.txtParametrPolprodukt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtParametrPolprodukt.Location = new System.Drawing.Point(36, 126);
            this.txtParametrPolprodukt.Name = "txtParametrPolprodukt";
            this.txtParametrPolprodukt.Size = new System.Drawing.Size(212, 25);
            this.txtParametrPolprodukt.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 117;
            this.label2.Text = "Parametr półproduktu";
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAkceptuj.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAkceptuj.Location = new System.Drawing.Point(147, 31);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(101, 31);
            this.btnAkceptuj.TabIndex = 116;
            this.btnAkceptuj.Text = "Akceptuj";
            this.btnAkceptuj.UseVisualStyleBackColor = false;
            // 
            // dgvvParametrPolprodukt
            // 
            this.dgvvParametrPolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvParametrPolprodukt.Location = new System.Drawing.Point(705, 99);
            this.dgvvParametrPolprodukt.Name = "dgvvParametrPolprodukt";
            this.dgvvParametrPolprodukt.Size = new System.Drawing.Size(593, 290);
            this.dgvvParametrPolprodukt.TabIndex = 115;
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(36, 621);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(212, 37);
            this.btnOdswiez.TabIndex = 114;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(36, 552);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(212, 37);
            this.btnDodaj.TabIndex = 113;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 112;
            this.label1.Text = "Półprodukt";
            // 
            // FormKontrolaJakosciPolprodukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1465, 790);
            this.Controls.Add(this.btnAlert);
            this.Controls.Add(this.btnRezultat);
            this.Controls.Add(this.txtKontrolaIlosc);
            this.Controls.Add(this.dgvRezultatKontroli);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnWczytajZamowienie);
            this.Controls.Add(this.cbZamowienie);
            this.Controls.Add(this.btnGeneruj);
            this.Controls.Add(this.dgvPozytywne);
            this.Controls.Add(this.dTPCzasDo);
            this.Controls.Add(this.dTPCzasOd);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.dgvvKontrolaJakosciKolejka);
            this.Controls.Add(this.dTPDataDo);
            this.Controls.Add(this.dTPDataOd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUwagi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBRodzajKontrola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBPracownik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvvKontrolaPolprodukt);
            this.Controls.Add(this.txtWartosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParametrPolprodukt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAkceptuj);
            this.Controls.Add(this.dgvvParametrPolprodukt);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Name = "FormKontrolaJakosciPolprodukt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kontrola Jakości Pólprodukt";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultatKontroli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPozytywne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvKontrolaJakosciKolejka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvKontrolaPolprodukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvParametrPolprodukt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlert;
        private System.Windows.Forms.Button btnRezultat;
        private System.Windows.Forms.TextBox txtKontrolaIlosc;
        private System.Windows.Forms.DataGridView dgvRezultatKontroli;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnWczytajZamowienie;
        private System.Windows.Forms.ComboBox cbZamowienie;
        private System.Windows.Forms.Button btnGeneruj;
        private System.Windows.Forms.DataGridView dgvPozytywne;
        private System.Windows.Forms.DateTimePicker dTPCzasDo;
        private System.Windows.Forms.DateTimePicker dTPCzasOd;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.DataGridView dgvvKontrolaJakosciKolejka;
        private System.Windows.Forms.DateTimePicker dTPDataDo;
        private System.Windows.Forms.DateTimePicker dTPDataOd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUwagi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBRodzajKontrola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBPracownik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvvKontrolaPolprodukt;
        private System.Windows.Forms.TextBox txtWartosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParametrPolprodukt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAkceptuj;
        private System.Windows.Forms.DataGridView dgvvParametrPolprodukt;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
    }
}