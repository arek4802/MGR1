namespace Praca_mgr
{
    partial class FormPojazdSilnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPojazdSilnik));
            this.btnDodajParametrProdukt = new System.Windows.Forms.Button();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPojazdyModel = new System.Windows.Forms.DataGridView();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvWersja = new System.Windows.Forms.DataGridView();
            this.txtWersja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGotowe = new System.Windows.Forms.DataGridView();
            this.txtRokProdukcji = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdyModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWersja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGotowe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajParametrProdukt
            // 
            this.btnDodajParametrProdukt.Location = new System.Drawing.Point(1085, -63);
            this.btnDodajParametrProdukt.Name = "btnDodajParametrProdukt";
            this.btnDodajParametrProdukt.Size = new System.Drawing.Size(118, 38);
            this.btnDodajParametrProdukt.TabIndex = 101;
            this.btnDodajParametrProdukt.Text = "Powiąż silnik";
            this.btnDodajParametrProdukt.UseVisualStyleBackColor = true;
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktualizuj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAktualizuj.Location = new System.Drawing.Point(18, 485);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(334, 37);
            this.btnAktualizuj.TabIndex = 100;
            this.btnAktualizuj.Text = "Aktualizacja";
            this.btnAktualizuj.UseVisualStyleBackColor = false;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtModel.Location = new System.Drawing.Point(17, 57);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(398, 39);
            this.txtModel.TabIndex = 99;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(17, 442);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 98;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPojazdyModel
            // 
            this.dgvPojazdyModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazdyModel.Location = new System.Drawing.Point(438, 41);
            this.dgvPojazdyModel.Name = "dgvPojazdyModel";
            this.dgvPojazdyModel.Size = new System.Drawing.Size(472, 212);
            this.dgvPojazdyModel.TabIndex = 97;
            this.dgvPojazdyModel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPojazdyModel_CellContentClick);
            // 
            // txtVIN
            // 
            this.txtVIN.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVIN.Location = new System.Drawing.Point(18, 155);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(398, 39);
            this.txtVIN.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(11, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 32);
            this.label3.TabIndex = 95;
            this.label3.Text = "Wersja silnikowa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 94;
            this.label2.Text = "Pojazd";
            // 
            // dgvWersja
            // 
            this.dgvWersja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWersja.Location = new System.Drawing.Point(438, 284);
            this.dgvWersja.Name = "dgvWersja";
            this.dgvWersja.Size = new System.Drawing.Size(252, 212);
            this.dgvWersja.TabIndex = 102;
            this.dgvWersja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWersja_CellContentClick);
            // 
            // txtWersja
            // 
            this.txtWersja.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWersja.Location = new System.Drawing.Point(12, 242);
            this.txtWersja.Name = "txtWersja";
            this.txtWersja.Size = new System.Drawing.Size(398, 39);
            this.txtWersja.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 103;
            this.label1.Text = "Numer VIN";
            // 
            // dgvGotowe
            // 
            this.dgvGotowe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGotowe.Location = new System.Drawing.Point(731, 284);
            this.dgvGotowe.Name = "dgvGotowe";
            this.dgvGotowe.Size = new System.Drawing.Size(472, 212);
            this.dgvGotowe.TabIndex = 105;
            this.dgvGotowe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGotowe_CellContentClick);
            // 
            // txtRokProdukcji
            // 
            this.txtRokProdukcji.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRokProdukcji.Location = new System.Drawing.Point(18, 338);
            this.txtRokProdukcji.Name = "txtRokProdukcji";
            this.txtRokProdukcji.Size = new System.Drawing.Size(398, 39);
            this.txtRokProdukcji.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 32);
            this.label4.TabIndex = 106;
            this.label4.Text = "Rok produkcji";
            // 
            // FormPojazdSilnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1267, 541);
            this.Controls.Add(this.txtRokProdukcji);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvGotowe);
            this.Controls.Add(this.txtWersja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWersja);
            this.Controls.Add(this.btnDodajParametrProdukt);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvPojazdyModel);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormPojazdSilnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pojazd - Silnik";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdyModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWersja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGotowe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajParametrProdukt;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPojazdyModel;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvWersja;
        private System.Windows.Forms.TextBox txtWersja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGotowe;
        private System.Windows.Forms.TextBox txtRokProdukcji;
        private System.Windows.Forms.Label label4;
    }
}