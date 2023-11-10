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
    public partial class FormMontaz : Form
    {
        Firma_produkcyjnaEntities db;
        public FormMontaz(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            RefreshScreen();
        }
        private void RefreshScreen()
        {
            dtpCzasOd.ShowUpDown = true;
            dtpCzasDo.ShowUpDown = true;
            initComboboxPracowicyProdukcji();
            initComboboxZamowienie();            
        }
        private void refreshComboboxes()
        {
            initComboboxPracowicyProdukcji();
        }
        private void initComboboxPracowicyProdukcji()
        {
            cbPracownik.DataSource = db.v_Pracownik_produkcja.ToList();
            cbPracownik.ValueMember = "ID_pracownik";
            cbPracownik.DisplayMember = "Pracownik";
        }        

        private void initComboboxZamowienie()
        {
            cbZamowienie.DataSource = db.v_Zamowienie_montaz.ToList();
            cbZamowienie.ValueMember = "ID";
            cbZamowienie.DisplayMember = "Klient";
        }


        private void enterIdOrder()
        {
            string zamowienie = cbZamowienie.SelectedValue.ToString();
            int zamowienieID = int.Parse(zamowienie);
            List<v_Zamowienie_szczegol_pojazd> vOrderId = db.v_Zamowienie_szczegol_pojazd.Where(a => a.Nr_zamówienia == zamowienieID).ToList();
            int vOrderIdInt = vOrderId.Count();
            if (vOrderIdInt > 0)
            {
                dgvZamowienieSzczegol.DataSource = vOrderId;
                this.dgvZamowienieSzczegol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                dgvZamowienieSzczegol.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvZamowienieSzczegol.Columns["ID_zamowienie_szczegol_pojazd"].Visible = false;
                dgvZamowienieSzczegol.Columns["ID_gwarancja"].Visible = false;
                dgvZamowienieSzczegol.Columns["Opis_gwarancja"].Visible = false;
                dgvZamowienieSzczegol.Columns["ID_pojazd"].Visible = false;
                RefreshScreen();
            }
            else
            {
                RefreshScreen();
            }
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            enterIdOrder();
        }

        private void dgvZamowienieSzczegol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSzukanyProduktID.Text = dgvZamowienieSzczegol.CurrentRow.Cells[6].Value.ToString();
            txtSzukanyProduktNazwa.Text = dgvZamowienieSzczegol.CurrentRow.Cells[2].Value.ToString();            
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            string produktID = txtSzukanyProduktID.Text;
            try
            {
                int produktIDint = int.Parse(produktID);
                List<v_Proces_montaz_kolejka> vProdukt = db.v_Proces_montaz_kolejka.Where(a => a.ID_pojazd == produktIDint).ToList();
                int vProduktIdInt = vProdukt.Count();
                if (vProduktIdInt > 0)
                {
                    dgvCzynnosci.DataSource = vProdukt;
                    dgvCzynnosci.Columns["ID"].Visible = false;
                    dgvCzynnosci.Columns["Nr_VIN"].Visible = false;
                    dgvCzynnosci.Columns["ID_pojazd"].Visible = false;
                    this.dgvCzynnosci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    dgvCzynnosci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    
                    RefreshScreen();
                    initDataGridViewWykonane();
                }
                else
                {
                    RefreshScreen();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wybierz czynności montażowe!");
            }
        }
        private void initDataGridViewWykonane()
        {
            dgvWykonane.DataSource = db.v_Proces_montaz_wykonane.ToList();
            this.dgvWykonane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvWykonane.Columns["ID"].Visible = false;
            dgvWykonane.Columns["ID_montaz_pojazd"].Visible = false;
            dgvWykonane.Columns["ID_pojazd"].Visible = false;
            dgvWykonane.Columns["ID_zamowienie"].Visible = false;
            dgvWykonane.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Montaz_pojazd montaz_Pojazd = new Montaz_pojazd();
            montaz_Pojazd.ID_pracownik = int.Parse(cbPracownik.SelectedValue.ToString());

            if (dgvZamowienieSzczegol.Rows.Count == 0)
            {
                MessageBox.Show("Wybierz zamówienie dla którego chcesz opracować proces produkcyjny");
            }
            else
            {
                montaz_Pojazd.ID_zamowienie_szczegol_pojazd = int.Parse(dgvZamowienieSzczegol.CurrentRow.Cells[0].Value.ToString());
                montaz_Pojazd.Czas_od = dtpDataOd.Value.Date + dtpCzasOd.Value.TimeOfDay;
                montaz_Pojazd.Czas_do = dtpDataDo.Value.Date + dtpCzasDo.Value.TimeOfDay;
                db.Montaz_pojazd.Add(montaz_Pojazd);
                db.SaveChanges();

                int montazID = (from n in db.Montaz_pojazd orderby n.ID_montaz_pojazd descending select n.ID_montaz_pojazd).FirstOrDefault();
                if (txtSzukanyProduktNazwa.Text == dgvCzynnosci.CurrentRow.Cells[1].Value.ToString())
                {
                    Proces_montaz_pojazd proces_Montaz_Pojazd = new Proces_montaz_pojazd();
                    proces_Montaz_Pojazd.ID_montaz_pojazd = montazID;
                    proces_Montaz_Pojazd.ID_proces_montaz_pojazd_czynnosc = int.Parse(dgvCzynnosci.CurrentRow.Cells[0].Value.ToString());

                    db.Proces_montaz_pojazd.Add(proces_Montaz_Pojazd);
                    db.SaveChanges();
                    RefreshScreen();
                    initDataGridViewWykonane();
                    MessageBox.Show("Poprawnie dodano proces montażu dla pojazdu.");
                }
                else
                {
                    MessageBox.Show("Wybierz czynność!");
                }
            }
            refreshComboboxes();
        }

        private void dgvCzynnosci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCzynnosc.Text = this.dgvCzynnosci.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
