namespace Praca_mgr
{
    partial class FormNowyPojazd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNowyPojazd));
            this.label4 = new System.Windows.Forms.Label();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPojazdyModel = new System.Windows.Forms.DataGridView();
            this.txtRokProdukcji = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvMarkaModel = new System.Windows.Forms.DataGridView();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.txtWyposazenie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWyposazenie = new System.Windows.Forms.DataGridView();
            this.dgvSpis = new System.Windows.Forms.DataGridView();
            this.btnUsun = new System.Windows.Forms.Button();
            this.tbVinSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchVin = new System.Windows.Forms.Button();
            this.btnRefreshVin = new System.Windows.Forms.Button();
            this.btnDodajMarkaModel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdyModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkaModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyposazenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpis)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 32);
            this.label4.TabIndex = 67;
            this.label4.Text = "Rok produkcji";
            // 
            // txtVIN
            // 
            this.txtVIN.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVIN.Location = new System.Drawing.Point(12, 166);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(398, 39);
            this.txtVIN.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 65;
            this.label3.Text = "Numer VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 32);
            this.label2.TabIndex = 63;
            this.label2.Text = "Model Pojazdu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 16F);
            this.label5.Location = new System.Drawing.Point(439, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 70;
            this.label5.Text = "Wybierz model:";
            // 
            // dgvPojazdyModel
            // 
            this.dgvPojazdyModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazdyModel.Location = new System.Drawing.Point(444, 366);
            this.dgvPojazdyModel.Name = "dgvPojazdyModel";
            this.dgvPojazdyModel.Size = new System.Drawing.Size(472, 212);
            this.dgvPojazdyModel.TabIndex = 69;
            this.dgvPojazdyModel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPojazdyModel_CellContentClick);
            // 
            // txtRokProdukcji
            // 
            this.txtRokProdukcji.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRokProdukcji.Location = new System.Drawing.Point(12, 259);
            this.txtRokProdukcji.Name = "txtRokProdukcji";
            this.txtRokProdukcji.Size = new System.Drawing.Size(398, 39);
            this.txtRokProdukcji.TabIndex = 68;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(18, 447);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 89;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvMarkaModel
            // 
            this.dgvMarkaModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkaModel.Location = new System.Drawing.Point(444, 68);
            this.dgvMarkaModel.Name = "dgvMarkaModel";
            this.dgvMarkaModel.Size = new System.Drawing.Size(310, 212);
            this.dgvMarkaModel.TabIndex = 90;
            this.dgvMarkaModel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarkaModel_CellContentClick);
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtModel.Location = new System.Drawing.Point(18, 68);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(398, 39);
            this.txtModel.TabIndex = 91;
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(18, 490);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 92;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // txtWyposazenie
            // 
            this.txtWyposazenie.Enabled = false;
            this.txtWyposazenie.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWyposazenie.Location = new System.Drawing.Point(12, 357);
            this.txtWyposazenie.Name = "txtWyposazenie";
            this.txtWyposazenie.Size = new System.Drawing.Size(398, 39);
            this.txtWyposazenie.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 32);
            this.label1.TabIndex = 94;
            this.label1.Text = "Wybierz wyposażenie";
            // 
            // dgvWyposazenie
            // 
            this.dgvWyposazenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWyposazenie.Location = new System.Drawing.Point(811, 68);
            this.dgvWyposazenie.Name = "dgvWyposazenie";
            this.dgvWyposazenie.Size = new System.Drawing.Size(323, 212);
            this.dgvWyposazenie.TabIndex = 96;
            this.dgvWyposazenie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWyposazenie_CellContentClick);
            // 
            // dgvSpis
            // 
            this.dgvSpis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpis.Location = new System.Drawing.Point(969, 366);
            this.dgvSpis.Name = "dgvSpis";
            this.dgvSpis.Size = new System.Drawing.Size(392, 212);
            this.dgvSpis.TabIndex = 97;
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(18, 533);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 98;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // tbVinSearch
            // 
            this.tbVinSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbVinSearch.Location = new System.Drawing.Point(760, 301);
            this.tbVinSearch.Name = "tbVinSearch";
            this.tbVinSearch.Size = new System.Drawing.Size(138, 26);
            this.tbVinSearch.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(663, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 100;
            this.label6.Text = "Numer VIN:";
            // 
            // btnSearchVin
            // 
            this.btnSearchVin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearchVin.Location = new System.Drawing.Point(904, 298);
            this.btnSearchVin.Name = "btnSearchVin";
            this.btnSearchVin.Size = new System.Drawing.Size(75, 29);
            this.btnSearchVin.TabIndex = 101;
            this.btnSearchVin.Text = "Szukaj";
            this.btnSearchVin.UseVisualStyleBackColor = true;
            this.btnSearchVin.Click += new System.EventHandler(this.btnSearchVin_Click);
            // 
            // btnRefreshVin
            // 
            this.btnRefreshVin.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btnRefreshVin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefreshVin.Location = new System.Drawing.Point(985, 298);
            this.btnRefreshVin.Name = "btnRefreshVin";
            this.btnRefreshVin.Size = new System.Drawing.Size(87, 29);
            this.btnRefreshVin.TabIndex = 102;
            this.btnRefreshVin.Text = "Odśwież";
            this.btnRefreshVin.UseVisualStyleBackColor = true;
            this.btnRefreshVin.Click += new System.EventHandler(this.btnRefreshVin_Click);
            // 
            // btnDodajMarkaModel
            // 
            this.btnDodajMarkaModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajMarkaModel.Location = new System.Drawing.Point(1263, 22);
            this.btnDodajMarkaModel.Name = "btnDodajMarkaModel";
            this.btnDodajMarkaModel.Size = new System.Drawing.Size(118, 46);
            this.btnDodajMarkaModel.TabIndex = 103;
            this.btnDodajMarkaModel.Text = "Dodaj nowe wyposażenie wyposażenia";
            this.btnDodajMarkaModel.UseVisualStyleBackColor = true;
            this.btnDodajMarkaModel.Click += new System.EventHandler(this.btnDodajMarkaModel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1263, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 47);
            this.button1.TabIndex = 104;
            this.button1.Text = "Dodaj nowe zamówienie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(1263, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 50);
            this.button2.TabIndex = 105;
            this.button2.Text = "Przypisz czynności";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(1263, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 50);
            this.button3.TabIndex = 106;
            this.button3.Text = "Dodaj nową markę";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 16F);
            this.label7.Location = new System.Drawing.Point(806, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 25);
            this.label7.TabIndex = 107;
            this.label7.Text = "Wybierz wersję wyposażenia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(440, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 108;
            this.label8.Text = "Pojazdy:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(965, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 20);
            this.label9.TabIndex = 109;
            this.label9.Text = "Wersje wyposażenia pojazdów:";
            // 
            // FormNowyPojazd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1393, 590);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDodajMarkaModel);
            this.Controls.Add(this.btnRefreshVin);
            this.Controls.Add(this.btnSearchVin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbVinSearch);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.dgvSpis);
            this.Controls.Add(this.dgvWyposazenie);
            this.Controls.Add(this.txtWyposazenie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.dgvMarkaModel);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPojazdyModel);
            this.Controls.Add(this.txtRokProdukcji);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormNowyPojazd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nowy Pojazd";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdyModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkaModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyposazenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPojazdyModel;
        private System.Windows.Forms.TextBox txtRokProdukcji;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvMarkaModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.TextBox txtWyposazenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWyposazenie;
        private System.Windows.Forms.DataGridView dgvSpis;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.TextBox tbVinSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchVin;
        private System.Windows.Forms.Button btnRefreshVin;
        private System.Windows.Forms.Button btnDodajMarkaModel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}