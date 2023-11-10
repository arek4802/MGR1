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
    public partial class FormPojazdCzynnosc : Form
    {
        Firma_produkcyjnaEntities db;
        public FormPojazdCzynnosc(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            RefreshScreen();
        }
        private void RefreshScreen()
        {
            comboBoxStanowisko();
            initDataGridViewPojazdy();
            initDataGridviewCzynnosci();
            initDaataGridViewPojazdCzynnosci();
        }
        private void comboBoxStanowisko()
        {
            cBStanowisko.DataSource = db.v_Stanowiska_produkcyjne.ToList();
            cBStanowisko.ValueMember = "ID_stanowisko_produkcyjne";
            cBStanowisko.DisplayMember = "Nazwa";
        }

        private void initDataGridViewPojazdy()
        {
            dgvPojazd.DataSource = db.v_Pojazdy_modele.ToList();
            this.dgvPojazd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPojazd.Columns["ID_pojazd"].Visible = false;
            dgvPojazd.Columns["ID_marka_model"].Visible = false;
            dgvPojazd.Columns["ID_marka_model_pojazd"].Visible = false;
            dgvPojazd.Columns["ID_typ_pojazd_model"].Visible = false;
            dgvPojazd.Columns["ID_wersja_wyposazenia"].Visible = false;
            dgvPojazd.Columns["Nazwa"].Visible = false;
            dgvPojazd.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void initDataGridviewCzynnosci()
        {
            dgvCzynnosc.DataSource = db.v_Czynnosc_produkcyjna.ToList();
            this.dgvCzynnosc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCzynnosc.Columns["ID_czynnosci"].Visible = false;
            dgvCzynnosc.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void initDaataGridViewPojazdCzynnosci()
        {
            dgvPojazdCzynnosc.DataSource = db.v_Proces_montaz.ToList();
            this.dgvPojazdCzynnosc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPojazdCzynnosc.Columns["ID"].Visible = false;
            dgvPojazdCzynnosc.Columns["ID_pojazd"].Visible = false;
            dgvPojazdCzynnosc.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewProdukty()
        {
            int pojazd = int.Parse(this.dgvPojazd.CurrentRow.Cells[0].Value.ToString());
            List<v_Wersja_wyposazenia_pojazd> wyposazenie = db.v_Wersja_wyposazenia_pojazd.Where(a => a.ID_pojazd == pojazd).ToList();
            dgvProdukty.DataSource = wyposazenie;

            this.dgvProdukty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdukty.Columns["ID_pojazd"].Visible = false;
            dgvProdukty.Columns["Nr_VIN"].Visible = false;
            dgvProdukty.Columns["Wersja_wyposażenia"].Visible = false;
            dgvProdukty.Columns["Ilosc"].Visible = false;
            dgvProdukty.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgvPojazd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtVin.Text = this.dgvPojazd.CurrentRow.Cells[1].Value.ToString();
            initDataGridViewProdukty();
        }

        private void dgvCzynnosc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCzynnosc.Text = this.dgvCzynnosc.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtVin.Text) || String.IsNullOrEmpty(txtCzynnosc.Text) || String.IsNullOrEmpty(txtCzas.Text))
            {
                MessageBox.Show("Nie wypełniono formularza!");
            }
            else
            {
                Proces_montaz_pojazd_czynnosc proces_Montaz_Pojazd_Czynnosc = new Proces_montaz_pojazd_czynnosc();

                proces_Montaz_Pojazd_Czynnosc.ID_pojazd = int.Parse(this.dgvPojazd.CurrentRow.Cells[0].Value.ToString());
                proces_Montaz_Pojazd_Czynnosc.ID_czynnosc_produkcyjna = int.Parse(this.dgvCzynnosc.CurrentRow.Cells[0].Value.ToString());
                proces_Montaz_Pojazd_Czynnosc.ID_stanowisko_produkcyjne = int.Parse(cBStanowisko.SelectedValue.ToString());
                proces_Montaz_Pojazd_Czynnosc.Czas_trwania = int.Parse(txtCzas.Text);
                db.Proces_montaz_pojazd_czynnosc.Add(proces_Montaz_Pojazd_Czynnosc);
                db.SaveChanges();
                RefreshScreen();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtVin.Text) || String.IsNullOrEmpty(txtCzynnosc.Text) || String.IsNullOrEmpty(txtCzas.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć: " + this.dgvPojazdCzynnosc.CurrentRow.Cells[1].Value.ToString() + " - " + this.dgvPojazdCzynnosc.CurrentRow.Cells[3].Value.ToString(), "Question", MessageBoxButtons.YesNo); ;
                if (dialogResult == DialogResult.Yes)
                {
                    int current_pojazdczynnosc = int.Parse(this.dgvPojazdCzynnosc.CurrentRow.Cells[0].Value.ToString());
                    Proces_montaz_pojazd_czynnosc result3 = db.Proces_montaz_pojazd_czynnosc.SingleOrDefault(modeltyp => modeltyp.ID_proces_montaz_pojazd_czynnosc == current_pojazdczynnosc);
                    db.Proces_montaz_pojazd_czynnosc.Remove(result3);
                    db.SaveChanges();
                    RefreshScreen();
                }
            }
        }
    }
}
