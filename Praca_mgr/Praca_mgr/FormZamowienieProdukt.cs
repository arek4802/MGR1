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
    public partial class FormZamowienieProdukt : Form
    {
        Firma_produkcyjnaEntities db;
        public FormZamowienieProdukt(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            RefreshScreen();
        }

        private void comboBoxDostawca()
        {
            cBDostawca.DataSource = this.db.Dostawca.ToList();
            cBDostawca.ValueMember = "ID_dostawca";
            cBDostawca.DisplayMember = "Nazwa_dostawca";
        }
        private void comboBoxPracownik()
        {
            cBPracownik.DataSource = this.db.v_Pracownik.ToList();
            cBPracownik.ValueMember = "ID";
            cBPracownik.DisplayMember = "Nr_dowodu";
        }
        private void comboBoxPojazd()
        {
            cBPojazd.DataSource = this.db.Zamowienie_szczegol_pojazd.ToList();
            cBPojazd.ValueMember = "ID_zamowienie_szczegol_pojazd";
            cBPojazd.DisplayMember = "ID_zamowienie_szczegol_pojazd";
        }
        private void initDataGridViewZamowienie()
        {
            dgvZamowienie.DataSource = db.v_Zamowienie_produkt.ToList();
            this.dgvZamowienie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvZamowienie.Columns["ID_zamowienie_produkt"].Visible = false;    
            this.dgvZamowienie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void RefreshScreen()
        {
            comboBoxDostawca();
            comboBoxPracownik();
            comboBoxPojazd();
            initDataGridViewZamowienie();
        }

        private void btnSzczegolyZamowienie_Click_1(object sender, EventArgs e)
        {
            FormZamowienieProduktSzczegol formZamowienieProduktSzczegol = new FormZamowienieProduktSzczegol(db);
            formZamowienieProduktSzczegol.ShowDialog();
        }

        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cBDostawca.Text) || String.IsNullOrEmpty(cBPracownik.Text) || String.IsNullOrEmpty(cBPojazd.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Zamowienie_produkt zamowienie = new Zamowienie_produkt();
                zamowienie.ID_dostawca = int.Parse(cBDostawca.SelectedValue.ToString());
                zamowienie.ID_pracownik = int.Parse(cBPracownik.SelectedValue.ToString());
                zamowienie.Data_zamowienia = dtpZamowienie.Value.Date;
                zamowienie.ID_zamowienie_szczegol_pojazd = int.Parse(cBPojazd.SelectedValue.ToString());
                db.Zamowienie_produkt.Add(zamowienie);
                db.SaveChanges();
                RefreshScreen();
                MessageBox.Show("Poprawnie dodano " + zamowienie.Data_zamowienia + " do bazy danych");

                DialogResult dialogResult1 = MessageBox.Show("Czy chcesz dodać nowe szczegóły zamowienia?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    FormZamowienieProduktSzczegol formZamowienieProduktSzczegol = new FormZamowienieProduktSzczegol(db);
                    formZamowienieProduktSzczegol.ShowDialog();
                }
            }
        }
    }
}
