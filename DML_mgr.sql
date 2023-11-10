
USE master
GO
USE Firma_produkcyjna
GO

INSERT INTO Dzial (Nazwa_dzial)
	VALUES
	('Kadr i przygotowania produkcji'),
	('Handlowy i marketingu'),
	('Produkcji'),
	('Zasobów i dostaw'),
	('Utrzymania ruchu'),
	('Logistyczny'),
	('Kontroli jakoœci');

INSERT INTO Wyksztalcenie (Nazwa)
	VALUES
	('Podstawowe'),
	('Œrednie bran¿owe'),
	('Œrednie'),
	('In¿ynier'), 
	('Wy¿sze');

INSERT INTO Czynnosc_produkcyjna (Nazwa)
	VALUES
	('Przygotowanie stanowiska'),
	('Obróbka zgrubna'),
	('Projektowanie'),
	('Przykrêcanie'),
	('Wyg³adzanie'),
	('Szlifowanie'),
	('Lakierowanie'),
	('Klejenie'),
	('Drukowanie'),
	('Monta¿'),
	('Monta¿ silnika'),
	('Monta¿ kierownicy'),
	('Mocowanie kierownicy'),
	('Monta¿ zderzaka przedniego'),
	('Monta¿ zderzaka tylnego');

INSERT INTO Pracownik (Nazwisko, Imie, Nr_dowodu, Pesel, ID_wyksztalcenie)
	VALUES
	('Nowak','Jan','AAA00000',5505000005,1),
	('Marsza³','Grzegorz','ABC20000',88090100005,2),
	('Gont','Józef','RF004050',97030400005,3),
	('Markowska', 'Anna', 'ABC00020',88063603005,1),
	('Pawlak','Katarzyna','GDE00900',90041200003,2),
	('Kowalczylk','Adam','UJG02033',99051707802, 3),
	('Andrzejewski', 'Micha³','DCE986557',79072900034,1),
	('Krawczyk', 'Karol', 'GDT80967',90050004505,2),
	('Wieczorek', 'Karolina', 'HNR23123',87050500006,3),
	('Baran', 'Szymon', 'MFN67926',99050068003,1),
	('Wilk', 'Zuzanna', 'MDK85609',68050450673,2),
	('Sadowski', 'Aleksander', 'NFL48923',98050056806,3),
	('Borkowska', 'Zofia', 'LDG57291',76050045006,1),
	('Sikora', 'Julia', 'LFB57823',85050087096,2),
	('Nowicki', 'Filip', 'LAP46723',95050657006,3),
	('Duda', 'Wojciech', 'PKE95123',98050670006,1),
	('Grabowski', 'Stanis³aw', 'LDH65793',92050008906,1),
	('Dzban', 'Jan', 'LDP65793',98050228905,1),
	('Gawron', 'Patrycja', 'LPG69699',82050008902,1),
	('Pudzianowski', 'Mariusz', 'XD954821',74010508905,4),
	('Mahyz', 'Ednan', 'SNG65602',88092408590,4),
	('Nierob', 'Janusz', 'M6565PO1',81123157832,3),
	('Knob', 'Daniel', 'M5645P12', 87945645612,3),
	('Krolczyk', 'Ernest', 'K457P54', 8765941233,2),
	('Grubczyk', 'Marcel', 'S789D56', 8754123695,3);

INSERT INTO Dane_adresowe_pracownik (ID_pracownik, Miejscowosc, Ulica, Nr_budynku, Nr_lokalu, Kod_pocztowy, Data_od)
	VALUES
	(1, 'Warszawa', 'Jana Paw³a II', '21', '37', '02137', '2021-04-14'),
	(2, 'Marki', 'Markowa', '23', '11', '12000', '2019-08-14'),
	(3, 'Warszawa', 'Kombatantów', '6', '26', '11500', '2020-02-13'),
	(4, 'Warszawa', 'Królowej Jadwigi', '11', '20', '02347', '2020-04-19'),
	(5, 'Warszawa', 'Koœciuszki', '51', '32', '02952', '2018-10-02'),
	(6, 'Marki', 'D³uga', '1', '1', '12301','2019-03-09'),
	(7, 'Warszawa', 'Krótka', '2','2','02022','2021-06-11'),
	(8, 'Warszawa', 'Œrednia', '3','3','01437','2021-06-11'),
	(9, 'Warszawa', 'Kaliskiego', '2', '11', '01534','2020-02-11'),
	(10, 'Warszawa', 'Górczewska', '11', '20', '03321','2020-01-13'),
	(11, 'Marki', 'Naturalna', '21', '36', '08808', '2018-07-13'), 
	(12, 'Pruszków', 'Wiejska', '13', '32', '11111','2017-05-13'),
	(13, 'Warszawa',' Po³czyñska', '2','33', '01910','2018-01-01'),
	(14, 'Warszawa', 'Al. Jerozolimskie', '5','10', '02147', '2017-01-01'),
	(15, 'Pruszków', 'Marsza³kowska', '1', '1', '03332', '2019-01-01'),
	(16, 'Pruszków', 'Prosta', '27', '22', '01712', '2020-01-01'),
	(17, 'Pruszków', 'Karolkowa' ,'3', '34', '04543', '2022-01-01'),
	(18, 'Warszawa', 'Piertucha' ,'5', '15', '02495', '2022-02-21'),
	(19, 'Warszawa', 'Ziemniaczana' ,'13', '13', '00251', '2022-01-12'),
	(20, 'Warszawa', 'Marchewkowa' ,'15', '12', '00957', '2021-01-11'),
	(21, 'Nadarzyn', 'Porowa' ,'1', '31', '05830', '2022-01-05'),
	(22, 'Marki', 'Cebulowa' ,'21', '3', '04543', '2020-01-03'),
	(23, 'Warszawa', 'Porowa', '21', '37', '04568', '2021-03-03'),
	(24, 'Wronki', 'Marcewkowa', '12', '73', '98765', '2020-04-04'),
	(25, 'Warszawa', 'Wrzecieniowa', '1', '1', '12321', '2020-09-09');

INSERT INTO Nr_telefon_pracownik (ID_pracownik, Numer, Data_od)
	VALUES
	(1,'123123123','2022-01-01'),
	(2,'321321321','2022-02-01'),
	(3,'456456456','2021-12-10'),
	(4,'321321321','2020-05-01'),
	(5,'321321321','2021-06-01');

INSERT INTO Email_pracownik (ID_pracownik,Email,Data_od)
	VALUES
	(1,'jannowak@drukarczyk.pl','2022-01-01'),
	(2,'grzegorzmarszal@drukarczyk.pl','2022-02-01'),
	(3,'jozefgont@drukarczyk.pl','2021-12-10'),
	(4,'annamarkowska@drukarczyk.pl','2020-05-01'),
	(5,'katarzynapawlak@drukarczyk.pl','2021-06-01');

INSERT INTO Stanowisko (ID_dzial, Placa, Nazwa_stanowiska)
	VALUES
	(6,12000,'Prezes'),
	(2,10000,'Dyrektor operacyjny'),
	(1,6500,'Specjalista do spraw kadr i p³ac'),
	(1,7000,'Projektant'),
	(1,5000,'Project manager'),
	(1,4500,'Specjalista do spraw finansów'),
	(2,7000,'Kierownik handlu i marketingu'),
	(2,5000,'Handlowiec'),
	(2,5000,'Marketingowiec'),
	(3,8000,'Kierownik produkcji'),
	(3,6000,'Brygadzista'),
	(3,5500,'Operator'),
	(4,7000,'Kierownik zasobów i dostaw'),
	(6,4500,'Zaopatrzeniowiec'),
	(4,4500,'Magazynier'),
	(5,5500,'Brygadzista utrzymania ruchu'),
	(5,6000,'Elektromechanik'),
	(6,4500,'Logistyk'),
	(7,4800,'Kontroler jakoœci');

