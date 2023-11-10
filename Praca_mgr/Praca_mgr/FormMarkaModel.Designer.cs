namespace Praca_mgr
{
    partial class FormMarkaModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarkaModel));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMarkaModel = new System.Windows.Forms.DataGridView();
            this.dgvModel = new System.Windows.Forms.DataGridView();
            this.dgvMarka = new System.Windows.Forms.DataGridView();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajModel = new System.Windows.Forms.Button();
            this.btnTypModel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkaModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarka)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 16F);
            this.label6.Location = new System.Drawing.Point(769, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 81;
            this.label6.Text = "Wybierz model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 16F);
            this.label5.Location = new System.Drawing.Point(437, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 80;
            this.label5.Text = "Wybierz marke:";
            // 
            // dgvMarkaModel
            // 
            this.dgvMarkaModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkaModel.Location = new System.Drawing.Point(442, 290);
            this.dgvMarkaModel.MultiSelect = false;
            this.dgvMarkaModel.Name = "dgvMarkaModel";
            this.dgvMarkaModel.Size = new System.Drawing.Size(798, 374);
            this.dgvMarkaModel.TabIndex = 79;
            this.dgvMarkaModel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarkaModel_CellContentClick);
            // 
            // dgvModel
            // 
            this.dgvModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModel.Location = new System.Drawing.Point(759, 46);
            this.dgvModel.Name = "dgvModel";
            this.dgvModel.Size = new System.Drawing.Size(453, 213);
            this.dgvModel.TabIndex = 78;
            this.dgvModel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModel_CellContentClick);
            // 
            // dgvMarka
            // 
            this.dgvMarka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarka.Location = new System.Drawing.Point(442, 47);
            this.dgvMarka.Name = "dgvMarka";
            this.dgvMarka.Size = new System.Drawing.Size(266, 212);
            this.dgvMarka.TabIndex = 77;
            this.dgvMarka.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarka_CellContentClick);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(12, 448);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 75;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(11, 405);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 74;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtModel.Location = new System.Drawing.Point(11, 243);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(398, 39);
            this.txtModel.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(5, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 72;
            this.label2.Text = "Model";
            // 
            // txtMarka
            // 
            this.txtMarka.Enabled = false;
            this.txtMarka.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMarka.Location = new System.Drawing.Point(11, 155);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(398, 39);
            this.txtMarka.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 70;
            this.label1.Text = "Marka";
            // 
            // btnDodajModel
            // 
            this.btnDodajModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajModel.Location = new System.Drawing.Point(292, 13);
            this.btnDodajModel.Name = "btnDodajModel";
            this.btnDodajModel.Size = new System.Drawing.Size(118, 49);
            this.btnDodajModel.TabIndex = 82;
            this.btnDodajModel.Text = "Dodaj nowy model";
            this.btnDodajModel.UseVisualStyleBackColor = true;
            this.btnDodajModel.Click += new System.EventHandler(this.btnDodajModel_Click);
            // 
            // btnTypModel
            // 
            this.btnTypModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTypModel.Location = new System.Drawing.Point(168, 13);
            this.btnTypModel.Name = "btnTypModel";
            this.btnTypModel.Size = new System.Drawing.Size(118, 49);
            this.btnTypModel.TabIndex = 83;
            this.btnTypModel.Text = "Powiąż typ";
            this.btnTypModel.UseVisualStyleBackColor = true;
            this.btnTypModel.Click += new System.EventHandler(this.btnTypModel_Click);
            // 
            // FormMarkaModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1252, 679);
            this.Controls.Add(this.btnTypModel);
            this.Controls.Add(this.btnDodajModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvMarkaModel);
            this.Controls.Add(this.dgvModel);
            this.Controls.Add(this.dgvMarka);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label1);
            this.Name = "FormMarkaModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Marka - Model";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkaModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMarkaModel;
        private System.Windows.Forms.DataGridView dgvModel;
        private System.Windows.Forms.DataGridView dgvMarka;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajModel;
        private System.Windows.Forms.Button btnTypModel;
    }
}