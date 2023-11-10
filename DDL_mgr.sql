USE master
GO
DROP DATABASE Firma_produkcyjna
GO
CREATE DATABASE Firma_produkcyjna
GO
USE Firma_produkcyjna
GO


CREATE TABLE Wyksztalcenie
	(
	ID_wyksztalcenie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa VARCHAR(35) NOT NULL,
);

CREATE TABLE Pracownik
	(
	ID_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwisko NVARCHAR(50) NOT NULL,
	Imie NVARCHAR(50) NOT NULL,
	Nr_dowodu NVARCHAR(9) NOT NULL,
	Pesel BIGINT NOT NULL,
	ID_wyksztalcenie INT FOREIGN KEY 
		REFERENCES Wyksztalcenie(ID_wyksztalcenie) NOT NULL,
);

CREATE TABLE Dzial
	(
	ID_dzial INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_dzial NVARCHAR(50) NOT NULL
);

CREATE TABLE Stanowisko
	(
	ID_stanowisko INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_dzial INT FOREIGN KEY
		REFERENCES Dzial(ID_dzial) NOT NULL,
	Placa SMALLMONEY NOT NULL,
	Nazwa_stanowiska NVARCHAR(250) NOT NULL,
	Opis_stanowiska NVARCHAR(250)
);

CREATE TABLE Stanowisko_pracownik
	(
	ID_stanowisko_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_stanowisko INT FOREIGN KEY
		REFERENCES Stanowisko(ID_stanowisko) NOT NULL,
	ID_pracownik INT FOREIGN KEY
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
);

CREATE TABLE Rodzaj_umowy
	(
	ID_rodzaj_umowy INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
	Urlop INT NOT NULL
);

CREATE TABLE Rodzaj_nieobecnosci
	(
	ID_rodzaj_nieobecnosci INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Symbol NVARCHAR(10) NOT NULL,
	Procent_wynagrodzenia INT NOT NULL
);

CREATE TABLE Nieobecnosc
	(
	ID_nieobecnosc INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_rodzaj_nieobecnosci  INT FOREIGN KEY REFERENCES Rodzaj_nieobecnosci(ID_rodzaj_nieobecnosci) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE NOT NULL
);

CREATE TABLE Umowa
	(
	ID_umowa INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_rodzaj_umowy INT FOREIGN KEY REFERENCES Rodzaj_umowy(ID_rodzaj_umowy) NOT NULL,
	ID_stanowisko_pracownik INT FOREIGN KEY REFERENCES Stanowisko_pracownik(ID_stanowisko_pracownik) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE
);

CREATE TABLE Rodzaj_szkolenie
	(
	ID_rodzaj_szkolenie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL,
);

CREATE TABLE Szkolenie_pracownik
	(
	ID_szkolenie_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_rodzaj_szkolenie INT FOREIGN KEY REFERENCES Rodzaj_szkolenie(ID_rodzaj_szkolenie) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_od DATETIME NOT NULL,
	Data_do DATETIME
);

CREATE TABLE Dane_adresowe_pracownik
	(
	ID_dane_adresowe_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Miejscowosc NVARCHAR(50) NOT NULL,
	Ulica NVARCHAR(50),
	Nr_budynku INT NOT NULL,
	Nr_lokalu INT,
	Kod_pocztowy NVARCHAR(6) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE,
	)

CREATE TABLE Nr_telefon_pracownik
	(
	ID_Nr_telefon_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Numer NVARCHAR(9) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE,
	)

CREATE TABLE Email_pracownik
	(
	ID_email_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	Data_od DATE NOT NULL,
	Data_do DATE,
	)

CREATE TABLE Rodzaj_kontrola
	(
	ID_rodzaj_kontrola INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Rodzaj_kontrola NVARCHAR(50) NOT NULL,
	Procedura NVARCHAR(250) NOT NULL
);

CREATE TABLE Produkt
	(
	ID_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_produkt NVARCHAR(50) NOT NULL
);

CREATE TABLE Jednostka 
	(
	ID_jednostka INT IDENTITY(1,1) NOT NULL PRIMARY KEY ,
	Nazwa_jednostka NVARCHAR(100) NOT NULL,
	Skrot NVARCHAR(10) NOT NULL
);

CREATE TABLE Rodzaj_parametr
	(
	ID_rodzaj_parametr INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_rodzaj_parametr NVARCHAR(50) NOT NULL,
	ID_jednostka INT FOREIGN KEY 
		REFERENCES Jednostka(ID_jednostka) NOT NULL
);

CREATE TABLE Parametr_produkt
	(
	ID_parametr_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_produkt INT FOREIGN KEY 
		REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_rodzaj_parametr INT FOREIGN KEY 
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Zakres_dol DECIMAL(15,2) NOT NULL,
	Zakres_gora DECIMAL(15,2) NOT NULL,
);

CREATE TABLE Slownik_polprodukt
	(
	ID_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL
);

