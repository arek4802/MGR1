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
    public partial class FormKontrolaPojazd : Form
    {
        Firma_produkcyjnaEntities db;
        public FormKontrolaPojazd(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            RefreshScreen();
        }
        private void clearDgvs()
        {
            dgvPozytywne.DataSource = 0;
            dgvvKontrolaJakosciKolejka.DataSource = 0;
            dgvRezultatKontroli.DataSource = 0;
            txtNazwa.Text = "";
            txtUwagi.Text = "";
            chBoxWynik.Checked = false;
        }
        private void RefreshScreen()
        {
            initComboboxPracownik();
            initComboboxRodzajKontrola();
            initComboboxZamowienie();
        }

        private void initComboboxPracownik()
        {
            cBPracownik.DataSource = db.v_Pracownik_produkcja.ToList();
            cBPracownik.ValueMember = "ID_pracownik";
            cBPracownik.DisplayMember = "Pracownik";
        }
        private void initComboboxRodzajKontrola()
        {
            cBRodzajKontrola.DataSource = db.v_Rodzaj_kontrola.ToList();
            cBRodzajKontrola.ValueMember = "ID";
            cBRodzajKontrola.DisplayMember = "Rodzaj_kontroli";
        }

        private void initComboboxZamowienie()
        {
            cbZamowienie.DataSource = db.v_Zamowienie_montaz.ToList();
            cbZamowienie.ValueMember = "ID";
            cbZamowienie.DisplayMember = "Klient";
        }
        private void initDataGridViewWytworzoneProduktyZamowienie()
        {
            int wybraneZamowienie = int.Parse(cbZamowienie.SelectedValue.ToString());
            List<v_Proces_montaz_wykonane1> montaz_Wykonane = db.v_Proces_montaz_wykonane1.Where(a => a.ID_zamowienie == wybraneZamowienie).ToList();
            dgvvKontrolaJakosciKolejka.DataSource = montaz_Wykonane;            
            dgvvKontrolaJakosciKolejka.Columns["ID_zamowienie"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["ID_montaz_pojazd"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["ID_pojazd"].Visible = false;
            this.dgvvKontrolaJakosciKolejka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvvKontrolaJakosciKolejka.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);            
        }
        private void initDataGridViewKontrolaPozytywna()
        {
            
            int wybraneZamowienie = int.Parse(cbZamowienie.SelectedValue.ToString());
            List<v_Kontrola_pozytywna_pojazd> pozytywnaKontrola = db.v_Kontrola_pozytywna_pojazd.Where(a => a.ID_zamowienie == wybraneZamowienie).ToList();
            dgvPozytywne.DataSource = pozytywnaKontrola;
            dgvPozytywne.Columns["ID_zamowienie"].Visible = false;
            dgvPozytywne.Columns["ID_pojazd"].Visible = false;
            dgvPozytywne.Columns["ID_montaz_pojazd"].Visible = false;

            this.dgvPozytywne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPozytywne.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void initDataGridViewRezultatKontroli()
        {
            this.db = new Firma_produkcyjnaEntities();
            int wybraneZamowienie = int.Parse(cbZamowienie.SelectedValue.ToString());
            List<v_Ilosc_kontrola_pozytywna_pojazd> RezultatKontroli = db.v_Ilosc_kontrola_pozytywna_pojazd.Where(a => a.ID_zamowienie == wybraneZamowienie).ToList();
            dgvRezultatKontroli.DataSource = RezultatKontroli;
            dgvRezultatKontroli.Columns["ID_montaz_pojazd"].Visible = false;
            dgvRezultatKontroli.Columns["ID_pojazd"].Visible = false;
            dgvRezultatKontroli.Columns["ID_zamowienie"].Visible = false;
            this.dgvRezultatKontroli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRezultatKontroli.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgvvKontrolaJakosciKolejka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwa.Text = this.dgvvKontrolaJakosciKolejka.CurrentRow.Cells[0].Value.ToString();
            txtCzynnosc.Text = this.dgvvKontrolaJakosciKolejka.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnWczytajZamowienie_Click(object sender, EventArgs e)
        {
            initDataGridViewWytworzoneProduktyZamowienie();
            initDataGridViewKontrolaPozytywna();            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwa.Text) || String.IsNullOrEmpty(cBPracownik.Text) || String.IsNullOrEmpty(cBRodzajKontrola.Text))
            {
                MessageBox.Show("Nie wypełniono formularza!");
            }
            else
            {
                Kontrola_jakosci_pojazd kontrola_Jakosci_Pojazd = new Kontrola_jakosci_pojazd();
                kontrola_Jakosci_Pojazd.ID_montaz_pojazd = int.Parse(this.dgvvKontrolaJakosciKolejka.CurrentRow.Cells[3].Value.ToString());
                kontrola_Jakosci_Pojazd.ID_pracownik = int.Parse(cBPracownik.SelectedValue.ToString());
                kontrola_Jakosci_Pojazd.ID_rodzaj_kontrola = int.Parse(cBRodzajKontrola.SelectedValue.ToString());
                kontrola_Jakosci_Pojazd.Data_kontroli = dTPDataOd.Value.Date;
                kontrola_Jakosci_Pojazd.Uwagi = txtUwagi.Text;
                kontrola_Jakosci_Pojazd.Wynik_kontroli = chBoxWynik.Checked;
                db.Kontrola_jakosci_pojazd.Add(kontrola_Jakosci_Pojazd);
                db.SaveChanges();

                this.db = new Firma_produkcyjnaEntities();

                MessageBox.Show("Poprawnie zarejestrowano kontrolę jakości.");
                initDataGridViewKontrolaPozytywna();
                RefreshScreen();
            }
            RefreshScreen();
            txtNazwa.Text = "";
            txtUwagi.Text = "";
        }

        private void btnRezultat_Click(object sender, EventArgs e)
        {
            initDataGridViewRezultatKontroli();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            clearDgvs();
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            if (this.dgvRezultatKontroli.SelectedRows.Count > 0)
            {
                if (this.dgvRezultatKontroli.CurrentRow != null)
                {
                    string pojazd = this.dgvRezultatKontroli.CurrentRow.Cells[0].Value.ToString();
                    int alertCountBefore = this.db.Alert.ToList().Count;
                    FormDodajAlert addAlert = new FormDodajAlert(db, pojazd);
                    addAlert.ShowDialog();
                    int alertCountAfter = this.db.Alert.ToList().Count;
                    if (alertCountBefore >= alertCountAfter)
                    {
                        MessageBox.Show("Nie dodano alarmu!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    int alertCountBefore = this.db.Alert.ToList().Count;
                    FormDodajAlert addAlert = new FormDodajAlert(db);
                    addAlert.ShowDialog();
                    int alertCountAfter = this.db.Alert.ToList().Count;
                    if (alertCountBefore >= alertCountAfter)
                    {
                        MessageBox.Show("Nie dodano alarmu!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                string pojazd = this.dgvRezultatKontroli.CurrentRow.Cells[0].Value.ToString();
                int alertCountBefore = this.db.Alert.ToList().Count;
                FormDodajAlert addAlert = new FormDodajAlert(db, pojazd);
                addAlert.ShowDialog();
                int alertCountAfter = this.db.Alert.ToList().Count;
                if (alertCountBefore >= alertCountAfter)
                {
                    MessageBox.Show("Nie dodano alarmu!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMagazynPojazd formMagazynPojazd = new FormMagazynPojazd(db);
            formMagazynPojazd.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Start start = new Start();
            start.ShowDialog();
            this.Close();
        }
    }
}
