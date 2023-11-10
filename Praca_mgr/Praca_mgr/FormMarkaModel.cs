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
    public partial class FormMarkaModel : Form
    {
        Firma_produkcyjnaEntities db;
        public FormMarkaModel(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            initRefreshScreen();
        }

        private void initDataGridViewMarka()
        {
            dgvMarka.DataSource = db.Marka_pojazd_slownik.ToList();
            dgvMarka.Columns["ID_marka_pojazd"].Visible = false;
            dgvMarka.Columns["Marka_model"].Visible = false;
        }

        private void initDataGridViewModel()
        {
            dgvModel.DataSource = db.Model_pojazd_slownik.ToList();
            dgvModel.Columns["ID_model_pojazd"].Visible = false;
            dgvModel.Columns["Marka_model"].Visible = false;
        }

        private void initDataGridViewMarkaModel()
        {
            dgvMarkaModel.DataSource = db.v_Wybor_model1.ToList();
            this.dgvMarkaModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarkaModel.Columns["ID_marka_model"].Visible = false;            
            dgvMarkaModel.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initRefreshScreen ()
        {
            initDataGridViewMarka();
            initDataGridViewModel();
            initDataGridViewMarkaModel();
        }

        private void dgvMarka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMarka.Text = this.dgvMarka.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvModel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtModel.Text = this.dgvModel.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvMarkaModel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMarka.Text = this.dgvMarkaModel.CurrentRow.Cells[1].Value.ToString();
            txtModel.Text = this.dgvMarkaModel.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnDodajModel_Click(object sender, EventArgs e)
        {
            FormModel formModel = new FormModel(db);
            formModel.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMarka.Text) || String.IsNullOrEmpty(txtModel.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Marka_model modelMarka = new Marka_model();
                modelMarka.ID_marka_pojazd = int.Parse(this.dgvMarka.CurrentRow.Cells[0].Value.ToString());
                modelMarka.ID_model_pojazd = int.Parse(this.dgvModel.CurrentRow.Cells[0].Value.ToString());
                db.Marka_model.Add(modelMarka);
                db.SaveChanges();
                initRefreshScreen();
                MessageBox.Show("Poprawnie dodano do bazy danych");

                DialogResult dialogResult1 = MessageBox.Show("Czy chcesz powiązać model z typem pojazdu?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    FormTypModel formTypModel = new FormTypModel(db);
                    formTypModel.ShowDialog();
                }
            }

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMarka.Text) || String.IsNullOrEmpty(txtModel.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć: " + this.dgvMarkaModel.CurrentRow.Cells[1].Value.ToString() + " - " +  this.dgvMarkaModel.CurrentRow.Cells[2].Value.ToString(), "Question", MessageBoxButtons.YesNo);;
                if (dialogResult == DialogResult.Yes)
                {
                    int current_markamodel = int.Parse(this.dgvMarkaModel.CurrentRow.Cells[0].Value.ToString());
                    Marka_model result3 = db.Marka_model.SingleOrDefault(markamodel => markamodel.ID_marka_model == current_markamodel);
                    db.Marka_model.Remove(result3);
                    db.SaveChanges();
                    initRefreshScreen();
                }
            }
        }

        private void btnTypModel_Click(object sender, EventArgs e)
        {
            FormTypModel formTypModel = new FormTypModel(db);
            formTypModel.ShowDialog();
        }
    }
}
