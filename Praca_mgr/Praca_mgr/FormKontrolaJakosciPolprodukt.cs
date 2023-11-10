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
    public partial class FormKontrolaJakosciPolprodukt : Form
    {
        Firma_produkcyjnaEntities db;
        public FormKontrolaJakosciPolprodukt(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            initComboboxPracownik();
            initComboboxRodzajKontrola();
            initDataGridViewKontrolaJakosciParametr();
            initComboboxZamowienie();
            refreshScreen();
            clearDgvs();
        }
        private void refreshScreen()
        {
            initComboboxPracownik();
            initComboboxRodzajKontrola();
            initDataGridViewKontrolaJakosciParametr();
            initDataGridViewKontrolaPozytywna();
            dTPCzasDo.ShowUpDown = true;
            dTPCzasOd.ShowUpDown = true;
        }

        private void clearDgvs()
        {
            dgvPozytywne.DataSource = 0;
            dgvvKontrolaJakosciKolejka.DataSource = 0;
            dgvvParametrPolprodukt.DataSource = 0;
            dgvRezultatKontroli.DataSource = 0;
            txtNazwa.Text = "";
            txtParametrPolprodukt.Text = "";
            txtWartosc.Text = "";
        }
        private void dgvvParametrPolprodukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtParametrPolprodukt.Text = this.dgvvParametrPolprodukt.CurrentRow.Cells[3].Value.ToString();
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
        private void initDataGridViewKontrolaJakosciParametr()
        {
            dgvvKontrolaPolprodukt.DataSource = db.v_Kontrola_jakosci_polprodukt.ToList();
            this.dgvvKontrolaPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvvKontrolaPolprodukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewWytworzonePolproduktyZamowienie()
        {
            int wybraneZamowienie = int.Parse(cbZamowienie.SelectedValue.ToString());
            List<v_Wytworzone_polprodukty_zamowienie> wytworzonePolproduktyZamowienie = db.v_Wytworzone_polprodukty_zamowienie.Where(a => a.ID_zamowienie == wybraneZamowienie).ToList();
            dgvvKontrolaJakosciKolejka.DataSource = wytworzonePolproduktyZamowienie;
            dgvvKontrolaJakosciKolejka.Columns["ID"].HeaderText = "ID_wytwarzanie";
            dgvvKontrolaJakosciKolejka.Columns["ID_polrodukt"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Czynność_produkcyjna"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Pracownik"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Stanowisko"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Szacowany_czas__min_"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Data_rozpoczęcia"].Visible = false;
            dgvvKontrolaJakosciKolejka.Columns["Data_zakończenia"].Visible = false;
            this.dgvvKontrolaJakosciKolejka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvvKontrolaJakosciKolejka.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewKontrolaPozytywna()
        {
            dgvPozytywne.DataSource = 0;
            int wybraneZamowienie = int.Parse(cbZamowienie.SelectedValue.ToString());
            List<v_Kontrola_pozytywna_polprodukt> pozytywnaKontrolaPolprodukt = db.v_Kontrola_pozytywna_polprodukt.Where(a => a.ID_zamowienie == wybraneZamowienie).ToList();
            dgvPozytywne.DataSource = pozytywnaKontrolaPolprodukt;
            dgvPozytywne.Columns["Wynik_kontrola"].Visible = false;
            this.dgvPozytywne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPozytywne.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewRezultatKontroli()
        {
            this.db = new Firma_produkcyjnaEntities();
            int wybraneZamowienie = int.Parse(cbZamowienie.SelectedValue.ToString());
            List<v_Ilosc_kontrola_pozytywna_polprodukt> RezultatKontroliPolprodukt = db.v_Ilosc_kontrola_pozytywna_polprodukt.Where(a => a.ID_zamowienie == wybraneZamowienie).ToList();
            dgvRezultatKontroli.DataSource = RezultatKontroliPolprodukt;
            dgvRezultatKontroli.Columns["ID_zamowienie"].Visible = false;
            dgvRezultatKontroli.Columns["ID_polprodukt"].Visible = false;
            this.dgvRezultatKontroli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRezultatKontroli.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initComboboxZamowienie()
        {
            cbZamowienie.DataSource = db.v_Zamowienie_produkcja.ToList();
            cbZamowienie.ValueMember = "ID";
            cbZamowienie.DisplayMember = "Klient";
        }
        private void dgvvKontrolaJakosciKolejka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwa.Text = this.dgvvKontrolaJakosciKolejka.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            dgvvParametrPolprodukt.DataSource = 0;
            if (dgvvKontrolaJakosciKolejka.DataSource != null)
            {
                int polproduktID = int.Parse(dgvvKontrolaJakosciKolejka.CurrentRow.Cells[1].Value.ToString());
                List<v_Parametry_polprodukt> parametrPolproduktList = db.v_Parametry_polprodukt.Where(a => a.ID_polprodukt == polproduktID).ToList();

                if (parametrPolproduktList.Count() > 0)
                {
                    dgvvParametrPolprodukt.DataSource = parametrPolproduktList;
                    dgvvParametrPolprodukt.Columns["ID_parametr_polprodukt"].Visible = false;
                    dgvvParametrPolprodukt.Columns["ID_polprodukt"].Visible = false;
                    this.dgvvParametrPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano półproduktu!");
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwa.Text) || String.IsNullOrEmpty(txtParametrPolprodukt.Text) || String.IsNullOrEmpty(cBPracownik.Text) || String.IsNullOrEmpty(cBRodzajKontrola.Text) || String.IsNullOrEmpty(txtWartosc.Text))
            {
                MessageBox.Show("Nie wypełniono formularza!");
            }
            else
            {
                Kontrola_jakosci_polprodukt kontrolaPolprodukt = new Kontrola_jakosci_polprodukt();
                kontrolaPolprodukt.ID_wytwarzanie = int.Parse(this.dgvvKontrolaJakosciKolejka.CurrentRow.Cells[0].Value.ToString());
                kontrolaPolprodukt.ID_pracownik = int.Parse(cBPracownik.SelectedValue.ToString());
                kontrolaPolprodukt.ID_rodzaj_kontrola = int.Parse(cBRodzajKontrola.SelectedValue.ToString());
                kontrolaPolprodukt.Data_od = dTPDataOd.Value.Date + dTPCzasOd.Value.TimeOfDay;
                kontrolaPolprodukt.Data_do = dTPDataDo.Value.Date + dTPCzasDo.Value.TimeOfDay;
                kontrolaPolprodukt.Uwagi = txtUwagi.Text;
                db.Kontrola_jakosci_polprodukt.Add(kontrolaPolprodukt);
                db.SaveChanges();

                this.db = new Firma_produkcyjnaEntities();

                Kontrola_parametr_polprodukt kontrolaParametrPolprodukt = new Kontrola_parametr_polprodukt();
                int numRows = dgvvKontrolaPolprodukt.Rows.Count;
                kontrolaParametrPolprodukt.ID_kontrola_jakosci_polprodukt = int.Parse(this.dgvvKontrolaPolprodukt.Rows[numRows - 1].Cells[0].Value.ToString()) + 1;
                kontrolaParametrPolprodukt.ID_parametr_polprodukt = int.Parse(this.dgvvParametrPolprodukt.CurrentRow.Cells[0].Value.ToString());
                kontrolaParametrPolprodukt.Wartosc = decimal.Parse(txtWartosc.Text);
                db.Kontrola_parametr_polprodukt.Add(kontrolaParametrPolprodukt);
                db.SaveChanges();
                MessageBox.Show("Poprawnie zarejestrowano kontrolę jakości.");
                refreshScreen();
            }
            refreshScreen();
            txtParametrPolprodukt.Text = "";
            txtWartosc.Text = "";
        }

        public double NextDouble(Random rand, double minValue, double maxValue)
        {
            return rand.NextDouble() * (maxValue - minValue) + minValue;
        }

        private void btnRezultat_Click(object sender, EventArgs e)
        {
            initDataGridViewRezultatKontroli();
        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            int iloscPolproduktowKontrola = 0;
            if (dgvvKontrolaJakosciKolejka.DataSource == null)
            {
                MessageBox.Show("Nie wypełniono formularza!");
            }
            else
            {
                int iloscPolproduktowKolejka = 0;
                int startIndex = 0;

                if (String.IsNullOrEmpty(txtKontrolaIlosc.Text))
                {
                    iloscPolproduktowKolejka = int.Parse(dgvvKontrolaJakosciKolejka.RowCount.ToString());
                }
                else
                {
                    startIndex = int.Parse(dgvvKontrolaJakosciKolejka.RowCount.ToString()) - int.Parse(txtKontrolaIlosc.Text);
                    iloscPolproduktowKolejka = int.Parse(dgvvKontrolaJakosciKolejka.RowCount.ToString());
                }

                for (int i = startIndex; i < iloscPolproduktowKolejka; i++)
                {
                    int currentIdPolprodukt = int.Parse(dgvvKontrolaJakosciKolejka.Rows[i].Cells[1].Value.ToString());
                    List<v_Parametry_polprodukt> parametryPolprodukt = db.v_Parametry_polprodukt.Where(a => a.ID_polprodukt == currentIdPolprodukt).ToList();
                    dgvvParametrPolprodukt.DataSource = parametryPolprodukt;
                    dgvvParametrPolprodukt.Columns["ID_parametr_polprodukt"].Visible = false;
                    dgvvParametrPolprodukt.Columns["ID_polprodukt"].Visible = false;
                    this.dgvvParametrPolprodukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                    int iloscParametrow = int.Parse(dgvvParametrPolprodukt.RowCount.ToString());
                    iloscPolproduktowKontrola++;

                    for (int j = 0; j <= iloscParametrow - 1; j++)
                    {
                        Kontrola_jakosci_polprodukt kontrolaPolprodukt = new Kontrola_jakosci_polprodukt();
                        kontrolaPolprodukt.ID_wytwarzanie = int.Parse(this.dgvvKontrolaJakosciKolejka.Rows[i].Cells[0].Value.ToString());
                        kontrolaPolprodukt.ID_pracownik = int.Parse(cBPracownik.SelectedValue.ToString());
                        kontrolaPolprodukt.ID_rodzaj_kontrola = int.Parse(cBRodzajKontrola.SelectedValue.ToString());
                        kontrolaPolprodukt.Data_od = dTPDataOd.Value.Date + dTPCzasOd.Value.TimeOfDay;
                        kontrolaPolprodukt.Data_do = dTPDataDo.Value.Date + dTPCzasDo.Value.TimeOfDay;
                        kontrolaPolprodukt.Uwagi = txtUwagi.Text;
                        db.Kontrola_jakosci_polprodukt.Add(kontrolaPolprodukt);
                        db.SaveChanges();

                        this.db = new Firma_produkcyjnaEntities();

                        Kontrola_parametr_polprodukt kontrolaParametrPolprodukt = new Kontrola_parametr_polprodukt();
                        int numRows = dgvvKontrolaPolprodukt.Rows.Count;
                        kontrolaParametrPolprodukt.ID_kontrola_jakosci_polprodukt = int.Parse(this.dgvvKontrolaPolprodukt.Rows[numRows - 1].Cells[0].Value.ToString()) + 1;
                        kontrolaParametrPolprodukt.ID_parametr_polprodukt = int.Parse(this.dgvvParametrPolprodukt.Rows[j].Cells[0].Value.ToString());


                        Random rand = new Random();
                        double dolnyPrzedział = double.Parse(this.dgvvParametrPolprodukt.Rows[j].Cells[4].Value.ToString());
                        double gornyPrzedzial = double.Parse(this.dgvvParametrPolprodukt.Rows[j].Cells[5].Value.ToString());
                        decimal wartosc = Convert.ToDecimal(NextDouble(rand, dolnyPrzedział, gornyPrzedzial));

                        kontrolaParametrPolprodukt.Wartosc = wartosc;
                        db.Kontrola_parametr_polprodukt.Add(kontrolaParametrPolprodukt);
                        db.SaveChanges();
                    }
                    refreshScreen();
                }
                initDataGridViewRezultatKontroli();
                MessageBox.Show("Przeprowadzono kontrolę dla " + iloscPolproduktowKontrola + " półproduktów.");
            }
        }

        private void btnWczytajZamowienie_Click(object sender, EventArgs e)
        {
            initDataGridViewWytworzonePolproduktyZamowienie();
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
                    string polprodukt = this.dgvRezultatKontroli.CurrentRow.Cells[1].Value.ToString();
                    int ilosc = int.Parse(this.dgvRezultatKontroli.CurrentRow.Cells[2].Value.ToString());
                    int alertCountBefore = this.db.Alert.ToList().Count;
                    FormDodajAlert addAlert = new FormDodajAlert(db, polprodukt, ilosc);
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
                string polprodukt = this.dgvRezultatKontroli.CurrentRow.Cells[1].Value.ToString();
                int ilosc = int.Parse(this.dgvRezultatKontroli.CurrentRow.Cells[2].Value.ToString());
                int alertCountBefore = this.db.Alert.ToList().Count;
                FormDodajAlert addAlert = new FormDodajAlert(db, polprodukt, ilosc);
                addAlert.ShowDialog();
                int alertCountAfter = this.db.Alert.ToList().Count;
                if (alertCountBefore >= alertCountAfter)
                {
                    MessageBox.Show("Nie dodano alarmu!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
