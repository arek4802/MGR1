namespace Praca_mgr
{
    partial class FormWyposazenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWyposazenie));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.txtNazwaWyposazenie = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvWyposazenie = new System.Windows.Forms.DataGridView();
            this.btnDodajModel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyposazenie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.Location = new System.Drawing.Point(62, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nazwa wyposażenia:";
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(68, 261);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 32;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(68, 322);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 31;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // txtNazwaWyposazenie
            // 
            this.txtNazwaWyposazenie.Font = new System.Drawing.Font("Arial", 20F);
            this.txtNazwaWyposazenie.Location = new System.Drawing.Point(68, 134);
            this.txtNazwaWyposazenie.Name = "txtNazwaWyposazenie";
            this.txtNazwaWyposazenie.Size = new System.Drawing.Size(334, 38);
            this.txtNazwaWyposazenie.TabIndex = 30;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(68, 202);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 29;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvWyposazenie
            // 
            this.dgvWyposazenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWyposazenie.Location = new System.Drawing.Point(434, 134);
            this.dgvWyposazenie.Name = "dgvWyposazenie";
            this.dgvWyposazenie.RowHeadersWidth = 51;
            this.dgvWyposazenie.Size = new System.Drawing.Size(295, 225);
            this.dgvWyposazenie.TabIndex = 28;
            this.dgvWyposazenie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWyposazenie_CellContentClick);
            // 
            // btnDodajModel
            // 
            this.btnDodajModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajModel.Location = new System.Drawing.Point(628, 25);
            this.btnDodajModel.Name = "btnDodajModel";
            this.btnDodajModel.Size = new System.Drawing.Size(143, 49);
            this.btnDodajModel.TabIndex = 107;
            this.btnDodajModel.Text = "Dodaj nowy skład wersji wyposażenia";
            this.btnDodajModel.UseVisualStyleBackColor = true;
            this.btnDodajModel.Click += new System.EventHandler(this.btnDodajModel_Click);
            // 
            // FormWyposazenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 443);
            this.Controls.Add(this.btnDodajModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.txtNazwaWyposazenie);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvWyposazenie);
            this.Name = "FormWyposazenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nowe Wyposażenie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyposazenie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.TextBox txtNazwaWyposazenie;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvWyposazenie;
        private System.Windows.Forms.Button btnDodajModel;
    }
}