INSERT INTO Rodzaj_kontrola (Rodzaj_kontrola, Procedura)
	VALUES
	('Wymiarowa', 'Dokonaæ pomiaru najwa¿niejszych wymiarów'),
	('Wzrokowa', 'Ogólne oglêdziny otrzymanego produktu'),
	('Badanie twardoœci', 'Dokonaæ pomiaru twardoœci badanego produktu'),
	('Badanie chropowatoœci', 'Okreœliæ chropowatoœæ uzyskanej powierzchni'),
	('Wytrzyma³oœciowa', 'Poddaæ produkt obci¹¿eniu próbnemu');

INSERT INTO Slownik_stanowisko (Nazwa_stanowiska)
	VALUES
	('Stanowisko do drukowania'),
	('Stanowisko do podwozia'),
	('Stanowisko blacharskie'),
	('Stanowisko do klejenia'),
	('Stanowisko do szlifowania'),
	('Stanowisko do ³¹czenia pó³produktów'),
	('Stanowisko do lakierowania'),
	('Stanowisko do projektowania'),
	('Stanowisko do obróbki');

INSERT INTO Produkt (Nazwa_produkt)
	VALUES
	('Lampa'),							--1
	('Zderzak przedni'),				--2
	('Tapicerka samochodowa'),			--3
	('Kokpit'),							--4
	('Fotel'),							--5
	('Fotel M'),						--6	
	('Kierownica'),						--7
	('Kierownica M'),					--8
	('Zderzak przedni M'),				--9
	('Zderzak tylny'),					--10
	('Zderzak tylny M'),				--11
	('Szyba przednia'),					--12		
	('Listwa M'),						--13
	('Silnik 320'),						--14
	('Silnik 325'),						--15
	('Silnik 320d'),					--16
	('Silnik 520'),						--17
	('Silnik 525'),						--18
	('Silnik 530'),						--19
	('Silnik 520d'),					--20
	('Silnik 530d'),					--21
	('Skrzynia automat'),				--22
	('Skrzynia manual'),				--23
	('Karoseria');						--24

INSERT INTO Slownik_polprodukt (Nazwa)
	VALUES
	('Uchwyt zasilacza'),				--1
	('Wa³ czynny'),						--2
	('Wa³ bierny'),						--3
	('Obudowa fotela'),					--4
	('Mocowanie silnika 5**'),			--5
	('Mocowanie silnika 3**'),			--6
	('Œlizgi zderzaka pzrzód'),			--7
	('Œlizgi zderzaka pzrzód M'),		--8
	('Œlizgi zderzaka ty³'),			--9
	('Œlizgi zderzaka ty³ M'),			--10
	('Mocowanie ch³odzenia'),			--11
	('¯arówka'),						--12
	('Odb³yœnik'),						--13
	('Maskownica do kabli'),			--14
	('Grill zderzaka przód'),			--15
	('Grill zderzaka przód M'),			--16
	('Skóra'),							--17
	('Wyœwietlacz'),					--18
	('Listwa fotela M');				--19

INSERT INTO Sklad_produkt (ID_produkt, ID_polprodukt, Ilosc)
	VALUES
	(1,12,2),
	(1,13,1),
	(2,7,4),
	(2,15,1),
	(3,3,1),
	(4,18,2),
	(4,14,5),
	(5,4,2),
	(5,17,1),
	(6,4,2),
	(6,17,1),
	(6,19,1),
	(9,8,4),
	(9,16,1),
	(10,9,4),
	(11,10,4),
	(14,6,4),
	(14,11,1),
	(14,14,4),
	(15,6,4),
	(15,11,1),
	(15,14,4),
	(16,6,4),
	(16,11,1),
	(16,14,4),
	(17,5,4),
	(17,11,1),
	(17,14,4),
	(18,5,4),
	(18,11,1),
	(18,14,4),
	(19,5,4),
	(19,11,1),
	(19,14,4),
	(20,5,4),
	(20,11,1),
	(20,14,4),
	(21,5,4),
	(21,11,1),
	(21,14,4);

INSERT INTO Narzedzie (Nazwa_narzedzie)
	VALUES
	('Œrubokrêt p³aski'),
	('Kombinerki'),
	('Nó¿'),
	('No¿yczki'),
	('Suwmiarka'),
	('Klucz francuski');

INSERT INTO Rodzaj_material (Nazwa_rodzaj_material)
	VALUES
	('Stal'),
	('Tekstylia'),
	('Tworzywo sztuczne'),
	('Klej');

INSERT INTO Rodzaj_maszyna (Nazwa_rodzaj_maszyna, Opis)
	VALUES
	('Robot MZP','Monta¿ zderzaków przód'),
	('Robot MZT','Monta¿ zderzaków ty³'),
	('Robot MK','Monta¿ kierownicy i kokpitu'),
	('Prasa',NULL),
	('Drukarka 3D','Drukowanie przy wykorzystaniu technolgii 3D'),
	('Odlewnia','Odlew produktów z ABS'),
	('Spawarka MIG', NULL),
	('Drukarka laserowa','Laserowa'),
	('PC','Komputer stacjonarny'),
	('Szlifierka', NULL);

INSERT INTO Rodzaj_czesc (Nazwa_rodzaj_czesc)
	VALUES
	('Ramiê robota'),
	('Rama'),
	('Platforma robocza'),
	('Si³ownik robota'),
	('Kolo zebate'),
	('Silnik krokowy'),
	('Stolik obrotowy'),
	('Chwytak'),
	('Prasa'),
	('Glowica lasera'),
	('Ekran LCD'),
	('Wentylator'),
	('Drut spawarki');

INSERT INTO Rodzaj_obsluga(Nazwa_rodzaj_obsluga)
	VALUES
	('Wymiana czesci'),
	('Czyszczenie'),
	('Kontrola stanu'),
	('Kalibracja'),
	('Smarowanie');

INSERT INTO Status_zamowienie(Nazwa_status)
	VALUES
	('Zamowiono'),
	('W trakcie realizacji'),
	('Dostarczono'),
	('Odebrano');

INSERT INTO Jednostka (Nazwa_jednostka, Skrot)
	VALUES
	('Milimetr','mm'),
	('Gram','g'),
	('Megapascal','MPa'),
	('Sekunda','s'),
	('Gram na centymetr szescienny','g/cm3'),
	('Stopien Celsjusza','oC'),
	('Decybel','dB'),
	('Metr na sekunde do kwadratu','m/s2'),
	('Wat','W'),
	('Metr szeœcienny', 'm3');

INSERT INTO Rodzaj_parametr (Nazwa_rodzaj_parametr, ID_Jednostka)
	VALUES
	('Gêstoœæ',5),
	('D³ugoœæ',1),
	('Szerokoœæ',1),
	('Œrednica',1),
	('Masa',2),
	('Wytrzyma³oœæ na rozci¹ganie', 3),
	('Wytrzyma³oœæ na skrêcanie', 3),
	('Modu³ Younga',3),
	('Szerokoœæ szczeliny',1),
	('G³oœnoœæ pracy',7),
	('Prêdkoœæ obróbki', 8),
	('Prêdkoœæ przejazdów ja³owych', 8),
	('Temperatura',6),
	('Maksymalny pobór mocy',9),
	('Pojemnoœæ', 10),
	('Noœnoœæ', 2);