CREATE TABLE Rodzaj_material
	(
	ID_rodzaj_material INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_rodzaj_material nvarchar(50) NOT NULL
);

CREATE TABLE Material 
	(
	ID_material int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_rodzaj_material INT FOREIGN KEY 
		REFERENCES Rodzaj_material(ID_rodzaj_material) NOT NULL,
	Nazwa_material nvarchar(100) NOT NULL
);

CREATE TABLE Sklad_polprodukt
	(
	ID_sklad_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_polprodukt INT FOREIGN KEY 
		REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
	ID_material INT FOREIGN KEY
		REFERENCES Material(ID_material) NOT NULL,
	Ilosc INT NOT NULL
);

CREATE TABLE Parametr_polprodukt
	(
	ID_parametr_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_polprodukt INT FOREIGN KEY 
		REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
	ID_rodzaj_parametr INT FOREIGN KEY 
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Zakres_dol DECIMAL(15,2) NOT NULL,
	Zakres_gora DECIMAL(15,2) NOT NULL,
);

CREATE TABLE Sklad_produkt
	(
	ID_sklad_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_produkt INT FOREIGN KEY
		REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_polprodukt INT FOREIGN KEY
		REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
	Ilosc INT NOT NULL
);

CREATE TABLE Sklad_produkt_material
	(
	ID_sklad_produkt_material INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_produkt INT FOREIGN KEY
		REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_material INT FOREIGN KEY
		REFERENCES Material(ID_material) NOT NULL,
	Ilosc_g INT NOT NULL
);

CREATE TABLE Czynnosc_produkcyjna
	(
	ID_czynnosc_produkcyjna INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(50) NOT NULL
);

CREATE TABLE Slownik_stanowisko
	(
	ID_nazwa_stanowiska INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_stanowiska NVARCHAR(50) NOT NULL
);

CREATE TABLE Nr_seryjny
	(
	ID_nr_seryjny INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nr_seryjny NVARCHAR(30) UNIQUE NOT NULL
);

CREATE TABLE Rodzaj_maszyna	
	(
	ID_rodzaj_maszyna INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_rodzaj_maszyna NVARCHAR(50) NOT NULL,
	Opis NVARCHAR(50)
);

CREATE TABLE Maszyna
	(
	ID_maszyna INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_maszyna NVARCHAR(50) NOT NULL,
	ID_rodzaj_maszyna INT FOREIGN KEY 
		REFERENCES Rodzaj_maszyna(ID_rodzaj_maszyna) NOT NULL,
	Koszt_RBG DECIMAL(15,2) NOT NULL
);

CREATE TABLE Maszyna_nr_seryjny
	(
	ID_maszyna_nr INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_maszyna INT FOREIGN KEY 
		REFERENCES Maszyna(ID_maszyna) NOT NULL,
	ID_nr_seryjny INT FOREIGN KEY 
		REFERENCES Nr_seryjny(ID_nr_seryjny) NOT NULL
);

CREATE TABLE Stanowisko_produkcyjne
	(
	ID_stanowisko_produkcyjne INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_nazwa_stanowiska INT FOREIGN KEY
		REFERENCES Slownik_stanowisko(ID_nazwa_stanowiska) NOT NULL
);

CREATE TABLE Proces_polprodukt_czynnosc 
	(
	ID_proces_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_polprodukt INT FOREIGN KEY 
		REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
	ID_czynnosc_produkcyjna INT FOREIGN KEY 
		REFERENCES Czynnosc_produkcyjna(ID_czynnosc_produkcyjna) NOT NULL,
	ID_stanowisko_produkcyjne INT FOREIGN KEY
		REFERENCES	Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL,
	Czas_trwania INT NOT NULL,
);

CREATE TABLE Proces_produkt_czynnosc 
	(
	ID_proces_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_produkt INT FOREIGN KEY 
		REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_czynnosc_produkcyjna INT FOREIGN KEY 
		REFERENCES Czynnosc_produkcyjna(ID_czynnosc_produkcyjna) NOT NULL,
	ID_stanowisko_produkcyjne INT FOREIGN KEY
		REFERENCES	Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL,
	Czas_trwania INT NOT NULL,
);

CREATE TABLE Narzedzie
	(
	ID_narzedzie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_narzedzie NVARCHAR(50) NOT NULL
);

CREATE TABLE Sklad_stanowisko_produkcyjne_maszyna
	(
	ID_sklad_stanowisko_produkcyjne_maszyna INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_stanowisko_produkcyjne INT FOREIGN KEY
		REFERENCES Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL,
	ID_maszyna_nr INT FOREIGN KEY
		REFERENCES Maszyna_nr_seryjny(ID_maszyna_nr) NOT NULL,
);

