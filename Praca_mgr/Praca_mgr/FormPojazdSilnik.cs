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
    public partial class FormPojazdSilnik : Form
    {
        Firma_produkcyjnaEntities db;
        public FormPojazdSilnik(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridViewPojazdyModel();
            initDataGridGotowe();


        }

        private void initDataGridViewPojazdyModel()
        {
            dgvPojazdyModel.DataSource = db.v_Pojazdy_modele.ToList();
            this.dgvPojazdyModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPojazdyModel.Columns["ID_pojazd"].Visible = false;
            //dgvPojazdyModel.Columns["ID_marka_model"].Visible = false;
            dgvPojazdyModel.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewWersja()
        {
            int wybranyModel =int.Parse(this.dgvPojazdyModel.CurrentRow.Cells[3].Value.ToString()); 
            List<v_Wybor_silnika> wyborSilnika = db.v_Wybor_silnika.Where(a => a.ID_marka_model == wybranyModel).ToList();
            dgvWersja.DataSource = wyborSilnika;
            dgvWersja.Columns["ID_typ_pojazd"].Visible = false;
            dgvWersja.Columns["ID_marka_model"].Visible = false;
            this.dgvWersja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvWersja.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void dgvPojazdyModel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtModel.Text = this.dgvPojazdyModel.CurrentRow.Cells[4].Value.ToString();
            txtVIN.Text = this.dgvPojazdyModel.CurrentRow.Cells[1].Value.ToString();
            initDataGridViewWersja();

        }

        private void initDataGridGotowe()
        {
            dgvGotowe.DataSource = db.v_Wybor_silnika_zrobione.ToList();
            this.dgvPojazdyModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvGotowe.Columns["ID_pojazd"].Visible = false;
            dgvGotowe.Columns["ID_typ_pojazd"].Visible = false;
            dgvGotowe.Columns["ID_marka_model"].Visible = false;
            dgvGotowe.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtModel.Text) || String.IsNullOrEmpty(txtVIN.Text) || String.IsNullOrEmpty(txtWersja.Text))
            {
                MessageBox.Show("Nie wypełniono formularza!");
            }
            else
            {
                Typ_pojazd_model typ_Pojazd_Model = new Typ_pojazd_model();

                typ_Pojazd_Model.ID_marka_model = int.Parse(this.dgvPojazdyModel.CurrentRow.Cells[3].Value.ToString());
                typ_Pojazd_Model.ID_typ_pojazd = int.Parse(this.dgvWersja.CurrentRow.Cells[0].Value.ToString());
                db.Typ_pojazd_model.Add(typ_Pojazd_Model);
                db.SaveChanges();
                initDataGridGotowe();
            }
        }

        private void dgvWersja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWersja.Text = this.dgvWersja.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtModel.Text) || String.IsNullOrEmpty(txtVIN.Text) || String.IsNullOrEmpty(txtWersja.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int currentID = int.Parse(dgvGotowe.CurrentRow.Cells[0].Value.ToString());
                int newModel = int.Parse(dgvWersja.CurrentRow.Cells[0].Value.ToString());
                Typ_pojazd_model result = db.Typ_pojazd_model.SingleOrDefault(b => b.ID_marka_model == currentID);

                if (result != null)
                {
                    result.ID_typ_pojazd = newModel;

                    db.SaveChanges();
                }
                MessageBox.Show("Poprawnie zaktualizowano.");
            }
        }

        private void dgvGotowe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtModel.Text = this.dgvGotowe.CurrentRow.Cells[6].Value.ToString();
            txtVIN.Text = this.dgvGotowe.CurrentRow.Cells[2].Value.ToString();
            txtWersja.Text = this.dgvGotowe.CurrentRow.Cells[1].Value.ToString();
            initDataGridViewWersja1();
        }

        private void initDataGridViewWersja1()
        {
            int wybranyModel = int.Parse(this.dgvGotowe.CurrentRow.Cells[3].Value.ToString());
            List<v_Wybor_silnika> wyborSilnika = db.v_Wybor_silnika.Where(a => a.ID_marka_model == wybranyModel).ToList();
            dgvWersja.DataSource = wyborSilnika;
            dgvWersja.Columns["ID_typ_pojazd"].Visible = false;
            dgvWersja.Columns["ID_marka_model"].Visible = false;
            this.dgvWersja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvWersja.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
    }
}
