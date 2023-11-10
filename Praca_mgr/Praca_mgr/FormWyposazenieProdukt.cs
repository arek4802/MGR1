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
    public partial class FormWyposazenieProdukt : Form
    {
        Firma_produkcyjnaEntities db;
        public FormWyposazenieProdukt(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            RefreshScreen();
        }

        private void RefreshScreen()
        {
            initDataGridViewProdukt();
            initDataGridViewWyposazenieProdukt();
            initDataGridViewWyposazenie();
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

        private void initDataGridViewProdukt()
        {
            dgvProdukt.DataSource = db.Produkt.ToList();
            this.dgvProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdukt.Columns["ID_produkt"].Visible = false;
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
            dgvProdukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewWyposazenieProdukt()
        {
            dgvWyposazenieProdukt.DataSource = db.v_Wersja_wyposazenia.ToList();
            this.dgvWyposazenieProdukt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            
            dgvWyposazenieProdukt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgvWyposazenie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWyposazenie.Text = this.dgvWyposazenie.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvProdukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProdukt.Text = this.dgvProdukt.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvWyposazenieProdukt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWyposazenie.Text = this.dgvWyposazenieProdukt.CurrentRow.Cells[1].Value.ToString();
            txtProdukt.Text = this.dgvWyposazenieProdukt.CurrentRow.Cells[2].Value.ToString();
            txtIlosc.Text = this.dgvWyposazenieProdukt.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDodajModel_Click(object sender, EventArgs e)
        {
            FormWyposazenie formWyposazenie = new FormWyposazenie(db);
            formWyposazenie.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtWyposazenie.Text) || String.IsNullOrEmpty(txtProdukt.Text) || String.IsNullOrEmpty(txtIlosc.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Wersja_wyposazenia_produkt wersja_Wyposazenia_Produkt = new Wersja_wyposazenia_produkt();
                wersja_Wyposazenia_Produkt.ID_wersja_wyposazenia = int.Parse(this.dgvWyposazenie.CurrentRow.Cells[0].Value.ToString());
                wersja_Wyposazenia_Produkt.ID_produkt = int.Parse(this.dgvProdukt.CurrentRow.Cells[0].Value.ToString());
                wersja_Wyposazenia_Produkt.Ilosc = int.Parse(txtIlosc.Text);
                db.Wersja_wyposazenia_produkt.Add(wersja_Wyposazenia_Produkt);
                db.SaveChanges();
                RefreshScreen();
                MessageBox.Show("Poprawnie dodano do bazy danych");
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtWyposazenie.Text) || String.IsNullOrEmpty(txtProdukt.Text) || String.IsNullOrEmpty(txtIlosc.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć: " + this.dgvWyposazenieProdukt.CurrentRow.Cells[1].Value.ToString() + " - " + this.dgvWyposazenieProdukt.CurrentRow.Cells[3].Value.ToString(), "Question", MessageBoxButtons.YesNo); ;
                if (dialogResult == DialogResult.Yes)
                {
                    int current_wyposazenieprodukt = int.Parse(this.dgvWyposazenieProdukt.CurrentRow.Cells[0].Value.ToString());
                    Wersja_wyposazenia_produkt result3 = db.Wersja_wyposazenia_produkt.SingleOrDefault(wyposazenieprodukt => wyposazenieprodukt.ID_wersja_wyposazenia_produkt == current_wyposazenieprodukt);
                    db.Wersja_wyposazenia_produkt.Remove(result3);
                    db.SaveChanges();
                    RefreshScreen();
                }
            }
        }
    }
}
