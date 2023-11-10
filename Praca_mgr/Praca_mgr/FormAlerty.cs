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
    public partial class FormAlerty : Form
    {
        Firma_produkcyjnaEntities db;
        public FormAlerty(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }

        private void initDataGridView()
        {
            dgvAlerty.DataSource = db.v_Alerty_ProductionDepartment_nieodczytane.ToList();
            dgvAlerty.Columns[1].Visible = false;
            dgvAlerty.Columns[4].Visible = false;
            dgvAlerty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodajAlert_Click_1(object sender, EventArgs e)
        {
            FormDodajAlert dodajAlert = new FormDodajAlert(db);
            dodajAlert.ShowDialog();
        }

        private void btnOdczytano_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy alert: " + this.dgvAlerty.CurrentRow.Cells[2].Value + " został odczytany?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int odczytano = int.Parse(this.dgvAlerty.CurrentRow.Cells[0].Value.ToString());
                Alert odczytanoID = this.db.Alert.Single(a => a.ID_alert == odczytano);
                odczytanoID.Czy_odczytano = Convert.ToBoolean(1);
                db.SaveChanges();
                initDataGridView();
            }
        }

        private void btnOdswiez_Click_1(object sender, EventArgs e)
        {
            initDataGridView();
        }
    }
}
