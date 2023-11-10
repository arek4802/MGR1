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
    public partial class FormZamowienieProduktSzczegol : Form
    {
        Firma_produkcyjnaEntities db;
        public FormZamowienieProduktSzczegol(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            RefreshScreen();
        }

        private void comboBoxZamowienieProdukt()
        {
            cBZamowienie.DataSource = this.db.Zamowienie_produkt.ToList();
            cBZamowienie.ValueMember = "ID_zamowienie_produkt";
            cBZamowienie.DisplayMember = "ID_zamowienie_produkt";
        }
        private void comboBoxProdukt()
        {
            cBProdukt.DataSource = this.db.Produkt.ToList();
            cBProdukt.ValueMember = "ID_produkt";
            cBProdukt.DisplayMember = "Nazwa_produkt";
        }
        
        private void initDataGridViewZamowienie()
        {
            dgvSzczegol.DataSource = db.v_Zamowienie_szczegol_produkt.ToList();
            this.dgvSzczegol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSzczegol.Columns["ID_szczegoly_zamowienie_produkt"].Visible = false;            
            this.dgvSzczegol.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void RefreshScreen()
        {
            comboBoxProdukt();
            comboBoxZamowienieProdukt();            
            initDataGridViewZamowienie();
        }

        private void btnSzczegolyZamowienie_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cBProdukt.Text) || String.IsNullOrEmpty(cBZamowienie.Text) || String.IsNullOrEmpty(txtCena.Text) || String.IsNullOrEmpty(txtIlosc.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {

                Szczegoly_zamowienie_produkt zamowienieProdukt = new Szczegoly_zamowienie_produkt();
                zamowienieProdukt.ID_zamowienie_produkt = int.Parse(cBZamowienie.SelectedValue.ToString());
                zamowienieProdukt.ID_produkt = int.Parse(cBProdukt.SelectedValue.ToString());
                zamowienieProdukt.Cena = int.Parse(txtCena.Text);
                zamowienieProdukt.Ilosc = int.Parse(txtIlosc.Text);
                db.Szczegoly_zamowienie_produkt.Add(zamowienieProdukt);
                db.SaveChanges();
                RefreshScreen();
                MessageBox.Show("Poprawnie dodano " + zamowienieProdukt.ID_szczegoly_zamowienie_produkt + " do bazy danych");
            }
        }
    }
}
