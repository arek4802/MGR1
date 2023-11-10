namespace Praca_mgr
{
    partial class FormZamowienie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZamowienie));
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cBKlient = new System.Windows.Forms.ComboBox();
            this.cBPracownik = new System.Windows.Forms.ComboBox();
            this.dtpZamowienie = new System.Windows.Forms.DateTimePicker();
            this.dgvZamowienie = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBTyp = new System.Windows.Forms.ComboBox();
            this.btnSzczegolyZamowienie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(27, 381);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(328, 27);
            this.btnDodaj.TabIndex = 89;
            this.btnDodaj.Text = "Dodaj zamówienie";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cBKlient
            // 
            this.cBKlient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBKlient.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBKlient.FormattingEnabled = true;
            this.cBKlient.Location = new System.Drawing.Point(160, 76);
            this.cBKlient.Name = "cBKlient";
            this.cBKlient.Size = new System.Drawing.Size(238, 28);
            this.cBKlient.TabIndex = 88;
            // 
            // cBPracownik
            // 
            this.cBPracownik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBPracownik.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBPracownik.FormattingEnabled = true;
            this.cBPracownik.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cBPracownik.Location = new System.Drawing.Point(160, 148);
            this.cBPracownik.Name = "cBPracownik";
            this.cBPracownik.Size = new System.Drawing.Size(238, 28);
            this.cBPracownik.TabIndex = 87;
            // 
            // dtpZamowienie
            // 
            this.dtpZamowienie.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpZamowienie.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpZamowienie.Location = new System.Drawing.Point(160, 116);
            this.dtpZamowienie.Name = "dtpZamowienie";
            this.dtpZamowienie.Size = new System.Drawing.Size(238, 26);
            this.dtpZamowienie.TabIndex = 86;
            // 
            // dgvZamowienie
            // 
            this.dgvZamowienie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienie.Location = new System.Drawing.Point(404, 24);
            this.dgvZamowienie.Name = "dgvZamowienie";
            this.dgvZamowienie.Size = new System.Drawing.Size(774, 450);
            this.dgvZamowienie.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "Data zamowienia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 92;
            this.label2.Text = "Klient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Pracownik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 95;
            this.label4.Text = "Typ zamówienia:";
            // 
            // cBTyp
            // 
            this.cBTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTyp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBTyp.FormattingEnabled = true;
            this.cBTyp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cBTyp.Location = new System.Drawing.Point(160, 40);
            this.cBTyp.Name = "cBTyp";
            this.cBTyp.Size = new System.Drawing.Size(238, 28);
            this.cBTyp.TabIndex = 94;
            // 
            // btnSzczegolyZamowienie
            // 
            this.btnSzczegolyZamowienie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSzczegolyZamowienie.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzczegolyZamowienie.Location = new System.Drawing.Point(27, 428);
            this.btnSzczegolyZamowienie.Name = "btnSzczegolyZamowienie";
            this.btnSzczegolyZamowienie.Size = new System.Drawing.Size(328, 27);
            this.btnSzczegolyZamowienie.TabIndex = 96;
            this.btnSzczegolyZamowienie.Text = "Dodaj szczegóły zamówienia";
            this.btnSzczegolyZamowienie.UseVisualStyleBackColor = true;
            this.btnSzczegolyZamowienie.Click += new System.EventHandler(this.btnSzczegolyZamowienie_Click);
            // 
            // FormZamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1253, 530);
            this.Controls.Add(this.btnSzczegolyZamowienie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBTyp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cBKlient);
            this.Controls.Add(this.cBPracownik);
            this.Controls.Add(this.dtpZamowienie);
            this.Controls.Add(this.dgvZamowienie);
            this.Name = "FormZamowienie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zamówienie ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cBKlient;
        private System.Windows.Forms.ComboBox cBPracownik;
        private System.Windows.Forms.DateTimePicker dtpZamowienie;
        private System.Windows.Forms.DataGridView dgvZamowienie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBTyp;
        private System.Windows.Forms.Button btnSzczegolyZamowienie;
    }
}