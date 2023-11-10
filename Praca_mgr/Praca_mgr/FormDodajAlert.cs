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
    public partial class FormDodajAlert : Form
    {
        Firma_produkcyjnaEntities db;
        string requiredMaterial;
        string amount;
        string wytworzonyProdukt;
        string wytworzonyPojazd;

        int iloscProduktu;
        public FormDodajAlert(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            cmbDzial.DataSource = db.Dzial.ToList();
            cmbDzial.DisplayMember = "Nazwa_dzial";
            cmbDzial.ValueMember = "ID_dzial";
        }
        public FormDodajAlert(Firma_produkcyjnaEntities db, string material, string ilosc)
        {
            InitializeComponent();
            this.db = db;
            cmbDzial.DataSource = db.Dzial.ToList();
            cmbDzial.DisplayMember = "Nazwa_dzial";
            cmbDzial.ValueMember = "ID_dzial";
            this.requiredMaterial = material;
            this.amount = ilosc;
            string textMessage = $"Brakujący materiał: {requiredMaterial}, w ilości: {amount}g.";
            cmbDzial.SelectedIndex = 3;
            txtTresc.Text = textMessage;
        }

        public FormDodajAlert(Firma_produkcyjnaEntities db, string produkt, int ilosc)
        {
            InitializeComponent();
            this.db = db;
            cmbDzial.DataSource = db.Dzial.ToList();
            cmbDzial.DisplayMember = "Nazwa_dzial";
            cmbDzial.ValueMember = "ID_dzial";
            this.wytworzonyProdukt = produkt;
            this.iloscProduktu = ilosc;
            string textMessage = $"Wytworzono: '{wytworzonyProdukt}', w ilości: {iloscProduktu} sztuk.";
            cmbDzial.SelectedIndex = 1;
            txtTresc.Text = textMessage;
        }
        public FormDodajAlert(Firma_produkcyjnaEntities db, string pojazd)
        {
            InitializeComponent();
            this.db = db;
            cmbDzial.DataSource = db.Dzial.ToList();
            cmbDzial.DisplayMember = "Nazwa_dzial";
            cmbDzial.ValueMember = "ID_dzial";
            this.wytworzonyPojazd = pojazd;
            string textMessage = $"Wytworzono: '{wytworzonyPojazd}'";
            cmbDzial.SelectedIndex = 2;
            txtTresc.Text = textMessage;
        }

        
        private void btnDodajAlert_Click_1(object sender, EventArgs e)
        {
            Alert dodajAlert = new Alert();
            dodajAlert.ID_dzial = (int)cmbDzial.SelectedValue;
            dodajAlert.Tresc = txtTresc.Text;
            dodajAlert.Czy_odczytano = Convert.ToBoolean(0);
            db.Alert.Add(dodajAlert);
            db.SaveChanges();
            MessageBox.Show("Dodano alert");
        }
    }
}
