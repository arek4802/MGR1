﻿namespace Praca_mgr
{
    partial class FormWytwarzanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWytwarzanie));
            this.txtGenerowanaIlosc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvCurrentPolprodukt = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGenerujPolprodukt = new System.Windows.Forms.Button();
            this.dtpCzasDo = new System.Windows.Forms.DateTimePicker();
            this.dtpCzasOd = new System.Windows.Forms.DateTimePicker();
            this.txtWybrany = new System.Windows.Forms.TextBox();
            this.txtWybranyID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.dgvProcesPolprodukt = new System.Windows.Forms.DataGridView();
            this.dgvProcesProdukt = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStanowisko = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWytwarzanieProdukt = new System.Windows.Forms.DataGridView();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.dtpDataDo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataOd = new System.Windows.Forms.DateTimePicker();
            this.dgvWytwarzaniePolprodukt = new System.Windows.Forms.DataGridView();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentPolprodukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieSzczegol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesPolprodukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzanieProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzaniePolprodukt)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGenerowanaIlosc
            // 
            this.txtGenerowanaIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtGenerowanaIlosc.Location = new System.Drawing.Point(1374, 684);
            this.txtGenerowanaIlosc.Name = "txtGenerowanaIlosc";
            this.txtGenerowanaIlosc.Size = new System.Drawing.Size(62, 38);
            this.txtGenerowanaIlosc.TabIndex = 93;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 14F);
            this.label14.Location = new System.Drawing.Point(425, 570);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(217, 22);
            this.label14.TabIndex = 92;
            this.label14.Text = "Wytworzone półprodukty";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 14F);
            this.label12.Location = new System.Drawing.Point(425, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 22);
            this.label12.TabIndex = 91;
            this.label12.Text = "Wytworzone produkty";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 14F);
            this.label13.Location = new System.Drawing.Point(758, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(291, 22);
            this.label13.TabIndex = 90;
            this.label13.Text = "Wybierz czynność dla półroduktu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 14F);
            this.label11.Location = new System.Drawing.Point(424, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(276, 22);
            this.label11.TabIndex = 89;
            this.label11.Text = "Wybierz czynność dla produktu:";
            // 
            // dgvCurrentPolprodukt
            // 
            this.dgvCurrentPolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentPolprodukt.Location = new System.Drawing.Point(1454, 684);
            this.dgvCurrentPolprodukt.Name = "dgvCurrentPolprodukt";
            this.dgvCurrentPolprodukt.Size = new System.Drawing.Size(325, 51);
            this.dgvCurrentPolprodukt.TabIndex = 88;
            this.dgvCurrentPolprodukt.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(1370, 577);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(295, 20);
            this.label10.TabIndex = 87;
            this.label10.Text = "Wykorzystywane w celach symulacyjnych";
            // 
            // btnGenerujPolprodukt
            // 
            this.btnGenerujPolprodukt.BackColor = System.Drawing.Color.Yellow;
            this.btnGenerujPolprodukt.Font = new System.Drawing.Font("Arial", 15F);
            this.btnGenerujPolprodukt.Location = new System.Drawing.Point(1374, 600);
            this.btnGenerujPolprodukt.Name = "btnGenerujPolprodukt";
            this.btnGenerujPolprodukt.Size = new System.Drawing.Size(380, 61);
            this.btnGenerujPolprodukt.TabIndex = 86;
            this.btnGenerujPolprodukt.Text = "Generuj wytwarzanie";
            this.btnGenerujPolprodukt.UseVisualStyleBackColor = false;
            this.btnGenerujPolprodukt.Click += new System.EventHandler(this.btnGenerujPolprodukt_Click);
            // 
            // dtpCzasDo
            // 
            this.dtpCzasDo.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpCzasDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCzasDo.Location = new System.Drawing.Point(278, 359);
            this.dtpCzasDo.Name = "dtpCzasDo";
            this.dtpCzasDo.Size = new System.Drawing.Size(118, 26);
            this.dtpCzasDo.TabIndex = 85;
            // 
            // dtpCzasOd
            // 
            this.dtpCzasOd.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpCzasOd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCzasOd.Location = new System.Drawing.Point(278, 272);
            this.dtpCzasOd.Name = "dtpCzasOd";
            this.dtpCzasOd.Size = new System.Drawing.Size(118, 26);
            this.dtpCzasOd.TabIndex = 84;
            // 
            // txtWybrany
            // 
            this.txtWybrany.Enabled = false;
            this.txtWybrany.Font = new System.Drawing.Font("Arial", 15F);
            this.txtWybrany.Location = new System.Drawing.Point(833, 333);
            this.txtWybrany.Name = "txtWybrany";
            this.txtWybrany.Size = new System.Drawing.Size(273, 30);
            this.txtWybrany.TabIndex = 83;
            // 
            // txtWybranyID
            // 
            this.txtWybranyID.Enabled = false;
            this.txtWybranyID.Font = new System.Drawing.Font("Arial", 15F);
            this.txtWybranyID.Location = new System.Drawing.Point(781, 333);
            this.txtWybranyID.Name = "txtWybranyID";
            this.txtWybranyID.Size = new System.Drawing.Size(46, 30);
            this.txtWybranyID.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(424, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(351, 25);
            this.label9.TabIndex = 81;
            this.label9.Text = "Rozpoczynasz proces produkcyjny dla:";
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAkceptuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAkceptuj.Location = new System.Drawing.Point(1374, 498);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(380, 37);
            this.btnAkceptuj.TabIndex = 80;
            this.btnAkceptuj.Text = "Akceptuj wybór";
            this.btnAkceptuj.UseVisualStyleBackColor = false;
            this.btnAkceptuj.Click += new System.EventHandler(this.btnAkceptuj_Click);
            // 
            // txtSzukanyProduktNazwa
            // 
            this.txtSzukanyProduktNazwa.Enabled = false;
            this.txtSzukanyProduktNazwa.Font = new System.Drawing.Font("Arial", 15F);
            this.txtSzukanyProduktNazwa.Location = new System.Drawing.Point(1481, 447);
            this.txtSzukanyProduktNazwa.Name = "txtSzukanyProduktNazwa";
            this.txtSzukanyProduktNazwa.Size = new System.Drawing.Size(273, 30);
            this.txtSzukanyProduktNazwa.TabIndex = 79;
            // 
            // txtSzukanyProduktID
            // 
            this.txtSzukanyProduktID.Enabled = false;
            this.txtSzukanyProduktID.Font = new System.Drawing.Font("Arial", 15F);
            this.txtSzukanyProduktID.Location = new System.Drawing.Point(1374, 447);
            this.txtSzukanyProduktID.Name = "txtSzukanyProduktID";
            this.txtSzukanyProduktID.Size = new System.Drawing.Size(46, 30);
            this.txtSzukanyProduktID.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(1476, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 77;
            this.label8.Text = "Nazwa produktu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(1369, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 25);
            this.label7.TabIndex = 76;
            this.label7.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(1369, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(385, 25);
            this.label6.TabIndex = 75;
            this.label6.Text = "Przygotowanie procesu produkcyjnego dla:";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSzukaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnSzukaj.Location = new System.Drawing.Point(1566, 47);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(217, 37);
            this.btnSzukaj.TabIndex = 74;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = false;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(1331, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 73;
            this.label5.Text = "Zamówienie:";
            // 
            // cbZamowienie
            // 
            this.cbZamowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbZamowienie.FormattingEnabled = true;
            this.cbZamowienie.Location = new System.Drawing.Point(1336, 90);
            this.cbZamowienie.Name = "cbZamowienie";
            this.cbZamowienie.Size = new System.Drawing.Size(447, 28);
            this.cbZamowienie.TabIndex = 72;
            // 
            // dgvZamowienieSzczegol
            // 
            this.dgvZamowienieSzczegol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienieSzczegol.Location = new System.Drawing.Point(1336, 124);
            this.dgvZamowienieSzczegol.Name = "dgvZamowienieSzczegol";
            this.dgvZamowienieSzczegol.Size = new System.Drawing.Size(447, 220);
            this.dgvZamowienieSzczegol.TabIndex = 71;
            this.dgvZamowienieSzczegol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZamowienieSzczegol_CellContentClick);
            // 
            // dgvProcesPolprodukt
            // 
            this.dgvProcesPolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesPolprodukt.Location = new System.Drawing.Point(772, 68);
            this.dgvProcesPolprodukt.Name = "dgvProcesPolprodukt";
            this.dgvProcesPolprodukt.Size = new System.Drawing.Size(521, 259);
            this.dgvProcesPolprodukt.TabIndex = 70;
            this.dgvProcesPolprodukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesPolprodukt_CellContentClick);
            // 
            // dgvProcesProdukt
            // 
            this.dgvProcesProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesProdukt.Location = new System.Drawing.Point(428, 67);
            this.dgvProcesProdukt.Name = "dgvProcesProdukt";
            this.dgvProcesProdukt.Size = new System.Drawing.Size(329, 259);
            this.dgvProcesProdukt.TabIndex = 69;
            this.dgvProcesProdukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesProdukt_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(57, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 68;
            this.label4.Text = "Data zakończenia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(57, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "Data rozpoczęcia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(57, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "Stanowisko:";
            // 
            // cbStanowisko
            // 
            this.cbStanowisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbStanowisko.FormattingEnabled = true;
            this.cbStanowisko.Location = new System.Drawing.Point(62, 159);
            this.cbStanowisko.Name = "cbStanowisko";
            this.cbStanowisko.Size = new System.Drawing.Size(260, 28);
            this.cbStanowisko.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(57, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Pracownik:";
            // 
            // dgvWytwarzanieProdukt
            // 
            this.dgvWytwarzanieProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWytwarzanieProdukt.Location = new System.Drawing.Point(429, 390);
            this.dgvWytwarzanieProdukt.Name = "dgvWytwarzanieProdukt";
            this.dgvWytwarzanieProdukt.Size = new System.Drawing.Size(874, 177);
            this.dgvWytwarzanieProdukt.TabIndex = 63;
            // 
            // cbPracownik
            // 
            this.cbPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(62, 90);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(260, 28);
            this.cbPracownik.TabIndex = 62;
            // 
            // dtpDataDo
            // 
            this.dtpDataDo.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDataDo.Location = new System.Drawing.Point(62, 359);
            this.dtpDataDo.Name = "dtpDataDo";
            this.dtpDataDo.Size = new System.Drawing.Size(200, 26);
            this.dtpDataDo.TabIndex = 61;
            // 
            // dtpDataOd
            // 
            this.dtpDataOd.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDataOd.Location = new System.Drawing.Point(62, 272);
            this.dtpDataOd.Name = "dtpDataOd";
            this.dtpDataOd.Size = new System.Drawing.Size(200, 26);
            this.dtpDataOd.TabIndex = 60;
            // 
            // dgvWytwarzaniePolprodukt
            // 
            this.dgvWytwarzaniePolprodukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWytwarzaniePolprodukt.Location = new System.Drawing.Point(429, 596);
            this.dgvWytwarzaniePolprodukt.Name = "dgvWytwarzaniePolprodukt";
            this.dgvWytwarzaniePolprodukt.Size = new System.Drawing.Size(874, 177);
            this.dgvWytwarzaniePolprodukt.TabIndex = 59;
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(62, 656);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(334, 37);
            this.btnOdswiez.TabIndex = 56;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(62, 596);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 55;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FormWytwarzanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1822, 809);
            this.Controls.Add(this.txtGenerowanaIlosc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvCurrentPolprodukt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGenerujPolprodukt);
            this.Controls.Add(this.dtpCzasDo);
            this.Controls.Add(this.dtpCzasOd);
            this.Controls.Add(this.txtWybrany);
            this.Controls.Add(this.txtWybranyID);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.dgvProcesPolprodukt);
            this.Controls.Add(this.dgvProcesProdukt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStanowisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWytwarzanieProdukt);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.dtpDataDo);
            this.Controls.Add(this.dtpDataOd);
            this.Controls.Add(this.dgvWytwarzaniePolprodukt);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnDodaj);
            this.Name = "FormWytwarzanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wytwarzanie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentPolprodukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienieSzczegol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesPolprodukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzanieProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWytwarzaniePolprodukt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGenerowanaIlosc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvCurrentPolprodukt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGenerujPolprodukt;
        private System.Windows.Forms.DateTimePicker dtpCzasDo;
        private System.Windows.Forms.DateTimePicker dtpCzasOd;
        private System.Windows.Forms.TextBox txtWybrany;
        private System.Windows.Forms.TextBox txtWybranyID;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.DataGridView dgvProcesPolprodukt;
        private System.Windows.Forms.DataGridView dgvProcesProdukt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStanowisko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWytwarzanieProdukt;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.DateTimePicker dtpDataDo;
        private System.Windows.Forms.DateTimePicker dtpDataOd;
        private System.Windows.Forms.DataGridView dgvWytwarzaniePolprodukt;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btnDodaj;
    }
}