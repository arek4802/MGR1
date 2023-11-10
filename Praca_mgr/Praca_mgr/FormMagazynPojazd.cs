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
    public partial class FormMagazynPojazd : Form
    {
        Firma_produkcyjnaEntities db;
        public FormMagazynPojazd(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            initComboboxPojazd();
            initComboboxPoziom();
            initDataGridViewMagazyn();
        }
        private void initComboboxPojazd()
        {
            cBPojazd.DataSource = db.Pojazd.ToList();
            cBPojazd.ValueMember = "ID_pojazd";
            cBPojazd.DisplayMember = "Nr_VIN";
        }
        private void initComboboxPoziom()
        {
            cBMagazyn.DataSource = db.v_Magazynowanie_pojazd_wybor.ToList();
            cBMagazyn.ValueMember = "ID_poziom_magazynowanie";
            cBMagazyn.DisplayMember = "Nazwa";
        }

        private void initDataGridViewMagazyn()
        {
            dgvMagazyn.DataSource = db.v_Magazynowanie_pojazd.ToList();
            dgvMagazyn.Columns[0].Visible = false;
            dgvMagazyn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cBMagazyn.Text) || String.IsNullOrEmpty(cBPojazd.Text) || String.IsNullOrEmpty(txtMiejsce.Text))
            {
                MessageBox.Show("Nie wypełniono formularza!");
            }
            else
            {
                Miejsce_magazynowanie_pojazd miejsce_Magazynowanie_Pojazd = new Miejsce_magazynowanie_pojazd();
                miejsce_Magazynowanie_Pojazd.ID_poziom_magazynowanie = int.Parse(this.cBMagazyn.SelectedValue.ToString());
                miejsce_Magazynowanie_Pojazd.ID_pojazd = int.Parse(cBPojazd.SelectedValue.ToString());
                miejsce_Magazynowanie_Pojazd.Nr_miejsca = int.Parse(txtMiejsce.Text);             
                db.Miejsce_magazynowanie_pojazd.Add(miejsce_Magazynowanie_Pojazd);
                db.SaveChanges();

                this.db = new Firma_produkcyjnaEntities();

                MessageBox.Show("Poprawnie przeniesione do magazynu.");
                initDataGridViewMagazyn();
            }
        }
    }
}
