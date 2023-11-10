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
    public partial class FormTyp : Form
    {
        Firma_produkcyjnaEntities db;
        public FormTyp(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            initRefreshScreen();
        }       

        private void initDataGridViewTyp()
        {
            dgvTyp.DataSource = db.Typ_pojazd_slownik.ToList();
            dgvTyp.Columns["ID_typ_pojazd"].Visible = false;
            dgvTyp.Columns["Typ_pojazd_model"].Visible = false;
            dgvTyp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initRefreshScreen()
        {
            initDataGridViewTyp();
            txtNazwaTyp.Text = "";
        }
             

        private void dgvTyp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwaTyp.Text = this.dgvTyp.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaTyp.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Typ_pojazd_slownik typ_Pojazd_Slownik = new Typ_pojazd_slownik();
                typ_Pojazd_Slownik.Nazwa_typ = txtNazwaTyp.Text;
                db.Typ_pojazd_slownik.Add(typ_Pojazd_Slownik);
                db.SaveChanges();
                initRefreshScreen();
                MessageBox.Show("Poprawnie dodano " + typ_Pojazd_Slownik.Nazwa_typ + " do bazy danych");
            }
        }

        private void btnAktualizuj_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaTyp.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                this.dgvTyp.CurrentRow.Cells[1].Value = txtNazwaTyp.Text;
                db.SaveChanges();
                initRefreshScreen();
            }
        }

        private void btnUsun_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaTyp.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć produkt: " + this.dgvTyp.CurrentRow.Cells[1].Value, "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string current_typ = this.dgvTyp.CurrentRow.Cells[1].Value.ToString();
                    db.Typ_pojazd_slownik.Remove(db.Typ_pojazd_slownik.Where(typ => typ.Nazwa_typ == current_typ).First());
                    db.SaveChanges();
                    initRefreshScreen();
                }
            }
        }
    }
    
}
