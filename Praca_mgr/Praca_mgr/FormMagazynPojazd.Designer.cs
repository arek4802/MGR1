namespace Praca_mgr
{
    partial class FormMagazynPojazd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMagazynPojazd));
            this.cBMagazyn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBPojazd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiejsce = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMagazyn = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazyn)).BeginInit();
            this.SuspendLayout();
            // 
            // cBMagazyn
            // 
            this.cBMagazyn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBMagazyn.FormattingEnabled = true;
            this.cBMagazyn.Location = new System.Drawing.Point(63, 151);
            this.cBMagazyn.Name = "cBMagazyn";
            this.cBMagazyn.Size = new System.Drawing.Size(212, 25);
            this.cBMagazyn.TabIndex = 145;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(73, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 24);
            this.label5.TabIndex = 144;
            this.label5.Text = "Rodzaj magazynu";
            // 
            // cBPojazd
            // 
            this.cBPojazd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBPojazd.FormattingEnabled = true;
            this.cBPojazd.Location = new System.Drawing.Point(63, 94);
            this.cBPojazd.Name = "cBPojazd";
            this.cBPojazd.Size = new System.Drawing.Size(212, 25);
            this.cBPojazd.TabIndex = 143;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(73, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 142;
            this.label4.Text = "Pojazd";
            // 
            // txtMiejsce
            // 
            this.txtMiejsce.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMiejsce.Location = new System.Drawing.Point(63, 216);
            this.txtMiejsce.Name = "txtMiejsce";
            this.txtMiejsce.Size = new System.Drawing.Size(212, 25);
            this.txtMiejsce.TabIndex = 147;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(73, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 24);
            this.label6.TabIndex = 146;
            this.label6.Text = "Numer miejsca";
            // 
            // dgvMagazyn
            // 
            this.dgvMagazyn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazyn.Location = new System.Drawing.Point(334, 81);
            this.dgvMagazyn.Name = "dgvMagazyn";
            this.dgvMagazyn.Size = new System.Drawing.Size(593, 290);
            this.dgvMagazyn.TabIndex = 148;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(63, 351);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(212, 37);
            this.btnDodaj.TabIndex = 149;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FormMagazynPojazd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(966, 470);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvMagazyn);
            this.Controls.Add(this.txtMiejsce);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBMagazyn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBPojazd);
            this.Controls.Add(this.label4);
            this.Name = "FormMagazynPojazd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Magazyn Pojazdy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazyn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBMagazyn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBPojazd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiejsce;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvMagazyn;
        private System.Windows.Forms.Button btnDodaj;
    }
}