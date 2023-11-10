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
    public partial class FormZamowienie : Form
    {
        Firma_produkcyjnaEntities db;
        public FormZamowienie(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            RefreshScreen();
        }

        private void comboBoxKlient()
        {
            cBKlient.DataSource = this.db.Klient.ToList();
            cBKlient.ValueMember = "ID_klient";
            cBKlient.DisplayMember = "Numer_telefonu";
        }
        private void comboBoxPracownik()
        {
            cBPracownik.DataSource = this.db.v_Pracownik.ToList();
            cBPracownik.ValueMember = "ID";
            cBPracownik.DisplayMember = "Nr_dowodu";
        }
        private void comboBoxTyp()
        {
            cBTyp.DataSource = this.db.Typ_zamowienie.ToList();
            cBTyp.ValueMember = "ID_typ_zamowienie";
            cBTyp.DisplayMember = "Rodzaj_zamowienie";
        }
        private void initDataGridViewZamowienie()
        {
            dgvZamowienie.DataSource = db.v_Zamowienie_pojazd.ToList();
            this.dgvZamowienie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvZamowienie.Columns["ID_zamowienie"].Visible = false;
            dgvZamowienie.Columns["ID_typ_zamowienie"].Visible = false;
            this.dgvZamowienie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void RefreshScreen()
        {
            comboBoxKlient();
            comboBoxPracownik(); 
            comboBoxTyp();
            initDataGridViewZamowienie();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cBKlient.Text) || String.IsNullOrEmpty(cBPracownik.Text) || String.IsNullOrEmpty(cBTyp.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Zamowienie zamowienie = new Zamowienie();
                zamowienie.ID_klient = int.Parse(cBKlient.SelectedValue.ToString());
                zamowienie.ID_pracownik = int.Parse(cBPracownik.SelectedValue.ToString());
                zamowienie.Data_zamowienie = dtpZamowienie.Value.Date;
                zamowienie.ID_typ_zamowienie = int.Parse(cBTyp.SelectedValue.ToString());
                db.Zamowienie.Add(zamowienie);
                db.SaveChanges();
                RefreshScreen();
                MessageBox.Show("Poprawnie dodano " + zamowienie.Data_zamowienie + " do bazy danych");
                DialogResult dialogResult1 = MessageBox.Show("Czy chcesz dodać nowe szczegóły zamówienia?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    FormZamowienieSzczegol formZamowienieSzczegol = new FormZamowienieSzczegol(db);
                    formZamowienieSzczegol.ShowDialog();
                }
            }
        }

        private void btnSzczegolyZamowienie_Click(object sender, EventArgs e)
        {
            FormZamowienieSzczegol formZamowienieSzczegol = new FormZamowienieSzczegol(db);
            formZamowienieSzczegol.ShowDialog();
        }
    }
}
