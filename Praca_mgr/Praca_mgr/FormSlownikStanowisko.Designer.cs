﻿namespace Praca_mgr
{
    partial class FormSlownikStanowisko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSlownikStanowisko));
            this.btnDodajStanowisko = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.txtNazwaStanowisko = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvStanowisko = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanowisko)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajStanowisko
            // 
            this.btnDodajStanowisko.BackColor = System.Drawing.Color.Coral;
            this.btnDodajStanowisko.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodajStanowisko.Location = new System.Drawing.Point(30, 313);
            this.btnDodajStanowisko.Name = "btnDodajStanowisko";
            this.btnDodajStanowisko.Size = new System.Drawing.Size(334, 37);
            this.btnDodajStanowisko.TabIndex = 22;
            this.btnDodajStanowisko.Text = "Dodaj Stanowisko Produkcyjne";
            this.btnDodajStanowisko.UseVisualStyleBackColor = false;
            this.btnDodajStanowisko.Click += new System.EventHandler(this.btnDodajStanowisko_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.Location = new System.Drawing.Point(24, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nazwa stanowiska:";
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(30, 182);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 20;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(30, 243);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 19;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(30, 386);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(334, 37);
            this.btnOdswiez.TabIndex = 18;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // txtNazwaStanowisko
            // 
            this.txtNazwaStanowisko.Font = new System.Drawing.Font("Arial", 20F);
            this.txtNazwaStanowisko.Location = new System.Drawing.Point(30, 55);
            this.txtNazwaStanowisko.Name = "txtNazwaStanowisko";
            this.txtNazwaStanowisko.Size = new System.Drawing.Size(334, 38);
            this.txtNazwaStanowisko.TabIndex = 17;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(30, 123);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvStanowisko
            // 
            this.dgvStanowisko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanowisko.Location = new System.Drawing.Point(415, 69);
            this.dgvStanowisko.Name = "dgvStanowisko";
            this.dgvStanowisko.RowHeadersWidth = 51;
            this.dgvStanowisko.Size = new System.Drawing.Size(361, 376);
            this.dgvStanowisko.TabIndex = 15;
            this.dgvStanowisko.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStanowisko_CellContentClick);
            // 
            // FormSlownikStanowisko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnDodajStanowisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.txtNazwaStanowisko);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvStanowisko);
            this.Name = "FormSlownikStanowisko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nowe Stanowisko";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanowisko)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajStanowisko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.TextBox txtNazwaStanowisko;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvStanowisko;
    }
}