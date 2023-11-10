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
    public partial class Start : Form
    {
        Firma_produkcyjnaEntities db = new Firma_produkcyjnaEntities();
        public Start()
        {
            InitializeComponent();            
        }

        private void btnProdukty_Click(object sender, EventArgs e)
        {
            FormProdukt produktFrom = new FormProdukt(db);
            produktFrom.ShowDialog();
        }

        private void btnPolprodukt_Click(object sender, EventArgs e)
        {
            FormSkladProdukt polproduktForm = new FormSkladProdukt(db);
            polproduktForm.ShowDialog();
        }

        private void btnStanowiskaProd_Click(object sender, EventArgs e)
        {
            FormSlownikStanowisko slownikStanowiskoForm = new FormSlownikStanowisko(db);
            slownikStanowiskoForm.ShowDialog();
        }

        private void btnWytwarzanie_Click(object sender, EventArgs e)
        {
            FormWytwarzanie wytwarzanieForm = new FormWytwarzanie(db);
            wytwarzanieForm.ShowDialog();
        }

        private void btnKontrola_Click(object sender, EventArgs e)
        {
            FormKontrolaJakosciProdukt kontrolaJakosciProduktForm = new FormKontrolaJakosciProdukt(db);
            kontrolaJakosciProduktForm.ShowDialog();
        }

        private void btnKontrolaPol_Click(object sender, EventArgs e)
        {
            FormKontrolaJakosciPolprodukt kontrolaJakosciPolproduktForm = new FormKontrolaJakosciPolprodukt(db);
            kontrolaJakosciPolproduktForm.ShowDialog();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            FormNowyPojazd nowyPojazdForm = new FormNowyPojazd(db);
            nowyPojazdForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMarka markaForm = new FormMarka(db);
            markaForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSzeregowanie szeregowanieForm = new FormSzeregowanie(db);
            szeregowanieForm.ShowDialog();
        }

        private void btnKontrolaPojazd_Click(object sender, EventArgs e)
        {
            FormKontrolaPojazd formKontrolaPojazd = new FormKontrolaPojazd(db);
            formKontrolaPojazd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMontaz formMontaz = new FormMontaz(db);
            formMontaz.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAlerty formAlerty = new FormAlerty(db);
            formAlerty.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMagazynPojazd formMagazynPojazd = new FormMagazynPojazd(db);
            formMagazynPojazd.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormKlient formKlient = new FormKlient(db);
            formKlient.ShowDialog();
        }
    }
}