CREATE TABLE Sklad_stanowisko_produkcyjne_narzedzie
	(
	ID_sklad_stanowisko_produkcyjne_narzedzie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_stanowisko_produkcyjne INT FOREIGN KEY
		REFERENCES Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL,
	ID_narzedzie INT FOREIGN KEY
		REFERENCES Narzedzie(ID_narzedzie) NOT NULL,
	Ilosc INT NOT NULL
);

CREATE TABLE Rodzaj_czesc 
	(
	ID_rodzaj_czesc INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_rodzaj_czesc NVARCHAR(50) NOT NULL
);

CREATE TABLE Czesc 
	(
	ID_czesc INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_czesc NVARCHAR(50) NOT NULL,
	ID_rodzaj_czesc int FOREIGN KEY 
		REFERENCES Rodzaj_czesc(ID_rodzaj_czesc) NOT NULL
);

CREATE TABLE Klient
	(
	ID_klient INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwisko NVARCHAR(50) NOT NULL,
	Imie NVARCHAR(50) NOT NULL,
	NIP NVARCHAR(10),
	Miejscowosc NVARCHAR(50) NOT NULL,
	Ulica NVARCHAR(50),
	Nr_budynek INT NOT NULL,
	Nr_lokal INT,
	Kod_pocztowy NVARCHAR(10) NOT NULL,
	Numer_telefonu NVARCHAR(20) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
);

CREATE TABLE Typ_zamowienie
	(
	ID_typ_zamowienie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Rodzaj_zamowienie NVARCHAR(50) NOT NULL
);

CREATE TABLE Gwarancja
	(
	ID_gwarancja INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Opis_gwarancja  NVARCHAR(250) NOT NULL,
	Okres_gwarancja INT NOT NULL
);

CREATE TABLE Zamowienie
	(
	ID_zamowienie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_klient INT FOREIGN KEY 
		REFERENCES Klient(ID_klient),
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_zamowienie DATE NOT NULL,
	ID_typ_zamowienie INT FOREIGN KEY 
		REFERENCES Typ_zamowienie(ID_typ_zamowienie) NOT NULL 
);

CREATE TABLE Zamowienie_szczegol
	(
	ID_zamowienie_szczegol INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_zamowienie INT FOREIGN KEY
		REFERENCES Zamowienie(ID_zamowienie) NOT NULL,
	ID_produkt INT FOREIGN KEY
		REFERENCES Produkt(ID_produkt) NOT NULL,
	ID_gwarancja INT FOREIGN KEY
		REFERENCES Gwarancja(ID_gwarancja) NOT NULL,
	Ilosc INT NOT NULL
);

CREATE TABLE Wytwarzanie
	(
	ID_wytwarzanie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_zamowienie_szczegol INT FOREIGN KEY
		REFERENCES Zamowienie_szczegol(ID_zamowienie_szczegol) NOT NULL,
	Czas_od DATETIME NOT NULL,
	Czas_do DATETIME
);

CREATE TABLE Proces_wytwarzanie_produkt
	(
	ID_proces_wytwarzanie_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_wytwarzanie INT FOREIGN KEY
		REFERENCES Wytwarzanie(ID_wytwarzanie) NOT NULL,
	ID_proces_produkt INT FOREIGN KEY
		REFERENCES Proces_produkt_czynnosc(ID_proces_produkt),
);

CREATE TABLE Proces_wytwarzanie_polprodukt
	(
	ID_proces_wytwarzanie_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_wytwarzanie INT FOREIGN KEY
		REFERENCES Wytwarzanie(ID_wytwarzanie) NOT NULL,
	ID_proces_polprodukt INT FOREIGN KEY
		REFERENCES Proces_polprodukt_czynnosc(ID_proces_polprodukt),
);

CREATE TABLE Kontrola_jakosci_produkt
	(
	ID_kontrola_jakosci_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_wytwarzanie INT FOREIGN KEY
		REFERENCES Wytwarzanie(ID_wytwarzanie) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_rodzaj_kontrola INT FOREIGN KEY
		REFERENCES Rodzaj_kontrola(ID_rodzaj_kontrola) NOT NULL,
	Data_od DATETIME NOT NULL,
	Data_do DATETIME, 
	Uwagi NVARCHAR(250)
);

CREATE TABLE Kontrola_jakosci_polprodukt
	(
	ID_kontrola_jakosci_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_wytwarzanie INT FOREIGN KEY
		REFERENCES Wytwarzanie(ID_wytwarzanie) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_rodzaj_kontrola INT FOREIGN KEY
		REFERENCES Rodzaj_kontrola(ID_rodzaj_kontrola) NOT NULL,
	Data_od DATETIME NOT NULL,
	Data_do DATETIME, 
	Uwagi NVARCHAR(250)
);

CREATE TABLE Kontrola_parametr_produkt
(
	ID_kontrola_parametr_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_kontrola_jakosci_produkt INT FOREIGN KEY 
		REFERENCES Kontrola_jakosci_produkt(ID_kontrola_jakosci_produkt) NOT NULL,
	ID_parametr_produkt INT FOREIGN KEY
		REFERENCES Parametr_produkt (ID_parametr_produkt) NOT NULL,
	Wartosc DECIMAL(15,2) NOT NULL
);

