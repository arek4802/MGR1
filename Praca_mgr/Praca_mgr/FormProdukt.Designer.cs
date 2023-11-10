namespace Praca_mgr
{
    partial class FormProdukt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdukt));
            this.btnSkladProduktMaterial = new System.Windows.Forms.Button();
            this.btnDodajSkladProduktu = new System.Windows.Forms.Button();
            this.btnDodajParametrProdukt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.txtNazwaProdukt = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvProdukt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSkladProduktMaterial
            // 
            this.btnSkladProduktMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSkladProduktMaterial.Location = new System.Drawing.Point(299, 12);
            this.btnSkladProduktMaterial.Name = "btnSkladProduktMaterial";
            this.btnSkladProduktMaterial.Size = new System.Drawing.Size(131, 52);
            this.btnSkladProduktMaterial.TabIndex = 19;
            this.btnSkladProduktMaterial.Text = "Powiąż materiał montażowy";
            this.btnSkladProduktMaterial.UseVisualStyleBackColor = true;
            this.btnSkladProduktMaterial.Click += new System.EventHandler(this.btnSkladProduktMaterial_Click);
            // 
            // btnDodajSkladProduktu
            // 
            this.btnDodajSkladProduktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajSkladProduktu.Location = new System.Drawing.Point(175, 12);
            this.btnDodajSkladProduktu.Name = "btnDodajSkladProduktu";
            this.btnDodajSkladProduktu.Size = new System.Drawing.Size(119, 52);
            this.btnDodajSkladProduktu.TabIndex = 18;
            this.btnDodajSkladProduktu.Text = "Powiąż skład produktu";
            this.btnDodajSkladProduktu.UseVisualStyleBackColor = true;
            this.btnDodajSkladProduktu.Click += new System.EventHandler(this.btnDodajSkladProduktu_Click);
            // 
            // btnDodajParametrProdukt
            // 
            this.btnDodajParametrProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajParametrProdukt.Location = new System.Drawing.Point(43, 12);
            this.btnDodajParametrProdukt.Name = "btnDodajParametrProdukt";
            this.btnDodajParametrProdukt.Size = new System.Drawing.Size(126, 52);
            this.btnDodajParametrProdukt.TabIndex = 17;
            this.btnDodajParametrProdukt.Text = "Powiąż parametr";
            this.btnDodajParametrProdukt.UseVisualStyleBackColor = true;
            this.btnDodajParametrProdukt.Click += new System.EventHandler(this.btnDodajParametrProdukt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.Location = new System.Drawing.Point(77, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nazwa produktu:";
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(83, 342);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 15;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(83, 403);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 14;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(83, 462);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(334, 37);
            this.btnOdswiez.TabIndex = 13;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = true;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // txtNazwaProdukt
            // 
            this.txtNazwaProdukt.Font = new System.Drawing.Font("Arial", 20F);
            this.txtNazwaProdukt.Location = new System.Drawing.Point(83, 195);
            this.txtNazwaProdukt.Name = "txtNazwaProdukt";
            this.txtNazwaProdukt.Size = new System.Drawing.Size(334, 38);
            this.txtNazwaProdukt.TabIndex = 12;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(83, 283);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvProdukt
            // 
            this.dgvProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukt.Location = new System.Drawing.Point(466, 89);
            this.dgvProdukt.Name = "dgvProdukt";
            this.dgvProdukt.RowHeadersWidth = 51;
            this.dgvProdukt.Size = new System.Drawing.Size(374, 420);
            this.dgvProdukt.TabIndex = 10;
            this.dgvProdukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukt_CellContentClick);
            // 
            // FormProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(906, 584);
            this.Controls.Add(this.btnSkladProduktMaterial);
            this.Controls.Add(this.btnDodajSkladProduktu);
            this.Controls.Add(this.btnDodajParametrProdukt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.txtNazwaProdukt);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvProdukt);
            this.Name = "FormProdukt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nowy Produkt";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSkladProduktMaterial;
        private System.Windows.Forms.Button btnDodajSkladProduktu;
        private System.Windows.Forms.Button btnDodajParametrProdukt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.TextBox txtNazwaProdukt;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvProdukt;
    }
}