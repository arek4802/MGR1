namespace Praca_mgr
{
    partial class FormTypModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTypModel));
            this.btnDodajModel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvModelTyp = new System.Windows.Forms.DataGridView();
            this.dgvTyp = new System.Windows.Forms.DataGridView();
            this.dgvModel = new System.Windows.Forms.DataGridView();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelTyp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajModel
            // 
            this.btnDodajModel.Location = new System.Drawing.Point(335, 12);
            this.btnDodajModel.Name = "btnDodajModel";
            this.btnDodajModel.Size = new System.Drawing.Size(118, 38);
            this.btnDodajModel.TabIndex = 94;
            this.btnDodajModel.Text = "Dodaj nowy typ";
            this.btnDodajModel.UseVisualStyleBackColor = true;
            this.btnDodajModel.Click += new System.EventHandler(this.btnDodajModel_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 16F);
            this.label6.Location = new System.Drawing.Point(983, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 93;
            this.label6.Text = "Wybierz typ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 16F);
            this.label5.Location = new System.Drawing.Point(459, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 92;
            this.label5.Text = "Wybierz model:";
            // 
            // dgvModelTyp
            // 
            this.dgvModelTyp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelTyp.Location = new System.Drawing.Point(464, 315);
            this.dgvModelTyp.MultiSelect = false;
            this.dgvModelTyp.Name = "dgvModelTyp";
            this.dgvModelTyp.Size = new System.Drawing.Size(798, 374);
            this.dgvModelTyp.TabIndex = 91;
            this.dgvModelTyp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModelTyp_CellContentClick);
            // 
            // dgvTyp
            // 
            this.dgvTyp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTyp.Location = new System.Drawing.Point(988, 72);
            this.dgvTyp.Name = "dgvTyp";
            this.dgvTyp.Size = new System.Drawing.Size(258, 212);
            this.dgvTyp.TabIndex = 90;
            this.dgvTyp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTyp_CellContentClick);
            // 
            // dgvModel
            // 
            this.dgvModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModel.Location = new System.Drawing.Point(464, 72);
            this.dgvModel.Name = "dgvModel";
            this.dgvModel.Size = new System.Drawing.Size(472, 212);
            this.dgvModel.TabIndex = 89;
            this.dgvModel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModel_CellContentClick_1);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial", 15F);
            this.btnUsun.Location = new System.Drawing.Point(33, 550);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(334, 37);
            this.btnUsun.TabIndex = 88;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click_1);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(33, 486);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 87;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
            // 
            // txtTyp
            // 
            this.txtTyp.Enabled = false;
            this.txtTyp.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTyp.Location = new System.Drawing.Point(33, 244);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(398, 39);
            this.txtTyp.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(27, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 32);
            this.label2.TabIndex = 85;
            this.label2.Text = "Typ";
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtModel.Location = new System.Drawing.Point(33, 156);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(398, 39);
            this.txtModel.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 83;
            this.label1.Text = "Model";
            // 
            // FormTypModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1290, 727);
            this.Controls.Add(this.btnDodajModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvModelTyp);
            this.Controls.Add(this.dgvTyp);
            this.Controls.Add(this.dgvModel);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtTyp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label1);
            this.Name = "FormTypModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Typ - Model";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelTyp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvModelTyp;
        private System.Windows.Forms.DataGridView dgvTyp;
        private System.Windows.Forms.DataGridView dgvModel;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label1;
    }
}