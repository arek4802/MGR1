namespace Praca_mgr
{
    partial class FormZamowienieSzczegol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZamowienieSzczegol));
            this.btnSzczegolyZamowienie = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBZamowienie = new System.Windows.Forms.ComboBox();
            this.cBPojazd = new System.Windows.Forms.ComboBox();
            this.dgvSzczegol = new System.Windows.Forms.DataGridView();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBGwarancja = new System.Windows.Forms.ComboBox();
            this.txtKoszt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvKoszta = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoszta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSzczegolyZamowienie
            // 
            this.btnSzczegolyZamowienie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSzczegolyZamowienie.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzczegolyZamowienie.Location = new System.Drawing.Point(23, 427);
            this.btnSzczegolyZamowienie.Name = "btnSzczegolyZamowienie";
            this.btnSzczegolyZamowienie.Size = new System.Drawing.Size(328, 27);
            this.btnSzczegolyZamowienie.TabIndex = 107;
            this.btnSzczegolyZamowienie.Text = "Dodaj szczegóły zamówienia";
            this.btnSzczegolyZamowienie.UseVisualStyleBackColor = true;
            this.btnSzczegolyZamowienie.Click += new System.EventHandler(this.btnSzczegolyZamowienie_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(19, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 106;
            this.label4.Text = "Gwarancja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(19, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 104;
            this.label3.Text = "Pojazd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 103;
            this.label2.Text = "Zamówienie:";
            // 
            // cBZamowienie
            // 
            this.cBZamowienie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBZamowienie.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBZamowienie.FormattingEnabled = true;
            this.cBZamowienie.Location = new System.Drawing.Point(116, 103);
            this.cBZamowienie.Name = "cBZamowienie";
            this.cBZamowienie.Size = new System.Drawing.Size(278, 28);
            this.cBZamowienie.TabIndex = 100;
            // 
            // cBPojazd
            // 
            this.cBPojazd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBPojazd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBPojazd.FormattingEnabled = true;
            this.cBPojazd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cBPojazd.Location = new System.Drawing.Point(116, 137);
            this.cBPojazd.Name = "cBPojazd";
            this.cBPojazd.Size = new System.Drawing.Size(278, 28);
            this.cBPojazd.TabIndex = 99;
            // 
            // dgvSzczegol
            // 
            this.dgvSzczegol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzczegol.Location = new System.Drawing.Point(400, 70);
            this.dgvSzczegol.Name = "dgvSzczegol";
            this.dgvSzczegol.Size = new System.Drawing.Size(774, 450);
            this.dgvSzczegol.TabIndex = 97;
            this.dgvSzczegol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSzczegol_CellContentClick);
            // 
            // txtIlosc
            // 
            this.txtIlosc.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtIlosc.Location = new System.Drawing.Point(116, 205);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(278, 26);
            this.txtIlosc.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(20, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 108;
            this.label5.Text = "Ilość:";
            // 
            // cBGwarancja
            // 
            this.cBGwarancja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBGwarancja.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBGwarancja.FormattingEnabled = true;
            this.cBGwarancja.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cBGwarancja.Location = new System.Drawing.Point(116, 171);
            this.cBGwarancja.Name = "cBGwarancja";
            this.cBGwarancja.Size = new System.Drawing.Size(278, 28);
            this.cBGwarancja.TabIndex = 105;
            // 
            // txtKoszt
            // 
            this.txtKoszt.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtKoszt.Location = new System.Drawing.Point(116, 237);
            this.txtKoszt.Name = "txtKoszt";
            this.txtKoszt.Size = new System.Drawing.Size(278, 26);
            this.txtKoszt.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 110;
            this.label1.Text = "Koszt:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(23, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 27);
            this.button1.TabIndex = 112;
            this.button1.Text = "Zamów produkty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(24, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(328, 27);
            this.button2.TabIndex = 113;
            this.button2.Text = "Aktualizuj cenę";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvKoszta
            // 
            this.dgvKoszta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKoszta.Location = new System.Drawing.Point(400, 589);
            this.dgvKoszta.Name = "dgvKoszta";
            this.dgvKoszta.Size = new System.Drawing.Size(252, 40);
            this.dgvKoszta.TabIndex = 114;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(24, 559);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(328, 27);
            this.button3.TabIndex = 115;
            this.button3.Text = "Zapisz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(833, 548);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 27);
            this.button4.TabIndex = 116;
            this.button4.Text = "Usuń";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(396, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 117;
            this.label6.Text = "Koszty wyposażenia:";
            // 
            // FormZamowienieSzczegol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1202, 641);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvKoszta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKoszt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSzczegolyZamowienie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBGwarancja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBZamowienie);
            this.Controls.Add(this.cBPojazd);
            this.Controls.Add(this.dgvSzczegol);
            this.Name = "FormZamowienieSzczegol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Szczególy Zamówienia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoszta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSzczegolyZamowienie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBZamowienie;
        private System.Windows.Forms.ComboBox cBPojazd;
        private System.Windows.Forms.DataGridView dgvSzczegol;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBGwarancja;
        private System.Windows.Forms.TextBox txtKoszt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvKoszta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
    }
}