CREATE TABLE Kontrola_parametr_polprodukt
(
	ID_kontrola_parametr_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_kontrola_jakosci_polprodukt INT FOREIGN KEY 
		REFERENCES Kontrola_jakosci_polprodukt(ID_kontrola_jakosci_polprodukt) NOT NULL,
	ID_parametr_polprodukt INT FOREIGN KEY
		REFERENCES Parametr_polprodukt (ID_parametr_polprodukt) NOT NULL,
	Wartosc DECIMAL(15,2) NOT NULL
);

CREATE TABLE Sklad_maszyna 
	(
	ID_sklad_maszyna INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_maszyna INT FOREIGN KEY 
		REFERENCES Maszyna(ID_maszyna) NOT NULL,
	ID_czesc INT FOREIGN KEY 
		REFERENCES Czesc(ID_czesc) NOT NULL,
	Ilosc_czesci INT NOT NULL
);

CREATE TABLE Rodzaj_obsluga
	(
	ID_rodzaj_obsluga INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_rodzaj_obsluga NVARCHAR(50) NOT NULL
);

CREATE TABLE Obsluga
	(
	ID_obsluga INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_rodzaj_obsluga INT FOREIGN KEY
		REFERENCES Rodzaj_obsluga(ID_rodzaj_obsluga) NOT NULL,
	ID_stanowisko_produkcyjne INT FOREIGN KEY
		REFERENCES Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL,
	Data_od DATETIME NOT NULL,
	Data_do DATETIME
);

CREATE TABLE Obsluga_pracownik
	(
	ID_obsluga_pracownik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_obsluga INT FOREIGN KEY 
		REFERENCES Obsluga(ID_Obsluga) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_Pracownik) NOT NULL
);

CREATE TABLE Parametr_material 
	(
	ID_parametr_material INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_material INT FOREIGN KEY 
		REFERENCES Material(ID_material) NOT NULL,
	ID_rodzaj_parametr INT FOREIGN KEY 
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Zakres_dol DECIMAL(15,2) NOT NULL,
	Zakres_gora DECIMAL(15,2) NOT NULL
);

CREATE TABLE Parametr_narzedzie
	(
	ID_parametr_narzedzie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_narzedzie INT FOREIGN KEY 
		REFERENCES Narzedzie(ID_narzedzie) NOT NULL,
	ID_rodzaj_parametr INT FOREIGN KEY 
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Zakres_dol DECIMAL(15,2) NOT NULL,
	Zakres_gora DECIMAL(15,2) NOT NULL
);

CREATE TABLE Parametr_maszyna 
	(
	ID_parametr_maszyna INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_maszyna INT FOREIGN KEY 
		REFERENCES Maszyna(ID_maszyna) NOT NULL,
	ID_rodzaj_parametr int FOREIGN KEY 
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Zakres_dol DECIMAL(15,2) NOT NULL,
	Zakres_gora DECIMAL(15,2) NOT NULL
);

CREATE TABLE Parametr_czesc 
	(
	ID_parametr_czesc INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_czesc INT FOREIGN KEY 
		REFERENCES Czesc(ID_czesc) NOT NULL,
	ID_rodzaj_parametr int FOREIGN KEY 
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Zakres_dol DECIMAL(15,2) NOT NULL,
	Zakres_gora DECIMAL(15,2) NOT NULL
);

CREATE TABLE Dostawca
	(
	ID_dostawca INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_dostawca NVARCHAR(50) NOT NULL
);

CREATE TABLE Zamowienie_material 
	(
	ID_zamowienie_material INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
		Data_zamowienia DATE NOT NULL,
	ID_dostawca INT FOREIGN KEY 
		REFERENCES Dostawca(ID_dostawca) NOT NULL
);

CREATE TABLE Status_zamowienie 
	(
	ID_status_zamowienie INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_status NVARCHAR(20) NOT NULL
);
 
CREATE TABLE Stan_realizacji_zamowienie_material 
	(
	ID_stan_realizacji_zamowienie_material INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_zamowienie_material INT FOREIGN KEY 
		REFERENCES Zamowienie_material(ID_zamowienie_material) NOT NULL,
	ID_status_zamowienie INT FOREIGN KEY 
		REFERENCES Status_zamowienie(ID_status_zamowienie) NOT NULL,
	Data_stan SMALLDATETIME NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL
);

CREATE TABLE Producent 
	(
	ID_producent INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nazwa_producenta NVARCHAR(50) NOT NULL
);
 
