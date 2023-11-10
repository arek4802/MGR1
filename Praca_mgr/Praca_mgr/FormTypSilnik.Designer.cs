namespace Praca_mgr
{
    partial class FormTypSilnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTypSilnik));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPrzypisane = new System.Windows.Forms.DataGridView();
            this.dgvSilnik = new System.Windows.Forms.DataGridView();
            this.dgvMarkaModel = new System.Windows.Forms.DataGridView();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtSilnik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzypisane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkaModel)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 16F);
            this.label6.Location = new System.Drawing.Point(948, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 93;
            this.label6.Text = "Wybierz silnik:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 16F);
            this.label5.Location = new System.Drawing.Point(424, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 25);
            this.label5.TabIndex = 92;
            this.label5.Text = "Wybierz typ pojazdu:";
            // 
            // dgvPrzypisane
            // 
            this.dgvPrzypisane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrzypisane.Location = new System.Drawing.Point(429, 279);
            this.dgvPrzypisane.MultiSelect = false;
            this.dgvPrzypisane.Name = "dgvPrzypisane";
            this.dgvPrzypisane.Size = new System.Drawing.Size(782, 374);
            this.dgvPrzypisane.TabIndex = 91;
            this.dgvPrzypisane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrzypisane_CellContentClick);
            // 
            // dgvSilnik
            // 
            this.dgvSilnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSilnik.Location = new System.Drawing.Point(953, 36);
            this.dgvSilnik.Name = "dgvSilnik";
            this.dgvSilnik.Size = new System.Drawing.Size(258, 212);
            this.dgvSilnik.TabIndex = 90;
            this.dgvSilnik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSilnik_CellContentClick);
            // 
            // dgvMarkaModel
            // 
            this.dgvMarkaModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkaModel.Location = new System.Drawing.Point(429, 36);
            this.dgvMarkaModel.Name = "dgvMarkaModel";
            this.dgvMarkaModel.Size = new System.Drawing.Size(472, 212);
            this.dgvMarkaModel.TabIndex = 89;
            this.dgvMarkaModel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPojazdyModel_CellContentClick);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(12, 439);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 88;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(11, 396);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 87;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtSilnik
            // 
            this.txtSilnik.Enabled = false;
            this.txtSilnik.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSilnik.Location = new System.Drawing.Point(12, 201);
            this.txtSilnik.Name = "txtSilnik";
            this.txtSilnik.Size = new System.Drawing.Size(398, 39);
            this.txtSilnik.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 85;
            this.label2.Text = "Silnik";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTyp
            // 
            this.txtTyp.Enabled = false;
            this.txtTyp.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTyp.Location = new System.Drawing.Point(12, 113);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(398, 39);
            this.txtTyp.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 83;
            this.label1.Text = "Typ pojazdu";
            // 
            // FormTypSilnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1257, 666);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPrzypisane);
            this.Controls.Add(this.dgvSilnik);
            this.Controls.Add(this.dgvMarkaModel);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtSilnik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTyp);
            this.Controls.Add(this.label1);
            this.Name = "FormTypSilnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Typ - Silnik";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzypisane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkaModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPrzypisane;
        private System.Windows.Forms.DataGridView dgvSilnik;
        private System.Windows.Forms.DataGridView dgvMarkaModel;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtSilnik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.Label label1;
    }
}