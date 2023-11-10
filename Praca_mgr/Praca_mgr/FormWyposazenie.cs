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
    public partial class FormWyposazenie : Form
    {
        Firma_produkcyjnaEntities db;
        public FormWyposazenie(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            initRefreshScreen();
        }

        private void initDataGridViewWyposazenie()
        {
            dgvWyposazenie.DataSource = db.Wersja_wyposazenia_slownik.ToList();
            this.dgvWyposazenie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvWyposazenie.Columns["ID_wersja_wyposazenia"].Visible = false;
            dgvWyposazenie.Columns["Wersja_wyposazenia_pojazd"].Visible = false;
            dgvWyposazenie.Columns["Wersja_wyposazenia_produkt"].Visible = false;
            dgvWyposazenie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initRefreshScreen()
        {
            initDataGridViewWyposazenie();
            txtNazwaWyposazenie.Text = "";
        }


        private void dgvWyposazenie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwaWyposazenie.Text = this.dgvWyposazenie.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaWyposazenie.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Wersja_wyposazenia_slownik wersja_Wyposazenia_Slownik = new Wersja_wyposazenia_slownik();
                wersja_Wyposazenia_Slownik.Nazwa = txtNazwaWyposazenie.Text;
                db.Wersja_wyposazenia_slownik.Add(wersja_Wyposazenia_Slownik);
                db.SaveChanges();
                initRefreshScreen();
                MessageBox.Show("Poprawnie dodano " + wersja_Wyposazenia_Slownik.Nazwa + " do bazy danych");

                DialogResult dialogResult1 = MessageBox.Show("Czy chcesz określić z jakich produktów składa się wersja wyposażenia: " + wersja_Wyposazenia_Slownik.Nazwa, "Question", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    FormWyposazenieProdukt formWyposazenieProdukt = new FormWyposazenieProdukt(db);
                    formWyposazenieProdukt.ShowDialog();
                }
            }
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaWyposazenie.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                this.dgvWyposazenie.CurrentRow.Cells[1].Value = txtNazwaWyposazenie.Text;
                db.SaveChanges();
                initRefreshScreen();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaWyposazenie.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć produkt: " + this.dgvWyposazenie.CurrentRow.Cells[1].Value, "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string current_wyposazenie = this.dgvWyposazenie.CurrentRow.Cells[1].Value.ToString();
                    db.Wersja_wyposazenia_slownik.Remove(db.Wersja_wyposazenia_slownik.Where(wyposazenie => wyposazenie.Nazwa == current_wyposazenie).First());
                    db.SaveChanges();
                    initRefreshScreen();
                }
            }
        }

        private void btnDodajModel_Click(object sender, EventArgs e)
        {
            FormWyposazenieProdukt formWyposazenieProdukt = new FormWyposazenieProdukt(db);
            formWyposazenieProdukt.ShowDialog();
        }
    }
}
