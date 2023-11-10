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
    public partial class FormDodajJednostka : Form
    {
        Firma_produkcyjnaEntities db;
        public FormDodajJednostka(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnDodajJednostka_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNazwaJednostka.Text) || String.IsNullOrEmpty(txtSkrot.Text))
            {
                MessageBox.Show("Wprowadź dane!");
            }
            else
            {
                Jednostka dodajJednostka = new Jednostka();
                dodajJednostka.Nazwa_jednostka = txtNazwaJednostka.Text;
                dodajJednostka.Skrot = txtSkrot.Text;
                db.Jednostka.Add(dodajJednostka);
                db.SaveChanges();
                MessageBox.Show("Poprawnie dodano jednostkę " + txtNazwaJednostka.Text);
                this.Close();
            }
        }
    }
}
