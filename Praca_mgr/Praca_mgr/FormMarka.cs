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
    public partial class FormMarka : Form
    {
        Firma_produkcyjnaEntities db;
        public FormMarka(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            initRefreshScreen();
        }

        private void initDataGridView()
        {
            dgvMarka.DataSource = db.Marka_pojazd_slownik.ToList();
            this.dgvMarka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;            
            dgvMarka.Columns["ID_marka_pojazd"].Visible = false;
            dgvMarka.Columns["Marka_model"].Visible = false;
            dgvMarka.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initRefreshScreen()
        {
            initDataGridView();
            txtNazwaMarka.Text = "";
        }

        private void dgvMarka_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNazwaMarka.Text = this.dgvMarka.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaMarka.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Marka_pojazd_slownik marka_Pojazd_Slownik = new Marka_pojazd_slownik();
                marka_Pojazd_Slownik.Nazwa = txtNazwaMarka.Text;
                db.Marka_pojazd_slownik.Add(marka_Pojazd_Slownik);
                db.SaveChanges();
                initRefreshScreen();
                MessageBox.Show("Poprawnie dodano " + marka_Pojazd_Slownik.Nazwa + " do bazy danych");

                DialogResult dialogResult1 = MessageBox.Show("Czy chcesz powiązać markę: " + marka_Pojazd_Slownik.Nazwa + "z modelem?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    FormMarkaModel formMarkaModel = new FormMarkaModel(db);
                    formMarkaModel.ShowDialog();
                }
            }
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaMarka.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                this.dgvMarka.CurrentRow.Cells[1].Value = txtNazwaMarka.Text;
                db.SaveChanges();
                initRefreshScreen();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaMarka.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć produkt: " + this.dgvMarka.CurrentRow.Cells[1].Value, "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string current_marka = this.dgvMarka.CurrentRow.Cells[1].Value.ToString();
                    db.Marka_pojazd_slownik.Remove(db.Marka_pojazd_slownik.Where(marka => marka.Nazwa == current_marka).First());
                    db.SaveChanges();
                    initRefreshScreen();
                }
            }
        }

        private void btnDodajMarkaModel_Click(object sender, EventArgs e)
        {
            FormMarkaModel formMarkaModel = new FormMarkaModel(db);
            formMarkaModel.ShowDialog();
        }

       
    }
    }
    

