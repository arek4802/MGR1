using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praca_mgr
{
    public partial class FormSzeregowanie : Form
    {
        Firma_produkcyjnaEntities db;
        public FormSzeregowanie(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            RefreshScreen();
            cbMaszyna.Text = "13";
            cBMaszyna2.Text = "12";
        }

        private void RefreshScreen()
        {            
            initComboboxMaszyna();
            initComboboxMaszyna2();            
        }
       
        private void initComboboxMaszyna()
        {
            cbMaszyna.DataSource = db.Maszyna_nr_seryjny.ToList();
            cbMaszyna.ValueMember = "ID_maszyna_nr";
            cbMaszyna.DisplayMember = "ID_numer_seryjny";
        }
        private void initComboboxMaszyna2()
        {
            cBMaszyna2.DataSource = db.Maszyna_nr_seryjny.ToList();
            cBMaszyna2.ValueMember = "ID_maszyna_nr";
            cBMaszyna2.DisplayMember = "ID_numer_seryjny";
        }
            private void initDataGridViewSzeregowanie()
        {
            dgvSzeregowanie.DataSource = db.v_Szeregowanie_zadan_przed.ToList();
            this.dgvSzeregowanie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSzeregowanie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);                  
        }

        private void initDataGridViewSzeregowaniePo()
        {
            dgvSzeregowanie.DataSource = db.v_Szeregowanie_zadan.ToList();
            this.dgvSzeregowanie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSzeregowanie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void initDataGridViewCzasPrzed()
        {
            dgvCzas_przed.DataSource = db.v_Czas_przed_szeregowaniem.ToList();
        }

        private void initDataGridViewCzasPo()
        {
            dgvCzas_po.DataSource = db.v_Czas_po_szeregowaniu.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            initDataGridViewSzeregowaniePo();
            initDataGridViewCzasPrzed();
            initDataGridViewCzasPo();


            int sumPr = 0;
            for (int i = 0; i < dgvCzas_przed.Rows.Count; ++i)
            {
                sumPr += Convert.ToInt32(dgvCzas_przed.Rows[i].Cells[2].Value);
            }

            int sumPo = 0;
            for (int i = 0; i < dgvCzas_przed.Rows.Count; ++i)
            {
                sumPo += Convert.ToInt32(dgvCzas_po.Rows[i].Cells[2].Value);
            }
            MessageBox.Show("Przeprowadzono szeregowanie zadań. Przed szeregowaniem czas pracy maszyn wynosił " + sumPr  + " natomiast po szeregowaniu wynosi: " + sumPo);

            
            chart1.Series["Czas_przed"].Points.AddXY(1, sumPr);
            //chart1.Series["Czas_przed"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;*/
            chart1.Series["Czas_po"].Points.AddXY(2, sumPo);
            //chart1.Series["Czas_po"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            initDataGridViewSzeregowanie();
        }
    }
}
