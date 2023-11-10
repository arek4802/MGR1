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
    public partial class FormZamowienieSzczegol : Form
    {
        Firma_produkcyjnaEntities db;
        public FormZamowienieSzczegol(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            RefreshScreen();
        }

        private void comboBoxZamowienie()
        {
            cBZamowienie.DataSource = this.db.Zamowienie.ToList();
            cBZamowienie.ValueMember = "ID_zamowienie";
            cBZamowienie.DisplayMember = "ID_zamowienie";
        }
        private void comboBoxPojazd()
        {
            cBPojazd.DataSource = this.db.Pojazd.ToList();
            cBPojazd.ValueMember = "ID_pojazd";
            cBPojazd.DisplayMember = "Nr_VIN";
        }
        private void comboBoxGwarancja()
        {
            cBGwarancja.DataSource = this.db.Gwarancja.ToList();
            cBGwarancja.ValueMember = "ID_gwarancja";
            cBGwarancja.DisplayMember = "Opis_gwarancja";
        }
        private void initDataGridViewZamowienie()
        {
            dgvSzczegol.DataSource = db.v_Zamowienie_szczegol_pojazd.ToList();
            this.dgvSzczegol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSzczegol.Columns["ID_zamowienie_szczegol_pojazd"].Visible = false;
            dgvSzczegol.Columns["ID_gwarancja"].Visible = false;
            this.dgvSzczegol.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void RefreshScreen()
        {
            comboBoxGwarancja();
            comboBoxPojazd();
            comboBoxZamowienie();
            initDataGridViewZamowienie();
            txtKoszt.Text = "0";
        }


        private void btnSzczegolyZamowienie_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cBGwarancja.Text) || String.IsNullOrEmpty(cBPojazd.Text) || String.IsNullOrEmpty(cBZamowienie.Text) || String.IsNullOrEmpty(txtIlosc.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Zamowienie_szczegol_pojazd zamowieniePojazd = new Zamowienie_szczegol_pojazd();
                zamowieniePojazd.ID_zamowienie = int.Parse(cBZamowienie.SelectedValue.ToString());
                zamowieniePojazd.ID_pojazd = int.Parse(cBPojazd.SelectedValue.ToString());
                zamowieniePojazd.ID_gwarancja = int.Parse(cBGwarancja.SelectedValue.ToString());
                zamowieniePojazd.Ilosc = int.Parse(txtIlosc.Text);
                zamowieniePojazd.Koszt = int.Parse(txtKoszt.Text);
                db.Zamowienie_szczegol_pojazd.Add(zamowieniePojazd);
                db.SaveChanges();
                RefreshScreen();
                MessageBox.Show("Poprawnie dodano " + zamowieniePojazd.ID_zamowienie_szczegol_pojazd + " do bazy danych");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormZamowienieProdukt formZamowienieProdukt = new FormZamowienieProdukt(db);
            formZamowienieProdukt.ShowDialog();
        }

        private void dgvSzczegol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cBZamowienie.Text = this.dgvSzczegol.CurrentRow.Cells[1].Value.ToString();
            cBPojazd.Text = this.dgvSzczegol.CurrentRow.Cells[2].Value.ToString();
            cBGwarancja.Text = this.dgvSzczegol.CurrentRow.Cells[5].Value.ToString();
            txtIlosc.Text = this.dgvSzczegol.CurrentRow.Cells[3].Value.ToString();
            txtKoszt.Text = this.dgvSzczegol.CurrentRow.Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtKoszt.Text = db.v_Zamowienie_szczegol_produkt_koszta.ToString();

            string pojazd = cBPojazd.SelectedValue.ToString();
            int pojazdID = int.Parse(pojazd);
            List<v_Zamowienie_szczegol_produkt_koszta> vOrderId = db.v_Zamowienie_szczegol_produkt_koszta.Where(a => a.ID_pojazd == pojazdID).ToList();
            int vOrderIdInt = vOrderId.Count();
            dgvKoszta.DataSource = vOrderId;
            dgvKoszta.Columns["ID_pojazd"].Visible = false;
            this.dgvKoszta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            int suma = int.Parse(this.dgvKoszta.CurrentRow.Cells[1].Value.ToString()) + 150000;
            txtKoszt.Text = suma.ToString();
            //DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zaktualizować dane zamówenia: " + pojazd, "Question", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
                
            //}



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zamowienie_szczegol_pojazd zamowieniePojazd = new Zamowienie_szczegol_pojazd();
            zamowieniePojazd.ID_zamowienie = int.Parse(cBZamowienie.SelectedValue.ToString());
            zamowieniePojazd.ID_pojazd = int.Parse(cBPojazd.SelectedValue.ToString());
            zamowieniePojazd.ID_gwarancja = int.Parse(cBGwarancja.SelectedValue.ToString());
            zamowieniePojazd.Ilosc = int.Parse(txtIlosc.Text);
            zamowieniePojazd.Koszt = int.Parse(txtKoszt.Text);
            db.Zamowienie_szczegol_pojazd.Add(zamowieniePojazd);
            db.SaveChanges();
            RefreshScreen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int current_szczegol = int.Parse(this.dgvSzczegol.CurrentRow.Cells[0].Value.ToString());
            Zamowienie_szczegol_pojazd result8 = db.Zamowienie_szczegol_pojazd.SingleOrDefault(szczegol => szczegol.ID_zamowienie_szczegol_pojazd == current_szczegol);
            db.Zamowienie_szczegol_pojazd.Remove(result8);            ;
            db.SaveChanges();
            RefreshScreen();
        }
    }
}
