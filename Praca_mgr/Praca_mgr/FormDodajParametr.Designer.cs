namespace Praca_mgr
{
    partial class FormDodajParametr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajParametr));
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.btnDodajJednostka = new System.Windows.Forms.Button();
            this.btnDodajParametr = new System.Windows.Forms.Button();
            this.lblJednostka = new System.Windows.Forms.Label();
            this.cmbJednostka = new System.Windows.Forms.ComboBox();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.txtNazwaParametr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.Ivory;
            this.btnOdswiez.Font = new System.Drawing.Font("Arial", 15F);
            this.btnOdswiez.Location = new System.Drawing.Point(576, 150);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(150, 41);
            this.btnOdswiez.TabIndex = 69;
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // btnDodajJednostka
            // 
            this.btnDodajJednostka.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDodajJednostka.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajJednostka.Location = new System.Drawing.Point(547, 211);
            this.btnDodajJednostka.Name = "btnDodajJednostka";
            this.btnDodajJednostka.Size = new System.Drawing.Size(179, 34);
            this.btnDodajJednostka.TabIndex = 68;
            this.btnDodajJednostka.Text = "Dodaj nową jednostkę";
            this.btnDodajJednostka.UseVisualStyleBackColor = false;
            this.btnDodajJednostka.Click += new System.EventHandler(this.btnDodajJednostka_Click);
            // 
            // btnDodajParametr
            // 
            this.btnDodajParametr.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodajParametr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajParametr.Location = new System.Drawing.Point(249, 264);
            this.btnDodajParametr.Name = "btnDodajParametr";
            this.btnDodajParametr.Size = new System.Drawing.Size(239, 37);
            this.btnDodajParametr.TabIndex = 67;
            this.btnDodajParametr.Text = "Dodaj nowy parametr";
            this.btnDodajParametr.UseVisualStyleBackColor = false;
            this.btnDodajParametr.Click += new System.EventHandler(this.btnDodajParametr_Click);
            // 
            // lblJednostka
            // 
            this.lblJednostka.AutoSize = true;
            this.lblJednostka.BackColor = System.Drawing.Color.Transparent;
            this.lblJednostka.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJednostka.Location = new System.Drawing.Point(74, 211);
            this.lblJednostka.Name = "lblJednostka";
            this.lblJednostka.Size = new System.Drawing.Size(122, 27);
            this.lblJednostka.TabIndex = 66;
            this.lblJednostka.Text = "Jednostka";
            // 
            // cmbJednostka
            // 
            this.cmbJednostka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbJednostka.FormattingEnabled = true;
            this.cmbJednostka.Location = new System.Drawing.Point(202, 211);
            this.cmbJednostka.Name = "cmbJednostka";
            this.cmbJednostka.Size = new System.Drawing.Size(324, 33);
            this.cmbJednostka.TabIndex = 65;
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwa.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwa.Location = new System.Drawing.Point(74, 164);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(91, 27);
            this.lblNazwa.TabIndex = 64;
            this.lblNazwa.Text = "Nazwa ";
            // 
            // txtNazwaParametr
            // 
            this.txtNazwaParametr.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaParametr.Location = new System.Drawing.Point(202, 156);
            this.txtNazwaParametr.Name = "txtNazwaParametr";
            this.txtNazwaParametr.Size = new System.Drawing.Size(324, 35);
            this.txtNazwaParametr.TabIndex = 63;
            // 
            // FormDodajParametr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.btnDodajJednostka);
            this.Controls.Add(this.btnDodajParametr);
            this.Controls.Add(this.lblJednostka);
            this.Controls.Add(this.cmbJednostka);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.txtNazwaParametr);
            this.Name = "FormDodajParametr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nowy Parametr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.Button btnDodajJednostka;
        private System.Windows.Forms.Button btnDodajParametr;
        private System.Windows.Forms.Label lblJednostka;
        private System.Windows.Forms.ComboBox cmbJednostka;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.TextBox txtNazwaParametr;
    }
}