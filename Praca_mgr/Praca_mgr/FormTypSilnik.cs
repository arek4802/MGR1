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
    public partial class FormTypSilnik : Form
    {
        Firma_produkcyjnaEntities db;
        public FormTypSilnik(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            RefreshScreen();
        }

        private void RefreshScreen()
        {
            initDataGridViewTypPojazd();
            initDataGridViewLista();
            initDataGridViewPrzypisane();
        }

        private void initDataGridViewTypPojazd()
        {
            dgvMarkaModel.DataSource = db.v_Wybor_silnika2.ToList();
            this.dgvMarkaModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarkaModel.Columns["ID_marka_model"].Visible = false;
            dgvMarkaModel.Columns["ID_typ_pojazd"].Visible = false;            
            dgvMarkaModel.Columns["Nazwa_typ"].Visible = false;
            dgvMarkaModel.Columns["ID_typ_pojazd_model"].Visible = false;
            this.dgvMarkaModel.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); 
        }

        private void initDataGridViewLista()
        {
            dgvSilnik.DataSource = db.v_Lista_silnikow.ToList();
            this.dgvSilnik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSilnik.Columns["ID_produkt"].Visible = false;
            dgvSilnik.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewPrzypisane()
        {
            dgvPrzypisane.DataSource = db.v_Przypisane_silniki.ToList();
            this.dgvPrzypisane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrzypisane.Columns["ID_typ_pojazd"].Visible = false;
            dgvPrzypisane.Columns["Nazwa_typ"].Visible = false;
            dgvPrzypisane.Columns["ID_marka_model"].Visible = false;
            dgvPrzypisane.Columns["MM"].Visible = false;
            dgvPrzypisane.Columns["ID_pojazd_model"].Visible = false;
            dgvPrzypisane.Columns["ID_produkt"].Visible = false;
            this.dgvPrzypisane.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgvPojazdyModel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTyp.Text = this.dgvMarkaModel.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvSilnik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSilnik.Text = this.dgvSilnik.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvPrzypisane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTyp.Text = this.dgvPrzypisane.CurrentRow.Cells[4].Value.ToString();
            txtSilnik.Text = this.dgvPrzypisane.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTyp.Text) || String.IsNullOrEmpty(txtSilnik.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Typ_pojazd_model_silnik typ_Pojazd_Model_Silnik = new Typ_pojazd_model_silnik();
                typ_Pojazd_Model_Silnik.ID_typ_pojazd_model = int.Parse(this.dgvPrzypisane.CurrentRow.Cells[5].Value.ToString());
                typ_Pojazd_Model_Silnik.ID_produkt = int.Parse(this.dgvPrzypisane.CurrentRow.Cells[7].Value.ToString());
                db.Typ_pojazd_model_silnik.Add(typ_Pojazd_Model_Silnik);
                db.SaveChanges();
                RefreshScreen();
                MessageBox.Show("Poprawnie dodano do bazy danych");
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTyp.Text) || String.IsNullOrEmpty(txtSilnik.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć: " + this.dgvPrzypisane.CurrentRow.Cells[4].Value.ToString() + " - " + this.dgvPrzypisane.CurrentRow.Cells[6].Value.ToString(), "Question", MessageBoxButtons.YesNo); ;
                if (dialogResult == DialogResult.Yes)
                {
                    int current_typsilnik = int.Parse(this.dgvPrzypisane.CurrentRow.Cells[0].Value.ToString());
                    Typ_pojazd_model_silnik result7 = db.Typ_pojazd_model_silnik.SingleOrDefault(typsilnik => typsilnik.ID_typ_pojazd_model_silnik == current_typsilnik);
                    db.Typ_pojazd_model_silnik.Remove(result7);
                    db.SaveChanges();
                    RefreshScreen();
                }
            }
        }
    }
}
