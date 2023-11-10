namespace Praca_mgr
{
    partial class FormDodajAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajAlert));
            this.txtTresc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDzial = new System.Windows.Forms.ComboBox();
            this.btnDodajAlert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTresc
            // 
            this.txtTresc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTresc.Location = new System.Drawing.Point(209, 145);
            this.txtTresc.Name = "txtTresc";
            this.txtTresc.Size = new System.Drawing.Size(375, 146);
            this.txtTresc.TabIndex = 9;
            this.txtTresc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F);
            this.label2.Location = new System.Drawing.Point(115, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Treść";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(120, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dział";
            // 
            // cmbDzial
            // 
            this.cmbDzial.Font = new System.Drawing.Font("Arial", 14F);
            this.cmbDzial.FormattingEnabled = true;
            this.cmbDzial.Location = new System.Drawing.Point(209, 85);
            this.cmbDzial.Name = "cmbDzial";
            this.cmbDzial.Size = new System.Drawing.Size(375, 30);
            this.cmbDzial.TabIndex = 6;
            // 
            // btnDodajAlert
            // 
            this.btnDodajAlert.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajAlert.Font = new System.Drawing.Font("Arial", 18F);
            this.btnDodajAlert.Location = new System.Drawing.Point(321, 297);
            this.btnDodajAlert.Name = "btnDodajAlert";
            this.btnDodajAlert.Size = new System.Drawing.Size(177, 63);
            this.btnDodajAlert.TabIndex = 5;
            this.btnDodajAlert.Text = "Dodaj alert";
            this.btnDodajAlert.UseVisualStyleBackColor = false;
            this.btnDodajAlert.Click += new System.EventHandler(this.btnDodajAlert_Click_1);
            // 
            // FormDodajAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTresc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDzial);
            this.Controls.Add(this.btnDodajAlert);
            this.Name = "FormDodajAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nowy Alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTresc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDzial;
        private System.Windows.Forms.Button btnDodajAlert;
    }
}