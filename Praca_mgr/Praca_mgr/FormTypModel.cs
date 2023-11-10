using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praca_mgr
{
    public partial class FormTypModel : Form
    {
        Firma_produkcyjnaEntities db;
        public FormTypModel(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            RefreshScreen();
        }

        private void RefreshScreen()
        {
            initDataGridViewModel();
            initDataGridViewModelTyp();
            initDataGridViewTyp();
        }
        private void initDataGridViewTyp()
        { 
            dgvTyp.DataSource = db.Typ_pojazd_slownik.ToList();
            this.dgvTyp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvTyp.Columns["ID_typ_pojazd"].Visible = false;
            dgvTyp.Columns["Typ_pojazd_model"].Visible = false;
            dgvTyp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

    private void initDataGridViewModel()
    {
        dgvModel.DataSource = db.Model_pojazd_slownik.ToList();
        this.dgvModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvModel.Columns["ID_model_pojazd"].Visible = false;
        dgvModel.Columns["Marka_model"].Visible = false;
        dgvModel.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

    private void initDataGridViewModelTyp()
    {
        dgvModelTyp.DataSource = db.v_Wybor_model_typ.ToList();
        this.dgvModelTyp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvModelTyp.Columns["ID_typ_pojazd_model"].Visible = false;
            dgvModelTyp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
    }   
          

        private void dgvModel_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtModel.Text = this.dgvModel.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvTyp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTyp.Text = this.dgvTyp.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvModelTyp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTyp.Text = this.dgvModelTyp.CurrentRow.Cells[1].Value.ToString();
            txtModel.Text = this.dgvModelTyp.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDodajModel_Click_1(object sender, EventArgs e)
        {
            FormTyp formTyp = new FormTyp(db);
            formTyp.ShowDialog();
        }

        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTyp.Text) || String.IsNullOrEmpty(txtModel.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Typ_pojazd_model modelTyp = new Typ_pojazd_model();
                modelTyp.ID_typ_pojazd = int.Parse(this.dgvTyp.CurrentRow.Cells[0].Value.ToString());
                modelTyp.ID_marka_model = int.Parse(this.dgvModel.CurrentRow.Cells[0].Value.ToString());
                db.Typ_pojazd_model.Add(modelTyp);
                db.SaveChanges();
                RefreshScreen();
                MessageBox.Show("Poprawnie dodano do bazy danych");
            }
        }

        private void btnUsun_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTyp.Text) || String.IsNullOrEmpty(txtModel.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć: " + this.dgvModelTyp.CurrentRow.Cells[1].Value.ToString() + " - " + this.dgvModelTyp.CurrentRow.Cells[3].Value.ToString(), "Question", MessageBoxButtons.YesNo); ;
                if (dialogResult == DialogResult.Yes)
                {
                    int current_modeltyp = int.Parse(this.dgvModelTyp.CurrentRow.Cells[0].Value.ToString());
                    Typ_pojazd_model result3 = db.Typ_pojazd_model.SingleOrDefault(modeltyp => modeltyp.ID_typ_pojazd_model == current_modeltyp);
                    db.Typ_pojazd_model.Remove(result3);
                    db.SaveChanges();
                    RefreshScreen();
                }
            }
        }
    }
}
