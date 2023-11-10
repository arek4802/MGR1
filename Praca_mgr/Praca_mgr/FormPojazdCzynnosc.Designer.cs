namespace Praca_mgr
{
    partial class FormPojazdCzynnosc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPojazdCzynnosc));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPojazdCzynnosc = new System.Windows.Forms.DataGridView();
            this.dgvCzynnosc = new System.Windows.Forms.DataGridView();
            this.dgvPojazd = new System.Windows.Forms.DataGridView();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtCzynnosc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBStanowisko = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCzas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProdukty = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdCzynnosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzynnosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 16F);
            this.label6.Location = new System.Drawing.Point(1108, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 25);
            this.label6.TabIndex = 92;
            this.label6.Text = "Wybierz czynność:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 16F);
            this.label5.Location = new System.Drawing.Point(431, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 91;
            this.label5.Text = "Wybierz pojazd:";
            // 
            // dgvPojazdCzynnosc
            // 
            this.dgvPojazdCzynnosc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazdCzynnosc.Location = new System.Drawing.Point(436, 274);
            this.dgvPojazdCzynnosc.MultiSelect = false;
            this.dgvPojazdCzynnosc.Name = "dgvPojazdCzynnosc";
            this.dgvPojazdCzynnosc.Size = new System.Drawing.Size(798, 374);
            this.dgvPojazdCzynnosc.TabIndex = 90;
            // 
            // dgvCzynnosc
            // 
            this.dgvCzynnosc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzynnosc.Location = new System.Drawing.Point(1113, 31);
            this.dgvCzynnosc.Name = "dgvCzynnosc";
            this.dgvCzynnosc.Size = new System.Drawing.Size(258, 212);
            this.dgvCzynnosc.TabIndex = 89;
            this.dgvCzynnosc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCzynnosc_CellContentClick);
            // 
            // dgvPojazd
            // 
            this.dgvPojazd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazd.Location = new System.Drawing.Point(436, 31);
            this.dgvPojazd.Name = "dgvPojazd";
            this.dgvPojazd.Size = new System.Drawing.Size(321, 212);
            this.dgvPojazd.TabIndex = 88;
            this.dgvPojazd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPojazd_CellContentClick);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(5, 441);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 87;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(5, 389);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 86;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtCzynnosc
            // 
            this.txtCzynnosc.Enabled = false;
            this.txtCzynnosc.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCzynnosc.Location = new System.Drawing.Point(6, 134);
            this.txtCzynnosc.Name = "txtCzynnosc";
            this.txtCzynnosc.Size = new System.Drawing.Size(398, 39);
            this.txtCzynnosc.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 32);
            this.label2.TabIndex = 84;
            this.label2.Text = "Czynność produkcyjna";
            // 
            // txtVin
            // 
            this.txtVin.Enabled = false;
            this.txtVin.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVin.Location = new System.Drawing.Point(6, 46);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(398, 39);
            this.txtVin.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 82;
            this.label1.Text = "Pojazd";
            // 
            // cBStanowisko
            // 
            this.cBStanowisko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBStanowisko.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.cBStanowisko.FormattingEnabled = true;
            this.cBStanowisko.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cBStanowisko.Location = new System.Drawing.Point(6, 230);
            this.cBStanowisko.Name = "cBStanowisko";
            this.cBStanowisko.Size = new System.Drawing.Size(398, 39);
            this.cBStanowisko.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(-1, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 94;
            this.label3.Text = "Stanowisko";
            // 
            // txtCzas
            // 
            this.txtCzas.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.txtCzas.Location = new System.Drawing.Point(5, 325);
            this.txtCzas.Name = "txtCzas";
            this.txtCzas.Size = new System.Drawing.Size(399, 38);
            this.txtCzas.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(0, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 32);
            this.label4.TabIndex = 111;
            this.label4.Text = "Czas trwania [min]";
            // 
            // dgvProdukty
            // 
            this.dgvProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukty.Location = new System.Drawing.Point(763, 30);
            this.dgvProdukty.Name = "dgvProdukty";
            this.dgvProdukty.Size = new System.Drawing.Size(321, 212);
            this.dgvProdukty.TabIndex = 112;
            // 
            // FormPojazdCzynnosc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1403, 706);
            this.Controls.Add(this.dgvProdukty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCzas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBStanowisko);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPojazdCzynnosc);
            this.Controls.Add(this.dgvCzynnosc);
            this.Controls.Add(this.dgvPojazd);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtCzynnosc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.label1);
            this.Name = "FormPojazdCzynnosc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Czynności - Pojazd";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdCzynnosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzynnosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPojazdCzynnosc;
        private System.Windows.Forms.DataGridView dgvCzynnosc;
        private System.Windows.Forms.DataGridView dgvPojazd;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtCzynnosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBStanowisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCzas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProdukty;
    }
}