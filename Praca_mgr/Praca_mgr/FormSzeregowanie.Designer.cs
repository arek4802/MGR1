namespace Praca_mgr
{
    partial class FormSzeregowanie
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSzeregowanie));
            this.dgvSzeregowanie = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaszyna = new System.Windows.Forms.ComboBox();
            this.cBMaszyna2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCzas_przed = new System.Windows.Forms.DataGridView();
            this.dgvCzas_po = new System.Windows.Forms.DataGridView();
            this.btnAkceptuj = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzeregowanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzas_przed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzas_po)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSzeregowanie
            // 
            this.dgvSzeregowanie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzeregowanie.Location = new System.Drawing.Point(542, 63);
            this.dgvSzeregowanie.MultiSelect = false;
            this.dgvSzeregowanie.Name = "dgvSzeregowanie";
            this.dgvSzeregowanie.Size = new System.Drawing.Size(782, 374);
            this.dgvSzeregowanie.TabIndex = 102;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(58, 311);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 37);
            this.btnDodaj.TabIndex = 98;
            this.btnDodaj.Text = "Szereguj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(52, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 94;
            this.label1.Text = "Maszyna nr 1";
            // 
            // cbMaszyna
            // 
            this.cbMaszyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMaszyna.FormattingEnabled = true;
            this.cbMaszyna.Location = new System.Drawing.Point(58, 142);
            this.cbMaszyna.Name = "cbMaszyna";
            this.cbMaszyna.Size = new System.Drawing.Size(385, 33);
            this.cbMaszyna.TabIndex = 106;
            // 
            // cBMaszyna2
            // 
            this.cBMaszyna2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBMaszyna2.FormattingEnabled = true;
            this.cBMaszyna2.Location = new System.Drawing.Point(58, 237);
            this.cBMaszyna2.Name = "cBMaszyna2";
            this.cBMaszyna2.Size = new System.Drawing.Size(385, 33);
            this.cBMaszyna2.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(52, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 32);
            this.label2.TabIndex = 107;
            this.label2.Text = "Maszyna nr 2";
            // 
            // dgvCzas_przed
            // 
            this.dgvCzas_przed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzas_przed.Location = new System.Drawing.Point(1224, 16);
            this.dgvCzas_przed.MultiSelect = false;
            this.dgvCzas_przed.Name = "dgvCzas_przed";
            this.dgvCzas_przed.Size = new System.Drawing.Size(131, 41);
            this.dgvCzas_przed.TabIndex = 109;
            this.dgvCzas_przed.Visible = false;
            // 
            // dgvCzas_po
            // 
            this.dgvCzas_po.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzas_po.Location = new System.Drawing.Point(1087, 16);
            this.dgvCzas_po.MultiSelect = false;
            this.dgvCzas_po.Name = "dgvCzas_po";
            this.dgvCzas_po.Size = new System.Drawing.Size(131, 41);
            this.dgvCzas_po.TabIndex = 110;
            this.dgvCzas_po.Visible = false;
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAkceptuj.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAkceptuj.Location = new System.Drawing.Point(412, 63);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(101, 31);
            this.btnAkceptuj.TabIndex = 111;
            this.btnAkceptuj.Text = "Akceptuj";
            this.btnAkceptuj.UseVisualStyleBackColor = false;
            this.btnAkceptuj.Click += new System.EventHandler(this.btnAkceptuj_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(282, 465);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Czas_przed";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Czas_po";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(763, 434);
            this.chart1.TabIndex = 112;
            this.chart1.Text = "chart1";
            // 
            // FormSzeregowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1448, 932);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnAkceptuj);
            this.Controls.Add(this.dgvCzas_po);
            this.Controls.Add(this.dgvCzas_przed);
            this.Controls.Add(this.cBMaszyna2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaszyna);
            this.Controls.Add(this.dgvSzeregowanie);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Name = "FormSzeregowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Szeregowanie Zadań";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzeregowanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzas_przed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzas_po)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSzeregowanie;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaszyna;
        private System.Windows.Forms.ComboBox cBMaszyna2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCzas_przed;
        private System.Windows.Forms.DataGridView dgvCzas_po;
        private System.Windows.Forms.Button btnAkceptuj;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}