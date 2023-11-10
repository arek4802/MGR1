namespace Praca_mgr
{
    partial class FormZamowienieProduktSzczegol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZamowienieProduktSzczegol));
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSzczegolyZamowienie = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBZamowienie = new System.Windows.Forms.ComboBox();
            this.cBProdukt = new System.Windows.Forms.ComboBox();
            this.dgvSzczegol = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegol)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtCena.Location = new System.Drawing.Point(161, 161);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(244, 26);
            this.txtCena.TabIndex = 120;
            // 
            // txtIlosc
            // 
            this.txtIlosc.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtIlosc.Location = new System.Drawing.Point(161, 196);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(244, 26);
            this.txtIlosc.TabIndex = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 118;
            this.label5.Text = "Ilość:";
            // 
            // btnSzczegolyZamowienie
            // 
            this.btnSzczegolyZamowienie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSzczegolyZamowienie.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzczegolyZamowienie.Location = new System.Drawing.Point(30, 481);
            this.btnSzczegolyZamowienie.Name = "btnSzczegolyZamowienie";
            this.btnSzczegolyZamowienie.Size = new System.Drawing.Size(328, 27);
            this.btnSzczegolyZamowienie.TabIndex = 117;
            this.btnSzczegolyZamowienie.Text = "Dodaj szczegóły zamówienia";
            this.btnSzczegolyZamowienie.UseVisualStyleBackColor = true;
            this.btnSzczegolyZamowienie.Click += new System.EventHandler(this.btnSzczegolyZamowienie_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 116;
            this.label4.Text = "Cena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 115;
            this.label3.Text = "Produkt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 114;
            this.label2.Text = "Zamówienie produkt:";
            // 
            // cBZamowienie
            // 
            this.cBZamowienie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBZamowienie.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBZamowienie.FormattingEnabled = true;
            this.cBZamowienie.Location = new System.Drawing.Point(161, 91);
            this.cBZamowienie.Name = "cBZamowienie";
            this.cBZamowienie.Size = new System.Drawing.Size(244, 28);
            this.cBZamowienie.TabIndex = 113;
            // 
            // cBProdukt
            // 
            this.cBProdukt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBProdukt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBProdukt.FormattingEnabled = true;
            this.cBProdukt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cBProdukt.Location = new System.Drawing.Point(161, 125);
            this.cBProdukt.Name = "cBProdukt";
            this.cBProdukt.Size = new System.Drawing.Size(244, 28);
            this.cBProdukt.TabIndex = 112;
            // 
            // dgvSzczegol
            // 
            this.dgvSzczegol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzczegol.Location = new System.Drawing.Point(411, 58);
            this.dgvSzczegol.Name = "dgvSzczegol";
            this.dgvSzczegol.Size = new System.Drawing.Size(774, 450);
            this.dgvSzczegol.TabIndex = 111;
            // 
            // FormZamowienieProduktSzczegol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1224, 577);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSzczegolyZamowienie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBZamowienie);
            this.Controls.Add(this.cBProdukt);
            this.Controls.Add(this.dgvSzczegol);
            this.Name = "FormZamowienieProduktSzczegol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Szczegóły Zamówienia Produktu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSzczegolyZamowienie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBZamowienie;
        private System.Windows.Forms.ComboBox cBProdukt;
        private System.Windows.Forms.DataGridView dgvSzczegol;
    }
}