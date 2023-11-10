namespace Praca_mgr
{
    partial class FormWyposazenieProdukt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWyposazenieProdukt));
            this.btnDodajModel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvWyposazenieProdukt = new System.Windows.Forms.DataGridView();
            this.dgvProdukt = new System.Windows.Forms.DataGridView();
            this.dgvWyposazenie = new System.Windows.Forms.DataGridView();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtProdukt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWyposazenie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyposazenieProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyposazenie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajModel
            // 
            this.btnDodajModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajModel.Location = new System.Drawing.Point(290, 10);
            this.btnDodajModel.Name = "btnDodajModel";
            this.btnDodajModel.Size = new System.Drawing.Size(143, 49);
            this.btnDodajModel.TabIndex = 106;
            this.btnDodajModel.Text = "Dodaj nową wersję wyposażenia";
            this.btnDodajModel.UseVisualStyleBackColor = true;
            this.btnDodajModel.Click += new System.EventHandler(this.btnDodajModel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 16F);
            this.label6.Location = new System.Drawing.Point(984, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 105;
            this.label6.Text = "Wybierz produkt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 16F);
            this.label5.Location = new System.Drawing.Point(460, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 25);
            this.label5.TabIndex = 104;
            this.label5.Text = "Wybierz wersje wyposażenia:";
            // 
            // dgvWyposazenieProdukt
            // 
            this.dgvWyposazenieProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWyposazenieProdukt.Location = new System.Drawing.Point(465, 287);
            this.dgvWyposazenieProdukt.MultiSelect = false;
            this.dgvWyposazenieProdukt.Name = "dgvWyposazenieProdukt";
            this.dgvWyposazenieProdukt.Size = new System.Drawing.Size(798, 374);
            this.dgvWyposazenieProdukt.TabIndex = 103;
            this.dgvWyposazenieProdukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWyposazenieProdukt_CellContentClick);
            // 
            // dgvProdukt
            // 
            this.dgvProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukt.Location = new System.Drawing.Point(989, 44);
            this.dgvProdukt.Name = "dgvProdukt";
            this.dgvProdukt.Size = new System.Drawing.Size(258, 212);
            this.dgvProdukt.TabIndex = 102;
            this.dgvProdukt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukt_CellContentClick);
            // 
            // dgvWyposazenie
            // 
            this.dgvWyposazenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWyposazenie.Location = new System.Drawing.Point(465, 44);
            this.dgvWyposazenie.Name = "dgvWyposazenie";
            this.dgvWyposazenie.Size = new System.Drawing.Size(472, 212);
            this.dgvWyposazenie.TabIndex = 101;
            this.dgvWyposazenie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWyposazenie_CellContentClick);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(34, 522);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 100;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(34, 458);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 99;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtProdukt
            // 
            this.txtProdukt.Enabled = false;
            this.txtProdukt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProdukt.Location = new System.Drawing.Point(44, 211);
            this.txtProdukt.Name = "txtProdukt";
            this.txtProdukt.Size = new System.Drawing.Size(398, 39);
            this.txtProdukt.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(38, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 97;
            this.label2.Text = "Produkt";
            // 
            // txtWyposazenie
            // 
            this.txtWyposazenie.Enabled = false;
            this.txtWyposazenie.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWyposazenie.Location = new System.Drawing.Point(44, 123);
            this.txtWyposazenie.Name = "txtWyposazenie";
            this.txtWyposazenie.Size = new System.Drawing.Size(398, 39);
            this.txtWyposazenie.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 95;
            this.label1.Text = "Wersja wyposażenia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(38, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 107;
            this.label3.Text = "Ilość";
            // 
            // txtIlosc
            // 
            this.txtIlosc.Font = new System.Drawing.Font("Arial", 20F);
            this.txtIlosc.Location = new System.Drawing.Point(43, 302);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(334, 38);
            this.txtIlosc.TabIndex = 108;
            // 
            // FormWyposazenieProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1294, 668);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodajModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvWyposazenieProdukt);
            this.Controls.Add(this.dgvProdukt);
            this.Controls.Add(this.dgvWyposazenie);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtProdukt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWyposazenie);
            this.Controls.Add(this.label1);
            this.Name = "FormWyposazenieProdukt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Skład Wyposażenia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyposazenieProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyposazenie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvWyposazenieProdukt;
        private System.Windows.Forms.DataGridView dgvProdukt;
        private System.Windows.Forms.DataGridView dgvWyposazenie;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtProdukt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWyposazenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIlosc;
    }
}