CREATE TABLE Szczegoly_zamowienie_material
	(
	ID_szczegoly_zamowienie_material INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_zamowienie_material INT FOREIGN KEY 
		REFERENCES Zamowienie_material(ID_zamowienie_material) NOT NULL,
	ID_material INT FOREIGN KEY 
		REFERENCES Material(ID_material) NOT NULL,
	ID_producent INT FOREIGN KEY 
		REFERENCES Producent(ID_producent) NOT NULL,
	Waga_g INT NOT NULL,
	Cena DECIMAL(15,2) NOT NULL
);

CREATE TABLE Zamowienie_polprodukt
	(
	ID_zamowienie_polprodukt INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
		Data_zamowienia DATE NOT NULL,
	ID_dostawca INT FOREIGN KEY 
		REFERENCES Dostawca(ID_dostawca) NOT NULL
);

CREATE TABLE Stan_realizacji_zamowienie_polprodukt
	(
	ID_stan_realizacji_zamowienie_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_zamowienie_polprodukt INT FOREIGN KEY 
		REFERENCES Zamowienie_polprodukt(ID_zamowienie_polprodukt) NOT NULL,
	ID_status_zamowienie INT FOREIGN KEY 
		REFERENCES Status_zamowienie(ID_status_zamowienie) NOT NULL,
	Data_stan SMALLDATETIME NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL
);

CREATE TABLE Szczegoly_zamowienie_polprodukt
	(
	ID_szczegoly_zamowienie_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_zamowienie_polprodukt INT FOREIGN KEY 
		REFERENCES Zamowienie_polprodukt(ID_zamowienie_polprodukt) NOT NULL,
	ID_polprodukt INT FOREIGN KEY 
		REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
	Ilosc INT NOT NULL,
	Cena DECIMAL(15,2) NOT NULL
);

CREATE TABLE Zamowienie_czesc 
	(
	ID_zamowienie_czesc int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_pracownik int FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_zamowienia DATE NOT NULL,
	ID_dostawca INT FOREIGN KEY 
		REFERENCES Dostawca(ID_dostawca) NOT NULL
);

CREATE TABLE Stan_realizacji_zamowienie_czesc 
	(
	ID_zamowienie_czesc INT FOREIGN KEY 
		REFERENCES Zamowienie_czesc(ID_zamowienie_czesc) NOT NULL,
	ID_status_zamowienie INT FOREIGN KEY 
		REFERENCES Status_zamowienie(ID_status_zamowienie) NOT NULL,
	Data_stan SMALLDATETIME NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	CONSTRAINT PK_StanRZCZ PRIMARY KEY (ID_zamowienie_czesc, ID_status_zamowienie, ID_pracownik)
);

CREATE TABLE Szczegoly_zamowienie_czesc 
	(
	ID_zamowienie_czesc INT FOREIGN KEY 
		REFERENCES Zamowienie_czesc(ID_zamowienie_czesc) NOT NULL,
	ID_czesc INT FOREIGN KEY 
		REFERENCES Czesc(ID_czesc) NOT NULL,
	ID_producent INT FOREIGN KEY 
		REFERENCES Producent(ID_producent) NOT NULL,
	Ilosc INT NOT NULL,
	Cena DECIMAL(15,2) NOT NULL,
		CONSTRAINT PK_SzczegolyZCZ PRIMARY KEY (ID_zamowienie_czesc, ID_czesc, ID_producent)
);

CREATE TABLE Zamowienie_maszyna 
	(
	ID_zamowienie_maszyna INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_zamowienia DATE NOT NULL,
	ID_dostawca INT FOREIGN KEY 
		REFERENCES Dostawca(ID_dostawca) NOT NULL
);
 
CREATE TABLE Stan_realizacji_zamowienie_maszyna 
	(
	ID_zamowienie_maszyna INT FOREIGN KEY 
		REFERENCES Zamowienie_maszyna(ID_zamowienie_maszyna) NOT NULL,
	ID_status_zamowienie INT FOREIGN KEY 
		REFERENCES Status_zamowienie(ID_status_zamowienie) NOT NULL,
	Data_stan SMALLDATETIME NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	CONSTRAINT PK_StanRZM PRIMARY KEY (ID_zamowienie_maszyna, ID_status_zamowienie)
);
 
CREATE TABLE Szczegoly_zamowienie_maszyna 
	(
	ID_zamowienie_maszyna INT FOREIGN KEY
		REFERENCES Zamowienie_maszyna(ID_zamowienie_maszyna) NOT NULL,
	ID_maszyna INT FOREIGN KEY 
		REFERENCES Maszyna(ID_maszyna) NOT NULL,
	ID_producent INT FOREIGN KEY 
		REFERENCES Producent(ID_producent) NOT NULL,
	Ilosc INT NOT NULL,
	Cena DECIMAL(15,2) NOT NULL,
	CONSTRAINT PK_SzczegolyZM PRIMARY KEY (ID_zamowienie_maszyna, ID_maszyna, ID_producent)
);

CREATE TABLE Zamowienie_narzedzie 
	(
	ID_zamowienie_narzedzie int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	Data_zamowienia DATE NOT NULL,
	ID_dostawca INT FOREIGN KEY 
		REFERENCES Dostawca(ID_dostawca) NOT NULL
);
 
