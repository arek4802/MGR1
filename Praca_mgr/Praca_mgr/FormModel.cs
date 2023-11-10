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
    public partial class FormModel : Form
    {
        Firma_produkcyjnaEntities db;
        public FormModel(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            initRefreshScreen();
        }

        private void initDataGridView()
        {
            dgvModel.DataSource = db.Model_pojazd_slownik.ToList();
            dgvModel.Columns["ID_model_pojazd"].Visible = false;
            dgvModel.Columns["Marka_model"].Visible = false;
        }

        private void initRefreshScreen()
        {
            initDataGridView();
            txtNazwaModel.Text = "";
        }

        private void dgvModel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwaModel.Text = this.dgvModel.CurrentRow.Cells[1].Value.ToString();
            txtRokOd.Text = this.dgvModel.CurrentRow.Cells[2].Value.ToString();
            txtRokDo.Text = this.dgvModel.CurrentRow.Cells[3].Value.ToString();            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaModel.Text) || String.IsNullOrEmpty(txtRokOd.Text) || String.IsNullOrEmpty(txtRokDo.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Model_pojazd_slownik model_Pojazd_Slownik = new Model_pojazd_slownik();
                model_Pojazd_Slownik.Nazwa = txtNazwaModel.Text;
                model_Pojazd_Slownik.Rok_produkcji_od = int.Parse(txtRokOd.Text);
                model_Pojazd_Slownik.Rok_produkcji_do = int.Parse(txtRokDo.Text);
                db.Model_pojazd_slownik.Add(model_Pojazd_Slownik);
                db.SaveChanges();
                initRefreshScreen();
                MessageBox.Show("Poprawnie dodano " + model_Pojazd_Slownik.Nazwa + " do bazy danych");
            }
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaModel.Text) || String.IsNullOrEmpty(txtRokOd.Text) || String.IsNullOrEmpty(txtRokDo.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                this.dgvModel.CurrentRow.Cells[1].Value = txtNazwaModel.Text;
                this.dgvModel.CurrentRow.Cells[2].Value = int.Parse(txtRokOd.Text);
                this.dgvModel.CurrentRow.Cells[3].Value = int.Parse(txtRokDo.Text);
                db.SaveChanges();
                initRefreshScreen();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaModel.Text) || String.IsNullOrEmpty(txtRokOd.Text) || String.IsNullOrEmpty(txtRokDo.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć produkt: " + this.dgvModel.CurrentRow.Cells[1].Value, "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string current_model = this.dgvModel.CurrentRow.Cells[1].Value.ToString();
                    db.Model_pojazd_slownik.Remove(db.Model_pojazd_slownik.Where(model => model.Nazwa == current_model).First());
                    db.SaveChanges();
                    initRefreshScreen();
                }
            }
        }
    }
}
