﻿namespace Praca_mgr
{
    partial class FormSkladStanowisko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSkladStanowisko));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsun2 = new System.Windows.Forms.Button();
            this.btnDodajMaszyne = new System.Windows.Forms.Button();
            this.btnUsunNarzedzie = new System.Windows.Forms.Button();
            this.btnDodajNarzedzie = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodajStanowisko = new System.Windows.Forms.Button();
            this.txtMaszyny = new System.Windows.Forms.TextBox();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.txtNarzedzie = new System.Windows.Forms.TextBox();
            this.txtStanowisko = new System.Windows.Forms.TextBox();
            this.dgvSkladMaszyny = new System.Windows.Forms.DataGridView();
            this.dgvSkladNarzedzia = new System.Windows.Forms.DataGridView();
            this.dgvMaszyny = new System.Windows.Forms.DataGridView();
            this.dgvNarzedzia = new System.Windows.Forms.DataGridView();
            this.dgvStanowisko = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladMaszyny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladNarzedzia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarzedzia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanowisko)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(652, 373);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(415, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Aby dodać lub usunąć maszynę ze stanowiska kliknij na powiązanie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(153, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(420, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Aby dodać lub usunąć narzędzie ze stanowiska kliknij na powiązanie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(751, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Wybierz dostępną maszynę";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(631, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ilość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(460, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Wybierz narzędzie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(152, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Wybierz rodzaj stanowiska";
            // 
            // btnUsun2
            // 
            this.btnUsun2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun2.Location = new System.Drawing.Point(909, 571);
            this.btnUsun2.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsun2.Name = "btnUsun2";
            this.btnUsun2.Size = new System.Drawing.Size(222, 36);
            this.btnUsun2.TabIndex = 35;
            this.btnUsun2.Text = "Usuń maszynę ze stanowiska";
            this.btnUsun2.UseVisualStyleBackColor = true;
            this.btnUsun2.Click += new System.EventHandler(this.btnUsun2_Click);
            // 
            // btnDodajMaszyne
            // 
            this.btnDodajMaszyne.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajMaszyne.Location = new System.Drawing.Point(656, 571);
            this.btnDodajMaszyne.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajMaszyne.Name = "btnDodajMaszyne";
            this.btnDodajMaszyne.Size = new System.Drawing.Size(233, 36);
            this.btnDodajMaszyne.TabIndex = 34;
            this.btnDodajMaszyne.Text = "Dodaj kolejną maszynę do stanowiska";
            this.btnDodajMaszyne.UseVisualStyleBackColor = true;
            this.btnDodajMaszyne.Click += new System.EventHandler(this.btnDodajMaszyne_Click);
            // 
            // btnUsunNarzedzie
            // 
            this.btnUsunNarzedzie.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsunNarzedzie.Location = new System.Drawing.Point(406, 571);
            this.btnUsunNarzedzie.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsunNarzedzie.Name = "btnUsunNarzedzie";
            this.btnUsunNarzedzie.Size = new System.Drawing.Size(223, 36);
            this.btnUsunNarzedzie.TabIndex = 33;
            this.btnUsunNarzedzie.Text = "Usuń narzędzie ze stanowiska";
            this.btnUsunNarzedzie.UseVisualStyleBackColor = true;
            this.btnUsunNarzedzie.Click += new System.EventHandler(this.btnUsunNarzedzie_Click);
            // 
            // btnDodajNarzedzie
            // 
            this.btnDodajNarzedzie.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNarzedzie.Location = new System.Drawing.Point(157, 571);
            this.btnDodajNarzedzie.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajNarzedzie.Name = "btnDodajNarzedzie";
            this.btnDodajNarzedzie.Size = new System.Drawing.Size(236, 36);
            this.btnDodajNarzedzie.TabIndex = 32;
            this.btnDodajNarzedzie.Text = "Dodaj kolejne narzędzie do stanowiska";
            this.btnDodajNarzedzie.UseVisualStyleBackColor = true;
            this.btnDodajNarzedzie.Click += new System.EventHandler(this.btnDodajNarzedzie_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.IndianRed;
            this.btnUsun.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(432, 330);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(198, 33);
            this.btnUsun.TabIndex = 31;
            this.btnUsun.Text = "Usuń stanowisko";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodajStanowisko
            // 
            this.btnDodajStanowisko.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodajStanowisko.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajStanowisko.Location = new System.Drawing.Point(156, 328);
            this.btnDodajStanowisko.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajStanowisko.Name = "btnDodajStanowisko";
            this.btnDodajStanowisko.Size = new System.Drawing.Size(272, 37);
            this.btnDodajStanowisko.TabIndex = 30;
            this.btnDodajStanowisko.Text = "Dodaj Stanowisko";
            this.btnDodajStanowisko.UseVisualStyleBackColor = false;
            this.btnDodajStanowisko.Click += new System.EventHandler(this.btnDodajStanowisko_Click);
            // 
            // txtMaszyny
            // 
            this.txtMaszyny.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMaszyny.Location = new System.Drawing.Point(755, 110);
            this.txtMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaszyny.Name = "txtMaszyny";
            this.txtMaszyny.Size = new System.Drawing.Size(293, 25);
            this.txtMaszyny.TabIndex = 29;
            // 
            // txtIlosc
            // 
            this.txtIlosc.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIlosc.Location = new System.Drawing.Point(635, 110);
            this.txtIlosc.Margin = new System.Windows.Forms.Padding(2);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(104, 25);
            this.txtIlosc.TabIndex = 28;
            // 
            // txtNarzedzie
            // 
            this.txtNarzedzie.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNarzedzie.Location = new System.Drawing.Point(464, 110);
            this.txtNarzedzie.Margin = new System.Windows.Forms.Padding(2);
            this.txtNarzedzie.Name = "txtNarzedzie";
            this.txtNarzedzie.Size = new System.Drawing.Size(165, 25);
            this.txtNarzedzie.TabIndex = 27;
            // 
            // txtStanowisko
            // 
            this.txtStanowisko.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStanowisko.Location = new System.Drawing.Point(157, 110);
            this.txtStanowisko.Margin = new System.Windows.Forms.Padding(2);
            this.txtStanowisko.Name = "txtStanowisko";
            this.txtStanowisko.Size = new System.Drawing.Size(289, 25);
            this.txtStanowisko.TabIndex = 26;
            // 
            // dgvSkladMaszyny
            // 
            this.dgvSkladMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladMaszyny.Location = new System.Drawing.Point(656, 395);
            this.dgvSkladMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSkladMaszyny.Name = "dgvSkladMaszyny";
            this.dgvSkladMaszyny.RowHeadersWidth = 51;
            this.dgvSkladMaszyny.RowTemplate.Height = 24;
            this.dgvSkladMaszyny.Size = new System.Drawing.Size(475, 172);
            this.dgvSkladMaszyny.TabIndex = 25;
            // 
            // dgvSkladNarzedzia
            // 
            this.dgvSkladNarzedzia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladNarzedzia.Location = new System.Drawing.Point(157, 395);
            this.dgvSkladNarzedzia.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSkladNarzedzia.Name = "dgvSkladNarzedzia";
            this.dgvSkladNarzedzia.RowHeadersWidth = 51;
            this.dgvSkladNarzedzia.RowTemplate.Height = 24;
            this.dgvSkladNarzedzia.Size = new System.Drawing.Size(473, 172);
            this.dgvSkladNarzedzia.TabIndex = 24;
            // 
            // dgvMaszyny
            // 
            this.dgvMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaszyny.Location = new System.Drawing.Point(755, 139);
            this.dgvMaszyny.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMaszyny.Name = "dgvMaszyny";
            this.dgvMaszyny.RowHeadersWidth = 51;
            this.dgvMaszyny.RowTemplate.Height = 24;
            this.dgvMaszyny.Size = new System.Drawing.Size(293, 176);
            this.dgvMaszyny.TabIndex = 23;
            this.dgvMaszyny.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaszyny_CellContentClick);
            // 
            // dgvNarzedzia
            // 
            this.dgvNarzedzia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarzedzia.Location = new System.Drawing.Point(464, 139);
            this.dgvNarzedzia.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNarzedzia.Name = "dgvNarzedzia";
            this.dgvNarzedzia.RowHeadersWidth = 51;
            this.dgvNarzedzia.RowTemplate.Height = 24;
            this.dgvNarzedzia.Size = new System.Drawing.Size(275, 176);
            this.dgvNarzedzia.TabIndex = 22;
            this.dgvNarzedzia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarzedzia_CellContentClick);
            // 
            // dgvStanowisko
            // 
            this.dgvStanowisko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanowisko.Location = new System.Drawing.Point(156, 139);
            this.dgvStanowisko.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStanowisko.Name = "dgvStanowisko";
            this.dgvStanowisko.RowHeadersWidth = 51;
            this.dgvStanowisko.RowTemplate.Height = 24;
            this.dgvStanowisko.Size = new System.Drawing.Size(290, 176);
            this.dgvStanowisko.TabIndex = 21;
            this.dgvStanowisko.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStanowisko_CellContentClick);
            // 
            // FormSkladStanowisko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1282, 690);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsun2);
            this.Controls.Add(this.btnDodajMaszyne);
            this.Controls.Add(this.btnUsunNarzedzie);
            this.Controls.Add(this.btnDodajNarzedzie);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodajStanowisko);
            this.Controls.Add(this.txtMaszyny);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.txtNarzedzie);
            this.Controls.Add(this.txtStanowisko);
            this.Controls.Add(this.dgvSkladMaszyny);
            this.Controls.Add(this.dgvSkladNarzedzia);
            this.Controls.Add(this.dgvMaszyny);
            this.Controls.Add(this.dgvNarzedzia);
            this.Controls.Add(this.dgvStanowisko);
            this.Name = "FormSkladStanowisko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Skład Stanowiska";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladMaszyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladNarzedzia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarzedzia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanowisko)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsun2;
        private System.Windows.Forms.Button btnDodajMaszyne;
        private System.Windows.Forms.Button btnUsunNarzedzie;
        private System.Windows.Forms.Button btnDodajNarzedzie;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodajStanowisko;
        private System.Windows.Forms.TextBox txtMaszyny;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.TextBox txtNarzedzie;
        private System.Windows.Forms.TextBox txtStanowisko;
        private System.Windows.Forms.DataGridView dgvSkladMaszyny;
        private System.Windows.Forms.DataGridView dgvSkladNarzedzia;
        private System.Windows.Forms.DataGridView dgvMaszyny;
        private System.Windows.Forms.DataGridView dgvNarzedzia;
        private System.Windows.Forms.DataGridView dgvStanowisko;
    }
}