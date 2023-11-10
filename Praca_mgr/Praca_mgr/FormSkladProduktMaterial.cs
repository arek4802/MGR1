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
    public partial class FormSkladProduktMaterial : Form
    {
        Firma_produkcyjnaEntities db;
        public FormSkladProduktMaterial(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridViewProdukt();
            initDataGridViewMaterial();
            initDataGridViewSkladProdukt();
        }
        private void refreshScreen()
        {
            initDataGridViewProdukt();
            initDataGridViewMaterial();
            initDataGridViewSkladProdukt();
            txtProdukt.Text = "";
            txtMaterial.Text = "";
            txtIlosc.Text = "";
        }

        private void initDataGridViewProdukt()
        {
            dgvProdukt.DataSource = db.Produkt.ToList();
            dgvProdukt.Columns["Parametr_produkt"].Visible = false;
            dgvProdukt.Columns["Proces_produkt_czynnosc"].Visible = false;
            dgvProdukt.Columns["Sklad_produkt"].Visible = false;
            dgvProdukt.Columns["Sklad_produkt_material"].Visible = false;
            dgvProdukt.Columns["Szczegoly_zamowienie_produkt"].Visible = false;
            dgvProdukt.Columns["Zamowienie_szczegol"].Visible = false;
            dgvProdukt.Columns["Zwrot_produkt"].Visible = false;
            dgvProdukt.Columns["Miejsce_magazynowanie_produkt"].Visible = false;
            dgvProdukt.Columns["Szczegol_reklamacja_produkt"].Visible = false;
            dgvProdukt.Columns["Typ_pojazd_model_silnik"].Visible = false;
            dgvProdukt.Columns["Wersja_wyposazenia_produkt"].Visible = false;
            this.dgvProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initDataGridViewMaterial()
        {
            dgvMaterial.DataSource = db.Material.ToList();
            dgvMaterial.Columns["ID_rodzaj_material"].Visible = false;
            dgvMaterial.Columns["Rodzaj_material"].Visible = false;
            dgvMaterial.Columns["Parametr_material"].Visible = false;
            dgvMaterial.Columns["Sklad_polprodukt"].Visible = false;
            dgvMaterial.Columns["Szczegoly_zamowienie_material"].Visible = false;
            dgvMaterial.Columns["Sklad_produkt_material"].Visible = false;
            this.dgvMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void initDataGridViewSkladProdukt()
        {
            dgvvSkladProdukt.DataSource = db.v_Sklad_produkt_material.ToList();

            this.dgvvSkladProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProdukt.Text) || String.IsNullOrEmpty(txtMaterial.Text) || String.IsNullOrEmpty(txtIlosc.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Sklad_produkt_material skladProduktMaterial = new Sklad_produkt_material();
                skladProduktMaterial.ID_produkt = int.Parse(dgvProdukt.CurrentRow.Cells[0].Value.ToString());
                skladProduktMaterial.ID_material = int.Parse(dgvMaterial.CurrentRow.Cells[0].Value.ToString());
                skladProduktMaterial.Ilosc_g = int.Parse(txtIlosc.Text);
                db.Sklad_produkt_material.Add(skladProduktMaterial);
                db.SaveChanges();
                MessageBox.Show("Poprawnie powiązano półprodukt " + txtProdukt.Text + " z materiałem " + txtMaterial.Text + ".");
                refreshScreen();
            }
        }

        private void dgvProdukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProdukt.Text = dgvProdukt.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaterial.Text = dgvMaterial.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProdukt.Text) || String.IsNullOrEmpty(txtMaterial.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                DialogResult deleteResult = MessageBox.Show("Czy na pewno chcesz usunąć powiązanie między produktem: " + txtProdukt.Text + Environment.NewLine + "a materiałem " + txtMaterial.Text + "?", "Question", MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    int currentSkladProduktMaterial = int.Parse(dgvvSkladProdukt.CurrentRow.Cells[0].Value.ToString());

                    db.Sklad_produkt_material.Remove(db.Sklad_produkt_material.Where(produkt => produkt.ID_sklad_produkt_material == currentSkladProduktMaterial).First());
                    db.SaveChanges();
                }
                MessageBox.Show("Poprawnie usunięto.");
                refreshScreen();
            }
        }     

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProdukt.Text) || String.IsNullOrEmpty(txtMaterial.Text) || String.IsNullOrEmpty(txtIlosc.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int currentID = int.Parse(dgvvSkladProdukt.CurrentRow.Cells[0].Value.ToString());
                int newValue = int.Parse(txtIlosc.Text);

                Sklad_produkt_material result = db.Sklad_produkt_material.SingleOrDefault(b => b.ID_sklad_produkt_material == currentID);
                if (result != null)
                {
                    result.Ilosc_g = newValue;
                    db.SaveChanges();
                }
                MessageBox.Show("Poprawnie zaktualizowano.");
                refreshScreen();
            }
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            refreshScreen();
        }

        private void dgvvSkladProdukt_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtProdukt.Text = dgvvSkladProdukt.CurrentRow.Cells[1].Value.ToString();
            txtMaterial.Text = dgvvSkladProdukt.CurrentRow.Cells[2].Value.ToString();
            txtIlosc.Text = dgvvSkladProdukt.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
