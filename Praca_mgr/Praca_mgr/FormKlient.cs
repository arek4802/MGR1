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
    public partial class FormKlient : Form
    {
        Firma_produkcyjnaEntities db;
        public FormKlient(Firma_produkcyjnaEntities db)
        {
            InitializeComponent();
            this.db = db;
            cleanTextBox();
            showData();
        }
        private void cleanTextBox()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxNIP.Clear();
            textBoxCity.Clear();
            textBoxBuildingNumber.Clear();
            textBoxApartmentNumber.Clear();
            textBoxPostCode.Clear();
            textBoxStreet.Clear();
            txtEmail.Clear();
            txtNumer.Clear();
        }
        private void messageBox(string searchItem)
        {
            MessageBox.Show($"{searchItem} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void msgCleanShowData(string searchItem)
        {
            messageBox(searchItem);
            cleanTextBox();
            showData();
        }
        private void showData()
        {
            this.db = new Firma_produkcyjnaEntities();
            this.dgvClient.DataSource = this.db.Klient.ToList();
            this.dgvClient.Columns["Zamowienie"].Visible = false;
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }           
        
        
        private void searchSurname()
        {
            List<Klient> searchClientSurnameList = db.Klient.Where(a => a.Nazwisko == textBoxSurname.Text).ToList();
            if (searchClientSurnameList.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientSurnameList;
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData($"Wyszukiwane nazwisko: {textBoxSurname.Text}");
            }
        }
        private void searchEmail()
        {
            List<Klient> searchClientEmailList = db.Klient.Where(a => a.Email == txtEmail.Text).ToList();
            if (searchClientEmailList.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientEmailList;
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData($"Wyszukiwany email : {txtEmail.Text}");
            }
        }
        private void searchNumer()
        {
            List<Klient> searchClientNumerList = db.Klient.Where(a => a.Numer_telefonu == txtNumer.Text).ToList();
            if (searchClientNumerList.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientNumerList;
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData($"Wyszukiwany numer telefonu : {txtNumer.Text}");
            }
        }
        private void searchName()
        {
            List<Klient> searchClientNameList = db.Klient.Where(a => a.Imie == textBoxName.Text).ToList();
            if (searchClientNameList.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientNameList;
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData($"Wyszukiwane imię: {textBoxName.Text}");
            }
        }
        private void searchNip()
        {
            List<Klient> searchClientNIPList = db.Klient.Where(a => a.NIP == textBoxNIP.Text).ToList();
            if (searchClientNIPList.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientNIPList;
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData($"Wyszukiwany NIP: {textBoxNIP.Text}");
            }
        }
        private void searchCity()
        {
            List<Klient> searchClientCityList = db.Klient.Where(a => a.Miejscowosc == textBoxCity.Text).ToList();
            if (searchClientCityList.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientCityList;
                this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData($"Wyszukiwana miejscowość: {textBoxCity.Text}");
            }
        }
        private void searchNoBuilding()
        {
            try
            {
                int noBuildingToInt = int.Parse(textBoxBuildingNumber.Text);
                List<Klient> searchClientNoBuildingList = db.Klient.Where(a => a.Nr_budynek == noBuildingToInt).ToList();
                if (searchClientNoBuildingList.Count() > 0)
                {
                    this.dgvClient.DataSource = searchClientNoBuildingList;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany nr budynku: {textBoxBuildingNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru budynku!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchNoApartment()
        {
            try
            {
                int noApartmentToInt = int.Parse(textBoxApartmentNumber.Text);
                List<Klient> searchClientNoApartmentList = db.Klient.Where(a => a.Nr_lokal == noApartmentToInt).ToList();
                if (searchClientNoApartmentList.Count() > 0)
                {
                    this.dgvClient.DataSource = searchClientNoApartmentList;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany nr lokalu: {textBoxApartmentNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru lokalu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchPostCode()
        {
            List<Klient> searchClientPostCodeList = db.Klient.Where(a => a.Kod_pocztowy == textBoxPostCode.Text).ToList();
            if (searchClientPostCodeList.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientPostCodeList;
                cleanTextBox();
            }
            else
            {
                msgCleanShowData($"Wyszukiwany kod pocztowy: {textBoxPostCode.Text}");
            }
        }
        private void searchStreet()
        {
            List<Klient> searchClientStreet = db.Klient.Where(a => a.Ulica == textBoxStreet.Text).ToList();
            if (searchClientStreet.Count() > 0)
            {
                this.dgvClient.DataSource = searchClientStreet;
            }
            else
            {
                msgCleanShowData($"Wyszukiwana ulica: {textBoxStreet.Text}");
            }
        }
        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showData();
        }

        private void FormSalesDepartmentClient_Activated(object sender, EventArgs e)
        {
            showData();
        }

        private void btnAddNewClient_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtNumer.Text) || String.IsNullOrEmpty(textBoxBuildingNumber.Text) || String.IsNullOrEmpty(textBoxCity.Text) || String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxPostCode.Text) || String.IsNullOrEmpty(textBoxSurname.Text))
            {
                MessageBox.Show("Nie wypełniono formularza!");
            }
            else
            {
                Klient klient = new Klient();
                klient.Nazwisko = textBoxSurname.Text;
                klient.Imie = textBoxName.Text;
                klient.NIP = textBoxNIP.Text;
                klient.Miejscowosc = textBoxCity.Text;
                klient.Ulica = textBoxStreet.Text;
                klient.Nr_lokal = int.Parse(textBoxApartmentNumber.Text);
                klient.Nr_budynek = int.Parse(textBoxBuildingNumber.Text);
                klient.Kod_pocztowy = textBoxPostCode.Text;
                klient.Numer_telefonu = txtNumer.Text;
                klient.Email = txtEmail.Text;
                db.Klient.Add(klient);
                db.SaveChanges();

                this.db = new Firma_produkcyjnaEntities();

                MessageBox.Show("Poprawnie dodano klienta.");
                cleanTextBox();
                showData();
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string choose = "";
            if (textBoxSurname.Text.Length > 0)
                choose = "Surname";
            if (textBoxName.Text.Length > 0)
                choose = "Name";
            if (textBoxNIP.Text.Length > 0)
                choose = "NIP";
            if (textBoxCity.Text.Length > 0)
                choose = "City";
            if (textBoxBuildingNumber.Text.Length > 0)
                choose = "NoBuilding";
            if (textBoxApartmentNumber.Text.Length > 0)
                choose = "NoApartment";
            if (textBoxPostCode.Text.Length > 0)
                choose = "PostCode";
            if (textBoxStreet.Text.Length > 0)
                choose = "Street";
            if (txtEmail.Text.Length > 0)
                choose = "Email";
            if (txtNumer.Text.Length > 0)
                choose = "Numer";

            switch (choose)
            {
                case "Surname":
                    searchSurname();
                    break;
                case "Name":
                    searchName();
                    break;
                case "NIP":
                    searchNip();
                    break;
                case "City":
                    searchCity();
                    break;
                case "NoBuilding":
                    searchNoBuilding();
                    break;
                case "NoApartment":
                    searchNoApartment();
                    break;
                case "PostCode":
                    searchPostCode();
                    break;
                case "Street":
                    searchStreet();
                    break;
                case "Email":
                    searchEmail();
                    break;
                case "Numer":
                    searchNumer();
                    break;
                default:
                    wrongData();
                    break;
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            showData();
            cleanTextBox();
        }       
    }
}
