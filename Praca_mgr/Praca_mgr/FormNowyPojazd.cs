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
    public partial class FormNowyPojazd : Form
    {
        Firma_produkcyjnaEntities db;
        public FormNowyPojazd(Firma_produkcyjnaEntities db)
        {
            this.db = db;
            InitializeComponent();
            refreshScreen();        
        }

        private void refreshScreen()
        {            
            txtModel.Text = "";
            txtVIN.Text = "";
            txtRokProdukcji.Text = "";
            txtWyposazenie.Text = "";
            initDataGridViewPojazdyModel();
            initDataGridViewMarkaModel();
            initDataGridViewWyposazenie();
            initDataGridViewSpis();
        }      

        private void initDataGridViewPojazdyModel()
        {
            dgvPojazdyModel.DataSource = db.v_Pojazdy_modele.ToList();
            this.dgvPojazdyModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPojazdyModel.Columns["ID_pojazd"].Visible = false;
            dgvPojazdyModel.Columns["ID_marka_model"].Visible = false;
            dgvPojazdyModel.Columns["ID_marka_model_pojazd"].Visible = false;
            dgvPojazdyModel.Columns["ID_typ_pojazd_model"].Visible = false;
            dgvPojazdyModel.Columns["ID_wersja_wyposazenia"].Visible = false;
            dgvPojazdyModel.Columns["Nazwa"].Visible = false;
            dgvPojazdyModel.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewMarkaModel()
        {
            dgvMarkaModel.DataSource = db.v_Wybor_silnika2.ToList();
            this.dgvMarkaModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarkaModel.Columns["ID_marka_model"].Visible = false;
            dgvMarkaModel.Columns["ID_typ_pojazd"].Visible = false;
            dgvMarkaModel.Columns["MM"].Visible = false;
            dgvMarkaModel.Columns["Nazwa_typ"].Visible = false;
            dgvMarkaModel.Columns["ID_typ_pojazd_model"].Visible = false;            
            this.dgvMarkaModel.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initDataGridViewWyposazenie()
        {
            dgvWyposazenie.DataSource = db.Wersja_wyposazenia_slownik.ToList();
            this.dgvWyposazenie.AutoSizeColumnsMode=System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvWyposazenie.Columns["ID_wersja_wyposazenia"].Visible = false;
            dgvWyposazenie.Columns["Wersja_wyposazenia_pojazd"].Visible = false;
            dgvWyposazenie.Columns["Wersja_wyposazenia_produkt"].Visible = false;
            this.dgvWyposazenie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void initDataGridViewSpis()
        {
            dgvSpis.DataSource = db.v_Wersja_wyposazenia_pojazd_spis.ToList();
            this.dgvSpis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSpis.Columns["ID_pojazd"].Visible = false;
            this.dgvSpis.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

            private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtModel.Text) || String.IsNullOrEmpty(txtVIN.Text) || String.IsNullOrEmpty(txtRokProdukcji.Text) || String.IsNullOrEmpty(txtWyposazenie.Text))
            {
                MessageBox.Show("Nie wypełniono formularza!");
            }
            else
            {
                Pojazd pojazd = new Pojazd();
                pojazd.Nr_VIN = txtVIN.Text;
                pojazd.Rok_produkcji = int.Parse(txtRokProdukcji.Text);
                db.Pojazd.Add(pojazd);
                db.SaveChanges();

                Marka_model_pojazd marka_Model_Pojazd = new Marka_model_pojazd();
                marka_Model_Pojazd.ID_pojazd = pojazd.ID_pojazd;
                marka_Model_Pojazd.ID_typ_pojazd_model = int.Parse(dgvMarkaModel.CurrentRow.Cells[5].Value.ToString());
                int numRows = dgvMarkaModel.Rows.Count;
                db.Marka_model_pojazd.Add(marka_Model_Pojazd);
                db.SaveChanges();

                Wersja_wyposazenia_pojazd wersja_Wyposazenia_Pojazd = new Wersja_wyposazenia_pojazd();
                wersja_Wyposazenia_Pojazd.ID_pojazd = pojazd.ID_pojazd;
                wersja_Wyposazenia_Pojazd.ID_wersja_wyposazenia = int.Parse(this.dgvWyposazenie.CurrentRow.Cells[0].Value.ToString());
                int numRows1 = dgvMarkaModel.Rows.Count;
                db.Wersja_wyposazenia_pojazd.Add(wersja_Wyposazenia_Pojazd);
                db.SaveChanges();
                MessageBox.Show("Poprawnie dodano.");
                refreshScreen();

                DialogResult dialogResult = MessageBox.Show("Czy chcesz dodać nowe czynności montażowe dla: " + pojazd.Nr_VIN, "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    FormPojazdCzynnosc formPojazdCzynnosc = new FormPojazdCzynnosc(db);
                    formPojazdCzynnosc.ShowDialog();
                }

                DialogResult dialogResult1 = MessageBox.Show("Czy chcesz dodać nowe zamówienie na " + pojazd.Nr_VIN, "Question", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    FormZamowienie formZamowienie = new FormZamowienie(db);
                    formZamowienie.ShowDialog();
                }

            }
            
        }

        private void dgvMarkaModel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtModel.Text = this.dgvMarkaModel.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvPojazdyModel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtModel.Text = this.dgvPojazdyModel.CurrentRow.Cells[4].Value.ToString();
            txtVIN.Text = this.dgvPojazdyModel.CurrentRow.Cells[1].Value.ToString();
            txtRokProdukcji.Text = this.dgvPojazdyModel.CurrentRow.Cells[2].Value.ToString();
            txtWyposazenie.Text = this.dgvPojazdyModel.CurrentRow.Cells[7].Value.ToString();
            initDataGridViewPojazdyModel();
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtModel.Text) || String.IsNullOrEmpty(txtVIN.Text) || String.IsNullOrEmpty(txtRokProdukcji.Text) || String.IsNullOrEmpty(txtWyposazenie.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int currentID = int.Parse(dgvPojazdyModel.CurrentRow.Cells[0].Value.ToString());
                int newRokProdukcji = int.Parse(txtRokProdukcji.Text);
                string newVIN = txtVIN.Text;
                int newModel = int.Parse(dgvMarkaModel.CurrentRow.Cells[5].Value.ToString());
                int newWersja = int.Parse(this.dgvWyposazenie.CurrentRow.Cells[0].Value.ToString());
                Pojazd result = db.Pojazd.SingleOrDefault(b => b.ID_pojazd == currentID);
                Marka_model_pojazd result1 = db.Marka_model_pojazd.SingleOrDefault(b => b.ID_pojazd == currentID);
                Wersja_wyposazenia_pojazd result2 = db.Wersja_wyposazenia_pojazd.SingleOrDefault(b => b.ID_pojazd == currentID);
                if (result != null || result1 != null || result2 !=null )
                {
                    result.Nr_VIN = newVIN;
                    result.Rok_produkcji = newRokProdukcji;
                    result1.ID_typ_pojazd_model = newModel;
                    result2.ID_wersja_wyposazenia = newWersja;
                    db.SaveChanges();
                }
                MessageBox.Show("Poprawnie zaktualizowano.");
                refreshScreen();
            }
        }

        private void dgvWyposazenie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWyposazenie.Text = this.dgvWyposazenie.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtModel.Text) || String.IsNullOrEmpty(txtVIN.Text) || String.IsNullOrEmpty(txtRokProdukcji.Text) || String.IsNullOrEmpty(txtWyposazenie.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć pojazd: " + this.dgvPojazdyModel.CurrentRow.Cells[1].Value, "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    int current_pojazd = int.Parse(this.dgvPojazdyModel.CurrentRow.Cells[0].Value.ToString());
                    Marka_model_pojazd result3 = db.Marka_model_pojazd.SingleOrDefault(pojazd => pojazd.ID_pojazd == current_pojazd);
                    Wersja_wyposazenia_pojazd result4 = db.Wersja_wyposazenia_pojazd.SingleOrDefault(pojazd => pojazd.ID_pojazd == current_pojazd);
                    db.Pojazd.Remove(db.Pojazd.Where(pojazd => pojazd.ID_pojazd == current_pojazd).First());
                    db.Marka_model_pojazd.Remove(result3);
                    db.Wersja_wyposazenia_pojazd.Remove(result4);                    
                    db.SaveChanges();
                    refreshScreen();
                }
            }
        }

        private void btnSearchVin_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (tbVinSearch.Text.Length > 0)
                choose = "VinNumber";
            switch (choose)
            {
                case "VinNumber":
                    searchVinNumber();
                    break;
            }
        }

        private void searchVinNumber()
        {
            try
            {
                List<v_Pojazdy_modele> searchVIN = db.v_Pojazdy_modele.Where(a => a.Nr_VIN == tbVinSearch.Text).ToList();
                if (searchVIN.Count() > 0)
                {
                    this.dgvPojazdyModel.DataSource = searchVIN;
                }
                else
                {
                    MessageBox.Show("Brak auta o takim numerze VIN!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru VIN!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshVin_Click(object sender, EventArgs e)
        {
            initDataGridViewPojazdyModel();
        }

        private void btnDodajMarkaModel_Click(object sender, EventArgs e)
        {
            FormWyposazenie formWyposazenie = new FormWyposazenie(db);
            formWyposazenie.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormZamowienie formZamowienie = new FormZamowienie(db);
            formZamowienie.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPojazdCzynnosc formPojazdCzynnosc = new FormPojazdCzynnosc(db);
            formPojazdCzynnosc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMarkaModel formMarkaModel = new FormMarkaModel(db);
            formMarkaModel.ShowDialog();
        }
    }
}
