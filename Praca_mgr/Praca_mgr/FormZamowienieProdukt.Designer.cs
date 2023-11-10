namespace Praca_mgr
{
    partial class FormZamowienieProdukt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZamowienieProdukt));
            this.btnSzczegolyZamowienie = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cBPojazd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cBDostawca = new System.Windows.Forms.ComboBox();
            this.cBPracownik = new System.Windows.Forms.ComboBox();
            this.dtpZamowienie = new System.Windows.Forms.DateTimePicker();
            this.dgvZamowienie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSzczegolyZamowienie
            // 
            this.btnSzczegolyZamowienie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSzczegolyZamowienie.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzczegolyZamowienie.Location = new System.Drawing.Point(58, 480);
            this.btnSzczegolyZamowienie.Name = "btnSzczegolyZamowienie";
            this.btnSzczegolyZamowienie.Size = new System.Drawing.Size(328, 27);
            this.btnSzczegolyZamowienie.TabIndex = 107;
            this.btnSzczegolyZamowienie.Text = "Dodaj szczegóły zamówienia";
            this.btnSzczegolyZamowienie.UseVisualStyleBackColor = true;
            this.btnSzczegolyZamowienie.Click += new System.EventHandler(this.btnSzczegolyZamowienie_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(1, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 25);
            this.label4.TabIndex = 106;
            this.label4.Text = "Numer zamowienia pojazdu:";
            // 
            // cBPojazd
            // 
            this.cBPojazd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBPojazd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBPojazd.FormattingEnabled = true;
            this.cBPojazd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cBPojazd.Location = new System.Drawing.Point(235, 275);
            this.cBPojazd.Name = "cBPojazd";
            this.cBPojazd.Size = new System.Drawing.Size(233, 28);
            this.cBPojazd.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 104;
            this.label3.Text = "Pracownik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 103;
            this.label2.Text = "Dostawca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 102;
            this.label1.Text = "Data zamowienia:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(58, 434);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(328, 27);
            this.btnDodaj.TabIndex = 101;
            this.btnDodaj.Text = "Dodaj zamówienie";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
            // 
            // cBDostawca
            // 
            this.cBDostawca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDostawca.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBDostawca.FormattingEnabled = true;
            this.cBDostawca.Location = new System.Drawing.Point(235, 169);
            this.cBDostawca.Name = "cBDostawca";
            this.cBDostawca.Size = new System.Drawing.Size(233, 28);
            this.cBDostawca.TabIndex = 100;
            // 
            // cBPracownik
            // 
            this.cBPracownik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBPracownik.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBPracownik.FormattingEnabled = true;
            this.cBPracownik.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cBPracownik.Location = new System.Drawing.Point(235, 241);
            this.cBPracownik.Name = "cBPracownik";
            this.cBPracownik.Size = new System.Drawing.Size(233, 28);
            this.cBPracownik.TabIndex = 99;
            // 
            // dtpZamowienie
            // 
            this.dtpZamowienie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpZamowienie.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpZamowienie.Location = new System.Drawing.Point(235, 209);
            this.dtpZamowienie.Name = "dtpZamowienie";
            this.dtpZamowienie.Size = new System.Drawing.Size(233, 26);
            this.dtpZamowienie.TabIndex = 98;
            // 
            // dgvZamowienie
            // 
            this.dgvZamowienie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienie.Location = new System.Drawing.Point(493, 58);
            this.dgvZamowienie.Name = "dgvZamowienie";
            this.dgvZamowienie.Size = new System.Drawing.Size(736, 450);
            this.dgvZamowienie.TabIndex = 97;
            // 
            // FormZamowienieProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 570);
            this.Controls.Add(this.btnSzczegolyZamowienie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBPojazd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cBDostawca);
            this.Controls.Add(this.cBPracownik);
            this.Controls.Add(this.dtpZamowienie);
            this.Controls.Add(this.dgvZamowienie);
            this.Name = "FormZamowienieProdukt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zamówienie Produkt";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSzczegolyZamowienie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBPojazd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cBDostawca;
        private System.Windows.Forms.ComboBox cBPracownik;
        private System.Windows.Forms.DateTimePicker dtpZamowienie;
        private System.Windows.Forms.DataGridView dgvZamowienie;
    }
}