CREATE TABLE Stan_realizacji_zamowienie_narzedzie 
	(
	ID_zamowienie_narzedzie INT FOREIGN KEY 
		REFERENCES Zamowienie_narzedzie(ID_zamowienie_narzedzie) NOT NULL,
	ID_status_zamowienie INT FOREIGN KEY 
		REFERENCES Status_zamowienie(ID_status_zamowienie) NOT NULL,
	Data_stan SMALLDATETIME NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	CONSTRAINT PK_StanRZN PRIMARY KEY (ID_zamowienie_narzedzie, ID_status_zamowienie)
);
 
CREATE TABLE Szczegoly_zamowienie_narzedzie
	(
	ID_zamowienie_narzedzie int FOREIGN KEY 
		REFERENCES Zamowienie_narzedzie(ID_zamowienie_narzedzie) NOT NULL,
	ID_narzedzie INT FOREIGN KEY 
		REFERENCES Narzedzie(ID_narzedzie) NOT NULL,
	ID_producent INT FOREIGN KEY 
		REFERENCES Producent(ID_producent) NOT NULL,
	Sztuk INT NOT NULL,
	Cena decimal(15,2) NOT NULL,
	CONSTRAINT PK_SzczegolyZN PRIMARY KEY (ID_zamowienie_narzedzie, ID_narzedzie, ID_producent)
);

CREATE TABLE Alert
	(
	ID_alert INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_dzial INT FOREIGN KEY
		REFERENCES Dzial(ID_dzial) NOT NULL,
	Tresc NVARCHAR(250) NOT NULL,
	Czy_odczytano BIT NOT NULL
);

CREATE TABLE Marka_pojazd_slownik
	(
	ID_marka_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(20) NOT NULL
);

CREATE TABLE Model_pojazd_slownik
	(
	ID_model_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(20) NOT NULL,
	Rok_produkcji_od INT NOT NULL,
	Rok_produkcji_do INT NOT NULL
);

CREATE TABLE Marka_model
	(
	ID_marka_model INT PRIMARY KEY IDENTITY(1,1) NOT NULL,	
	ID_marka_pojazd INT FOREIGN KEY
		REFERENCES Marka_pojazd_slownik(ID_marka_pojazd) NOT NULL,
	ID_model_pojazd INT FOREIGN KEY
		REFERENCES Model_pojazd_slownik(ID_model_pojazd) NOT NULL
);

CREATE TABLE Pojazd
	(
	ID_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nr_VIN NVARCHAR(15) UNIQUE NOT NULL,
	Rok_produkcji INT NOT NULL
);

CREATE TABLE Typ_pojazd_slownik
	(
	ID_typ_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa_typ NVARCHAR(20) NOT NULL,
);

CREATE TABLE Typ_pojazd_model
	(
	ID_typ_pojazd_model INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_marka_model INT FOREIGN KEY
		REFERENCES Marka_model(ID_marka_model) NOT NULL,
	ID_typ_pojazd INT FOREIGN KEY
		REFERENCES Typ_pojazd_slownik(ID_typ_pojazd) NOT NULL
);

CREATE TABLE Marka_model_pojazd
	(
	ID_marka_model_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,	
	ID_typ_pojazd_model INT FOREIGN KEY
		REFERENCES Typ_pojazd_model(ID_typ_pojazd_model) NOT NULL,
	ID_pojazd INT FOREIGN KEY
		REFERENCES Pojazd(ID_pojazd) NOT NULL
);

CREATE TABLE Typ_pojazd_model_silnik
	(
	ID_typ_pojazd_model_silnik INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_typ_pojazd_model INT FOREIGN KEY
		REFERENCES Typ_pojazd_model(ID_typ_pojazd_model) NOT NULL,
	ID_produkt INT FOREIGN KEY
		REFERENCES Produkt(ID_produkt) NOT NULL
);

CREATE TABLE Wersja_wyposazenia_slownik
	(
	ID_wersja_wyposazenia INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(20) NOT NULL
);

CREATE TABLE Wersja_wyposazenia_produkt
	(
	ID_wersja_wyposazenia_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_wersja_wyposazenia INT FOREIGN KEY
			REFERENCES Wersja_wyposazenia_slownik(ID_wersja_wyposazenia) NOT NULL,
	ID_produkt INT FOREIGN KEY
		REFERENCES Produkt(ID_produkt) NOT NULL,
	Ilosc INT NOT NULL
);

CREATE  TABLE Wersja_wyposazenia_pojazd
	(
	ID_wersja_wyposazenia_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_wersja_wyposazenia INT FOREIGN KEY
		REFERENCES Wersja_wyposazenia_slownik(ID_wersja_wyposazenia) NOT NULL,
	ID_pojazd INT FOREIGN KEY
		REFERENCES Pojazd(ID_pojazd) NOT NULL
);