INSERT INTO Parametr_produkt(ID_produkt, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
	VALUES
	(1,13,35,55),
	(2,6,100,105),
	(3,1,5,7),
	(4,13,-50,50),
	(5,5,2500,3000),
	(6,5,2000,2500),
	(7,4,450,451),
	(8,4,445,446),
	(9,13,30,40),
	(10,13,35,55),
	(11,13,30,35),
	(12,5,30000,35000),
	(13,5,40,42),
	(13,2,40,41),
	(13,3,10,11),
	(14,13,95,100);


INSERT INTO Parametr_polprodukt (ID_polprodukt, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
	VALUES
	(4,5,45,50),
	(7,6,60,63),
	(8,6,60,61),
	(9,6,60,63),
	(10,6,60,61),
	(15,5,400,410),
	(16,5,350,355);


INSERT INTO Material (ID_rodzaj_material, Nazwa_material)
	VALUES
	(1,'HSLA'),
	(1,'BH'),
	(1,'Aluminium'),
	(3,'ABS'),
	(3,'Guma'),
	(3,'Polipropylen'),
	(3,'Poliretan'),
	(2,'Welur'),
	(2,'Skóra'),
	(4,'Klej STRONG');

INSERT INTO Sklad_polprodukt (ID_polprodukt, ID_material, Ilosc)
	VALUES
	(1,4,20),
	(2,3,1500),
	(3,3,2000),
	(4,4,200),
	(5,3,35000),
	(6,3,30000),
	(7,4,50),
	(8,4,50),
	(9,4,50),
	(10,4,50),
	(11,4,50),
	(14,4,45);

INSERT INTO Sklad_produkt_material (ID_produkt, ID_material, Ilosc_g)
VALUES
	(2,6,5000),
	(2,7,300),
	(3,9,100),
	(5,8,1500),
	(6,9,1000),
	(7,9,1000),
	(7,7,1000),
	(8,9,1200),
	(8,7,1200);

INSERT INTO Czesc (Nazwa_czesc, ID_rodzaj_czesc)
	VALUES
	('Kolo zebate fi60',5),
	('Rama i3',2),
	('Rama i5',2),
	('Stol i3',3),
	('Stolik Shining', 3),
	('Rama ZX5',2),
	('Glowica End5',4),
	('Stol End5',3),
	('Ekran LG',11),
	('Ekran HP',11),
	('Wentylator IDZ',12),
	('Silnik krokowy KROK',6),
	('Glowica lasera LG', 10);

INSERT INTO Rodzaj_umowy (Nazwa, Urlop)
	VALUES
	('Umowa o pracê',26),
	('Umowa zlecenie',0),
	('Umowa o dzie³o',0);

INSERT INTO Rodzaj_nieobecnosci (Symbol, Procent_wynagrodzenia)
	VALUES
	('UW',0),
	('CH',-0.2),
	('NB',-1.0);

INSERT INTO Nieobecnosc (ID_pracownik, ID_rodzaj_nieobecnosci, Data_od, Data_do)
	VALUES
	(1,1,'2022-04-11','2022-04-24'),
	(2,2,'2022-04-12','2022-04-16'),
	(3,2,'2022-04-18','2022-04-19'),
	(4,2,'2022-04-13','2022-04-14'),
	(5,3,'2022-04-13','2022-04-19'),
	(6,2,'2022-04-13','2022-04-15'),
	(7,1,'2022-04-13','2022-04-15'),
	(8,1,'2022-04-13','2022-04-15'),
	(9,1,'2022-04-13','2022-04-15'),
	(10,1,'2022-04-13','2022-04-15');

INSERT INTO Stanowisko_pracownik (ID_stanowisko, ID_pracownik)							
	VALUES
	(1,8),
	(2,4),
	(3,6),
	(4,7),
	(5,2),
	(6,1),
	(7,9),
	(8,3),
	(9,10),
	(10,5),
	(11,11),
	(11,20),
	(12,21),
	(13,22),
	(14,13),
	(15,13),
	(16,14),
	(17,11);
	
INSERT INTO Umowa (ID_rodzaj_umowy, ID_stanowisko_pracownik, Data_od)
	VALUES
	(1,1,'2021-04-11'),
	(1,2,'2022-01-11'),
	(1,3,'2022-04-15'),
	(2,4,'2022-03-02'),
	(1,5,'2022-01-17'),
	(2,6,'2021-01-01'),
	(1,7,'2021-01-11'),
	(2,8,'2022-05-11'),
	(2,9,'2021-08-11'),
	(1,10,'2022-07-11'),
	(1,11,'2022-02-11'),
	(1,12,'2022-01-11'),
	(1,13,'2022-03-11'),
	(1,14,'2022-02-11'),
	(1,15,'2021-06-11'),
	(1,16,'2022-04-11'),
	(1,17,'2021-05-11'),
	(1,10,'2022-03-11'),
	(1,5,'2022-01-11'),
	(1,10,'2022-01-11'),
	(1,11,'2022-02-11'),
	(1,12,'2022-01-11'),
	(1,2,'2021-06-11');

INSERT INTO Maszyna (Nazwa_maszyna, ID_rodzaj_maszyna, Koszt_RBG)
	VALUES
	('BOSCH ZP1',1,25),
	('BOSCH ZT1',2,20),
	('ABB K2',3,27),
	('PRP 4',2,35),
	('Creality Ender-5 Pro',5,32),
	('Macbook PRO M1',9,5),
	('Szlifierka Fiberfox',10,30);

INSERT INTO Nr_seryjny (Nr_seryjny)
	VALUES
	('000-001'),
	('000-002'),
	('000-003'),
	('000-004'),
	('000-005'),
	('000-006'),
	('000-007'),
	('000-008'),
	('000-009'),
	('000-010'),
	('000-011'),
	('000-012'),
	('000-013'),
	('000-014'),
	('000-015'),
	('000-016'),
	('000-017'),
	('000-018'),
	('000-019'),
	('000-020'),
	('000-021'),
	('000-022'),
	('000-023'),
	('000-024'),
	('000-025'),
	('000-026'),
	('000-027'),
	('000-028'),
	('000-029');

INSERT INTO Maszyna_nr_seryjny (ID_maszyna, ID_nr_seryjny)
	VALUES
	(1,1),
	(2,2),
	(3,3),
	(4,4),
	(5,5),
	(6,6),
	(7,7),
	(1,8),
	(2,9),
	(3,10),
	(4,11),
	(5,12),
	(6,13),
	(7,14),
	(1,15),
	(2,16),
	(3,17),
	(4,18),
	(5,19),
	(6,20),
	(7,21),
	(1,22),
	(2,23),
	(3,24),
	(4,25),
	(5,26),
	(6,27),
	(7,28),
	(1,29);

INSERT INTO Stanowisko_produkcyjne (ID_nazwa_stanowiska)
	VALUES
	(2),		--podwozie
	(1),		--drukowanie
	(4),		--klejenie
	(5),		--szlifowanie
	(6),		--³¹czenie
	(7),		--lakierowanie
	(8),		--projektowanie
	(1),		--drukowanie
	(2),		--podwozie
	(1),		--drukowanie
	(4),		--klejenie
	(7),		--lakierowanie
	(8);		--projektowanie

INSERT INTO Sklad_stanowisko_produkcyjne_maszyna (ID_stanowisko_produkcyjne, ID_maszyna_nr)
	VALUES
	(1,6),
	(1,1),
	(2,13),
	(2,12),
	(3,13),
	(3,12),
	(4,7),
	(5,3),
	(5,7),
	(6,13),
	(6,12),
	(8,13),
	(8,12);


INSERT INTO Sklad_stanowisko_produkcyjne_narzedzie (ID_stanowisko_produkcyjne, ID_narzedzie, Ilosc)
	VALUES
	(3,1,5),
	(3,3,2),
	(2,5,1),
	(1,4,1),
	(4,3,3),
	(2,1,5),
	(3,4,1),
	(4,2,1),
	(5,2,2),
	(9,2,3),
	(9,5,2),
	(9,6,1);

INSERT INTO Marka_pojazd_slownik (Nazwa)
	VALUES
	('BMW');

INSERT INTO Model_pojazd_slownik (Nazwa, Rok_produkcji_od, Rok_produkcji_do)
	VALUES
	('5', 2016, 2022),
	('7', 2018, 2022),
	('3', 2015, 2023);

INSERT INTO Marka_model (ID_marka_pojazd, ID_model_pojazd)
	VALUES
	(1,1),
	(1,2),
	(1,3);

	INSERT INTO Typ_pojazd_slownik (Nazwa_typ)
	VALUES
	('520'),
	('525'),
	('530'),
	('520d'),
	('320'),
	('320d');

INSERT INTO Typ_pojazd_model (ID_marka_model, ID_typ_pojazd)
	VALUES
	(1,1),
	(1,2),
	(1,3),
	(1,4),
	(3,6),
	(3,5);

INSERT INTO Typ_pojazd_model_silnik (ID_typ_pojazd_model, ID_produkt)
	VALUES
	(1,17),
	(2,18),
	(3,19),
	(4,20),
	(5,16),
	(6,14);

INSERT INTO Pojazd (Nr_VIN, Rok_produkcji)
	VALUES
	('AXZEB45698745',2022),
	('AXZEE45998745',2022),
	('AXZEH45204745',2022),
	('AXZEJ12478745',2022),
	('AXZEK54748745',2022),
	('AXZEM45695487',2022);

INSERT INTO Marka_model_pojazd (ID_typ_pojazd_model, ID_pojazd)
	VALUES
	(1,1),
	(2,2),
	(3,3),
	(4,4),
	(6,5),
	(5,6);

INSERT INTO Wersja_wyposazenia_slownik (Nazwa)
	VALUES
	('Wersja standardowa'),
	('M Pakiet'),
	('Luxury');

INSERT INTO Wersja_wyposazenia_produkt (ID_wersja_wyposazenia, ID_produkt, Ilosc)
	VALUES
	(1,2,1),
	(1,5,4),
	(1,7,1),
	(1,10,1),
	(2,9,1),
	(2,11,1),
	(2,8,1),
	(2,6,4);

	INSERT INTO Wersja_wyposazenia_pojazd (ID_wersja_wyposazenia, ID_pojazd)
	VALUES
	(1,1),
	(1,2),
	(1,3),
	(2,4),
	(1,5),
	(1,6);
	
INSERT INTO Proces_polprodukt_czynnosc (ID_polprodukt, ID_czynnosc_produkcyjna,ID_stanowisko_produkcyjne, Czas_trwania)
	VALUES
	(1,1,7,10),			--Przygotowanie stanowiska	--8.Stanowisko do projektowania
	(1,3,7,15),	 		--Projektowanie				--8.Stanowisko do projektowania
	(1,9,2,360),		--Drukowanie				--1.Stanowisko do drukowania
	(1,6,2,30),			--Szlifowanie				--5.Stanowisko do szlifowania
	(4,3,7,120),		--Projektowanie				--8.Stanowisko do projektowania
	(4,1,1,15),			--Przygotowanie stanowiska	--1.Stanowisko do drukowania	
	(4,4,1,300),		--Drukowanie				--1.Stanowisko do drukowania SLS
	(4,7,6,30),			--Lakierowanie				--7.Stanowisko do lakierowania
	(7,3,6,120),		--Projektowanie				--8.Stanowisko do projektowania
	(7,1,1,15),			--Przygotowanie stanowiska	--1.Stanowisko do drukowania
	(7,9,1,360),		--Drukowanie				--3.Stanowisko do drukowania
	(7,7,3,30),		--Lakierowanie				--5.Stanowisko do lakierowania
	(15,3,3,120),		--Projektowanie				--8.Stanowisko do projektowania
	(15,1,8,15),		--Przygotowanie stanowiska	--1.Stanowisko do drukowania
	(15,9,8,360),		--Drukowanie				--3.Stanowisko do drukowania
	(15,7,12,30),		--Lakierowanie				--5.Stanowisko do lakierowania
	(9,3,7,120),		--Projektowanie				--8.Stanowisko do projektowania
	(9,1,1,15),			--Przygotowanie stanowiska	--1.Stanowisko do drukowania
	(9,9,1,360),		--Drukowanie				--3.Stanowisko do drukowania
	(9,7,12,30),		--Lakierowanie				--5.Stanowisko do lakierowania
	(8,3,7,120),		--Projektowanie				--8.Stanowisko do projektowania
	(8,1,7,15),			--Przygotowanie stanowiska	--1.Stanowisko do drukowania
	(8,9,7,360),		--Drukowanie				--3.Stanowisko do drukowania
	(8,7,12,30),		--Lakierowanie				--5.Stanowisko do lakierowania
	(16,1,7,10),		--Przygotowanie stanowiska	--8.Stanowisko do projektowania
	(16,3,7,15),	 	--Projektowanie				--8.Stanowisko do projektowania
	(16,9,1,360),		--Drukowanie				--1.Stanowisko do drukowania
	(16,6,4,30),		--Szlifowanie				--5.Stanowisko do szlifowania
	(10,1,7,10),		--Przygotowanie stanowiska	--8.Stanowisko do projektowania
	(10,3,7,15),	 	--Projektowanie				--8.Stanowisko do projektowania
	(10,9,1,360),		--Drukowanie				--1.Stanowisko do drukowania
	(10,6,4,30),		--Szlifowanie				--5.Stanowisko do szlifowania
	(17,8,4,60);		--klejenie

INSERT INTO Proces_produkt_czynnosc (ID_produkt, ID_czynnosc_produkcyjna,ID_stanowisko_produkcyjne, Czas_trwania)
	VALUES
	(1,8,3,15),			--Klejenie		--4.Stanowisko do klejenia
	(1,10,5,20),		--Monta¿		--6.Stanowisko do ³¹czenia
	(2,4,5,30),			--£¹czenie		--6.
	(2,10,5,20),		--Monta¿		--6.
	(4,10,5,30),		--Monta¿		--6.
	(5,10,5,15),		--Monta¿		--6.
	(10,10,5,30),		--Monta¿		--6.
	(9,10,5,35),		--£¹czenie		--6.
	(9,10,5,35),		--Monta¿		--6.
	(11,10,5,40),		--Monta¿		--6.
	(7,10,5,30),		--Monta¿		--6.
	(8,10,5,30);		--Monta¿		--6.

INSERT INTO Dostawca (Nazwa_dostawca)
	VALUES
	('BOSCH'),
	('VALEO'),
	('CHEVROLET'),
	('Motex'),
	('Polrad');

INSERT INTO Producent (Nazwa_producenta)
	VALUES
	('BOSCH'),
	('VALEO'),
	('CHEVROLET'),
	('SACHS'),
	('OSRAM'),
	('Apple'),
	('Fiberfox');

INSERT INTO Parametr_material (ID_material, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
	VALUES
	(1,1,4,4),
	(2,1,1.75,1.75),
	(5,6,1.75,1.75),
	(10,13,-50,350),
	(3,1,1.75,1.75);

INSERT INTO Klient (Nazwisko, Imie, NIP, Miejscowosc, Ulica, Nr_budynek, Nr_lokal, Kod_pocztowy, Numer_telefonu, Email) --UZUPE£NIÆ DALEJ
	VALUES 
	('Marczak', 'Marek', NULL, 'Warszawa', 'Sasankowa', 45, 2, '01-144', '652152045', 'marczak.marek@gmail.com'),
	('Adamiak', 'Adam', NULL, 'Wo³omin', 'Œwiêtokrzyska', 4, 25, '05-124', '652654045', 'adamiak.adamk@gmail.com'),
	('Nowak', 'Karol', NULL, 'Warszawa', 'D³uga', 5, NULL, '02-178', '669812045', 'karol.nowakk@gmail.com'),
	('Kowalski', 'Jan', NULL, 'Warszawa', 'Krêta', 12, 5, '03-155', '695232045', 'kowalski.jan@gmail.com'),
	('Lewandowski', 'Robert', NULL, 'Warszawa', 'Wojska Polskiego', 3, NULL, '01-145', '562348956', 'robert.lewandowski@gmail.com');

INSERT INTO Typ_zamowienie (Rodzaj_zamowienie)
	VALUES
	('Zamówienie wewnêtrzne'),
	('Zamówienie zewnêtrzne');

INSERT INTO Gwarancja (Okres_gwarancja, Opis_gwarancja)
	VALUES 
	(2, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 2 LAT'),
	(1, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 1 ROKU'),
	(3, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 3 LAT'),
	(4, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 4 LAT'),
	(5, 'GWARANCJA NA USZKODZENIA MECHANICZNE NA OKRES 5 LAT');

INSERT INTO Zamowienie (ID_klient, ID_pracownik, Data_zamowienie, ID_typ_zamowienie)
	VALUES
	(1, 1, '2022-04-04', 1),
	(2, 2, '2022-04-05', 1),
	(3, 2, '2022-04-06', 1),
	(4, 3, '2022-04-07', 1),
	(5, 4, '2022-04-08', 1);

INSERT INTO Zamowienie_szczegol (ID_zamowienie, ID_produkt, ID_gwarancja, Ilosc)
	VALUES
	(1, 2, 1, 50),
	(1, 10, 2, 50),
	(2, 9, 4, 30),
	(2, 11, 5, 30),
	(3, 5, 1, 60),
	(4, 7, 2, 60),
	(5, 8, 3, 60);

INSERT INTO Parametr_czesc (ID_czesc, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
	VALUES
	(1,5,50,60),
	(1,4,0.36,0.44),
	(2,4,59,61), 
	(2,5,540,580),
	(3,2,350,350), 
	(3,3,35,40),
	(4,5,200,200), 
	(4,10,10,30),
	(5,2,300,300),
	(5,3,290,290),
	(6,7,30,40),
	(6,11,450,450),
	(7,5,400,400),
	(7,4,60,60),
	(8,4,60,60),
	(8,5,300,300),
	(9,2,400,400), 
	(9,3,50,50),
	(10,5,300,300), 
	(10,10,10,30),
	(11,2,330,330),
	(11,3,300,300),
	(12,2,200,2000),
	(12,3,50,50),
	(13,2,60,60), 
	(13,3,60,60);

INSERT INTO Parametr_narzedzie (ID_narzedzie, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
	VALUES
	(1,4,19,21),
	(2,5,3500,3600),
	(3,2,15,15),
	(4,2,13,13),
	(5,2,20,20);

INSERT INTO Parametr_maszyna (ID_maszyna, ID_rodzaj_parametr, Zakres_dol, Zakres_gora)
	VALUES
	(1,7,30,40),
	(1,8,10,100),
	(1,9,200,200),
	(1,10,10,40),
	(2,5,20000,20000),
	(2,7,20,25),
	(2,10,15,25),
	(2,11,1000,1000),
	(3,5,150000,150000),
	(3,7,10,15),
	(3,10,10,40),
	(3,11,2000,2000),
	(4,5,15000,15000),
	(4,7,10,20),
	(4,10,15,25),
	(4,11,700,700),
	(5,7,50,60),
	(5,8,10,100),
	(5,9,200,200),
	(5,10,10,30);

INSERT INTO Zamowienie_material(ID_pracownik, Data_zamowienia, ID_dostawca)
	VALUES
	(14,'2022-04-16',1),
	(14,'2022-04-16',2),
	(14,'2022-04-16',3),
	(14,'2022-04-16',4),
	(14,'2022-04-16',5),
	(14,'2022-04-19',1),
	(14,'2022-04-20',4),
	(14,'2022-04-20',1),
	(14,'2022-04-20',2);

INSERT INTO Stan_realizacji_zamowienie_material(ID_zamowienie_material, ID_status_zamowienie, Data_stan, ID_pracownik)
	VALUES
	(1,1,'2022-04-16 09:10:00',14),
	(2,1,'2022-04-16 09:20:00',14),
	(3,1,'2022-04-16 09:30:00',14),
	(4,1,'2022-04-16 09:40:00',14),
	(5,1,'2022-04-16 09:50:00',14),
	(1,2,'2022-04-17 08:40:00',14),
	(2,2,'2022-04-17 09:10:00',14),
	(3,2,'2022-04-17 09:30:00',14),
	(4,2,'2022-04-17 10:10:00',14),
	(5,2,'2022-04-17 11:10:00',14),
	(1,3,'2022-04-18 08:30:00',15),
	(2,3,'2022-04-18 12:10:00',18),
	(3,3,'2022-04-18 12:30:00',19),
	(4,3,'2022-04-18 13:10:00',15),
	(5,3,'2022-04-18 13:40:00',19),
	(1,4,'2022-04-19 08:30:00',18),
	(2,4,'2022-04-19 09:10:00',19),
	(3,4,'2022-04-19 10:10:00',18),
	(4,4,'2022-04-19 11:40:00',15),
	(5,4,'2022-04-19 12:10:00',19),
	(6,1,'2022-04-19 12:48:51',14),
	(6,2,'2022-04-19 13:21:21',14),
	(6,3,'2022-04-19 14:21:21',19),
	(6,4,'2022-04-19 15:21:21',18),
	(7,1,'2022-04-20 08:48:51',14),
	(7,2,'2022-04-20 10:21:21',14),
	(7,3,'2022-04-20 11:21:21',19),
	(7,4,'2022-04-20 12:21:21',18),
	(8,1,'2022-04-21 09:48:51',14),
	(8,2,'2022-04-21 10:21:21',14),
	(9,1,'2022-04-21 11:45:33',14),
	(9,2,'2022-04-21 12:12:14',14),
	(9,3,'2022-04-21 13:37:35',15),
	(9,4,'2022-04-21 14:15:28',18);

INSERT INTO Szczegoly_zamowienie_material(ID_zamowienie_material, ID_material, ID_producent, Waga_g, Cena)
	VALUES
	(1,1,3,15000,3400),
	(2,2,2,20000,1650),
	(3,3,2,15000,1000),
	(4,4,5,25000,2000),
	(5,5,5,45000,3200),
	(6,6,1,20500,2500),
	(7,7,2,10000,1100),
	(8,3,1,28000,1700),
	(9,8,4,7000,310);

INSERT INTO Zamowienie_czesc(ID_pracownik, Data_zamowienia, ID_dostawca)
	VALUES
	(14,'2022-04-17',4),
	(14,'2022-04-17',2),
	(14,'2022-04-17',1),
	(14,'2022-04-17',3),
	(14,'2022-04-17',5),
	(14,'2022-04-20',1);

INSERT INTO Stan_realizacji_zamowienie_czesc(ID_zamowienie_czesc, ID_status_zamowienie, Data_stan, ID_pracownik)
	VALUES
	(1,1,'2022-04-17 08:10:00',14),
	(2,1,'2022-04-17 09:11:00',14),
	(3,1,'2022-04-17 09:45:00',14),
	(4,1,'2022-04-17 10:40:00',14),
	(5,1,'2022-04-17 10:50:00',14),
	(1,2,'2022-04-18 09:40:00',14),
	(2,2,'2022-04-18 09:50:00',14),
	(3,2,'2022-04-18 10:30:00',14),
	(4,2,'2022-04-18 11:10:00',14),
	(5,2,'2022-04-18 11:30:00',14),
	(1,3,'2022-04-19 08:30:00',18),
	(2,3,'2022-04-19 09:10:00',15),
	(3,3,'2022-04-19 09:30:00',19),
	(4,3,'2022-04-19 10:10:00',19),
	(5,3,'2022-04-19 10:40:00',15),
	(1,4,'2022-04-20 08:30:00',18),
	(2,4,'2022-04-20 09:10:00',18),
	(3,4,'2022-04-20 09:16:00',19),
	(4,4,'2022-04-20 10:14:00',15),
	(5,4,'2022-04-20 11:10:00',18),
	(6,1,'2022-04-20 12:43:51',14);

INSERT INTO Szczegoly_zamowienie_czesc(ID_zamowienie_czesc, ID_czesc, ID_producent, Ilosc, Cena)
	VALUES
	(1,1,1,1,500),
	(2,5,4,2,50),
	(3,7,5,1,7000),
	(4,8,2,1,1700),
	(5,10,3,3,1300),
	(6,3,1,5,1200);


INSERT INTO Zamowienie_narzedzie(ID_pracownik, Data_zamowienia, ID_dostawca)
	VALUES
	(14,'2022-04-17',1),
	(14,'2022-04-17',3),
	(14,'2022-04-17',5),
	(14,'2022-04-17',4),
	(14,'2022-04-17',2),
	(14,'2022-04-17',3),
	(14,'2022-04-20',1);

INSERT INTO Stan_realizacji_zamowienie_narzedzie(ID_zamowienie_narzedzie, ID_status_zamowienie, Data_stan, ID_pracownik)
	VALUES
	(1,1,'2022-04-17 08:17:00',14),
	(2,1,'2022-04-17 09:25:00',14),
	(3,1,'2022-04-17 10:15:00',14),
	(4,1,'2022-04-17 10:40:00',14),
	(5,1,'2022-04-17 10:48:00',14),
	(6,1,'2022-04-17 10:57:00',14),
	(1,2,'2022-04-18 09:12:00',14),
	(2,2,'2022-04-18 09:15:00',14),
	(3,2,'2022-04-18 09:37:00',14),
	(4,2,'2022-04-18 10:04:00',14),
	(5,2,'2022-04-18 10:21:00',14),
	(6,2,'2022-04-18 10:45:00',14),
	(1,3,'2022-04-19 08:22:00',18),
	(2,3,'2022-04-19 08:55:00',15),
	(3,3,'2022-04-19 09:29:00',19),
	(4,3,'2022-04-19 10:01:00',19),
	(5,3,'2022-04-19 10:23:00',15),
	(6,3,'2022-04-19 10:55:00',18),
	(1,4,'2022-04-20 08:38:00',19),
	(2,4,'2022-04-20 09:17:00',18),
	(3,4,'2022-04-20 09:48:00',19),
	(4,4,'2022-04-20 10:18:00',15),
	(5,4,'2022-04-20 11:14:00',18),
	(6,4,'2022-04-20 11:58:00',15),
	(7,1,'2022-04-20 12:17:00',14),
	(7,2,'2022-04-20 13:51:00',14),
	(7,3,'2022-04-21 14:11:00',18);

INSERT INTO Szczegoly_zamowienie_narzedzie(ID_zamowienie_narzedzie, ID_narzedzie, ID_producent, Sztuk, Cena)
	VALUES
	(1,1,1,15,65),
	(2,2,4,15,150),
	(3,3,5,11,240),
	(4,4,2,13,520),
	(5,5,3,18,450),
	(6,6,1,14,420),
	(7,1,3,2,10);

INSERT INTO Zamowienie_maszyna(ID_pracownik, Data_zamowienia, ID_dostawca)
	VALUES
	(14,'2022-04-18',1),
	(14,'2022-04-18',3),
	(14,'2022-04-18',5),
	(14,'2022-04-18',4),
	(14,'2022-04-18',2),
	(14,'2022-04-18',1),
	(14,'2022-04-18',3),
	(14,'2022-04-18',5),
	(14,'2022-04-18',4),
	(14,'2022-04-18',2),
	(14,'2022-04-18',1),
	(14,'2022-04-18',3),
	(14,'2022-04-18',5),
	(14,'2022-04-18',4),
	(14,'2022-04-18',2),
	(14,'2022-04-18',1),
	(14,'2022-04-18',3),
	(14,'2022-04-18',5),
	(14,'2022-04-18',4),
	(14,'2022-04-18',2),
	(14,'2022-04-18',1),
	(14,'2022-04-18',3),
	(14,'2022-04-18',5),
	(14,'2022-04-18',4),
	(14,'2022-04-18',2),
	(14,'2022-04-18',1),
	(14,'2022-04-18',3),
	(14,'2022-04-18',5),
	(14,'2022-04-21',2);

INSERT INTO Stan_realizacji_zamowienie_maszyna(ID_zamowienie_maszyna, ID_status_zamowienie, Data_stan, ID_pracownik)
	VALUES
	(1,1,'2022-04-18 08:17:00',14),
	(2,1,'2022-04-18 09:03:00',14),
	(3,1,'2022-04-18 09:15:00',14),
	(4,1,'2022-04-18 09:31:00',14),
	(5,1,'2022-04-18 09:43:00',14),
	(6,1,'2022-04-18 09:51:00',14),
	(7,1,'2022-04-18 10:01:00',14),
	(8,1,'2022-04-18 10:13:00',14),
	(9,1,'2022-04-18 10:21:00',14),
	(10,1,'2022-04-18 10:34:00',14),
	(11,1,'2022-04-18 10:39:00',14),
	(12,1,'2022-04-18 10:51:00',14),
	(13,1,'2022-04-18 11:02:00',14),
	(14,1,'2022-04-18 10:13:00',14),
	(15,1,'2022-04-18 10:20:00',14),
	(16,1,'2022-04-18 10:24:00',14),
	(17,1,'2022-04-18 10:29:00',14),
	(18,1,'2022-04-18 10:37:00',14),
	(19,1,'2022-04-18 10:48:00',14),
	(20,1,'2022-04-18 10:56:00',14),
	(21,1,'2022-04-18 11:04:00',14),
	(22,1,'2022-04-18 11:16:00',14),
	(23,1,'2022-04-18 11:21:00',14),
	(24,1,'2022-04-18 11:32:00',14),
	(25,1,'2022-04-18 11:44:00',14),
	(26,1,'2022-04-18 12:01:00',14),
	(27,1,'2022-04-18 12:09:00',14),
	(28,1,'2022-04-18 12:18:00',14),
	(1,2,'2022-04-19 08:17:00',14),
	(2,2,'2022-04-19 09:03:00',14),
	(3,2,'2022-04-19 09:15:00',14),
	(4,2,'2022-04-19 09:31:00',14),
	(5,2,'2022-04-19 09:43:00',14),
	(6,2,'2022-04-19 09:51:00',14),
	(7,2,'2022-04-19 10:02:00',14),
	(8,2,'2022-04-19 10:14:00',14),
	(9,2,'2022-04-19 10:22:00',14),
	(10,2,'2022-04-19 10:35:00',14),
	(11,2,'2022-04-19 10:42:00',14),
	(12,2,'2022-04-19 10:53:00',14),
	(13,2,'2022-04-19 11:01:00',14),
	(14,2,'2022-04-19 10:15:00',14),
	(15,2,'2022-04-19 10:26:00',14),
	(16,2,'2022-04-19 10:28:00',14),
	(17,2,'2022-04-19 10:31:00',14),
	(18,2,'2022-04-19 10:38:00',14),
	(19,2,'2022-04-19 10:43:00',14),
	(20,2,'2022-04-19 10:51:00',14),
	(21,2,'2022-04-19 11:02:00',14),
	(22,2,'2022-04-19 11:11:00',14),
	(23,2,'2022-04-19 11:23:00',14),
	(24,2,'2022-04-19 11:37:00',14),
	(25,2,'2022-04-19 11:44:00',14),
	(26,2,'2022-04-19 12:51:00',14),
	(27,2,'2022-04-19 12:58:00',14),
	(28,2,'2022-04-19 13:03:00',14),
	(1,3,'2022-04-20 08:17:00',15),
	(2,3,'2022-04-20 09:03:00',18),
	(3,3,'2022-04-20 09:15:00',19),
	(4,3,'2022-04-20 09:31:00',19),
	(5,3,'2022-04-20 09:43:00',18),
	(6,3,'2022-04-20 09:51:00',15),
	(7,3,'2022-04-20 10:01:00',15),
	(8,3,'2022-04-18 10:13:00',18),
	(9,3,'2022-04-20 10:21:00',19),
	(10,3,'2022-04-20 10:34:00',15),
	(11,3,'2022-04-20 10:39:00',19),
	(12,3,'2022-04-20 10:51:00',18),
	(13,3,'2022-04-20 11:02:00',18),
	(14,3,'2022-04-20 10:13:00',15),
	(15,3,'2022-04-20 10:20:00',19),
	(16,3,'2022-04-20 10:24:00',15),
	(17,3,'2022-04-20 10:29:00',19),
	(18,3,'2022-04-20 10:37:00',18),
	(19,3,'2022-04-20 10:48:00',18),
	(20,3,'2022-04-20 10:56:00',19),
	(21,3,'2022-04-20 11:04:00',15),
	(22,3,'2022-04-20 11:16:00',18),
	(23,3,'2022-04-20 11:21:00',18),
	(24,3,'2022-04-20 11:32:00',19),
	(25,3,'2022-04-20 11:44:00',19),
	(26,3,'2022-04-20 12:01:00',15),
	(27,3,'2022-04-20 12:09:00',15),
	(28,3,'2022-04-20 12:18:00',15),
	(1,4,'2022-04-21 08:17:00',15),
	(2,4,'2022-04-21 09:03:00',18),
	(3,4,'2022-04-21 09:15:00',19),
	(4,4,'2022-04-21 09:31:00',19),
	(5,4,'2022-04-21 09:43:00',18),
	(6,4,'2022-04-21 09:51:00',15),
	(7,4,'2022-04-21 10:01:00',15),
	(8,4,'2022-04-21 10:13:00',18),
	(9,4,'2022-04-21 10:21:00',19),
	(10,4,'2022-04-21 10:34:00',15),
	(11,4,'2022-04-21 10:39:00',19),
	(12,4,'2022-04-21 10:51:00',18),
	(13,4,'2022-04-21 11:02:00',18),
	(14,4,'2022-04-21 10:13:00',15),
	(15,4,'2022-04-21 10:20:00',19),
	(16,4,'2022-04-21 10:24:00',15),
	(17,4,'2022-04-21 10:29:00',19),
	(18,4,'2022-04-21 10:37:00',18),
	(19,4,'2022-04-21 10:48:00',18),
	(20,4,'2022-04-21 10:56:00',19),
	(21,4,'2022-04-21 11:04:00',15),
	(22,4,'2022-04-21 11:16:00',18),
	(23,4,'2022-04-21 11:21:00',18),
	(24,4,'2022-04-21 11:32:00',19),
	(25,4,'2022-04-21 11:44:00',19),
	(26,4,'2022-04-21 12:01:00',15),
	(27,4,'2022-04-21 12:09:00',15),
	(28,4,'2022-04-21 12:18:00',15),
	(29,1,'2022-04-21 12:20:00',15),
	(29,2,'2022-04-21 12:52:00',15);

INSERT INTO Szczegoly_zamowienie_maszyna(ID_zamowienie_maszyna, ID_maszyna, ID_producent, Ilosc,Cena)
	VALUES
	(1,1,1,4,14000),
	(2,2,2,1,7000),
	(3,3,3,1,65000),
	(4,4,4,1,2700),
	(5,5,5,1,1649),
	(6,6,6,1,5700),
	(7,7,7,1,2100),
	(8,1,1,1,3500),
	(9,1,1,1,3500),
	(10,1,1,1,3500),
	(11,2,2,1,7000),
	(12,2,2,1,7000),
	(13,2,2,1,7000),
	(14,3,3,1,65000),
	(15,3,3,1,65000),
	(16,3,3,1,65000),
	(17,4,4,1,2700),
	(18,4,4,1,2700),
	(19,4,4,1,2700),
	(20,5,5,1,1649),
	(21,5,5,1,1649),
	(22,5,5,1,1649),
	(23,6,6,1,5700),
	(24,6,6,1,5700),
	(25,6,6,2,11000),
	(26,7,7,1,2100),
	(27,7,7,1,2100),
	(28,7,7,1,2100),
	(29,6,6,2,10600);


INSERT INTO Obsluga(ID_rodzaj_obsluga, ID_stanowisko_produkcyjne, Data_od, Data_do)
	VALUES
	(3,1,'2022-04-20 08:52:31','2022-04-21 12:26:45'),
	(1,2,'2022-04-20 10:01:41',NULL),
	(1,3,'2022-04-21 13:21:15','2021-04-21 14:56:11'),
	(2,5,'2022-04-22 09:08:37','2021-04-23 10:21:57'),
	(3,2,'2022-04-22 11:00:01','2021-04-24 10:33:15'),
	(4,1,'2022-04-22 13:21:15','2022-04-22 14:56:11'),
	(3,1,'2022-04-23 09:08:37','2022-04-23 10:21:57'),
	(2,1,'2022-04-25 13:21:15','2022-04-26 14:56:11'),
	(2,1,'2022-04-30 09:08:37','2021-04-30 10:21:57');

INSERT Obsluga_pracownik (ID_obsluga, ID_pracownik)
	VALUES
	(1,22),
	(2,22),
	(2,21),
	(3,21),
	(4,22),
	(5,21),
	(6,22),
	(7,21),
	(8,22),
	(9,22);

INSERT INTO Sklad_maszyna ( ID_maszyna, ID_czesc, Ilosc_czesci)
	VALUES
	(1,3,3),
	(1,4,1),
	(1,5,1),
	(2,6,1),
	(2,7,1),
	(2,8,1),
	(3,2,1),
	(3,4,4),
	(3,1,4),
	(3,11,1),
	(4,3,4),
	(4,5,1),
	(4,12,4),
	(5,7,3),
	(5,8,1),
	(5,11,1);

INSERT INTO Wytwarzanie (Id_pracownik, Id_zamowienie_szczegol, Czas_od, Czas_do)
	VALUES														--zderzak przedni
	(7,1,'2022-04-04 08:00:00','2022-04-05 13:00:00'), 		--slizgi				
	(2,1,'2022-04-05 08:00:00','2022-04-05 09:15:00'),		--slizgi
	(2,1,'2022-04-05 13:30:00','2022-04-25 01:30:00'),		--slizgi
	(2,1,'2022-04-25 08:00:00','2022-04-26 12:00:00'),		--slizgi
	(8,1,'2022-04-04 08:00:00','2022-04-04 13:00:00'),		--grill
	(2,1,'2022-04-05 08:00:00','2022-04-05 10:15:00'),		--grill
	(2,1,'2022-04-05 11:15:00','2022-04-20 21:00:00'),		--grill
	(2,1,'2022-04-21 08:00:00','2022-04-21 13:00:00'),		--grill
	(7,1,'2022-04-05 11:00:00','2022-04-05 16:00:00'),		--zderzak ³¹czenie
	(2,1,'2022-04-27 12:00:00', NULL),						--zderzak monta¿
				
																--zderzak tylny
	(2,2,'2022-04-07 13:00:00','2022-04-07 16:00:00'), 		--slizgi
	(2,2,'2022-04-08 13:00:00','2022-04-09 16:00:00'),		--slizgi
	(2,2,'2022-04-10 08:00:00','2022-04-10 09:15:00'),  	--slizgi
	(2,2,'2022-04-10 10:15:00','2022-04-18 16:15:00'),		--slizgi
	(2,2,'2022-04-19 08:00:00','2022-04-20 08:30:00'),		--zderzak montaz

																--zderzak przedni M
	(7,3,'2022-04-05 08:00:00','2022-04-07 10:00:00'),		--slizgi
	(3,3,'2022-04-08 02:00:00','2022-04-08 03:15:00'),		--slizgi
	(3,3,'2022-04-08 03:35:00','2022-04-15 12:15:00'), 		--slizgi
	(3,3,'2022-04-15 13:15:00','2022-04-15 17:15:00'),		--slizgi
	(3,3,'2022-04-15 18:00:00','2022-04-16 01:15:00'),		--grill
	(7,3,'2022-04-10 08:00:00','2022-04-11 10:00:00'),		--grill
	(7,3,'2022-04-12 08:00:00','2022-04-13 10:00:00'),		--grill
	(7,3,'2022-04-13 11:00:00','2022-04-14 10:00:00'),		--grill
	(7,3,'2022-04-13 11:00:00','2022-04-14 10:00:00'),		--zderzak ³¹czenie
	(7,3,'2022-04-14 11:00:00','2022-04-14 10:00:00'),		--zderzak monta¿

																--zderzak tylny M
	(2,4,'2022-05-07 13:00:00','2022-05-07 16:00:00'), 		--slizgi
	(2,4,'2022-05-08 13:00:00','2022-05-09 16:00:00'),		--slizgi
	(2,4,'2022-05-10 08:00:00','2022-05-10 09:15:00'),  	--slizgi
	(2,4,'2022-05-10 10:15:00','2022-05-18 16:15:00'),		--slizgi
	(2,4,'2022-05-19 08:00:00','2022-05-20 08:30:00'),		--zderzak montaz

																--fotel
	(2,5,'2022-03-07 13:00:00','2022-03-07 16:00:00'), 		--obudowa
	(2,5,'2022-03-08 13:00:00','2022-03-09 16:00:00'),		--obudowa
	(2,5,'2022-03-10 08:00:00','2022-03-10 09:15:00'),  	--obudowa
	(2,5,'2022-03-10 10:15:00','2022-03-18 16:15:00'),		--obudowa
	(2,5,'2022-03-19 08:00:00','2022-03-20 08:00:00'),		--skóra
	(2,5,'2022-03-20 08:30:00','2022-03-21 08:30:00');		--fotel monta¿


INSERT INTO Proces_wytwarzanie_produkt (ID_wytwarzanie, ID_proces_produkt)
	VALUES
	(9,3),
	(10,4),
	(15,7),
	(24,8),
	(25,9),
	(30,10),
	(36,6);


INSERT INTO Proces_wytwarzanie_polprodukt (ID_wytwarzanie, ID_proces_polprodukt)
	VALUES
	(1,9),
	(2,10),
	(3,11),
	(4,12),
	(5,13),
	(6,14),
	(7,15),
	(8,16),
	(11,17),
	(12,18),
	(13,19),
	(14,20),
	(16,21),
	(17,22),
	(18,23),
	(19,24),
	(20,25),
	(21,26),
	(22,27),
	(23,28),
	(26,29),
	(27,30),
	(28,31),
	(29,32),
	(31,5),
	(32,6),
	(33,7),
	(34,8),
	(35,33);


INSERT INTO Kontrola_jakosci_produkt (ID_pracownik, ID_rodzaj_kontrola, ID_wytwarzanie, Data_od, Data_do, Uwagi)
	VALUES
	(2,2,10,'2022-04-07 13:00:00','2022-04-07 14:00:00','BRAK'),
	(2,1,15,'2022-04-07 14:00:00','2022-04-07 15:00:00','BRAK'),
	(2,2,25,'2022-04-09 08:30:00','2022-04-09 09:00:00','BRAK'),
	(3,2,30,'2022-04-05 15:15:00','2022-04-05 15:30:00','BRAK'),
	(3,5,36,'2022-04-05 15:30:00','2022-04-05 16:00:00','BRAK');

INSERT INTO Kontrola_parametr_produkt (ID_kontrola_jakosci_produkt, ID_parametr_produkt, Wartosc)
	VALUES
	(2,3,300),
	(2,4,105),
	(2,6,51),
	(3,5,83),
	(5,1,150),
	(5,2,98);

INSERT INTO Alert ( ID_dzial, Tresc, Czy_odczytano)
	VALUES
	(4, 'Zamów aluminium', 1),
	(4, 'Zamów stal', 0),
	(4, 'Aluminium', 1),
	(4, 'Stal', 1),
	(5, 'Wyczyœæ stanowisko nr 2', 0);

INSERT INTO Magazynowanie_slownik (Nazwa)
	VALUES
	('Magazyn zewnêtrzny'),
	('Magazyn wewnêtrzny'),
	('Magazyn bezpy³owy'),
	('Magazyn klimatyzowany');

INSERT INTO Parametr_typ_magazynowania (ID_magazynowanie, ID_rodzaj_parametr, Wartosc_dolna, Wartosc_gorna)
		VALUES
		(1,13,-25, 50),
		(1,15,-25, 50),
		(1,13,-25, 50),
		(1,13,-25, 50),
		(1,13,-25, 50);

INSERT INTO Poziom_magazynowanie (ID_magazynowanie, Poziom)
	VALUES
	(1,0),
	(2,0),
	(2,1),
	(2,2),
	(2,3),
	(3,0),
	(3,1),
	(3,2),
	(3,3),
	(3,4),
	(4,0),
	(4,1);

INSERT INTO Parametr_poziom_magazynowanie (ID_poziom_magazynowanie, ID_rodzaj_parametr, Wartosc_dolna, Wartosc_gorna)
	VALUES
	(1,15,6000,6500),
	(2,15,5000,5500),
	(3,16,4000,5000),
	(4,16,3000,5000),
	(5,16,2000,2500),
	(6,16,1000,1200),
	(7,15,5000,5900),
	(8,16,6000,6200),
	(9,16,1000,1200),
	(10,16,500,550),
	(11,15,3000,4000),
	(12,16,2000,2100);

INSERT INTO Miejsce_magazynowanie_produkt (ID_poziom_magazynowanie, ID_produkt, Nr_miejsca)
	VALUES
	(6,1,3),
	(2,2,2),
	(3,3,4),
	(4,4,1),
	(5,5,1);

INSERT INTO Miejsce_magazynowanie_polprodukt (ID_poziom_magazynowanie, ID_polprodukt, Nr_miejsca)
	VALUES
	(6,1,5),
	(7,2,8),
	(8,3,1),
	(9,4,2),
	(10,5,5);

INSERT INTO Miejsce_magazynowanie_pojazd (ID_poziom_magazynowanie, ID_pojazd, Nr_miejsca)
	VALUES
	(1,1,1),
	(1,2,2),
	(1,3,3),
	(1,4,4),
	(1,5,5);