CREATE TABLE Zamowienie_szczegol_pojazd
	(
	ID_zamowienie_szczegol_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_zamowienie INT FOREIGN KEY
		REFERENCES Zamowienie(ID_zamowienie) NOT NULL,
	ID_pojazd INT FOREIGN KEY
		REFERENCES Pojazd(ID_pojazd) NOT NULL,
	ID_gwarancja INT FOREIGN KEY	
		REFERENCES Gwarancja(ID_gwarancja) NOT NULL,
	Koszt INT NOT NULL,
	Ilosc INT NOT NULL
);

CREATE TABLE Zamowienie_produkt
	(
	ID_zamowienie_produkt INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_zamowienie_szczegol_pojazd INT FOREIGN KEY
		REFERENCES Zamowienie_szczegol_pojazd(ID_zamowienie_szczegol_pojazd) NOT NULL,
	Data_zamowienia DATE NOT NULL,
	ID_dostawca INT FOREIGN KEY 
		REFERENCES Dostawca(ID_dostawca) NOT NULL
);

CREATE TABLE Stan_realizacji_zamowienie_produkt
	(
	ID_stan_realizacji_zamowienie_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_zamowienie_produkt INT FOREIGN KEY 
		REFERENCES Zamowienie_produkt(ID_zamowienie_produkt) NOT NULL,
	ID_status_zamowienie INT FOREIGN KEY 
		REFERENCES Status_zamowienie(ID_status_zamowienie) NOT NULL,
	Data_stan SMALLDATETIME NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL
);

CREATE TABLE Szczegoly_zamowienie_produkt
	(
	ID_szczegoly_zamowienie_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_zamowienie_produkt INT FOREIGN KEY 
		REFERENCES Zamowienie_produkt(ID_zamowienie_produkt) NOT NULL,
	ID_produkt INT FOREIGN KEY 
		REFERENCES Produkt(ID_produkt) NOT NULL,
	Ilosc INT NOT NULL,
	Cena INT NOT NULL
);

CREATE TABLE Montaz_pojazd
	(
	ID_montaz_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_zamowienie_szczegol_pojazd INT FOREIGN KEY
		REFERENCES Zamowienie_szczegol_pojazd(ID_zamowienie_szczegol_pojazd) NOT NULL,
	Czas_od DATETIME NOT NULL,
	Czas_do DATETIME
);

CREATE TABLE Proces_montaz_pojazd_czynnosc 
	(
	ID_proces_montaz_pojazd_czynnosc INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pojazd INT FOREIGN KEY 
		REFERENCES Pojazd(ID_pojazd) NOT NULL,
	ID_czynnosc_produkcyjna INT FOREIGN KEY 
		REFERENCES Czynnosc_produkcyjna(ID_czynnosc_produkcyjna) NOT NULL,
	ID_stanowisko_produkcyjne INT FOREIGN KEY
		REFERENCES	Stanowisko_produkcyjne(ID_stanowisko_produkcyjne) NOT NULL,
	Czas_trwania INT NOT NULL,
);

CREATE TABLE Proces_montaz_pojazd
	(
	ID_proces_montaz_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_montaz_pojazd INT FOREIGN KEY
		REFERENCES Montaz_pojazd(ID_montaz_pojazd) NOT NULL,
	ID_proces_montaz_pojazd_czynnosc INT FOREIGN KEY
		REFERENCES Proces_montaz_pojazd_czynnosc(ID_proces_montaz_pojazd_czynnosc) NOT NULL
);

CREATE TABLE Kontrola_jakosci_pojazd
	(
	ID_kontrola_jakosci_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_montaz_pojazd INT FOREIGN KEY
		REFERENCES Montaz_pojazd(ID_montaz_pojazd) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_rodzaj_kontrola INT FOREIGN KEY
		REFERENCES Rodzaj_kontrola(ID_rodzaj_kontrola) NOT NULL,
	Data_kontroli DATE NOT NULL,
	Wynik_kontroli BIT NOT NULL, 
	Uwagi NVARCHAR(250)
);

CREATE TABLE Typ_reklamacja
	(
	ID_typ_reklamacja  INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(250) NOT NULL
);

CREATE TABLE Reklamacja_pojazd
	(
	ID_reklamacja_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_zamowienie INT FOREIGN KEY 
		REFERENCES Zamowienie(ID_zamowienie) NOT NULL,
	Data_reklamacja DATE NOT NULL,
	Opis_reklamacja NVARCHAR(250) NOT NULL
);

CREATE TABLE Szczegol_reklamacja_pojazd
	(
	ID_szczegol_reklamacja_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_reklamacja_pojazd INT FOREIGN KEY
		REFERENCES Reklamacja_pojazd(ID_reklamacja_pojazd) NOT NULL,
	ID_typ_reklamacja INT FOREIGN KEY 
		REFERENCES Typ_reklamacja(ID_typ_reklamacja) NOT NULL,
	ID_pojazd INT FOREIGN KEY 
		REFERENCES Pojazd(ID_pojazd) NOT NULL,
);
	
CREATE TABLE Zwrot_pojazd
	(
	ID_zwrot_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_reklamacja_pojazd INT FOREIGN KEY 
		REFERENCES Reklamacja_pojazd(ID_reklamacja_pojazd) NOT NULL,
	ID_pojazd INT FOREIGN KEY 
		REFERENCES Pojazd(ID_pojazd) NOT NULL,
	Ilosc INT NOT NULL,
	Akceptacja BIT NOT NULL
);

CREATE TABLE Reklamacja_produkt
	(
	ID_reklamacja_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_pracownik INT FOREIGN KEY 
		REFERENCES Pracownik(ID_pracownik) NOT NULL,
	ID_zamowienie INT FOREIGN KEY 
		REFERENCES Zamowienie(ID_zamowienie) NOT NULL,
	Data_reklamacja DATE NOT NULL,
	Opis_reklamacja NVARCHAR(250) NOT NULL
);

CREATE TABLE Szczegol_reklamacja_produkt
	(
	ID_szczegol_reklamacja_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_reklamacja_produkt INT FOREIGN KEY
		REFERENCES Reklamacja_produkt(ID_reklamacja_produkt) NOT NULL,
	ID_typ_reklamacja INT FOREIGN KEY 
		REFERENCES Typ_reklamacja(ID_typ_reklamacja) NOT NULL,
	ID_produkt INT FOREIGN KEY 
		REFERENCES Produkt(ID_produkt) NOT NULL,
);
	
CREATE TABLE Zwrot_produkt
	(
	ID_zwrot_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_reklamacja_produkt INT FOREIGN KEY 
		REFERENCES Reklamacja_produkt(ID_reklamacja_produkt) NOT NULL,
	ID_produkt INT FOREIGN KEY 
		REFERENCES Produkt(ID_produkt) NOT NULL,
	Ilosc INT NOT NULL,
	Akceptacja BIT NOT NULL
);

CREATE TABLE Magazynowanie_slownik
	(
	ID_magazynowanie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nazwa NVARCHAR(60) NOT NULL
);

CREATE TABLE Parametr_typ_magazynowania
	(
	ID_parametr_typ_magazynowania INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_magazynowanie INT FOREIGN KEY 
		REFERENCES Magazynowanie_slownik(ID_magazynowanie) NOT NULL,
	ID_rodzaj_parametr INT FOREIGN KEY
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Wartosc_dolna INT NOT NULL,
	Wartosc_gorna INT NOT NULL
);

	CREATE TABLE Poziom_magazynowanie
	(
	ID_poziom_magazynowanie INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_magazynowanie INT FOREIGN KEY
		REFERENCES Magazynowanie_slownik(ID_magazynowanie) NOT NULL,
	Poziom INT NOT NULL
);

CREATE TABLE Parametr_poziom_magazynowanie
	(
	ID_parametr_poziom_magazynowanie INT PRIMARY KEY IDENTITY NOT NULL,
	ID_poziom_magazynowanie INT FOREIGN KEY REFERENCES Poziom_magazynowanie(ID_poziom_magazynowanie) NOT NULL,
	ID_rodzaj_parametr INT FOREIGN KEY
		REFERENCES Rodzaj_parametr(ID_rodzaj_parametr) NOT NULL,
	Wartosc_dolna INT NOT NULL,
	Wartosc_gorna INT NOT NULL
);

CREATE TABLE Miejsce_magazynowanie_produkt
	(
	ID_miejsce_magazynowanie_produkt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_poziom_magazynowanie INT FOREIGN KEY
		REFERENCES Poziom_magazynowanie(ID_poziom_magazynowanie) NOT NULL,
	ID_produkt INT FOREIGN KEY
		REFERENCES Produkt(ID_produkt) NOT NULL,
	Nr_miejsca INT NOT NULL
);

CREATE TABLE Miejsce_magazynowanie_polprodukt
	(
	ID_miejsce_magazynowanie_polprodukt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_poziom_magazynowanie INT FOREIGN KEY
		REFERENCES Poziom_magazynowanie(ID_poziom_magazynowanie) NOT NULL,
	ID_polprodukt INT FOREIGN KEY
		REFERENCES Slownik_polprodukt(ID_polprodukt) NOT NULL,
	Nr_miejsca INT NOT NULL
);

CREATE TABLE Miejsce_magazynowanie_pojazd
	(
	ID_miejsce_magazynowanie_pojazd INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ID_poziom_magazynowanie INT FOREIGN KEY
		REFERENCES Poziom_magazynowanie(ID_poziom_magazynowanie) NOT NULL,
	ID_pojazd INT FOREIGN KEY
		REFERENCES Pojazd(ID_pojazd) NOT NULL,
	Nr_miejsca INT NOT NULL
);