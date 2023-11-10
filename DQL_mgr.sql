USE master
GO
USE Firma_produkcyjna
GO

------- PRODUCTION DEPARTMENT --------

CREATE VIEW v_Czynnosc_produkcyjna
AS
SELECT ID_czynnosc_produkcyjna AS [ID czynnosci], Nazwa AS [Nazwa czynnosci]
FROM Czynnosc_produkcyjna;
GO

CREATE VIEW v_Parametry_produkt
AS
SELECT ID_parametr_produkt, P.ID_produkt, P.Nazwa_produkt AS [Produkt], RP.Nazwa_rodzaj_parametr AS [Parametr],
PP.Zakres_dol AS [Wymiar minimalny], PP.Zakres_gora AS [Wymiar maksymalny], J.Skrot AS [Jednostka]
FROM Parametr_produkt AS PP
INNER JOIN Produkt AS P ON PP.ID_produkt = P.ID_produkt
INNER JOIN Rodzaj_parametr AS RP ON PP.ID_rodzaj_parametr = RP.ID_rodzaj_parametr
INNER JOIN Jednostka AS J ON RP.ID_jednostka = J.ID_jednostka
GO

CREATE VIEW v_Parametry_polprodukt
AS
SELECT ID_parametr_polprodukt, PPp.ID_polprodukt, SP.Nazwa AS [Nazwa pó³produktu], RP.Nazwa_rodzaj_parametr AS [Parametr],
PPp.Zakres_dol AS [Wymiar minimalny], PPp.Zakres_gora AS [Wymiar maksymalny], J.Skrot AS [Jednostka]
FROM Parametr_polprodukt AS PPp
INNER JOIN Slownik_polprodukt AS SP ON PPp.ID_polprodukt = SP.ID_polprodukt
INNER JOIN Rodzaj_parametr AS RP ON PPp.ID_rodzaj_parametr = RP.ID_rodzaj_parametr
INNER JOIN Jednostka AS J ON RP.ID_jednostka = J.ID_jednostka
GO

CREATE VIEW v_Sklad_produkt
AS
SELECT P.ID_produkt, SlwPP.ID_polprodukt, SP.ID_sklad_produkt AS [ID sk³ad], P.Nazwa_produkt AS [Produkt], SlwPP.Nazwa AS [Pó³produkt], SP.Ilosc
FROM Sklad_produkt AS SP
INNER JOIN Produkt AS P ON SP.ID_produkt = P.ID_produkt
INNER JOIN Slownik_polprodukt AS SlwPP ON SP.ID_polprodukt = SlwPP.ID_polprodukt
ORDER BY P.Nazwa_produkt OFFSET 0 ROWS
GO

CREATE VIEW v_Sklad_produkt_ewidencja
AS
SELECT SP.ID_sklad_produkt AS [ID sk³ad], SP.ID_produkt, SP.ID_polprodukt, SlwPP.Nazwa AS [Pó³produkt], SP.Ilosc
FROM Sklad_produkt AS SP
INNER JOIN Produkt AS P ON SP.ID_produkt = P.ID_produkt
INNER JOIN Slownik_polprodukt AS SlwPP ON SP.ID_polprodukt = SlwPP.ID_polprodukt
ORDER BY P.Nazwa_produkt OFFSET 0 ROWS
GO

CREATE VIEW v_Sklad_polprodukt
AS
SELECT SP.ID_sklad_polprodukt AS [ID_sk³ad], SlwPp.Nazwa AS [Pó³produkt], M.Nazwa_material AS [Materia³], RM.Nazwa_rodzaj_material AS [Rodzaj],
SP.Ilosc AS [Waga {g}]
FROM Sklad_polprodukt AS SP
INNER JOIN Slownik_polprodukt AS SlwPp ON SP.ID_polprodukt = SlwPp.ID_polprodukt
INNER JOIN Material AS M ON SP.ID_material = M.ID_material
INNER JOIN Rodzaj_material AS RM ON M.ID_rodzaj_material = RM.ID_rodzaj_material
ORDER BY SlwPp.Nazwa OFFSET 0 ROWS
GO

CREATE VIEW v_Sklad_produkt_material
AS
SELECT ID_sklad_produkt_material, P.Nazwa_produkt AS [Produkt], M.Nazwa_material AS [Materia³], RM.Nazwa_rodzaj_material AS [Rodzaj],
SPM.Ilosc_g AS [Waga {g}]
FROM Sklad_produkt_material AS SPM
INNER JOIN Produkt AS P ON SPM.ID_produkt = P.ID_produkt
INNER JOIN Material AS M ON SPM.ID_material = M.ID_material
INNER JOIN Rodzaj_material AS RM ON M.ID_rodzaj_material = RM.ID_rodzaj_material
GO

CREATE VIEW v_Slownik_stanowisko
AS
SELECT ID_nazwa_stanowiska AS ID, Nazwa_stanowiska AS [Nazwa stanowiska] 
FROM Slownik_stanowisko
GO

CREATE VIEW v_Stanowisko_produkcyjne
AS
SELECT SP.ID_stanowisko_produkcyjne AS [ID], SS.Nazwa_stanowiska AS [Nazwa stanowiska]
FROM Stanowisko_produkcyjne AS SP
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
GO

CREATE VIEW v_Sklad_stanowisko_produkcyjne_narzedzie
AS
SELECT SP.ID_stanowisko_produkcyjne AS [ID Stanowiska], SS.Nazwa_stanowiska, N.Nazwa_narzedzie AS [Narzêdzie], Ilosc 
FROM Sklad_stanowisko_produkcyjne_narzedzie AS SSPN
INNER JOIN Stanowisko_produkcyjne AS SP ON SSPN.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Narzedzie AS N ON SSPN.ID_narzedzie = N.ID_narzedzie
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
ORDER BY SP.ID_stanowisko_produkcyjne ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Sklad_stanowisko_produkcyjne_narzedzie_ID
AS
SELECT SSPN.ID_sklad_stanowisko_produkcyjne_narzedzie, SP.ID_stanowisko_produkcyjne AS [ID Stanowiska], SS.Nazwa_stanowiska, N.Nazwa_narzedzie AS [Narzêdzie], Ilosc
FROM Sklad_stanowisko_produkcyjne_narzedzie AS SSPN
INNER JOIN Stanowisko_produkcyjne AS SP ON SSPN.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Narzedzie AS N ON SSPN.ID_narzedzie = N.ID_narzedzie
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
ORDER BY SP.ID_stanowisko_produkcyjne ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Sklad_stanowisko_produkcyjne_maszyna
AS
SELECT SP.ID_stanowisko_produkcyjne AS [ID stanowiska produkcyjnego], SS.Nazwa_stanowiska AS [Nazwa Stanowiska], 
NS.Nr_seryjny AS [Nr seryjny maszyny], M.Nazwa_maszyna AS [Maszyna], M.Koszt_RBG [Koszt roboczogodziny {PLN}],
RM.Nazwa_rodzaj_maszyna AS [Rodzaj maszyny]
FROM Sklad_stanowisko_produkcyjne_maszyna AS SSPM
INNER JOIN Stanowisko_produkcyjne AS SP ON SSPM.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
INNER JOIN Maszyna_nr_seryjny AS MS ON SSPM.ID_maszyna_nr = MS.ID_maszyna_nr
INNER JOIN Maszyna AS M ON MS.ID_maszyna = M.ID_maszyna
INNER JOIN Rodzaj_maszyna AS RM ON M.ID_rodzaj_maszyna = RM.ID_rodzaj_maszyna
INNER JOIN Nr_seryjny AS NS ON MS.ID_maszyna_nr = NS.ID_nr_seryjny
ORDER BY SP.ID_stanowisko_produkcyjne ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Sklad_stanowisko_produkcyjne_maszyna_ID
AS
SELECT SSPM.ID_sklad_stanowisko_produkcyjne_maszyna, SP.ID_stanowisko_produkcyjne AS [ID stanowiska produkcyjnego], SS.Nazwa_stanowiska AS [Nazwa Stanowiska],
NS.Nr_seryjny AS [Nr seryjny maszyny], M.Nazwa_maszyna AS [Maszyna], M.Koszt_RBG [Koszt roboczogodziny {PLN}],
RM.Nazwa_rodzaj_maszyna AS [Rodzaj maszyny]
FROM Sklad_stanowisko_produkcyjne_maszyna AS SSPM
INNER JOIN Stanowisko_produkcyjne AS SP ON SSPM.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
INNER JOIN Maszyna_nr_seryjny AS MS ON SSPM.ID_maszyna_nr = MS.ID_maszyna_nr
INNER JOIN Maszyna AS M ON MS.ID_maszyna = M.ID_maszyna
INNER JOIN Rodzaj_maszyna AS RM ON M.ID_rodzaj_maszyna = RM.ID_rodzaj_maszyna
INNER JOIN Nr_seryjny AS NS ON MS.ID_maszyna_nr = NS.ID_nr_seryjny
ORDER BY SP.ID_stanowisko_produkcyjne ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Koszt_roboczogodziny_stanowiska
AS
SELECT [ID stanowiska produkcyjnego],SUM([Koszt roboczogodziny {PLN}]) AS [Koszt roboczogodziny stanowiska {PLN}] 
FROM v_Sklad_stanowisko_produkcyjne_maszyna
GROUP BY [ID stanowiska produkcyjnego]
GO

CREATE VIEW v_Koszt_procesow_polprodukt
AS
SELECT DISTINCT SP.ID_produkt, P.ID_polprodukt AS ID, P.Nazwa AS [Pó³produkt], PPPC.Czas_trwania AS [Czas trwania], CP.Nazwa AS [Czynnoœæ],
CONVERT(DECIMAL(15,2),vK.[Koszt roboczogodziny stanowiska {PLN}] * PPPC.Czas_trwania/60) AS [Suma kosztu procesów]
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN v_Koszt_roboczogodziny_stanowiska AS vK ON PPPC.ID_stanowisko_produkcyjne = vK.[ID stanowiska produkcyjnego]
INNER JOIN Slownik_polprodukt AS P ON PPPC.ID_polprodukt = P.ID_polprodukt
INNER JOIN Sklad_produkt AS SP ON SP.ID_polprodukt = P.ID_polprodukt
INNER JOIN Wytwarzanie AS W ON PWPP.ID_wytwarzanie = W.ID_wytwarzanie
GO

CREATE VIEW v_Koszt_procesow_produkt
AS
SELECT P.ID_produkt, P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynnoœæ], PPPC.Czas_trwania AS [Czas trwania], vK.[Koszt roboczogodziny stanowiska {PLN}], vK.[Koszt roboczogodziny stanowiska {PLN}] * PPPC.Czas_trwania/60 AS [Suma kosztu procesów]
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_produkt
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN v_Koszt_roboczogodziny_stanowiska AS vK ON PPPC.ID_stanowisko_produkcyjne = vK.[ID stanowiska produkcyjnego]
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
GO

CREATE VIEW v_Koszt_produkcji
AS
SELECT P.Nazwa_produkt, SUM(KPP.[Suma kosztu procesów] * SP.Ilosc) + SUM(KP.[Suma kosztu procesów]) AS [Koszt wytworzenia produktu {PLN}]
FROM Sklad_produkt AS SP
INNER JOIN Produkt AS P ON SP.ID_produkt = P.ID_produkt
INNER JOIN Slownik_polprodukt AS SlwPP ON SP.ID_polprodukt = SlwPP.ID_polprodukt
INNER JOIN v_Koszt_procesow_polprodukt AS KPP ON SlWPP.Nazwa = KPP.Pó³produkt
INNER JOIN v_Koszt_procesow_produkt AS KP ON P.Nazwa_produkt = KP.Produkt
GROUP BY P.Nazwa_produkt
GO

CREATE VIEW v_Koszt
AS
SELECT P.Nazwa_produkt, ISNULL(Kp.[Suma kosztu procesów],0) AS [Koszt produktów], SlwPP.Nazwa, SP.Ilosc, ISNULL((KPP.[Suma kosztu procesów] * SP.Ilosc),0) AS [Koszt pó³produktów], Kp.[Suma kosztu procesów] + ISNULL((KPP.[Suma kosztu procesów] * SP.Ilosc),0) AS SUMA
FROM Sklad_produkt AS SP
INNER JOIN Produkt AS P ON SP.ID_produkt = P.ID_produkt
INNER JOIN Slownik_polprodukt AS SlwPP ON SP.ID_polprodukt = SlwPP.ID_polprodukt
LEFT JOIN v_Koszt_procesow_polprodukt AS KPP ON SlWPP.Nazwa = KPP.Pó³produkt
LEFT JOIN v_Koszt_procesow_produkt AS KP ON P.Nazwa_produkt = KP.Produkt
GO

CREATE VIEW v_Kontrola_parametr_produkt
AS
SELECT w.ID_wytwarzanie AS [ID_wytwarzanie], P.ID_produkt AS [ID_produkt], P.Nazwa_produkt AS [Produkt], RP.Nazwa_rodzaj_parametr AS [Parametr], KPP.Wartosc AS [Wartoœæ],
PP.Zakres_dol AS [Zakres dolny], PP.Zakres_gora AS [Zakres górny], (CASE WHEN KPP.Wartosc BETWEEN PP.Zakres_dol AND PP.Zakres_gora THEN 1 ELSE 0 END) AS [Rezultat kontroli], Z.ID_zamowienie AS ID_zamowienie,
PP.ID_parametr_produkt, KJP.Data_od, KJP.Data_do
FROM Kontrola_parametr_produkt AS KPP
INNER JOIN Kontrola_jakosci_produkt AS KJP ON KPP.ID_kontrola_jakosci_produkt = KJP.ID_kontrola_jakosci_produkt
INNER JOIN Parametr_produkt AS PP ON KPP.ID_parametr_produkt = PP.ID_parametr_produkt
INNER JOIN Produkt AS P ON PP.ID_produkt = P.ID_produkt
INNER JOIN Rodzaj_parametr AS RP ON PP.ID_rodzaj_parametr = RP.ID_rodzaj_parametr
INNER JOIN Wytwarzanie AS W ON KJP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Zamowienie_szczegol AS ZS ON W.ID_zamowienie_szczegol = ZS.ID_zamowienie_szczegol
INNER JOIN Zamowienie AS Z ON ZS.ID_zamowienie = Z.ID_zamowienie
GO

CREATE VIEW v_Kontrola_parametr_polprodukt
AS
SELECT w.ID_wytwarzanie AS [ID_wytwarzanie], P.ID_polprodukt AS [ID_polprodukt], P.Nazwa AS [Polprodukt], RP.Nazwa_rodzaj_parametr AS [Parametr], KPP.Wartosc AS [Wartoœæ],
PP.Zakres_dol AS [Zakres dolny], PP.Zakres_gora AS [Zakres górny], (CASE WHEN KPP.Wartosc BETWEEN PP.Zakres_dol AND PP.Zakres_gora THEN 1 ELSE 0 END) AS [Rezultat kontroli], Z.ID_zamowienie AS ID_zamowienie,
PP.ID_parametr_polprodukt, KJP.Data_od, KJP.Data_do
FROM Kontrola_parametr_polprodukt AS KPP
INNER JOIN Kontrola_jakosci_polprodukt AS KJP ON KPP.ID_kontrola_jakosci_polprodukt = KJP.ID_kontrola_jakosci_polprodukt
INNER JOIN Parametr_polprodukt AS PP ON KPP.ID_parametr_polprodukt = PP.ID_parametr_polprodukt
INNER JOIN Slownik_polprodukt AS P ON PP.ID_polprodukt = P.ID_polprodukt
INNER JOIN Rodzaj_parametr AS RP ON PP.ID_rodzaj_parametr = RP.ID_rodzaj_parametr
INNER JOIN Wytwarzanie AS W ON KJP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Zamowienie_szczegol AS ZS ON W.ID_zamowienie_szczegol = ZS.ID_zamowienie_szczegol
INNER JOIN Zamowienie AS Z ON ZS.ID_zamowienie = Z.ID_zamowienie
GO

----------------
CREATE VIEW v_Wynik_kontroli_polprodukt
AS
SELECT ID_wytwarzanie, ID_polprodukt, SUM([Rezultat kontroli]) AS [Wynik_kontrola]
FROM v_Kontrola_parametr_polprodukt
GROUP BY ID_wytwarzanie, ID_polprodukt
GO

CREATE VIEW v_Kontrola_pozytywna_polprodukt
AS
SELECT ID_wytwarzanie, ID_polprodukt, [Polprodukt], AVG([Rezultat kontroli]) AS [Wynik_kontrola], [ID_zamowienie]
FROM v_Kontrola_parametr_polprodukt
GROUP BY ID_wytwarzanie, ID_polprodukt, [Polprodukt], [ID_zamowienie]
HAVING AVG([Rezultat kontroli]) = 1
GO

CREATE VIEW v_Ilosc_kontrola_pozytywna_polprodukt
AS
SELECT ID_polprodukt, [Polprodukt], COUNT([Wynik_kontrola]) AS [Iloœæ], [ID_zamowienie] FROM v_Kontrola_pozytywna_polprodukt
GROUP BY ID_polprodukt, [Polprodukt], [ID_zamowienie]
GO

CREATE VIEW v_Kontrola_wszystkie_polprodukt
AS
SELECT ID_polprodukt, [Polprodukt], AVG([Rezultat kontroli]) AS [Wynik_kontrola]
FROM v_Kontrola_parametr_polprodukt
GROUP BY ID_wytwarzanie, ID_polprodukt, [Polprodukt], [ID_zamowienie]
GO

CREATE VIEW v_Kontrola_negatywna_polprodukt
AS
SELECT ID_wytwarzanie, ID_polprodukt, [Polprodukt], AVG([Rezultat kontroli]) AS [Wynik_kontrola] FROM v_Kontrola_parametr_polprodukt
GROUP BY ID_wytwarzanie, ID_polprodukt, [Polprodukt]
HAVING AVG([Rezultat kontroli]) < 1
GO

CREATE VIEW v_Kontrola_jakosci_polprodukt
AS
SELECT KJP.ID_kontrola_jakosci_polprodukt, PR.Nazwisko + ' ' +PR.Imie AS [Pracownik], RK.Rodzaj_kontrola
FROM Kontrola_jakosci_polprodukt AS KJP
INNER JOIN Pracownik AS PR ON  KJP.ID_pracownik = PR.ID_pracownik
INNER JOIN Rodzaj_kontrola AS RK ON KJP.ID_rodzaj_kontrola = RK.ID_rodzaj_kontrola
GO

CREATE VIEW v_Kontrola_jakosci_kolejka_polprodukt
AS
SELECT W.ID_wytwarzanie, P.ID_polprodukt, P.Nazwa
FROM Wytwarzanie AS W
LEFT JOIN Kontrola_jakosci_polprodukt AS KJP ON W.ID_wytwarzanie = KJP.ID_wytwarzanie
INNER JOIN Proces_wytwarzanie_polprodukt AS PWP ON  W.ID_wytwarzanie = PWP.ID_wytwarzanie
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Slownik_polprodukt AS P ON PPPC.ID_polprodukt = P.ID_polprodukt
WHERE W.Czas_do IS NOT NULL

EXCEPT

SELECT W.ID_wytwarzanie, P.ID_polprodukt, P.Nazwa
FROM Wytwarzanie AS W
INNER JOIN Kontrola_jakosci_polprodukt AS KJP ON W.ID_wytwarzanie = KJP.ID_wytwarzanie
INNER JOIN Proces_wytwarzanie_polprodukt AS PWP ON  W.ID_wytwarzanie = PWP.ID_wytwarzanie
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Slownik_polprodukt AS P ON PPPC.ID_polprodukt = P.ID_polprodukt
WHERE W.Czas_do IS NOT NULL
GO

CREATE VIEW v_Wynik_kontroli
AS
SELECT ID_wytwarzanie, ID_produkt, SUM([Rezultat kontroli]) AS [Wynik_kontrola]
FROM v_Kontrola_parametr_produkt
GROUP BY ID_wytwarzanie, ID_produkt
GO

CREATE VIEW v_Kontrola_pozytywna
AS
SELECT ID_wytwarzanie, ID_produkt, [Produkt], AVG([Rezultat kontroli]) AS [Wynik_kontrola], [ID_zamowienie]
FROM v_Kontrola_parametr_produkt
GROUP BY ID_wytwarzanie, ID_produkt, [Produkt], [ID_zamowienie]
HAVING AVG([Rezultat kontroli]) = 1
GO

CREATE VIEW v_Ilosc_kontrola_pozytywna
AS
SELECT ID_produkt, [Produkt], COUNT([Wynik_kontrola]) AS [Iloœæ], [ID_zamowienie] FROM v_Kontrola_pozytywna
GROUP BY ID_produkt, [Produkt], [ID_zamowienie]
GO

CREATE VIEW v_Kontrola_wszystkie
AS
SELECT ID_produkt, [Produkt], AVG([Rezultat kontroli]) AS [Wynik_kontrola]
FROM v_Kontrola_parametr_produkt
GROUP BY ID_wytwarzanie, ID_produkt, [Produkt], [ID_zamowienie]
GO

CREATE VIEW v_Kontrola_negatywna
AS
SELECT ID_wytwarzanie, ID_produkt, [Produkt], AVG([Rezultat kontroli]) AS [Wynik_kontrola] FROM v_Kontrola_parametr_produkt
GROUP BY ID_wytwarzanie, ID_produkt, [Produkt]
HAVING AVG([Rezultat kontroli]) < 1
GO

CREATE VIEW v_Kontrola_jakosci_produkt
AS
SELECT KJP.ID_kontrola_jakosci_produkt, PR.Nazwisko + ' ' +PR.Imie AS [Pracownik], RK.Rodzaj_kontrola
FROM Kontrola_jakosci_produkt AS KJP
INNER JOIN Pracownik AS PR ON  KJP.ID_pracownik = PR.ID_pracownik
INNER JOIN Rodzaj_kontrola AS RK ON KJP.ID_rodzaj_kontrola = RK.ID_rodzaj_kontrola
GO

CREATE VIEW v_Kontrola_jakosci_kolejka
AS
SELECT W.ID_wytwarzanie, P.ID_produkt, P.Nazwa_produkt
FROM Wytwarzanie AS W
LEFT JOIN Kontrola_jakosci_produkt AS KJP ON W.ID_wytwarzanie = KJP.ID_wytwarzanie
INNER JOIN Proces_wytwarzanie_produkt AS PWP ON  W.ID_wytwarzanie = PWP.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
WHERE W.Czas_do IS NOT NULL

EXCEPT

SELECT W.ID_wytwarzanie, P.ID_produkt, P.Nazwa_produkt
FROM Wytwarzanie AS W
INNER JOIN Kontrola_jakosci_produkt AS KJP ON W.ID_wytwarzanie = KJP.ID_wytwarzanie
INNER JOIN Proces_wytwarzanie_produkt AS PWP ON  W.ID_wytwarzanie = PWP.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
WHERE W.Czas_do IS NOT NULL
GO

CREATE VIEW v_Rodzaj_kontrola
AS
SELECT ID_rodzaj_kontrola AS ID, Rodzaj_kontrola AS [Rodzaj kontroli], Procedura AS [Procedura kontrolna]
FROM Rodzaj_kontrola
GO

CREATE VIEW v_Proces_polprodukt_czynnosc
AS
SELECT PPPC.ID_polprodukt AS [ID Pó³produktu], SPP.Nazwa AS [Pó³produkt], CP.Nazwa AS [Czynnoœæ], SP.ID_produkt AS [ID Produktu], PPPC.ID_proces_polprodukt
FROM Proces_polprodukt_czynnosc AS PPPC
INNER JOIN Slownik_polprodukt SPP ON PPPC.ID_polprodukt = SPP.ID_polprodukt
INNER JOIN Czynnosc_produkcyjna CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Sklad_produkt AS SP ON SPP.ID_polprodukt = SP.ID_polprodukt
ORDER BY PPPC.ID_polprodukt DESC OFFSET 0 ROWS
GO

CREATE VIEW v_Proces_produkt_czynnosc
AS
SELECT PPC.ID_produkt AS [ID Produktu], P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynnoœæ] , PPC.ID_proces_produkt
FROM Proces_produkt_czynnosc AS PPC
INNER JOIN Produkt AS P ON PPC.ID_produkt = P.ID_produkt
INNER JOIN Czynnosc_produkcyjna CP ON PPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
ORDER BY PPC.ID_produkt DESC OFFSET 0 ROWS 
GO

CREATE VIEW v_Liczba_zabiegow_wytworczych_polprodukt
AS
SELECT SP.Nazwa AS [Pó³produkt], Count(PPPC.ID_polprodukt) AS [Liczba zabiegów]
FROM Proces_polprodukt_czynnosc AS PPPC
INNER JOIN Slownik_polprodukt SP ON PPPC.ID_polprodukt = SP.ID_polprodukt
INNER JOIN Czynnosc_produkcyjna CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
GROUP BY SP.Nazwa
GO

CREATE VIEW v_Liczba_zabiegow_wytworczych_produkt
AS
SELECT P.Nazwa_produkt AS [Produkt], Count(PPC.ID_produkt) AS [Liczba zabiegów]
FROM Proces_produkt_czynnosc AS PPC
INNER JOIN Produkt AS P ON PPC.ID_produkt = P.ID_produkt
INNER JOIN Czynnosc_produkcyjna CP ON PPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
GROUP BY P.Nazwa_produkt
GO

CREATE VIEW v_Wytwarzanie
AS
SELECT W.ID_wytwarzanie AS [ID], ZS.ID_zamowienie_szczegol AS [ID zamówienie], Pr.Nazwa_produkt AS [Produkt], P.Nazwisko + ' ' + P.Imie AS [Pracownik],
W.Czas_od [Data rozpoczêcia], W.Czas_do AS [Data zakoñczenia]
FROM Wytwarzanie AS W
INNER JOIN Pracownik AS P ON W.ID_pracownik = P.ID_pracownik
INNER JOIN Zamowienie_szczegol AS ZS ON W.ID_zamowienie_szczegol = ZS.ID_zamowienie_szczegol
INNER JOIN Produkt AS Pr ON ZS.ID_produkt = Pr.ID_produkt
GO

CREATE VIEW v_Montaz
AS
SELECT M.ID_montaz_pojazd AS [ID], ZS.ID_zamowienie_szczegol_pojazd AS [ID zammówienie], Po.Nr_VIN AS [Numer VIN], P.Nazwisko + ' ' + P.Imie AS [Pracownik],
M.Czas_od [Data rozpoczêcia], M.Czas_do AS [Data zakoñczenia]
FROM Montaz_pojazd AS M
INNER JOIN Pracownik AS P ON M.ID_pracownik = P.ID_pracownik
INNER JOIN Zamowienie_szczegol_pojazd AS ZS ON M.ID_zamowienie_szczegol_pojazd = ZS.ID_zamowienie_szczegol_pojazd
INNER JOIN Pojazd AS Po ON ZS.ID_pojazd = Po.ID_pojazd
GO

CREATE VIEW v_Zamowienie_szczegol_produkcja AS
SELECT Z.ID_zamowienie AS [ID], P.ID_produkt AS [ID produktu], P.Nazwa_produkt AS [Produkt], ZC.Ilosc AS [Iloœæ], ZC.ID_zamowienie_szczegol AS [ID_zamowienie_szczegol]
FROM Zamowienie_szczegol AS ZC
INNER JOIN Produkt AS P ON P.ID_produkt = ZC.ID_produkt
INNER JOIN Zamowienie AS Z ON Z.ID_zamowienie = ZC.ID_zamowienie
GO

CREATE VIEW v_Zamowienie_produkcja AS
SELECT Z.ID_zamowienie AS [ID], CONVERT(NVARCHAR,Z.ID_zamowienie) + ' ' + '-' + ' ' + K.Nazwisko + ' ' + K.Imie + ' - ' + CONVERT(NVARCHAR,Z.Data_zamowienie) AS [Klient]
FROM Zamowienie AS Z
INNER JOIN Klient AS K ON K.ID_klient = Z.ID_klient
INNER JOIN Pracownik AS P ON P.ID_pracownik = Z.ID_pracownik
ORDER BY Data_zamowienie DESC OFFSET 0 ROWS
GO

CREATE VIEW v_Pracownik_produkcja
AS
SELECT P.ID_pracownik, P.Nazwisko + ' ' + P.Imie AS [Pracownik]
FROM Stanowisko_pracownik AS SP
INNER JOIN Stanowisko AS S ON SP.ID_stanowisko = S.ID_stanowisko
INNER JOIN Pracownik AS P ON SP.ID_pracownik = P.ID_pracownik
WHERE Nazwa_stanowiska IN ('Operator', 'Projektant', 'Brygadzista', 'Kontroler jakoœci')
ORDER BY [Pracownik] OFFSET 0 ROWS
GO

CREATE VIEW v_Tygodniowe_rozliczenie_pracy_produkcja
AS
SELECT [Pracownik], SUM(DATEDIFF(HOUR, [Data rozpoczêcia],[Data zakoñczenia])) AS [Czas pracy]
FROM v_Wytwarzanie
GROUP BY [Pracownik]
GO

CREATE VIEW v_Proces_wytwarzanie_polprodukt
AS
SELECT W.ID_wytwarzanie AS [ID], P.Nazwa AS [Pó³produkt], CP.Nazwa AS [Czynnoœæ produkcyjna], Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SST.Nazwa_stanowiska AS [Stanowisko], PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczêcia], W.Czas_do AS [Data zakoñczenia]
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Wytwarzanie AS W ON PWPP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Stanowisko_produkcyjne AS SP ON PPPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Slownik_polprodukt AS P ON PPPC.ID_polprodukt = P.ID_polprodukt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
GO

CREATE VIEW v_Proces_wytwarzanie_polprodukt_ewidencja
AS
SELECT W.ID_wytwarzanie AS [ID], P.Nazwa AS [Pó³produkt], CP.Nazwa AS [Czynnoœæ produkcyjna], Pr.ID_pracownik, Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SST.Nazwa_stanowiska AS [Stanowisko], PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczêcia], W.Czas_do AS [Data zakoñczenia], ISNULL(DATEDIFF(MINUTE, W.Czas_od,W.Czas_do),0) AS [Czas pracy]
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Wytwarzanie AS W ON PWPP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Stanowisko_produkcyjne AS SP ON PPPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Slownik_polprodukt AS P ON PPPC.ID_polprodukt = P.ID_polprodukt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
GO

CREATE VIEW v_Proces_wytwarzanie_polprodukt_koszt
AS
SELECT Z.ID_zamowienie AS [ID_zamowienie], P.Nazwa AS [Pó³produkt], SP.ID_stanowisko_produkcyjne AS [ID_stanowisko], SST.Nazwa_stanowiska AS [Stanowisko],
W.Czas_od AS [Data rozpoczêcia], W.Czas_do AS [Data zakoñczenia], ISNULL(DATEDIFF(MINUTE, W.Czas_od,W.Czas_do),0) AS [Czas pracy],
KRGS.[Koszt roboczogodziny stanowiska {PLN}],
CAST((ISNULL(DATEDIFF(MINUTE, W.Czas_od,W.Czas_do),0)*(KRGS.[Koszt roboczogodziny stanowiska {PLN}])/60) AS DECIMAL(10,2)) AS [Koszt_procesu]
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Wytwarzanie AS W ON PWPP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Stanowisko_produkcyjne AS SP ON PPPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Slownik_polprodukt AS P ON PPPC.ID_polprodukt = P.ID_polprodukt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
INNER JOIN Zamowienie_szczegol AS ZS ON W.ID_zamowienie_szczegol = ZS.ID_zamowienie_szczegol
INNER JOIN Zamowienie AS Z ON ZS.ID_zamowienie = Z.ID_zamowienie
INNER JOIN v_Koszt_roboczogodziny_stanowiska AS KRGS ON SP.ID_stanowisko_produkcyjne = KRGS.[ID stanowiska produkcyjnego]
WHERE W.Czas_do IS NOT NULL
GO

CREATE VIEW v_Szacowany_czas_wytwarzania_polprodukt
AS
SELECT [Pó³produkt], FORMAT(SUM([Szacowany czas {min}])/CAST(60 AS DECIMAL (4,1)),'0.######') AS [Czas wytwarzania {h}] FROM v_Proces_wytwarzanie_polprodukt
GROUP BY [Pó³produkt]
GO

CREATE VIEW v_Czas_wytwarzanie_polprodukt
AS
SELECT PPPC.ID_polprodukt, SP.ID_produkt, P.Nazwa_produkt AS [Produkt], SPP.Nazwa AS [Pó³produkt], SUM(PPPC.Czas_trwania * SP.Ilosc) AS [Czas]
FROM Proces_polprodukt_czynnosc AS PPPC
INNER JOIN Slownik_polprodukt AS SPP ON PPPC.ID_polprodukt = SPP.ID_polprodukt
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Sklad_produkt AS SP ON SPP.ID_polprodukt = SP.ID_polprodukt
INNER JOIN Produkt AS P ON SP.ID_produkt = P.ID_produkt
GROUP BY PPPC.ID_polprodukt, SPP.Nazwa, SP.ID_produkt, P.Nazwa_produkt
GO

CREATE VIEW v_Czas_wytwarzanie_produkt
AS
SELECT P.ID_produkt, P.Nazwa_produkt AS [Produkt], SUM(PPC.Czas_trwania) AS [Czas]
FROM Proces_produkt_czynnosc AS PPC
INNER JOIN Czynnosc_produkcyjna AS CP ON PPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Produkt AS P ON PPC.ID_produkt = P.ID_produkt
GROUP BY P.ID_produkt, P.Nazwa_produkt
GO

CREATE VIEW v_Sumaryczny_czas_wytwarzania_produktu
AS
SELECT ID_produkt, Produkt, SUM(Czas) AS Czas FROM (SELECT ID_produkt, Produkt, SUM(Czas) AS Czas FROM v_Czas_wytwarzanie_polprodukt
GROUP BY ID_produkt, Produkt
UNION
SELECT ID_produkt, Produkt, Czas AS Czas FROM v_Czas_wytwarzanie_produkt) AS suma
GROUP BY ID_produkt, Produkt
GO

CREATE VIEW v_Proces_wytwarzanie_produkt
AS
SELECT W.ID_wytwarzanie AS [ID], P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynnoœæ produkcyjna], Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SST.Nazwa_stanowiska AS [Stanowisko], PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczêcia], W.Czas_do AS [Data zakoñczenia]
FROM Proces_wytwarzanie_produkt AS PWP
INNER JOIN Wytwarzanie AS W ON PWP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Stanowisko_produkcyjne AS SP ON PPPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
GO

CREATE VIEW v_Proces_wytwarzanie_produkt_ewidencja
AS
SELECT W.ID_wytwarzanie AS [ID], P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynnoœæ produkcyjna],Pr.ID_pracownik, Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SST.Nazwa_stanowiska AS [Stanowisko], PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczêcia], W.Czas_do AS [Data zakoñczenia], ISNULL(DATEDIFF(MINUTE, W.Czas_od,W.Czas_do),0) AS [Czas pracy]
FROM Proces_wytwarzanie_produkt AS PWP
INNER JOIN Wytwarzanie AS W ON PWP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Stanowisko_produkcyjne AS SP ON PPPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
GO

CREATE VIEW v_Proces_wytwarzanie_produkt_koszt
AS
SELECT Z.ID_zamowienie AS [ID_zamowienie], P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynnoœæ produkcyjna], SP.ID_stanowisko_produkcyjne AS [ID_stanowisko], SST.Nazwa_stanowiska AS [Stanowisko],
W.Czas_od AS [Data rozpoczêcia], W.Czas_do AS [Data zakoñczenia], ISNULL(DATEDIFF(MINUTE, W.Czas_od,W.Czas_do),0) AS [Czas pracy], KRGS.[Koszt roboczogodziny stanowiska {PLN}],
CAST((ISNULL(DATEDIFF(MINUTE, W.Czas_od,W.Czas_do),0)*(KRGS.[Koszt roboczogodziny stanowiska {PLN}])/60) AS DECIMAL(6,2)) AS [Koszt_procesu]
FROM Proces_wytwarzanie_produkt AS PWP
INNER JOIN Wytwarzanie AS W ON PWP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Stanowisko_produkcyjne AS SP ON PPPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
INNER JOIN Zamowienie_szczegol AS ZS ON W.ID_zamowienie_szczegol = ZS.ID_zamowienie_szczegol
INNER JOIN Zamowienie AS Z ON ZS.ID_zamowienie = Z.ID_zamowienie
INNER JOIN v_Koszt_roboczogodziny_stanowiska AS KRGS ON SP.ID_stanowisko_produkcyjne = KRGS.[ID stanowiska produkcyjnego]
GO

CREATE VIEW v_Calkowity_koszt_zamowienia
AS
SELECT fs.ID_zamowienie, SUM(fs.Suma) AS Koszt FROM
(SELECT ID_zamowienie, SUM(Koszt_procesu) AS Suma FROM v_Proces_wytwarzanie_produkt_koszt
GROUP BY ID_zamowienie
UNION
SELECT ID_zamowienie, SUM(Koszt_procesu) AS Suma FROM v_Proces_wytwarzanie_polprodukt_koszt
GROUP BY ID_zamowienie) AS fs
GROUP BY fs.ID_zamowienie
GO

CREATE VIEW v_Wytworzone_polprodukty
AS
SELECT W.ID_wytwarzanie AS [ID], P.ID_polprodukt, P.Nazwa AS [Pó³rodukt], CP.Nazwa AS [Czynnoœæ produkcyjna], Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SST.Nazwa_stanowiska AS [Stanowisko], PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczêcia], W.Czas_do AS [Data zakoñczenia]
FROM Proces_wytwarzanie_polprodukt AS PWP
INNER JOIN Wytwarzanie AS W ON PWP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Stanowisko_produkcyjne AS SP ON PPPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Slownik_polprodukt AS P ON PPPC.ID_polprodukt = P.ID_polprodukt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
WHERE W.Czas_do <= GETDATE()
GO

CREATE VIEW v_Wytworzone_polprodukty_zamowienie
AS
SELECT W.ID_wytwarzanie AS [ID], P.ID_polprodukt, P.Nazwa AS [Pó³produkt], CP.Nazwa AS [Czynnoœæ produkcyjna], Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SST.Nazwa_stanowiska AS [Stanowisko], PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczêcia], W.Czas_do AS [Data zakoñczenia], Z.ID_zamowienie
FROM Proces_wytwarzanie_polprodukt AS PWP
INNER JOIN Wytwarzanie AS W ON PWP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Stanowisko_produkcyjne AS SP ON PPPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Slownik_polprodukt AS P ON PPPC.ID_polprodukt = P.ID_polprodukt
INNER JOIN Sklad_produkt AS SP1 ON PPPC.ID_polprodukt = SP1.ID_polprodukt
INNER JOIN Zamowienie_szczegol AS ZS ON W.ID_zamowienie_szczegol = ZS.ID_zamowienie_szczegol
INNER JOIN Zamowienie AS Z ON ZS.ID_zamowienie = Z.ID_zamowienie
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
WHERE W.Czas_do <= GETDATE() 
GO

CREATE VIEW v_Wytworzone_produkty
AS
SELECT W.ID_wytwarzanie AS [ID], P.ID_produkt, P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynnoœæ produkcyjna], Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SST.Nazwa_stanowiska AS [Stanowisko], PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczêcia], W.Czas_do AS [Data zakoñczenia]
FROM Proces_wytwarzanie_produkt AS PWP
INNER JOIN Wytwarzanie AS W ON PWP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Stanowisko_produkcyjne AS SP ON PPPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
WHERE W.Czas_do <= GETDATE() AND CP.Nazwa = 'Monta¿'
GO

CREATE VIEW v_Wytworzone_produkty_zamowienie
AS
SELECT W.ID_wytwarzanie AS [ID], P.ID_produkt, P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynnoœæ produkcyjna], Pr.Nazwisko + ' ' + Pr.Imie AS [Pracownik],
SST.Nazwa_stanowiska AS [Stanowisko], PPPC.Czas_trwania AS [Szacowany czas {min}],
W.Czas_od AS [Data rozpoczêcia], W.Czas_do AS [Data zakoñczenia], Z.ID_zamowienie
FROM Proces_wytwarzanie_produkt AS PWP
INNER JOIN Wytwarzanie AS W ON PWP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Stanowisko_produkcyjne AS SP ON PPPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Produkt AS P ON PPPC.ID_produkt = P.ID_produkt
INNER JOIN Pracownik AS Pr ON W.ID_pracownik = Pr.ID_pracownik
INNER JOIN Zamowienie_szczegol AS ZS ON W.ID_zamowienie_szczegol = ZS.ID_zamowienie_szczegol
INNER JOIN Zamowienie AS Z ON ZS.ID_zamowienie = Z.ID_zamowienie
WHERE W.Czas_do <= GETDATE() AND CP.Nazwa = 'Monta¿'
GO

CREATE VIEW v_Szacowany_czas_wytwarzania_produkt
AS
SELECT [Produkt], FORMAT(SUM([Szacowany czas {min}])/CAST(60 AS DECIMAL (4,1)),'0.######') AS [Czas wytwarzania {h}] FROM v_Proces_wytwarzanie_produkt
GROUP BY [Produkt]
GO

CREATE VIEW v_Stanowiska_produkcyjne
AS
SELECT SP.ID_stanowisko_produkcyjne, SS.Nazwa_stanowiska AS Nazwa
FROM Stanowisko_produkcyjne AS SP
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
GO

CREATE VIEW v_Nr_seryjny_maszyna
AS
SELECT MNS.ID_maszyna_nr AS [ID maszyny], M.Nazwa_maszyna AS [Nazwa maszyny], NS.Nr_seryjny AS [Numer seryjny]
FROM Maszyna_nr_seryjny AS MNS
INNER JOIN Maszyna AS M ON MNS.ID_maszyna = M.ID_maszyna
INNER JOIN Nr_seryjny AS NS ON MNS.ID_nr_seryjny = NS.ID_nr_seryjny
WHERE NS.Nr_seryjny NOT IN
(SELECT [Nr seryjny maszyny] FROM v_Sklad_stanowisko_produkcyjne_maszyna);
GO

CREATE VIEW v_Alerty_ProductionDepartment
AS
SELECT Alert.ID_alert, Dzial.ID_dzial, Dzial.Nazwa_dzial, Alert.Tresc, Alert.Czy_odczytano 
FROM Alert 
INNER JOIN Dzial ON Alert.ID_dzial = Dzial.ID_dzial
WHERE Alert.ID_dzial = 3 OR Alert.ID_dzial = 7
GO

CREATE VIEW v_Alerty_ProductionDepartment_nieodczytane
AS
SELECT * 
FROM v_Alerty_ProductionDepartment 
WHERE Czy_odczytano=0
GO

-----RESOURCE DEPARTMENT----

CREATE VIEW v_Sklad_maszyna 
AS 
SELECT Maszyna.ID_maszyna, Czesc.ID_czesc, Sklad_maszyna.ID_sklad_maszyna, Maszyna.Nazwa_maszyna AS [Nazwa maszyny], Czesc.Nazwa_czesc AS [Nazwa czêœci], Sklad_maszyna.Ilosc_czesci AS [Liczba czesci]
FROM Sklad_maszyna 
INNER JOIN Maszyna
ON Sklad_maszyna.ID_maszyna=Maszyna.ID_maszyna
INNER JOIN Czesc 
ON Sklad_maszyna.ID_czesc=Czesc.ID_czesc
GROUP BY Maszyna.ID_maszyna, Czesc.ID_czesc, Sklad_maszyna.ID_sklad_maszyna, Maszyna.Nazwa_maszyna, Czesc.Nazwa_czesc, Sklad_maszyna.Ilosc_czesci;
GO

CREATE VIEW v_Sklad_SP_maszyna
AS
SELECT SP.ID_stanowisko_produkcyjne AS [ID stanowiska produkcyjnego], MS.ID_maszyna_nr, M.ID_maszyna,
NS.Nr_seryjny AS [Nr seryjny maszyny], M.Nazwa_maszyna AS [Maszyna]
FROM Sklad_stanowisko_produkcyjne_maszyna AS SSPM
INNER JOIN Stanowisko_produkcyjne AS SP ON SSPM.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Maszyna_nr_seryjny AS MS ON SSPM.ID_maszyna_nr = MS.ID_maszyna_nr
INNER JOIN Maszyna AS M ON MS.ID_maszyna = M.ID_maszyna
INNER JOIN Nr_seryjny AS NS ON MS.ID_maszyna_nr = NS.ID_nr_seryjny
GO

CREATE VIEW v_Rodzaj_parametr
AS
SELECT RP.ID_rodzaj_parametr, RP.Nazwa_rodzaj_parametr + ' ' + Jednostka.Skrot AS [Parametr]
FROM Rodzaj_parametr AS RP
INNER JOIN Jednostka ON RP.ID_jednostka = Jednostka.ID_jednostka
GO

CREATE VIEW v_Material
AS
SELECT Material.ID_material, Rodzaj_material.ID_rodzaj_material, Rodzaj_material.Nazwa_rodzaj_material AS [Rodzaj materia³u], Nazwa_material AS [Nazwa materia³u]
FROM Material
INNER JOIN Rodzaj_material ON Material.ID_rodzaj_material = Rodzaj_material.ID_rodzaj_material
GO

CREATE VIEW v_Czesci
AS
SELECT Czesc.ID_czesc, Rodzaj_czesc.ID_rodzaj_czesc, Rodzaj_czesc.Nazwa_rodzaj_czesc AS [Rodzaj czêœci], Nazwa_czesc AS [Nazwa czêœci]
FROM Czesc
INNER JOIN Rodzaj_czesc ON Czesc.ID_rodzaj_czesc = Rodzaj_czesc.ID_rodzaj_czesc
GO

CREATE VIEW v_Maszyna
AS
SELECT Maszyna.ID_maszyna, Rodzaj_maszyna.ID_rodzaj_maszyna, Rodzaj_maszyna.Nazwa_rodzaj_maszyna AS [Rodzaj maszyny], Nazwa_maszyna AS [Nazwa maszyny], Koszt_RBG AS [Koszt roboczogodziny]
FROM Maszyna
INNER JOIN Rodzaj_maszyna ON Maszyna.ID_rodzaj_maszyna = Rodzaj_maszyna.ID_rodzaj_maszyna
GO

CREATE VIEW v_Parametry_maszyna AS
SELECT Maszyna.ID_maszyna, Rodzaj_parametr.ID_rodzaj_parametr, Maszyna.Nazwa_maszyna AS [Nazwa maszyny], Rodzaj_parametr.Nazwa_rodzaj_parametr AS [Parametr], Jednostka.Skrot AS [Jednostka], Zakres_dol AS [Zakres - granica dolna], Zakres_gora AS [Zakres - granica górna]
FROM Parametr_maszyna
INNER JOIN Maszyna
ON Parametr_maszyna.ID_maszyna=Maszyna.ID_maszyna
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_maszyna.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Maszyna.ID_maszyna, Rodzaj_parametr.ID_rodzaj_parametr, Maszyna.Nazwa_maszyna, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora;
GO

CREATE VIEW v_Parametry_material AS
SELECT Material.ID_material, Rodzaj_parametr.ID_rodzaj_parametr, Material.Nazwa_material AS [Nazwa materia³u], Rodzaj_parametr.Nazwa_rodzaj_parametr AS [Parametr], Jednostka.Skrot AS [Jednostka], Zakres_dol AS [Zakres - granica dolna], Zakres_gora AS [Zakres - granica górna]
FROM Parametr_material
INNER JOIN Material
ON Parametr_material.ID_material=Material.ID_material
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_material.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Material.ID_material, Rodzaj_parametr.ID_rodzaj_parametr, Material.Nazwa_material, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora;
GO

CREATE VIEW v_Parametry_czesc AS
SELECT Czesc.ID_czesc, Rodzaj_parametr.ID_rodzaj_parametr, Czesc.Nazwa_czesc AS [Nazwa czêœci], Rodzaj_parametr.Nazwa_rodzaj_parametr AS [Parametr], Jednostka.Skrot AS [Jednostka], Zakres_dol AS [Zakres - granica dolna], Zakres_gora AS [Zakres - granica górna]
FROM Parametr_czesc
INNER JOIN Czesc
ON Parametr_czesc.ID_czesc=Czesc.ID_czesc
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_czesc.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Czesc.ID_czesc, Rodzaj_parametr.ID_rodzaj_parametr, Czesc.Nazwa_czesc, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora;
GO

CREATE VIEW v_Parametry_narzedzie AS
SELECT Narzedzie.ID_narzedzie, Rodzaj_parametr.ID_rodzaj_parametr, Narzedzie.Nazwa_narzedzie AS [Nazwa narzêdzia], Rodzaj_parametr.Nazwa_rodzaj_parametr AS [Parametr], Jednostka.Skrot AS [Jednostka], Zakres_dol AS [Zakres - granica dolna], Zakres_gora AS [Zakres - granica górna]
FROM Parametr_narzedzie
INNER JOIN Narzedzie
ON Parametr_narzedzie.ID_narzedzie=Narzedzie.ID_narzedzie
INNER JOIN (Jednostka INNER JOIN Rodzaj_parametr ON Jednostka.ID_jednostka=Rodzaj_parametr.ID_jednostka)
ON Parametr_narzedzie.ID_rodzaj_parametr=Rodzaj_parametr.ID_rodzaj_parametr
GROUP BY Narzedzie.ID_narzedzie, Rodzaj_parametr.ID_rodzaj_parametr, Narzedzie.Nazwa_narzedzie, Rodzaj_parametr.Nazwa_rodzaj_parametr, Jednostka.Skrot, Zakres_dol, Zakres_gora
GO

CREATE VIEW v_Obslugi_zakonczone
AS
SELECT SP.ID_stanowisko_produkcyjne AS [Nr stanowiska], RO.Nazwa_rodzaj_obsluga AS [Obs³uga], Data_od AS [Data rozpoczêcia], Data_do AS [Data zakoñczenia]
FROM Obsluga_pracownik AS OP
INNER JOIN Obsluga AS O ON OP.ID_obsluga = O.ID_obsluga
INNER JOIN Rodzaj_obsluga AS RO ON O.ID_rodzaj_obsluga = RO.ID_rodzaj_obsluga
INNER JOIN Stanowisko_produkcyjne AS SP ON O.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
WHERE Data_do IS NOT NULL AND GETDATE() > Data_do
GO

CREATE VIEW v_Obslugi_zakonczone_suma 
AS
SELECT [Nr stanowiska], [Obs³uga], COUNT(Obs³uga) AS [Iloœæ]
FROM v_Obslugi_zakonczone
GROUP BY [Nr stanowiska], [Obs³uga]
GO

CREATE VIEW v_Obslugi_w_trakcie
AS
SELECT ID_obsluga AS [ID], SP.ID_stanowisko_produkcyjne AS [Nr stanowiska], RO.Nazwa_rodzaj_obsluga AS [Obs³uga], Data_od AS [Data rozpoczêcia], Data_do AS [Data zakoñczenia]
FROM Obsluga AS O
INNER JOIN Rodzaj_obsluga AS RO ON O.ID_rodzaj_obsluga = RO.ID_rodzaj_obsluga
INNER JOIN Stanowisko_produkcyjne AS SP ON O.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
WHERE Data_do IS NULL
GO

CREATE VIEW v_Stanowiska_w_uzyciu
AS
SELECT SP.ID_stanowisko_produkcyjne, SS.Nazwa_stanowiska AS Nazwa
FROM Proces_wytwarzanie_produkt AS PWP
INNER JOIN Wytwarzanie AS W ON PWP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_produkt_czynnosc AS PPPC ON PWP.ID_proces_produkt = PPPC.ID_proces_produkt
INNER JOIN Stanowisko_produkcyjne AS SP ON PPPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
LEFT JOIN v_Obslugi_w_trakcie AS OWT ON SP.ID_stanowisko_produkcyjne = OWT.[Nr stanowiska]
WHERE W.Czas_do IS NULL OR W.Czas_do >= GETDATE() OR OWT.Obs³uga IS NOT NULL
UNION
SELECT SP.ID_stanowisko_produkcyjne, SS.Nazwa_stanowiska AS Nazwa
FROM Proces_wytwarzanie_polprodukt AS PWPP
INNER JOIN Wytwarzanie AS W ON PWPP.ID_wytwarzanie = W.ID_wytwarzanie
INNER JOIN Proces_polprodukt_czynnosc AS PPPC ON PWPP.ID_proces_polprodukt = PPPC.ID_proces_polprodukt
INNER JOIN Stanowisko_produkcyjne AS SP ON PPPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
LEFT JOIN v_Obslugi_w_trakcie AS OWT ON SP.ID_stanowisko_produkcyjne = OWT.[Nr stanowiska]
WHERE W.Czas_do IS NULL OR W.Czas_do >= GETDATE() OR OWT.Obs³uga IS NOT NULL
GO

CREATE VIEW v_Stanowiska_do_uzycia
AS
SELECT SP.ID_stanowisko_produkcyjne, SS.Nazwa_stanowiska AS Nazwa FROM Stanowisko_produkcyjne AS SP
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
EXCEPT
SELECT * FROM v_Stanowiska_w_uzyciu
GO

CREATE VIEW v_Obslugi_w_trakcie_wymiana
AS
SELECT ID_obsluga AS [ID], SP.ID_stanowisko_produkcyjne AS [Nr stanowiska], RO.Nazwa_rodzaj_obsluga AS [Obs³uga], Data_od AS [Data rozpoczêcia], Data_do AS [Data zakoñczenia]
FROM Obsluga AS O
INNER JOIN Rodzaj_obsluga AS RO ON O.ID_rodzaj_obsluga = RO.ID_rodzaj_obsluga
INNER JOIN Stanowisko_produkcyjne AS SP ON O.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
WHERE Data_do IS NULL AND RO.Nazwa_rodzaj_obsluga = 'Wymiana czesci'
GO

CREATE VIEW v_Obsluga_cmb
AS
SELECT [ID], CONVERT(nvarchar,[ID]) + ': ' + [Obs³uga] + ' - ' + CONVERT(nvarchar,[Data rozpoczêcia]) AS [ComboObsluga]
FROM v_Obslugi_w_trakcie
GO

CREATE VIEW v_Obsluga_cmb_wymiana
AS
SELECT [ID], CONVERT(nvarchar,[ID]) + ': ' + [Obs³uga] + ' - ' + CONVERT(nvarchar,[Data rozpoczêcia]) AS [ComboObsluga]
FROM v_Obslugi_w_trakcie
WHERE [Obs³uga]='Wymiana czesci' 
GO

CREATE VIEW v_Obsluga_pracownik
AS
SELECT Obsluga.ID_obsluga, Pracownik.ID_pracownik, Rodzaj_obsluga.Nazwa_rodzaj_obsluga AS [Obs³uga], Pracownik.Nazwisko + ' ' + Pracownik.Imie AS [Pracownik]
FROM Obsluga_pracownik
INNER JOIN Obsluga ON Obsluga_pracownik.ID_obsluga = Obsluga.ID_obsluga
INNER JOIN Pracownik ON Obsluga_pracownik.ID_pracownik = Pracownik.ID_pracownik
INNER JOIN Rodzaj_obsluga ON Obsluga.ID_rodzaj_obsluga = Rodzaj_obsluga.ID_rodzaj_obsluga
GROUP BY Obsluga.ID_obsluga, Pracownik.ID_pracownik, Rodzaj_obsluga.Nazwa_rodzaj_obsluga, Pracownik.Nazwisko + ' ' + Pracownik.Imie
GO

CREATE VIEW v_Maszyna_nr_seryjny
AS
SELECT Maszyna_nr_seryjny.ID_maszyna_nr, Nazwa_maszyna + ' ' + Nr_seryjny.Nr_seryjny AS [Maszyna nr]
FROM Maszyna
INNER JOIN Maszyna_nr_seryjny ON Maszyna.ID_maszyna = Maszyna_nr_seryjny.ID_maszyna
INNER JOIN Nr_seryjny ON Maszyna_nr_seryjny.ID_nr_seryjny = Nr_seryjny.ID_nr_seryjny
GO

CREATE VIEW v_Zamowienia_czesci_w_trakcie_wszystko 
AS 
SELECT ZC.ID_zamowienie_czesc AS [Nr zamówienia], C.Nazwa_czesc AS [Nazwa czêœci], SRZC.Data_stan [Data zmiany stanu], Ilosc AS [Iloœæ], Cena, D.Nazwa_dostawca AS [Dostawca], SZ.Nazwa_status AS [Status], SZ.ID_status_zamowienie AS [StatusID], SZC.ID_czesc
FROM Szczegoly_zamowienie_czesc AS SZC 
INNER JOIN Zamowienie_czesc AS ZC ON SZC.ID_zamowienie_czesc = ZC.ID_zamowienie_czesc 
INNER JOIN Czesc AS C ON SZC.ID_czesc = C.ID_czesc 
INNER JOIN Stan_realizacji_zamowienie_czesc AS SRZC ON ZC.ID_zamowienie_czesc = SRZC.ID_zamowienie_czesc 
INNER JOIN Status_zamowienie AS SZ ON SRZC.ID_status_zamowienie = SZ.ID_status_zamowienie 
INNER JOIN Dostawca AS D ON ZC.ID_dostawca = D.ID_dostawca
GO 

CREATE VIEW v_Zamowienia_czesci_w_trakcie_bez_odebranych 
AS 
SELECT ZCWTW.[Nr zamówienia], ZCWTW.[Nazwa czêœci], ZCWTW.[Data zmiany stanu], ZCWTW.[Iloœæ], ZCWTW.Cena, ZCWTW.[Status], ZCWTW.[StatusID] 
FROM v_Zamowienia_czesci_w_trakcie_wszystko AS ZCWTW 
LEFT JOIN v_Zamowienia_czesci_w_trakcie_wszystko AS ZCWTWA ON ZCWTW.[Nr zamówienia] = ZCWTWA.[Nr zamówienia] AND ZCWTWA.[Status] = 'Odebrano' 
WHERE ZCWTWA.[Nr zamówienia] IS NULL 
GO 

CREATE VIEW v_Zamowienia_czesci_w_trakcie 
AS 
SELECT a.* 
FROM v_Zamowienia_czesci_w_trakcie_bez_odebranych AS a 
LEFT JOIN v_Zamowienia_czesci_w_trakcie_bez_odebranych AS b ON a.[Nr zamówienia] = b.[Nr zamówienia] AND a.StatusID < b.StatusID 
WHERE b.StatusID IS NULL 
GO 

CREATE VIEW v_Zamowienia_materialy_w_trakcie_wszystko 
AS 
SELECT ZM.ID_zamowienie_material AS [Nr zamówienia], M.ID_material, M.Nazwa_material AS [Nazwa materia³u], SRZM.Data_stan [Data zmiany stanu], Waga_g AS [Waga (g)], Cena, D.Nazwa_dostawca AS [Dostawca], SZ.Nazwa_status AS [Status], SZ.ID_status_zamowienie AS [StatusID] 
FROM Szczegoly_zamowienie_material AS SZM 
INNER JOIN Zamowienie_material AS ZM ON SZM.ID_zamowienie_material = ZM.ID_zamowienie_material 
INNER JOIN Material AS M ON SZM.ID_material = M.ID_material 
INNER JOIN Stan_realizacji_zamowienie_material AS SRZM ON ZM.ID_zamowienie_material = SRZM.ID_zamowienie_material 
INNER JOIN Status_zamowienie AS SZ ON SRZM.ID_status_zamowienie = SZ.ID_status_zamowienie 
INNER JOIN Dostawca AS D ON ZM.ID_dostawca = D.ID_dostawca
GO 

CREATE VIEW v_Zamowienia_materialy_w_trakcie_bez_odebranych 
AS 
SELECT ZMWTW.[Nr zamówienia], ZMWTW.[Nazwa materia³u], ZMWTW.[Data zmiany stanu], ZMWTW.[Waga (g)], ZMWTW.Cena, ZMWTW.[Status], ZMWTW.[StatusID] 
FROM v_Zamowienia_materialy_w_trakcie_wszystko AS ZMWTW 
LEFT JOIN v_Zamowienia_materialy_w_trakcie_wszystko AS ZMWTWA ON ZMWTW.[Nr zamówienia] = ZMWTWA.[Nr zamówienia] AND ZMWTWA.[Status] = 'Odebrano' 
WHERE ZMWTWA.[Nr zamówienia] IS NULL 
GO 

CREATE VIEW v_Zamowienia_materialy_w_trakcie 
AS 
SELECT a.* 
FROM v_Zamowienia_materialy_w_trakcie_bez_odebranych AS a 
LEFT JOIN v_Zamowienia_materialy_w_trakcie_bez_odebranych AS b ON a.[Nr zamówienia] = b.[Nr zamówienia] AND a.StatusID < b.StatusID 
WHERE b.StatusID IS NULL 
GO

CREATE VIEW v_Zamowienia_narzedzia_w_trakcie_wszystko 
AS 
SELECT ZN.ID_zamowienie_narzedzie AS [Nr zamówienia], N.Nazwa_narzedzie AS [Nazwa narzêdzia], SRZN.Data_stan [Data zmiany stanu], Sztuk, Cena, D.Nazwa_dostawca AS [Dostawca], SZ.Nazwa_status AS [Status], SZ.ID_status_zamowienie AS [StatusID], SZN.ID_narzedzie
FROM Szczegoly_zamowienie_narzedzie AS SZN 
INNER JOIN Zamowienie_narzedzie AS ZN ON SZN.ID_zamowienie_narzedzie = ZN.ID_zamowienie_narzedzie 
INNER JOIN Narzedzie AS N ON SZN.ID_narzedzie = N.ID_narzedzie
INNER JOIN Stan_realizacji_zamowienie_narzedzie AS SRZN ON ZN.ID_zamowienie_narzedzie = SRZN.ID_zamowienie_narzedzie 
INNER JOIN Status_zamowienie AS SZ ON SRZN.ID_status_zamowienie = SZ.ID_status_zamowienie 
INNER JOIN Dostawca AS D ON ZN.ID_dostawca = D.ID_dostawca
GO 

CREATE VIEW v_Zamowienia_narzedzia_w_trakcie_bez_odebranych 
AS 
SELECT ZNWTW.[Nr zamówienia], ZNWTW.[Nazwa narzêdzia], ZNWTW.[Data zmiany stanu], ZNWTW.Sztuk, ZNWTW.Cena, ZNWTW.[Status], ZNWTW.[StatusID] 
FROM v_Zamowienia_narzedzia_w_trakcie_wszystko AS ZNWTW 
LEFT JOIN v_Zamowienia_narzedzia_w_trakcie_wszystko AS ZNWTWA ON ZNWTW.[Nr zamówienia] = ZNWTWA.[Nr zamówienia] AND ZNWTWA.[Status] = 'Odebrano'
WHERE ZNWTWA.[Nr zamówienia] IS NULL 
GO 

CREATE VIEW v_Zamowienia_narzedzia_w_trakcie 
AS 
SELECT a.* 
FROM v_Zamowienia_narzedzia_w_trakcie_bez_odebranych AS a 
LEFT JOIN v_Zamowienia_narzedzia_w_trakcie_bez_odebranych AS b ON a.[Nr zamówienia] = b.[Nr zamówienia] AND a.StatusID < b.StatusID 
WHERE b.StatusID IS NULL 
GO

CREATE VIEW v_Zamowienia_maszyny_w_trakcie_wszystko 
AS 
SELECT ZM.ID_zamowienie_maszyna AS [Nr zamówienia], M.Nazwa_maszyna AS [Nazwa maszyny], SRZM.Data_stan AS [Data zmiany stanu], Ilosc AS [Iloœæ], Cena, D.Nazwa_dostawca AS [Dostawca], SZ.Nazwa_status AS [Status], SZ.ID_status_zamowienie AS [StatusID], SZM.ID_maszyna
FROM Szczegoly_zamowienie_maszyna AS SZM 
INNER JOIN Zamowienie_maszyna AS ZM ON SZM.ID_zamowienie_maszyna = ZM.ID_zamowienie_maszyna
INNER JOIN Maszyna AS M ON SZM.ID_maszyna = M.ID_maszyna
INNER JOIN Stan_realizacji_zamowienie_maszyna AS SRZM ON ZM.ID_zamowienie_maszyna = SRZM.ID_zamowienie_maszyna
INNER JOIN Status_zamowienie AS SZ ON SRZM.ID_status_zamowienie = SZ.ID_status_zamowienie 
INNER JOIN Dostawca AS D ON ZM.ID_dostawca = D.ID_dostawca
GROUP BY M.Nazwa_maszyna, ZM.ID_zamowienie_maszyna, SRZM.Data_stan, Ilosc, Cena, D.Nazwa_dostawca, SZ.Nazwa_status, SZ.ID_status_zamowienie, SZM.ID_maszyna
GO

CREATE VIEW v_Zamowienia_maszyny_w_trakcie_bez_odebranych 
AS 
SELECT ZMWTW.[Nr zamówienia], ZMWTW.[Nazwa maszyny], ZMWTW.[Data zmiany stanu], ZMWTW.Iloœæ, ZMWTW.Cena, ZMWTW.[Status], ZMWTW.[StatusID] 
FROM v_Zamowienia_maszyny_w_trakcie_wszystko  AS ZMWTW 
LEFT JOIN v_Zamowienia_maszyny_w_trakcie_wszystko AS ZMWTWA ON ZMWTW.[Nr zamówienia] = ZMWTWA.[Nr zamówienia] AND ZMWTWA.[Status] = 'Odebrano' 
WHERE ZMWTWA.[Nr zamówienia] IS NULL 
GO 

CREATE VIEW v_Zamowienia_maszyny_w_trakcie 
AS 
SELECT a.* 
FROM v_Zamowienia_maszyny_w_trakcie_bez_odebranych AS a 
LEFT JOIN v_Zamowienia_maszyny_w_trakcie_bez_odebranych AS b ON a.[Nr zamówienia] = b.[Nr zamówienia] AND a.StatusID < b.StatusID 
WHERE b.StatusID IS NULL 
GO

CREATE VIEW v_Magazyn_maszyn_wszystko 
AS
SELECT [Nazwa maszyny], SUM([Iloœæ]) AS [Liczba sztuk], ID_maszyna
FROM v_Zamowienia_maszyny_w_trakcie_wszystko 
WHERE StatusID = 4
GROUP BY [Nazwa maszyny], ID_maszyna
GO

CREATE VIEW v_Magazyn_maszyn_uzywane
AS
SELECT Maszyna, COUNT(Maszyna) AS [Liczba]
FROM v_Sklad_stanowisko_produkcyjne_maszyna AS SSPM
GROUP BY Maszyna
GO

CREATE VIEW v_Magazyn_maszyn_stan
AS
SELECT [Nazwa maszyny], [Liczba sztuk], IsNull(Liczba,0) as U¿ywane, ID_maszyna
FROM v_Magazyn_maszyn_wszystko AS MMW
LEFT JOIN v_Magazyn_maszyn_uzywane AS MMU ON MMW.[Nazwa maszyny]=MMU.Maszyna
GO

CREATE VIEW v_Magazyn_maszyn_nieuzywane
AS
SELECT [Nazwa maszyny], [Liczba sztuk]-U¿ywane AS [Iloœæ w magazynie], ID_maszyna
FROM v_Magazyn_maszyn_stan
GO

CREATE VIEW v_Magazyn_narzedzia_wszystko
AS
SELECT [Nazwa narzêdzia], SUM(Sztuk) AS [Iloœæ sztuk], ID_narzedzie
FROM v_Zamowienia_narzedzia_w_trakcie_wszystko
WHERE StatusID=4
GROUP BY [Nazwa narzêdzia], ID_narzedzie
GO

CREATE VIEW v_Magazyn_narzedzia_uzywane
AS
SELECT Narzêdzie, SUM (Ilosc) AS Liczba
FROM v_Sklad_stanowisko_produkcyjne_narzedzie AS SSPN
GROUP BY Narzêdzie
GO

CREATE VIEW v_Magazyn_narzedzia_stan
AS
SELECT [Nazwa narzêdzia], MNW.[Iloœæ sztuk], IsNull(Liczba,0) as U¿ywane, MNW.ID_narzedzie
FROM v_Magazyn_narzedzia_wszystko AS MNW
LEFT JOIN v_Magazyn_narzedzia_uzywane AS MNU ON MNW.[Nazwa narzêdzia]=MNU.[Narzêdzie]
GO

CREATE VIEW v_Magazyn_narzedzia_nieuzywane
AS
SELECT [Nazwa narzêdzia], [Iloœæ sztuk]-U¿ywane AS [Iloœæ w magazynie], ID_narzedzie
FROM v_Magazyn_narzedzia_stan
GO

CREATE VIEW v_Magazyn_narzedzia_nieuzywane_ID
AS
SELECT Narzedzie.ID_narzedzie, v_Magazyn_narzedzia_nieuzywane.[Nazwa narzêdzia], v_Magazyn_narzedzia_nieuzywane.[Iloœæ w magazynie]
FROM Narzedzie INNER JOIN v_Magazyn_narzedzia_nieuzywane ON Narzedzie.Nazwa_narzedzie = v_Magazyn_narzedzia_nieuzywane.[Nazwa narzêdzia]
GO

CREATE VIEW v_Magazyn_czesci_wszystko
AS
SELECT [Nazwa czêœci], SUM([Iloœæ]) AS [Iloœæ], ID_czesc
FROM v_Zamowienia_czesci_w_trakcie_wszystko 
WHERE StatusID = 4
GROUP BY [Nazwa czêœci], ID_czesc
GO

CREATE VIEW v_Magazyn_Produkty_Wytworzone
AS
SELECT KPP.Produkt AS [Nazwa Produktu], KPP.[Rezultat kontroli]
FROM v_Kontrola_parametr_produkt AS KPP
GO

CREATE VIEW v_Maszyny_numery_przypisane
AS
SELECT Maszyna.ID_maszyna AS [ID], Maszyna.Nazwa_maszyna AS [Nazwa maszyny], COUNT(Maszyna.Nazwa_maszyna) AS [Ile przypisano]
FROM Maszyna_nr_seryjny AS MNS
INNER JOIN Maszyna ON MNS.ID_maszyna = Maszyna.ID_maszyna
INNER JOIN Nr_seryjny ON MNS.ID_nr_seryjny = Nr_seryjny.ID_nr_seryjny
GROUP BY Maszyna.ID_maszyna, Maszyna.Nazwa_maszyna
GO

CREATE VIEW v_Maszyny_numery_porownanie
AS
SELECT [ID], MMW.[Nazwa maszyny], MMW.[Liczba sztuk], MNP.[Ile przypisano]
FROM v_Magazyn_maszyn_wszystko AS MMW
LEFT JOIN v_Maszyny_numery_przypisane AS MNP ON MMW.[Nazwa maszyny] = MNP.[Nazwa maszyny]
GO

CREATE VIEW v_Maszyny_numery_nieprzypisane
AS
SELECT [ID], [Nazwa maszyny], [Liczba sztuk]-[Ile przypisano] AS [Nieprzypisanych]
FROM v_Maszyny_numery_porownanie
GO

CREATE VIEW v_Maszyny_numery_nieprzypisane_zero
AS
SELECT * FROM v_Maszyny_numery_nieprzypisane
WHERE [Nieprzypisanych]>0
GO

CREATE VIEW v_Magazyn_material_wszystko 
AS
SELECT ID_material, [Nazwa materia³u], SUM([Waga (g)]) AS [Waga (g)]
FROM v_Zamowienia_materialy_w_trakcie_wszystko 
WHERE StatusID = 4
GROUP BY ID_material, [Nazwa materia³u]
GO

CREATE VIEW v_Polprodukt_material
AS
SELECT SP.ID_polprodukt, M.ID_material, SlwPp.Nazwa AS [Pó³produkt], M.Nazwa_material AS [Materia³], RM.Nazwa_rodzaj_material AS [Rodzaj],
SP.Ilosc AS [Waga (g)]
FROM Sklad_polprodukt AS SP
INNER JOIN Slownik_polprodukt AS SlwPp ON SP.ID_polprodukt = SlwPp.ID_polprodukt
INNER JOIN Material AS M ON SP.ID_material = M.ID_material
INNER JOIN Rodzaj_material AS RM ON M.ID_rodzaj_material = RM.ID_rodzaj_material
ORDER BY SP.ID_polprodukt OFFSET 0 ROWS
GO

CREATE VIEW v_Wytworzone_produkty_sklad
AS
SELECT WP.ID_produkt, SPE.ID_polprodukt, SPE.Ilosc
FROM v_Wytworzone_produkty AS WP
INNER JOIN v_Sklad_produkt_ewidencja AS SPE ON WP.ID_produkt=SPE.ID_produkt
GROUP BY WP.ID_produkt, SPE.ID_polprodukt, SPE.Ilosc
GO

CREATE VIEW v_Wytworzone_polprodukty_material
AS
SELECT WPS.ID_produkt, WPS.ID_polprodukt, PPM.ID_material, PPM.Materia³, WPS.Ilosc * PPM.[Waga (g)] AS [Zuzyty material (g)]
FROM v_Wytworzone_produkty_sklad AS WPS
INNER JOIN v_Polprodukt_material AS PPM ON WPS.ID_polprodukt =PPM.ID_polprodukt
GROUP BY WPS.ID_produkt, WPS.ID_polprodukt, PPM.ID_material, PPM.Materia³, WPS.Ilosc, PPM.[Waga (g)]
GO

CREATE VIEW v_Produkt_material
AS
SELECT P.ID_produkt, M.ID_material, P.Nazwa_produkt AS [Produkt], M.Nazwa_material AS [Materia³], RM.Nazwa_rodzaj_material AS [Rodzaj],
SPM.Ilosc_g AS [Waga (g)]
FROM Sklad_produkt_material AS SPM
INNER JOIN Produkt AS P ON SPM.ID_produkt = P.ID_produkt
INNER JOIN Material AS M ON SPM.ID_material = M.ID_material
INNER JOIN Rodzaj_material AS RM ON M.ID_rodzaj_material = RM.ID_rodzaj_material
GO

CREATE VIEW v_Wytworzony_produkt_material
AS
SELECT WPS.ID_produkt, PM.ID_material, PM.Materia³, PM.[Waga (g)] 
FROM v_Wytworzone_produkty_sklad AS WPS
INNER JOIN v_Produkt_material AS PM ON WPS.ID_produkt=PM.ID_produkt
GO

CREATE VIEW v_Magazyn_material_przejsciowy
AS
SELECT MMW.ID_material, MMW.[Nazwa materia³u], MMW.[Waga (g)], ISNULL(WPM.[Zuzyty material (g)],0) AS [Waga material polprodukt (g)], ISNULL(WPMM.[Waga (g)],0) AS [Waga material produkt (g)] 
FROM v_Magazyn_material_wszystko AS MMW
LEFT JOIN v_Wytworzone_polprodukty_material AS WPM ON MMW.ID_material=WPM.ID_material 
LEFT JOIN v_Wytworzony_produkt_material AS WPMM ON WPMM.ID_material=MMW.ID_material
GROUP BY MMW.ID_material, MMW.[Nazwa materia³u], MMW.[Waga (g)], WPM.[Zuzyty material (g)], WPMM.[Waga (g)] 
GO

CREATE VIEW v_Magazyn_material_aktualny_dodanie
AS
SELECT MMP.ID_material, MMP.[Nazwa materia³u], MMP.[Waga (g)], SUM (MMP.[Waga material polprodukt (g)]) AS [Waga material polprodukt (g)], SUM (MMP.[Waga material produkt (g)])  AS [Waga material produkt (g)]  
FROM v_Magazyn_material_przejsciowy AS MMP
GROUP BY MMP.ID_material, MMP.[Nazwa materia³u], MMP.[Waga (g)]	
GO
CREATE VIEW v_Magazyn_material_aktualny
AS
SELECT  MMP.ID_material, MMP.[Nazwa materia³u], (MMP.[Waga (g)] - MMP.[Waga material polprodukt (g)] - MMP.[Waga material produkt (g)]) AS [Stan w magazynie g]
FROM v_Magazyn_material_aktualny_dodanie AS MMP
GROUP BY MMP.ID_material, MMP.[Nazwa materia³u], MMP.[Waga (g)],MMP.[Waga material polprodukt (g)],MMP.[Waga material produkt (g)]
GO

CREATE VIEW v_Alerty_ResourceDepartment
AS
SELECT Alert.ID_alert, Dzial.ID_dzial, Dzial.Nazwa_dzial, Alert.Tresc, Alert.Czy_odczytano 
FROM Alert 
INNER JOIN Dzial ON Alert.ID_dzial = Dzial.ID_dzial
WHERE Alert.ID_dzial = 4 OR Alert.ID_dzial = 5
GO

CREATE VIEW v_Alerty_ResorceDepartment_nieodczytane
AS
SELECT * 
FROM v_Alerty_ResourceDepartment 
WHERE Czy_odczytano=0
GO

CREATE VIEW v_Zamowienia_czesc_status_zamowiono
AS
SELECT *
FROM v_Zamowienia_czesci_w_trakcie_wszystko	
WHERE StatusID=1
GO

CREATE VIEW v_Zamowienia_czesc_status_zamowiono_zmiana_daty
AS
SELECT CONVERT(varchar(7),CAST([Data zmiany stanu] AS DATE),126) AS [Data miesiac], Cena
FROM v_Zamowienia_czesc_status_zamowiono
GO

CREATE VIEW v_Zamowienia_czesci_koszt 
AS
SELECT [Data miesiac], SUM (Cena) AS [£¹czna cena]
FROM v_Zamowienia_czesc_status_zamowiono_zmiana_daty
GROUP BY [Data miesiac]
GO

CREATE VIEW v_Zamowienia_maszyna_status_zamowiono
AS
SELECT *
FROM v_Zamowienia_maszyny_w_trakcie_wszystko
WHERE StatusID=1
GO

CREATE VIEW v_Zamowienia_maszyna_status_zamowiono_zmiana_daty
AS
SELECT CONVERT(varchar(7),CAST([Data zmiany stanu] AS DATE),126) AS [Data miesiac], Cena
FROM v_Zamowienia_maszyna_status_zamowiono
GO

CREATE VIEW v_Zamowienia_maszyna_koszt 
AS
SELECT [Data miesiac], SUM (Cena) AS [£¹czna cena]
FROM v_Zamowienia_maszyna_status_zamowiono_zmiana_daty
GROUP BY [Data miesiac]
GO

CREATE VIEW v_Zamowienia_narzedzia_status_zamowiono
AS
SELECT *
FROM v_Zamowienia_narzedzia_w_trakcie_wszystko	
WHERE StatusID=1
GO

CREATE VIEW v_Zamowienia_narzedzia_status_zamowiono_zmiana_daty
AS
SELECT CONVERT(varchar(7),CAST([Data zmiany stanu] AS DATE),126) AS [Data miesiac], Cena
FROM v_Zamowienia_narzedzia_status_zamowiono
GO

CREATE VIEW v_Zamowienia_narzedzia_koszt 
AS
SELECT [Data miesiac], SUM (Cena) AS [£¹czna cena]
FROM v_Zamowienia_narzedzia_status_zamowiono_zmiana_daty
GROUP BY [Data miesiac]
GO

CREATE VIEW v_Zamowienia_material_status_zamowiono
AS
SELECT *
FROM v_Zamowienia_materialy_w_trakcie_wszystko
WHERE StatusID=1
GO

CREATE VIEW v_Zamowienia_material_status_zamowiono_zmiana_daty
AS
SELECT CONVERT(varchar(7),CAST([Data zmiany stanu] AS DATE),126) AS [Data miesiac], Cena
FROM v_Zamowienia_material_status_zamowiono
GO

CREATE VIEW v_Zamowienia_material_koszt
AS
SELECT [Data miesiac], SUM (Cena) AS [£¹czna cena]
FROM v_Zamowienia_material_status_zamowiono_zmiana_daty
GROUP BY [Data miesiac]
GO

CREATE VIEW v_Zamowienia_koszt_union
AS
SELECT * FROM v_Zamowienia_czesci_koszt
UNION 
SELECT * FROM v_Zamowienia_material_koszt
UNION 
SELECT * FROM v_Zamowienia_maszyna_koszt
UNION 
SELECT * FROM v_Zamowienia_narzedzia_koszt
GO

CREATE VIEW v_Zamowienia_koszt_suma
AS
SELECT [Data miesiac], SUM([£¹czna cena]) AS [Ca³kowity koszt]
FROM v_Zamowienia_koszt_union
GROUP BY [Data miesiac]
GO

CREATE VIEW v_Zamowienie_szczegol AS
	SELECT Zamowienie_szczegol.ID_zamowienie_szczegol AS [Nr szczegó³u], Zamowienie.ID_zamowienie AS [Nr zamówienia], Produkt.Nazwa_produkt AS [Produkt], Zamowienie_szczegol.Ilosc AS [Iloœæ]
	FROM Zamowienie_szczegol
	INNER JOIN Produkt ON Produkt.ID_produkt = Zamowienie_szczegol.ID_produkt
	INNER JOIN Zamowienie ON Zamowienie.ID_zamowienie = Zamowienie_szczegol.ID_zamowienie
GO

CREATE VIEW v_Zamowienie AS
	SELECT Zamowienie.Data_zamowienie AS [Data przyjêcia], Zamowienie.ID_zamowienie AS [Nr zamówienia], Klient.Nazwisko AS [Nazwisko klienta], Klient.Imie AS [Imiê klienta], Typ_zamowienie.Rodzaj_zamowienie AS [Typ zamówienia],
	Pracownik.Nazwisko AS [Nazwisko pracownika], Pracownik.Imie AS [Imiê pracownika]
	FROM Zamowienie
	INNER JOIN Klient ON Klient.ID_klient = Zamowienie.ID_klient
	INNER JOIN Pracownik ON Pracownik.ID_pracownik = Zamowienie.ID_pracownik
	INNER JOIN Typ_zamowienie ON Typ_zamowienie.ID_typ_zamowienie = Zamowienie.ID_typ_zamowienie
	ORDER BY Data_zamowienie DESC OFFSET 0 ROWS
GO

CREATE VIEW v_Srednia_cena_za_material AS
	SELECT v_Zamowienia_materialy_w_trakcie_wszystko.ID_material, AVG(v_Zamowienia_materialy_w_trakcie_wszystko.Cena/v_Zamowienia_materialy_w_trakcie_wszystko.[Waga (g)]) AS [Œrednia cena za (g)]
	FROM v_Zamowienia_materialy_w_trakcie_wszystko
	WHERE v_Zamowienia_materialy_w_trakcie_wszystko.StatusID = 4
	GROUP BY v_Zamowienia_materialy_w_trakcie_wszystko.ID_material
GO

CREATE VIEW v_Koszty_za_material_produkt AS
	SELECT DISTINCT Zamowienie.ID_zamowienie,Zamowienie_szczegol.ID_produkt,Zamowienie_szczegol.Ilosc,Sklad_produkt_material.Ilosc_g, v_Srednia_cena_za_material.[Œrednia cena za (g)],Zamowienie_szczegol.Ilosc*Sklad_produkt_material.Ilosc_g*v_Srednia_cena_za_material.[Œrednia cena za (g)] AS [Koszty za materia³y produktu]
	FROM Zamowienie
	INNER JOIN Zamowienie_szczegol ON Zamowienie_szczegol.ID_zamowienie = Zamowienie.ID_zamowienie
	INNER JOIN Produkt ON Produkt.ID_produkt = Zamowienie_szczegol.ID_produkt
	INNER JOIN Sklad_produkt_material ON Sklad_produkt_material.ID_produkt = Produkt.ID_produkt
	INNER JOIN Material ON Material.ID_material = Sklad_produkt_material.ID_material
	INNER JOIN v_Srednia_cena_za_material ON v_Srednia_cena_za_material.ID_material = Material.ID_material
	INNER JOIN Sklad_produkt ON Sklad_produkt.ID_produkt = Produkt.ID_produkt
	INNER JOIN Slownik_polprodukt ON Slownik_polprodukt.ID_polprodukt = Sklad_produkt.ID_polprodukt
	INNER JOIN Sklad_polprodukt ON Sklad_polprodukt.ID_polprodukt = Slownik_polprodukt.ID_polprodukt
GO

CREATE VIEW v_Koszty_za_material_produkt_suma AS 
	SELECT v_Koszty_za_material_produkt.ID_zamowienie, ROUND(SUM(v_Koszty_za_material_produkt.[Koszty za materia³y produktu]),0) AS [Suma kosztów materia³ów na produkt]
	FROM v_Koszty_za_material_produkt
	GROUP BY v_Koszty_za_material_produkt.ID_zamowienie
GO

CREATE VIEW v_Kwota_za_materialy_bez_produktu AS
	SELECT Zamowienie.ID_zamowienie, ROUND((Sum(Sklad_polprodukt.Ilosc*v_Srednia_cena_za_material.[Œrednia cena za (g)]*Sklad_produkt.Ilosc*Zamowienie_szczegol.Ilosc)),0) AS [Cena za zamówienie]
	FROM Zamowienie
	INNER JOIN Zamowienie_szczegol ON Zamowienie_szczegol.ID_zamowienie = Zamowienie.ID_zamowienie
	INNER JOIN Produkt ON Produkt.ID_produkt = Zamowienie_szczegol.ID_produkt
	INNER JOIN Sklad_produkt ON Sklad_produkt.ID_produkt = Produkt.ID_produkt
	INNER JOIN Slownik_polprodukt ON Slownik_polprodukt.ID_polprodukt = Sklad_produkt.ID_polprodukt
	INNER JOIN Sklad_polprodukt ON Sklad_polprodukt.ID_polprodukt = Slownik_polprodukt.ID_polprodukt
	INNER JOIN Material ON Material.ID_material = Sklad_polprodukt.ID_material
	INNER JOIN v_Srednia_cena_za_material ON v_Srednia_cena_za_material.ID_material = Material.ID_material
	GROUP BY Zamowienie.ID_zamowienie
GO

CREATE VIEW v_Kwota_za_materialy AS
	SELECT v_Koszty_za_material_produkt_suma.ID_zamowienie, ROUND(SUM(v_Koszty_za_material_produkt_suma.[Suma kosztów materia³ów na produkt]+v_Kwota_za_materialy_bez_produktu.[Cena za zamówienie]),0) AS [Cena za zamówienie]
	FROM v_Koszty_za_material_produkt_suma
	INNER JOIN v_Kwota_za_materialy_bez_produktu ON v_Kwota_za_materialy_bez_produktu.ID_zamowienie = v_Koszty_za_material_produkt_suma.ID_zamowienie
	GROUP BY v_Koszty_za_material_produkt_suma.ID_zamowienie
GO

CREATE VIEW v_Potrzebne_materialy_do_zamowienia AS
	SELECT Zamowienie_szczegol.ID_zamowienie,
	Material.ID_material,
	Material.Nazwa_material,
	SUM(Sklad_polprodukt.Ilosc) AS [Masa]
	FROM Zamowienie_szczegol
	INNER JOIN Zamowienie ON Zamowienie_szczegol.ID_zamowienie = Zamowienie.ID_zamowienie
	INNER JOIN Produkt ON Produkt.ID_produkt = Zamowienie_szczegol.ID_produkt
	INNER JOIN Material ON Material.ID_material = Produkt.ID_produkt
	INNER JOIN Sklad_polprodukt ON Sklad_polprodukt.ID_material = Material.ID_material
	INNER JOIN Slownik_polprodukt ON Slownik_polprodukt.ID_polprodukt = Sklad_polprodukt.ID_polprodukt
	GROUP BY Zamowienie_szczegol.ID_zamowienie, Material.Nazwa_material, Material.ID_material
GO

CREATE VIEW v_Potrzebne_materialy AS
	SELECT Zamowienie_szczegol.ID_zamowienie, Produkt.ID_produkt, Material.ID_material, SUM(Sklad_polprodukt.Ilosc*Sklad_produkt.Ilosc*Zamowienie_szczegol.Ilosc) AS [Masa materia³u]
	FROM Produkt
	INNER JOIN Sklad_produkt ON Sklad_produkt.ID_produkt = Produkt.ID_produkt
	INNER JOIN Slownik_polprodukt ON Slownik_polprodukt.ID_polprodukt = Sklad_produkt.ID_polprodukt
	INNER JOIN Sklad_polprodukt ON Sklad_polprodukt.ID_polprodukt = Slownik_polprodukt.ID_polprodukt
	INNER JOIN Material ON Sklad_polprodukt.ID_material = Material.ID_material
	INNER JOIN Zamowienie_szczegol ON Zamowienie_szczegol.ID_produkt = Produkt.ID_produkt
	INNER JOIN Zamowienie ON Zamowienie_szczegol.ID_zamowienie = Zamowienie.ID_zamowienie
	GROUP BY Material.ID_material, Produkt.ID_produkt, Zamowienie_szczegol.ID_zamowienie
	ORDER BY Zamowienie_szczegol.ID_zamowienie OFFSET 0 ROWS
GO

CREATE VIEW v_Materialy_magazyn AS
	SELECT MMP.ID_material, (MMP.[Waga (g)] - MMP.[Waga material polprodukt (g)] - MMP.[Waga material produkt (g)]) AS [Stan w magazynie g]
	FROM v_Magazyn_material_aktualny_dodanie AS MMP
	GROUP BY MMP.ID_material, MMP.[Waga (g)],MMP.[Waga material polprodukt (g)],MMP.[Waga material produkt (g)]
GO

CREATE VIEW v_Materialy_z_zamowien AS
SELECT Material.ID_material, SUM(Sklad_polprodukt.Ilosc*Sklad_produkt.Ilosc*Zamowienie_szczegol.Ilosc) AS [Masa materia³u]
FROM Produkt
INNER JOIN Sklad_produkt ON Sklad_produkt.ID_produkt = Produkt.ID_produkt
INNER JOIN Slownik_polprodukt ON Slownik_polprodukt.ID_polprodukt = Sklad_produkt.ID_polprodukt
INNER JOIN Sklad_polprodukt ON Sklad_polprodukt.ID_polprodukt = Slownik_polprodukt.ID_polprodukt
INNER JOIN Material ON Sklad_polprodukt.ID_material = Material.ID_material
INNER JOIN Zamowienie_szczegol ON Zamowienie_szczegol.ID_produkt = Produkt.ID_produkt
INNER JOIN Zamowienie ON Zamowienie_szczegol.ID_zamowienie = Zamowienie.ID_zamowienie
WHERE Zamowienie.ID_zamowienie <> 1 AND Zamowienie.ID_zamowienie <> 2 AND Zamowienie.ID_zamowienie <> 3 AND Zamowienie.ID_zamowienie <> 4 AND Zamowienie.ID_zamowienie <> 5
GROUP BY Material.ID_material
ORDER BY Material.ID_material OFFSET 0 ROWS
GO

CREATE VIEW v_Aktualny_stan_magazyn AS
SELECT ISNULL(ROW_NUMBER() OVER(ORDER BY Material.ID_material),-999) AS ID, CASE
	WHEN (v_Materialy_magazyn.[Stan w magazynie g] - v_Materialy_z_zamowien.[Masa materia³u]) is null THEN v_Materialy_magazyn.[Stan w magazynie g]
	ELSE (v_Materialy_magazyn.[Stan w magazynie g] - v_Materialy_z_zamowien.[Masa materia³u])
	END AS [Aktualny stan]
FROM v_Materialy_magazyn
INNER JOIN Material ON Material.ID_material = v_Materialy_magazyn.ID_material
FULL OUTER JOIN  v_Materialy_z_zamowien ON v_Materialy_z_zamowien.ID_material = v_Materialy_magazyn.ID_material
GROUP BY Material.ID_material,  v_Materialy_magazyn.ID_material, v_Materialy_magazyn.[Stan w magazynie g], v_Materialy_z_zamowien.[Masa materia³u]
ORDER BY Material.ID_material OFFSET 0 ROWS
GO

CREATE VIEW v_Brakujacy_material AS
SELECT Material.ID_material, Material.Nazwa_material AS [Materia³], ABS(v_Aktualny_stan_magazyn.[Aktualny stan]) AS [Brakuj¹ca iloœæ]
FROM v_Aktualny_stan_magazyn
INNER JOIN Material ON Material.ID_material = v_Aktualny_stan_magazyn.ID
WHERE v_Aktualny_stan_magazyn.[Aktualny stan] < 0
GO

CREATE VIEW v_Koszt_material_produkt_sztuka AS
	SELECT DISTINCT P.ID_produkt, SPM.Ilosc_g*v_Srednia_cena_za_material.[Œrednia cena za (g)] AS [Kwota material na produkt]
	FROM Produkt AS P
	INNER JOIN Sklad_produkt_material AS SPM ON SPM.ID_produkt = P.ID_produkt
	INNER JOIN Material AS M ON M.ID_material = SPM.ID_material
	INNER JOIN Sklad_produkt AS SP ON SP.ID_produkt = P.ID_produkt
	INNER JOIN Slownik_polprodukt AS SLPP ON SLPP.ID_polprodukt = SP.ID_polprodukt
	INNER JOIN Sklad_polprodukt AS SPP ON SPP.ID_polprodukt = SLPP.ID_polprodukt
	INNER JOIN v_Srednia_cena_za_material ON v_Srednia_cena_za_material.ID_material = M.ID_material
GO

CREATE VIEW v_Koszt_material_produkt_sztuka_suma AS
	SELECT v_Koszt_material_produkt_sztuka.ID_produkt, SUM(v_Koszt_material_produkt_sztuka.[Kwota material na produkt]) AS [Suma koszt material na produkt]
	FROM v_Koszt_material_produkt_sztuka
	GROUP BY v_Koszt_material_produkt_sztuka.ID_produkt
GO

CREATE VIEW v_Koszt_material_polprodukt_sztuka AS
	SELECT DISTINCT SP.ID_produkt,(SP.Ilosc*(SPP.Ilosc*v_Srednia_cena_za_material.[Œrednia cena za (g)])) AS [Kwota material na pó³produkt]
	FROM Produkt AS P
	LEFT JOIN Sklad_produkt_material AS SPM ON SPM.ID_produkt = P.ID_produkt
	LEFT JOIN Material AS M ON M.ID_material = SPM.ID_material
	INNER JOIN Sklad_produkt AS SP ON SP.ID_produkt = P.ID_produkt
	INNER JOIN Slownik_polprodukt AS SLPP ON SLPP.ID_polprodukt = SP.ID_polprodukt
	INNER JOIN Sklad_polprodukt AS SPP ON SPP.ID_polprodukt = SLPP.ID_polprodukt
	INNER JOIN v_Srednia_cena_za_material ON v_Srednia_cena_za_material.ID_material = SPP.ID_material
GO

CREATE VIEW v_Koszt_material_polprodukt_sztuka_suma AS
	SELECT v_Koszt_material_polprodukt_sztuka.ID_produkt, SUM(v_Koszt_material_polprodukt_sztuka.[Kwota material na pó³produkt]) AS [Suma koszt material na pó³produkt]
	FROM v_Koszt_material_polprodukt_sztuka
	GROUP BY v_Koszt_material_polprodukt_sztuka.ID_produkt
GO

CREATE VIEW v_Koszt_material_sztuka_suma AS
	SELECT Produkt.ID_produkt, ROUND(SUM(v_Koszt_material_polprodukt_sztuka_suma.[Suma koszt material na pó³produkt]+v_Koszt_material_produkt_sztuka_suma.[Suma koszt material na produkt]),0) AS [Suma koszt materia³]
	FROM Produkt
	INNER JOIN v_Koszt_material_polprodukt_sztuka_suma ON v_Koszt_material_polprodukt_sztuka_suma.ID_produkt = Produkt.ID_produkt
	INNER JOIN v_Koszt_material_produkt_sztuka_suma ON v_Koszt_material_produkt_sztuka_suma.ID_produkt = Produkt.ID_produkt
	GROUP BY Produkt.ID_produkt
GO

CREATE VIEW v_Zamowione_produkty AS
	SELECT Zamowienie_szczegol.ID_zamowienie_szczegol, Zamowienie.ID_zamowienie, Produkt.ID_produkt
	FROM Zamowienie_szczegol
	INNER JOIN Produkt ON Produkt.ID_produkt = Zamowienie_szczegol.ID_produkt
	INNER JOIN Zamowienie ON Zamowienie.ID_zamowienie = Zamowienie_szczegol.ID_zamowienie
GO

CREATE VIEW v_Czas_drukowanie_produktow_do_zamowien AS
	SELECT DISTINCT v_Zamowione_produkty.ID_zamowienie, v_Sumaryczny_czas_wytwarzania_produktu.Czas, Zamowienie_szczegol.Ilosc,v_Sumaryczny_czas_wytwarzania_produktu.Czas*Zamowienie_szczegol.Ilosc AS [£¹czny czas]
	FROM Zamowienie_szczegol
	INNER JOIN v_Zamowione_produkty on v_Zamowione_produkty.ID_zamowienie = Zamowienie_szczegol.ID_zamowienie
	INNER JOIN v_Sumaryczny_czas_wytwarzania_produktu on v_Sumaryczny_czas_wytwarzania_produktu.ID_produkt = Zamowienie_szczegol.ID_produkt
GO

CREATE VIEW v_Szacowany_czas_realizacji_zamowienia AS
	SELECT v_Czas_drukowanie_produktow_do_zamowien.ID_zamowienie, (SUM(v_Czas_drukowanie_produktow_do_zamowien.[£¹czny czas])/60)/24 AS [Szacowany czas realizacji]
	FROM v_Czas_drukowanie_produktow_do_zamowien
	GROUP BY v_Czas_drukowanie_produktow_do_zamowien.ID_zamowienie
GO

CREATE VIEW v_Szacowany_koszt_maszyn_do_zamowienia AS
	SELECT v_Szacowany_czas_realizacji_zamowienia.ID_zamowienie, 
		CASE 
			WHEN v_Szacowany_czas_realizacji_zamowienia.[Szacowany czas realizacji] = 0 THEN 1
			ELSE v_Szacowany_czas_realizacji_zamowienia.[Szacowany czas realizacji]
		END * 24 * (SELECT ROUND(AVG(Maszyna.Koszt_RBG),0) AS [Œredni koszt RBG] FROM Maszyna) AS [Œrednia]
	FROM v_Szacowany_czas_realizacji_zamowienia
GO

CREATE VIEW v_Wytwarzanie_grupowane AS
	SELECT Wytwarzanie.ID_zamowienie_szczegol
	FROM Wytwarzanie
	GROUP BY Wytwarzanie.ID_zamowienie_szczegol
GO

CREATE VIEW v_Pracownik
AS
SELECT P.ID_pracownik AS [ID], P.Nazwisko AS [Nazwisko], P.Imie AS [Imiê], P.Nr_dowodu AS [Nr dowodu], P.Pesel AS [Pesel], W.Nazwa AS [Wykszta³cenie], NTP.Numer AS [Numer telefonu], EP.Email AS [Email] FROM Pracownik AS P
INNER JOIN Wyksztalcenie AS W ON P.ID_wyksztalcenie = W.ID_wyksztalcenie
INNER JOIN Nr_telefon_pracownik AS NTP ON P.ID_pracownik = NTP.ID_pracownik
INNER JOIN Email_pracownik AS EP ON P.ID_pracownik = EP.ID_pracownik
GO

CREATE VIEW v_Dane_adresowe_pracownik
AS
SELECT ID_pracownik AS [ID], Miejscowosc AS [Miejscowoœæ zamieszkania], Ulica AS [Ulica], Nr_budynku AS [Nr budynku], Nr_lokalu AS [Nr_lokalu], Kod_pocztowy AS [Kod pocztowy], Data_od AS [Data od:], Data_do AS [Data do:]
FROM Dane_adresowe_pracownik;
GO

CREATE VIEW v_Nr_telefon_pracownik
AS
SELECT P.Nazwisko AS [Nazwisko], P.Imie AS [Imiê], NTP.Numer AS [Numer telefonu], NTP.Data_od AS [Data od:], NTP.Data_do AS [Data do:] From Nr_telefon_pracownik AS NTP
INNER JOIN Pracownik AS P ON NTP.ID_pracownik = P.ID_pracownik
GO

CREATE VIEW v_Email_pracownik
AS
SELECT P.Nazwisko AS [Nazwisko], P.Imie AS [Imiê], EP.Email AS [Email], EP.Data_od AS [Data od:], EP.Data_do AS [Data do:] From Email_pracownik AS EP
INNER JOIN Pracownik AS P ON EP.ID_pracownik = P.ID_pracownik
GO

CREATE VIEW v_Sz_czas_proces_polprodukt_czynnosc
AS
SELECT PPPC.ID_polprodukt AS [ID Pó³produktu], SP.Nazwa AS [Pó³produkt], CP.Nazwa AS [Czynnoœæ], PPPC.Czas_trwania AS [Szacowany czas w min]
FROM Proces_polprodukt_czynnosc AS PPPC
INNER JOIN Slownik_polprodukt AS SP ON PPPC.ID_polprodukt = SP.ID_polprodukt
INNER JOIN Czynnosc_produkcyjna AS CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
ORDER BY PPPC.ID_polprodukt DESC OFFSET 0 ROWS
GO
 
CREATE VIEW v_Sz_czas_proces_produkt_czynnosc
AS
SELECT PPC.ID_produkt AS [ID Produktu], P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynnoœæ], PPC.Czas_trwania AS [Szacowany czas w min]
FROM Proces_produkt_czynnosc AS PPC
INNER JOIN Produkt AS P ON PPC.ID_produkt = P.ID_produkt
INNER JOIN Czynnosc_produkcyjna AS CP ON PPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
ORDER BY PPC.ID_produkt DESC OFFSET 0 ROWS
GO

CREATE VIEW v_Proces_produkt_czynnosc_projekt
AS
SELECT PPC.ID_produkt AS [ID Produktu], P.Nazwa_produkt AS [Produkt], CP.Nazwa AS [Czynnoœæ] , PPC.Czas_trwania AS [Czas wytwarzania{min}]
FROM Proces_produkt_czynnosc AS PPC
INNER JOIN Produkt AS P ON PPC.ID_produkt = P.ID_produkt
INNER JOIN Czynnosc_produkcyjna CP ON PPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
--ORDER BY PPC.ID_produkt DESC OFFSET 0 ROWS
GO

CREATE VIEW v_Proces_polprodukt_czynnosc_projekt
AS
SELECT PPPC.ID_polprodukt AS [ID Pó³produktu], SPP.Nazwa AS [Pó³produkt], CP.Nazwa AS [Czynnoœæ], PPPC.Czas_trwania AS [Czas wytwarzania{min}]
FROM Proces_polprodukt_czynnosc AS PPPC
INNER JOIN Slownik_polprodukt SPP ON PPPC.ID_polprodukt = SPP.ID_polprodukt
INNER JOIN Czynnosc_produkcyjna CP ON PPPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
ORDER BY PPPC.ID_polprodukt DESC OFFSET 0 ROWS
GO

CREATE VIEW v_Wersja_wyposazenia_pojazd
AS 
SELECT P.ID_pojazd, P.Nr_VIN, WWS.Nazwa AS [Wersja wyposa¿enia], Pr.Nazwa_produkt, WWPr.Ilosc 
FROM Wersja_wyposazenia_produkt AS WWPr
INNER JOIN Wersja_wyposazenia_slownik AS WWS ON WWPr.ID_wersja_wyposazenia = WWS.ID_wersja_wyposazenia
INNER JOIN Wersja_wyposazenia_pojazd AS WWPo ON WWS.ID_wersja_wyposazenia = WWPo.ID_wersja_wyposazenia
INNER JOIN Pojazd AS P ON WWPo.ID_pojazd = P.ID_pojazd
INNER JOIN Produkt AS Pr ON WWPr.ID_produkt = Pr.ID_produkt
ORDER BY P.Nr_VIN OFFSET 0 ROWS
GO

CREATE VIEW v_Wersja_wyposazenia_pojazd_spis
AS 
SELECT P.ID_pojazd, P.Nr_VIN, WWS.Nazwa AS [Wersja wyposa¿enia]
FROM Wersja_wyposazenia_slownik AS WWS 
INNER JOIN Wersja_wyposazenia_pojazd AS WWPo ON WWS.ID_wersja_wyposazenia = WWPo.ID_wersja_wyposazenia
INNER JOIN Pojazd AS P ON WWPo.ID_pojazd = P.ID_pojazd
ORDER BY P.Nr_VIN OFFSET 0 ROWS
GO

CREATE VIEW v_Wersja_wyposazenia_pojazd_standard
AS 
SELECT P.ID_pojazd, P.Nr_VIN, WWS.Nazwa AS [Wersja wyposa¿enia], Pr.Nazwa_produkt, WWPr.Ilosc 
FROM Wersja_wyposazenia_produkt AS WWPr
INNER JOIN Wersja_wyposazenia_slownik AS WWS ON WWPr.ID_wersja_wyposazenia = WWS.ID_wersja_wyposazenia
INNER JOIN Wersja_wyposazenia_pojazd AS WWPo ON WWS.ID_wersja_wyposazenia = WWPo.ID_wersja_wyposazenia
INNER JOIN Pojazd AS P ON WWPO.ID_pojazd = P.ID_pojazd
INNER JOIN Produkt AS Pr ON WWPr.ID_produkt = Pr.ID_produkt
WHERE WWS.ID_wersja_wyposazenia = 1
ORDER BY P.Nr_VIN OFFSET 0 ROWS
GO

CREATE VIEW v_Wersja_wyposazenia_pojazd_M
AS 
SELECT P.ID_pojazd, P.Nr_VIN, WWS.Nazwa AS [Wersja wyposa¿enia], Pr.Nazwa_produkt, WWPr.Ilosc 
FROM Wersja_wyposazenia_produkt AS WWPr
INNER JOIN Wersja_wyposazenia_slownik AS WWS ON WWPr.ID_wersja_wyposazenia = WWS.ID_wersja_wyposazenia
INNER JOIN Wersja_wyposazenia_pojazd AS WWPo ON WWS.ID_wersja_wyposazenia = WWPo.ID_wersja_wyposazenia
INNER JOIN Pojazd AS P ON WWPO.ID_pojazd = P.ID_pojazd
INNER JOIN Produkt AS Pr ON WWPr.ID_produkt = Pr.ID_produkt
WHERE WWS.ID_wersja_wyposazenia = 2
ORDER BY P.Nr_VIN OFFSET 0 ROWS
GO

CREATE VIEW v_Wersja_wyposazenia_M
AS 
SELECT WWS.Nazwa, Pr.Nazwa_produkt, WWPr.Ilosc 
FROM Wersja_wyposazenia_produkt AS WWPr
INNER JOIN Wersja_wyposazenia_slownik AS WWS ON WWPr.ID_wersja_wyposazenia = WWS.ID_wersja_wyposazenia
INNER JOIN Produkt AS Pr ON WWPr.ID_produkt = Pr.ID_produkt
WHERE WWS.ID_wersja_wyposazenia = 2
ORDER BY WWS.ID_wersja_wyposazenia OFFSET 0 ROWS
GO

CREATE VIEW v_Wersja_wyposazenia_standard
AS 
SELECT WWS.Nazwa, Pr.Nazwa_produkt, WWPr.Ilosc 
FROM Wersja_wyposazenia_produkt AS WWPr
INNER JOIN Wersja_wyposazenia_slownik AS WWS ON WWPr.ID_wersja_wyposazenia = WWS.ID_wersja_wyposazenia
INNER JOIN Produkt AS Pr ON WWPr.ID_produkt = Pr.ID_produkt
WHERE WWS.ID_wersja_wyposazenia = 1
ORDER BY WWS.ID_wersja_wyposazenia OFFSET 0 ROWS
GO

CREATE VIEW v_Wersja_wyposazenia
AS 
SELECT WWS.Nazwa, Pr.Nazwa_produkt, WWPr.Ilosc 
FROM Wersja_wyposazenia_produkt AS WWPr
INNER JOIN Wersja_wyposazenia_slownik AS WWS ON WWPr.ID_wersja_wyposazenia = WWS.ID_wersja_wyposazenia
INNER JOIN Produkt AS Pr ON WWPr.ID_produkt = Pr.ID_produkt
ORDER BY WWS.ID_wersja_wyposazenia OFFSET 0 ROWS
GO



--------------------------------------
CREATE VIEW v_Sklad_stanowisko_produkcyjne_maszyna_polprodukt
AS
SELECT SS.ID_nazwa_stanowiska AS [ID Stanowiska], 
NS.Nr_seryjny AS [Nr seryjny maszyny], M.Nazwa_maszyna AS [Maszyna], M.Koszt_RBG [Koszt roboczogodziny {PLN}],
CP.Nazwa AS [Czynnoœæ]
FROM Sklad_stanowisko_produkcyjne_maszyna AS SSPM
INNER JOIN Stanowisko_produkcyjne AS SP ON SSPM.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
INNER JOIN Maszyna_nr_seryjny AS MS ON SSPM.ID_maszyna_nr = MS.ID_maszyna_nr
INNER JOIN Maszyna AS M ON MS.ID_maszyna = M.ID_maszyna
INNER JOIN Rodzaj_maszyna AS RM ON M.ID_rodzaj_maszyna = RM.ID_rodzaj_maszyna
INNER JOIN Nr_seryjny AS NS ON MS.ID_maszyna_nr = NS.ID_nr_seryjny
INNER JOIN Proces_polprodukt_czynnosc AS PPolC ON SP.ID_stanowisko_produkcyjne = PPolC.ID_stanowisko_produkcyjne
INNER JOIN Czynnosc_produkcyjna AS CP ON PPolC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
ORDER BY SP.ID_stanowisko_produkcyjne ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Sklad_stanowisko_produkcyjne_maszyna_produkt
AS
SELECT SS.ID_nazwa_stanowiska AS [ID Stanowiska], 
NS.Nr_seryjny AS [Nr seryjny maszyny], M.Nazwa_maszyna AS [Maszyna], M.Koszt_RBG [Koszt roboczogodziny {PLN}],
CP.Nazwa AS [Czynnoœæ]
FROM Sklad_stanowisko_produkcyjne_maszyna AS SSPM
INNER JOIN Stanowisko_produkcyjne AS SP ON SSPM.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
INNER JOIN Maszyna_nr_seryjny AS MS ON SSPM.ID_maszyna_nr = MS.ID_maszyna_nr
INNER JOIN Maszyna AS M ON MS.ID_maszyna = M.ID_maszyna
INNER JOIN Rodzaj_maszyna AS RM ON M.ID_rodzaj_maszyna = RM.ID_rodzaj_maszyna
INNER JOIN Nr_seryjny AS NS ON MS.ID_maszyna_nr = NS.ID_nr_seryjny
INNER JOIN Proces_produkt_czynnosc AS PPrC ON SP.ID_stanowisko_produkcyjne = PPrC.ID_stanowisko_produkcyjne
INNER JOIN Czynnosc_produkcyjna AS CP ON PPrC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
ORDER BY SP.ID_stanowisko_produkcyjne ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Wybor_model
AS
SELECT MM.ID_marka_model, MaPS.Nazwa + ' ' + MoPS.Nazwa + ' ' + CONVERT(NVARCHAR,MoPS.Rok_produkcji_od)  + ' - ' + CONVERT(NVARCHAR,MoPS.Rok_produkcji_do)  AS [Marka_model]
FROM  Marka_model AS MM
INNER JOIN Marka_pojazd_slownik AS MaPS ON MM.ID_marka_pojazd = MaPS.ID_marka_pojazd
INNER JOIN Model_pojazd_slownik AS MoPS ON MM.ID_model_pojazd = MoPS.ID_model_pojazd
GO

CREATE VIEW v_Wybor_model1
AS
SELECT MM.ID_marka_model, MaPS.Nazwa AS [Marka], MoPS.Nazwa AS [Model], MoPS.Rok_produkcji_od, MoPS.Rok_produkcji_do
FROM  Marka_model AS MM
INNER JOIN Marka_pojazd_slownik AS MaPS ON MM.ID_marka_pojazd = MaPS.ID_marka_pojazd
INNER JOIN Model_pojazd_slownik AS MoPS ON MM.ID_model_pojazd = MoPS.ID_model_pojazd
GO

CREATE VIEW v_Wybor_model_typ
AS
SELECT TPM.ID_typ_pojazd_model, TPS.Nazwa_typ, MaPS.Nazwa AS [Marka], MoPS.Nazwa AS [Model], MoPS.Rok_produkcji_od, MoPS.Rok_produkcji_do
FROM  Typ_pojazd_model AS TPM
INNER JOIN Typ_pojazd_slownik AS TPS ON TPM.ID_typ_pojazd = TPS.ID_typ_pojazd
INNER JOIN Marka_model AS MM ON TPM.ID_marka_model = MM.ID_marka_model
INNER JOIN Marka_pojazd_slownik AS MaPS ON MM.ID_marka_pojazd = MaPS.ID_marka_pojazd
INNER JOIN Model_pojazd_slownik AS MoPS ON MM.ID_model_pojazd = MoPS.ID_model_pojazd
GO

CREATE VIEW v_Pojazdy_modele
AS
SELECT P.ID_pojazd, P.Nr_VIN, P.Rok_produkcji, MM.ID_marka_model, MaPS.Nazwa + ' ' + MoPS.Nazwa + ' ' + TPS.Nazwa_typ + ' ' +  CONVERT(NVARCHAR,MoPS.Rok_produkcji_od)  + ' - ' + CONVERT(NVARCHAR,MoPS.Rok_produkcji_do)  AS [Marka_model], TPM.ID_typ_pojazd_model, WWP.ID_wersja_wyposazenia, WWS.Nazwa,  MMP.ID_marka_model_pojazd
FROM  Marka_model_pojazd AS MMP
INNER JOIN Pojazd AS P ON MMP.ID_pojazd = P.ID_pojazd
INNER JOIN Typ_pojazd_model AS TPM ON MMP.ID_typ_pojazd_model  = TPM.ID_typ_pojazd_model
INNER JOIN Typ_pojazd_slownik AS TPS ON TPM.ID_typ_pojazd = TPS.ID_typ_pojazd
INNER JOIN Marka_model AS MM ON TPM.ID_marka_model = MM.ID_marka_model
INNER JOIN Marka_pojazd_slownik AS MaPS ON MM.ID_marka_pojazd = MaPS.ID_marka_pojazd
INNER JOIN Model_pojazd_slownik AS MoPS ON MM.ID_model_pojazd = MoPS.ID_model_pojazd
INNER JOIN Wersja_wyposazenia_pojazd AS WWP ON P.ID_pojazd = WWP.ID_pojazd
INNER JOIN Wersja_wyposazenia_slownik AS WWS ON WWP.ID_wersja_wyposazenia = WWS.ID_wersja_wyposazenia
GO

CREATE VIEW v_Sklad_stanowisko_produkcyjne_maszyna_montaz
AS
SELECT SS.ID_nazwa_stanowiska AS [ID Stanowiska], 
NS.Nr_seryjny AS [Nr seryjny maszyny], M.Nazwa_maszyna AS [Maszyna], M.Koszt_RBG [Koszt roboczogodziny {PLN}],
CP.Nazwa AS [Czynnoœæ]
FROM Sklad_stanowisko_produkcyjne_maszyna AS SSPM
INNER JOIN Stanowisko_produkcyjne AS SP ON SSPM.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
INNER JOIN Maszyna_nr_seryjny AS MS ON SSPM.ID_maszyna_nr = MS.ID_maszyna_nr
INNER JOIN Maszyna AS M ON MS.ID_maszyna = M.ID_maszyna
INNER JOIN Rodzaj_maszyna AS RM ON M.ID_rodzaj_maszyna = RM.ID_rodzaj_maszyna
INNER JOIN Nr_seryjny AS NS ON MS.ID_maszyna_nr = NS.ID_nr_seryjny
INNER JOIN Proces_montaz_pojazd_czynnosc AS PMPC ON SP.ID_stanowisko_produkcyjne = PMPC.ID_stanowisko_produkcyjne
INNER JOIN Czynnosc_produkcyjna AS CP ON PMPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
ORDER BY SP.ID_stanowisko_produkcyjne ASC OFFSET 0 ROWS
GO

CREATE VIEW v_Wybor_silnika
AS
SELECT TPS.ID_typ_pojazd, TPS.Nazwa_typ, TPM.ID_marka_model, MM.ID_marka_model AS [MM], MaPS.Nazwa + ' ' + MoPS.Nazwa + ' ' + TPS.Nazwa_typ + ' ' + CONVERT(NVARCHAR,MoPS.Rok_produkcji_od)  + ' - ' + CONVERT(NVARCHAR,MoPS.Rok_produkcji_do)  AS [Marka_model], TPM.ID_typ_pojazd_model
FROM Typ_pojazd_slownik AS TPS 
INNER JOIN Typ_pojazd_model AS TPM ON TPS.ID_typ_pojazd = TPM.ID_typ_pojazd
INNER JOIN Marka_model_pojazd AS MMP ON TPM.ID_typ_pojazd_model = MMP.ID_typ_pojazd_model
INNER JOIN Marka_model AS MM ON TPM.ID_marka_model = MM.ID_marka_model
INNER JOIN Marka_pojazd_slownik AS MaPS ON MM.ID_marka_pojazd = MaPS.ID_marka_pojazd
INNER JOIN Model_pojazd_slownik AS MoPS ON MM.ID_model_pojazd = MoPS.ID_model_pojazd
INNER JOIN Pojazd AS P ON MMP.ID_pojazd = P.ID_pojazd
GO

CREATE VIEW v_Wybor_silnika2
AS
SELECT TPS.ID_typ_pojazd, TPS.Nazwa_typ, TPM.ID_marka_model, MM.ID_marka_model AS [MM], MaPS.Nazwa + ' ' + MoPS.Nazwa + ' ' + TPS.Nazwa_typ + ' ' + CONVERT(NVARCHAR,MoPS.Rok_produkcji_od)  + ' - ' + CONVERT(NVARCHAR,MoPS.Rok_produkcji_do)  AS [Marka_model], TPM.ID_typ_pojazd_model
FROM Typ_pojazd_slownik AS TPS 
INNER JOIN Typ_pojazd_model AS TPM ON TPS.ID_typ_pojazd = TPM.ID_typ_pojazd
INNER JOIN Marka_model AS MM ON TPM.ID_marka_model = MM.ID_marka_model
INNER JOIN Marka_pojazd_slownik AS MaPS ON MM.ID_marka_pojazd = MaPS.ID_marka_pojazd
INNER JOIN Model_pojazd_slownik AS MoPS ON MM.ID_model_pojazd = MoPS.ID_model_pojazd
GO

CREATE VIEW v_Przypisane_silniki
AS
SELECT TPS.ID_typ_pojazd, TPS.Nazwa_typ, TPM.ID_marka_model, MM.ID_marka_model AS [MM], MaPS.Nazwa + ' ' + MoPS.Nazwa + ' ' + TPS.Nazwa_typ + ' ' + CONVERT(NVARCHAR,MoPS.Rok_produkcji_od)  + ' - ' + CONVERT(NVARCHAR,MoPS.Rok_produkcji_do)  AS [Marka_model], TPM.ID_typ_pojazd_model, P.Nazwa_produkt, P.ID_produkt
FROM Typ_pojazd_slownik AS TPS 
INNER JOIN Typ_pojazd_model AS TPM ON TPS.ID_typ_pojazd = TPM.ID_typ_pojazd
INNER JOIN Typ_pojazd_model_silnik AS TPMS ON TPM.ID_typ_pojazd_model = TPMS.ID_typ_pojazd_model
INNER JOIN Marka_model AS MM ON TPM.ID_marka_model = MM.ID_marka_model
INNER JOIN Marka_pojazd_slownik AS MaPS ON MM.ID_marka_pojazd = MaPS.ID_marka_pojazd
INNER JOIN Model_pojazd_slownik AS MoPS ON MM.ID_model_pojazd = MoPS.ID_model_pojazd
INNER JOIN Produkt AS P ON TPMS.ID_produkt = P.ID_produkt
GO

CREATE VIEW v_Lista_silnikow
AS
SELECT  P.ID_produkt, P.Nazwa_produkt
FROM Produkt AS P
WHERE Nazwa_produkt 
Like 'Silnik%'
GO

CREATE VIEW v_Wybor_silnika_zrobione
AS
SELECT TPS.ID_typ_pojazd, TPS.Nazwa_typ, P.Nr_VIN, TPM.ID_marka_model,
P.ID_pojazd, P.Rok_produkcji, MaPS.Nazwa + ' ' + MoPS.Nazwa + ' ' + CONVERT(NVARCHAR,MoPS.Rok_produkcji_od)  + ' - ' + CONVERT(NVARCHAR,MoPS.Rok_produkcji_do)  AS [Marka_model]
FROM Typ_pojazd_model AS TPM 
INNER JOIN Typ_pojazd_slownik AS TPS ON TPM.ID_typ_pojazd = TPS.ID_typ_pojazd
INNER JOIN Marka_model AS MM ON TPM.ID_marka_model = MM.ID_marka_model
INNER JOIN Marka_pojazd_slownik AS MaPS ON MM.ID_marka_pojazd = MaPS.ID_marka_pojazd
INNER JOIN Model_pojazd_slownik AS MoPS ON MM.ID_model_pojazd = MoPS.ID_model_pojazd
INNER JOIN Marka_model_pojazd AS MMP ON TPM.ID_typ_pojazd_model = MMP.ID_typ_pojazd_model
INNER JOIN Pojazd AS P ON MMP.ID_pojazd = P.ID_pojazd
ORDER BY  TPS.ID_typ_pojazd OFFSET 0 ROWS
GO

CREATE VIEW v_Szeregowanie_zadan
AS
SELECT MNS.ID_maszyna_nr, PPC.ID_proces_polprodukt AS [Zadanie produkcyjne], PPC.Czas_trwania
FROM Proces_polprodukt_czynnosc AS PPC
INNER JOIN Stanowisko_produkcyjne AS SP ON PPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Sklad_stanowisko_produkcyjne_maszyna AS SSPM ON SP.ID_stanowisko_produkcyjne = SSPM.ID_stanowisko_produkcyjne
INNER JOIN Maszyna_nr_seryjny AS MNS ON SSPM.ID_maszyna_nr = MNS.ID_maszyna_nr
WHERE MNS.ID_maszyna_nr  IN ('12', '13')
GROUP BY SP.ID_stanowisko_produkcyjne, MNS.ID_maszyna_nr, PPC.ID_proces_polprodukt, PPC.Czas_trwania
ORDER BY PPC.Czas_trwania OFFSET 0 ROWS
GO

CREATE VIEW v_Szeregowanie_zadan_przed
AS
SELECT MNS.ID_maszyna_nr, PPC.ID_proces_polprodukt AS [Zadanie_produkcyjne], PPC.Czas_trwania
FROM Proces_polprodukt_czynnosc AS PPC
INNER JOIN Stanowisko_produkcyjne AS SP ON PPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Sklad_stanowisko_produkcyjne_maszyna AS SSPM ON SP.ID_stanowisko_produkcyjne = SSPM.ID_stanowisko_produkcyjne
INNER JOIN Maszyna_nr_seryjny AS MNS ON SSPM.ID_maszyna_nr = MNS.ID_maszyna_nr
WHERE MNS.ID_maszyna_nr  IN ('12', '13')
GO

CREATE VIEW v_Czas_przed_szeregowaniem
AS
select top 1 *
from v_Szeregowanie_zadan_przed
where ID_maszyna_nr = '13' 
union all
select *
from v_Szeregowanie_zadan_przed
where ID_maszyna_nr = '12'
GO

CREATE VIEW v_Czas_po_szeregowaniu
AS
select top 1 *
from v_Szeregowanie_zadan
where ID_maszyna_nr = '13' 
union all
select *
from v_Szeregowanie_zadan
where ID_maszyna_nr = '12'
GO

CREATE VIEW v_Suma_czas_przed
AS 
SELECT SUM(Czas_trwania) AS [Suma]
FROM v_Czas_przed_szeregowaniem
GO

CREATE VIEW v_Suma_czas_po
AS 
SELECT SUM(Czas_trwania) AS [Suma]
FROM v_Czas_po_szeregowaniu
GO

CREATE VIEW v_Stanowiska_czynnosci1
AS
SELECT SS.Nazwa_stanowiska, CP.Nazwa, PPC.Czas_trwania, PPC.ID_proces_polprodukt
FROM Proces_polprodukt_czynnosc AS PPC
INNER JOIN Stanowisko_produkcyjne AS SP ON PPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SS ON SP.ID_nazwa_stanowiska = SS.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
GO

CREATE VIEW v_Zamowienie_szczegol_pojazd 
AS
	SELECT Zamowienie_szczegol_pojazd.ID_zamowienie_szczegol_pojazd, Zamowienie.ID_zamowienie AS [Nr zamówienia], Pojazd.Nr_VIN, Zamowienie_szczegol_pojazd.Ilosc, Zamowienie_szczegol_pojazd.ID_gwarancja, Gwarancja.Opis_gwarancja, Pojazd.ID_pojazd, Zamowienie_szczegol_pojazd.Koszt
	FROM Zamowienie_szczegol_pojazd
	INNER JOIN Pojazd ON Pojazd.ID_pojazd = Zamowienie_szczegol_pojazd.ID_pojazd
	INNER JOIN Zamowienie ON Zamowienie.ID_zamowienie = Zamowienie_szczegol_pojazd.ID_zamowienie
	INNER JOIN Gwarancja ON Zamowienie_szczegol_pojazd.ID_gwarancja = Gwarancja.ID_gwarancja
GO

CREATE VIEW v_Zamowienie_pojazd 
AS
	SELECT Zamowienie.ID_zamowienie, Zamowienie.Data_zamowienie, Klient.Numer_telefonu, Pracownik.Nr_dowodu, Typ_zamowienie.ID_typ_zamowienie, Klient.Nazwisko AS [Nazwisko klienta], Klient.Imie AS [Imiê klienta], Typ_zamowienie.Rodzaj_zamowienie,
	Pracownik.Nazwisko AS [Nazwisko pracownika], Pracownik.Imie AS [Imiê pracownika]
	FROM Zamowienie
	INNER JOIN Klient ON Klient.ID_klient = Zamowienie.ID_klient
	INNER JOIN Pracownik ON Pracownik.ID_pracownik = Zamowienie.ID_pracownik
	INNER JOIN Typ_zamowienie ON Typ_zamowienie.ID_typ_zamowienie = Zamowienie.ID_typ_zamowienie
	ORDER BY Data_zamowienie DESC OFFSET 0 ROWS
GO

CREATE VIEW v_Proces_montaz
AS
SELECT PMPC.ID_proces_montaz_pojazd_czynnosc AS [ID], P.Nr_VIN, CP.Nazwa AS [Czynnoœæ produkcyjna],
SST.Nazwa_stanowiska AS [Stanowisko], PMPC.Czas_trwania, P.ID_pojazd
FROM  Proces_montaz_pojazd_czynnosc AS PMPC 
INNER JOIN Stanowisko_produkcyjne AS SP ON PMPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PMPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Pojazd AS P ON PMPC.ID_pojazd = P.ID_pojazd
GO

CREATE VIEW v_Proces_montaz_kolejka
AS
SELECT PMPC.ID_proces_montaz_pojazd_czynnosc AS [ID], P.Nr_VIN, CP.Nazwa AS [Czynnoœæ produkcyjna],
SST.Nazwa_stanowiska AS [Stanowisko], PMPC.Czas_trwania, P.ID_pojazd
FROM  Proces_montaz_pojazd_czynnosc AS PMPC 
LEFT JOIN Proces_montaz_pojazd AS PMP ON PMP.ID_proces_montaz_pojazd_czynnosc = PMPC.ID_proces_montaz_pojazd_czynnosc
INNER JOIN Stanowisko_produkcyjne AS SP ON PMPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PMPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Pojazd AS P ON PMPC.ID_pojazd = P.ID_pojazd

EXCEPT

SELECT PMPC.ID_proces_montaz_pojazd_czynnosc AS [ID], P.Nr_VIN, CP.Nazwa AS [Czynnoœæ produkcyjna],
SST.Nazwa_stanowiska AS [Stanowisko], PMPC.Czas_trwania, P.ID_pojazd
FROM  Proces_montaz_pojazd_czynnosc AS PMPC 
INNER JOIN Proces_montaz_pojazd AS PMP ON PMP.ID_proces_montaz_pojazd_czynnosc = PMPC.ID_proces_montaz_pojazd_czynnosc
INNER JOIN Stanowisko_produkcyjne AS SP ON PMPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PMPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Pojazd AS P ON PMPC.ID_pojazd = P.ID_pojazd
GO

CREATE VIEW v_Proces_montaz_wykonane
AS
SELECT PMP.ID_proces_montaz_pojazd AS [ID], P.Nr_VIN, CP.Nazwa AS [Czynnoœæ produkcyjna],
SST.Nazwa_stanowiska AS [Stanowisko], MP.Czas_od, MP.Czas_do, Pr.Nr_dowodu AS [Pracownik], MP.ID_montaz_pojazd, P.ID_pojazd, ZSP.ID_zamowienie
FROM  Proces_montaz_pojazd AS PMP
INNER JOIN Proces_montaz_pojazd_czynnosc AS PMPC ON PMP.ID_proces_montaz_pojazd_czynnosc = PMPC.ID_proces_montaz_pojazd_czynnosc
INNER JOIN Montaz_pojazd AS MP ON PMP.ID_montaz_pojazd = MP.ID_montaz_pojazd
INNER JOIN Stanowisko_produkcyjne AS SP ON PMPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PMPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Pojazd AS P ON PMPC.ID_pojazd = P.ID_pojazd
INNER JOIN Pracownik AS Pr ON MP.ID_pracownik = Pr.ID_pracownik
INNER JOIN Zamowienie_szczegol_pojazd AS ZSP ON ZSP.ID_pojazd = P.ID_pojazd
GO

CREATE VIEW v_Proces_montaz_wykonane1
AS
SELECT P.Nr_VIN, CP.Nazwa AS [Czynnoœæ produkcyjna],
SST.Nazwa_stanowiska AS [Stanowisko], MP.ID_montaz_pojazd, P.ID_pojazd, ZSP.ID_zamowienie
FROM  Proces_montaz_pojazd AS PMP
INNER JOIN Proces_montaz_pojazd_czynnosc AS PMPC ON PMP.ID_proces_montaz_pojazd_czynnosc = PMPC.ID_proces_montaz_pojazd_czynnosc
INNER JOIN Montaz_pojazd AS MP ON PMP.ID_montaz_pojazd = MP.ID_montaz_pojazd
INNER JOIN Stanowisko_produkcyjne AS SP ON PMPC.ID_stanowisko_produkcyjne = SP.ID_stanowisko_produkcyjne
INNER JOIN Slownik_stanowisko AS SST ON SP.ID_nazwa_stanowiska = SST.ID_nazwa_stanowiska
INNER JOIN Czynnosc_produkcyjna AS CP ON PMPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
INNER JOIN Pojazd AS P ON PMPC.ID_pojazd = P.ID_pojazd
INNER JOIN Pracownik AS Pr ON MP.ID_pracownik = Pr.ID_pracownik
INNER JOIN Zamowienie_szczegol_pojazd AS ZSP ON ZSP.ID_pojazd = P.ID_pojazd
GO

CREATE VIEW v_Zamowienie_produkt
AS
SELECT ZP.ID_zamowienie_produkt, Pr.Nr_dowodu, P.Nr_VIN, D.Nazwa_dostawca, ZP.Data_zamowienia
FROM Zamowienie_produkt AS ZP
INNER JOIN Pracownik AS Pr ON ZP.ID_pracownik = Pr.ID_pracownik
INNER JOIN Zamowienie_szczegol_pojazd AS ZSP ON ZP.ID_zamowienie_szczegol_pojazd = ZSP.ID_zamowienie_szczegol_pojazd
INNER JOIN Pojazd AS P ON ZSP.ID_pojazd = P.ID_pojazd
INNER JOIN Dostawca AS D ON ZP.ID_dostawca = D.ID_dostawca
GO

CREATE VIEW v_Zamowienie_szczegol_produkt
AS
SELECT SZP.ID_szczegoly_zamowienie_produkt, P.Nr_VIN, SZP.ID_zamowienie_produkt, SZP.Ilosc, SZP.Cena, Pr.Nazwa_produkt, Pr.ID_produkt, P.ID_pojazd
FROM Szczegoly_zamowienie_produkt AS SZP
INNER JOIN Zamowienie_produkt AS ZP ON SZP.ID_zamowienie_produkt = ZP.ID_zamowienie_produkt
INNER JOIN Zamowienie_szczegol_pojazd AS ZSP ON ZP.ID_zamowienie_szczegol_pojazd = ZSP.ID_zamowienie_szczegol_pojazd
INNER JOIN Pojazd AS P ON ZSP.ID_pojazd = P.ID_pojazd
INNER JOIN Produkt AS Pr ON SZP.ID_produkt = Pr.ID_produkt
GO

CREATE VIEW v_Zamowienie_montaz 
AS
SELECT Z.ID_zamowienie AS [ID], CONVERT(NVARCHAR,Z.ID_zamowienie) + ' ' + '-' + ' ' + K.Nazwisko + ' ' + K.Imie + ' - ' + CONVERT(NVARCHAR,Z.Data_zamowienie) + '-' + P.Nr_VIN AS [Klient]
FROM Zamowienie AS Z
INNER JOIN Zamowienie_szczegol_pojazd AS ZSP ON Z.ID_zamowienie = ZSP.ID_zamowienie
INNER JOIN Pojazd AS P ON ZSP.ID_pojazd = P.ID_pojazd
INNER JOIN Klient AS K ON K.ID_klient = Z.ID_klient
INNER JOIN Pracownik AS Pr ON Pr.ID_pracownik = Z.ID_pracownik
ORDER BY Data_zamowienie DESC OFFSET 0 ROWS
GO

CREATE VIEW v_Kontrola_jakosci_pojazd_kolejka
AS
SELECT MP.ID_montaz_pojazd, P.ID_pojazd, P.Nr_VIN
FROM Montaz_pojazd AS MP
LEFT JOIN Kontrola_jakosci_pojazd AS KJP ON MP.ID_montaz_pojazd = KJP.ID_montaz_pojazd
INNER JOIN Proces_montaz_pojazd AS PMP ON  MP.ID_montaz_pojazd = PMP.ID_montaz_pojazd
INNER JOIN Proces_montaz_pojazd_czynnosc AS PMPC ON PMP.ID_proces_montaz_pojazd_czynnosc = PMPC.ID_proces_montaz_pojazd_czynnosc
INNER JOIN Pojazd AS P ON PMPC.ID_pojazd = P.ID_pojazd
WHERE MP.Czas_do IS NOT NULL

EXCEPT

SELECT MP.ID_montaz_pojazd, P.ID_pojazd, P.Nr_VIN
FROM Montaz_pojazd AS MP
INNER JOIN Kontrola_jakosci_pojazd AS KJP ON MP.ID_montaz_pojazd = KJP.ID_montaz_pojazd
INNER JOIN Proces_montaz_pojazd AS PMP ON  MP.ID_montaz_pojazd = PMP.ID_montaz_pojazd
INNER JOIN Proces_montaz_pojazd_czynnosc AS PMPC ON PMP.ID_proces_montaz_pojazd_czynnosc = PMPC.ID_proces_montaz_pojazd_czynnosc
INNER JOIN Pojazd AS P ON PMPC.ID_pojazd = P.ID_pojazd
WHERE MP.Czas_do IS NOT NULL
GO

CREATE VIEW v_Kontrola_jakosci_pojazd
AS
SELECT KJP.ID_kontrola_jakosci_pojazd, P.ID_pojazd, P.Nr_VIN, Pr.Nr_dowodu, KJP.Wynik_kontroli, KJP.Uwagi, KJP.Data_kontroli, RK.Rodzaj_kontrola, MP.ID_montaz_pojazd, ZSP.ID_zamowienie, CP.Nazwa
FROM Kontrola_jakosci_pojazd AS KJP
INNER JOIN Montaz_pojazd AS MP ON MP.ID_montaz_pojazd = KJP.ID_montaz_pojazd
INNER JOIN Proces_montaz_pojazd AS PMP ON  MP.ID_montaz_pojazd = PMP.ID_montaz_pojazd
INNER JOIN Proces_montaz_pojazd_czynnosc AS PMPC ON PMP.ID_proces_montaz_pojazd_czynnosc = PMPC.ID_proces_montaz_pojazd_czynnosc
INNER JOIN Pojazd AS P ON PMPC.ID_pojazd = P.ID_pojazd
INNER JOIN Pracownik AS Pr ON KJP.ID_pracownik = Pr.ID_pracownik
INNER JOIN Rodzaj_kontrola AS RK ON KJP.ID_rodzaj_kontrola = RK.ID_rodzaj_kontrola
INNER JOIN Zamowienie_szczegol_pojazd AS ZSP ON MP.ID_zamowienie_szczegol_pojazd = ZSP.ID_zamowienie_szczegol_pojazd
INNER JOIN Czynnosc_produkcyjna AS CP ON PMPC.ID_czynnosc_produkcyjna = CP.ID_czynnosc_produkcyjna
GO

CREATE VIEW v_Wynik_kontroli_pojazd
AS
SELECT ID_montaz_pojazd, Nr_VIN, ID_pojazd, SUM(CASE WHEN Wynik_kontroli = 'TRUE' THEN 1 ELSE 0 END) AS [Rezultat_kontroli], ID_zamowienie, Nazwa
FROM v_Kontrola_jakosci_pojazd
GROUP BY ID_montaz_pojazd, Nr_VIN, ID_pojazd, ID_zamowienie, Nazwa
GO

CREATE VIEW v_Kontrola_pozytywna_pojazd
AS
SELECT ID_montaz_pojazd, Nr_VIN, AVG([Rezultat_kontroli]) AS [Wynik_kontrola], ID_pojazd, ID_zamowienie, Nazwa
FROM v_Wynik_kontroli_pojazd
GROUP BY ID_montaz_pojazd, Nr_VIN, ID_pojazd, ID_zamowienie, Nazwa
HAVING AVG([Rezultat_kontroli]) = 1
GO

CREATE VIEW v_Ilosc_kontrola_pozytywna_pojazd
AS
SELECT Nr_VIN, COUNT([Wynik_kontrola]) AS [Iloœæ], ID_montaz_pojazd, ID_pojazd, ID_zamowienie
FROM v_Kontrola_pozytywna_pojazd
GROUP BY Nr_VIN, ID_montaz_pojazd, ID_pojazd, ID_zamowienie
GO

CREATE VIEW v_Magazynowanie_pojazd
AS
SELECT MMP.ID_miejsce_magazynowanie_pojazd, P.Nr_VIN, MMP.Nr_miejsca, MS.Nazwa,PM.Poziom
FROM Miejsce_magazynowanie_pojazd AS MMP
INNER JOIN Pojazd AS P ON MMP.ID_pojazd = P.ID_pojazd
INNER JOIN Poziom_magazynowanie AS PM ON MMP.ID_poziom_magazynowanie = PM.ID_poziom_magazynowanie
INNER JOIN Magazynowanie_slownik AS MS ON PM.ID_magazynowanie = MS.ID_magazynowanie
GO

CREATE VIEW v_Magazynowanie_pojazd_wybor
AS
SELECT PM.ID_poziom_magazynowanie, PM.Poziom, MS.Nazwa
FROM Poziom_magazynowanie AS PM 
INNER JOIN Magazynowanie_slownik AS MS ON PM.ID_magazynowanie = MS.ID_magazynowanie
WHERE MS.ID_magazynowanie = 1
GO

CREATE VIEW v_Zamowienie_szczegol_produkt_koszta
AS
SELECT P.Nr_VIN, SUM(SZP.Cena) AS [Koszty], P.ID_pojazd
FROM Szczegoly_zamowienie_produkt AS SZP
INNER JOIN Zamowienie_produkt AS ZP ON SZP.ID_zamowienie_produkt = ZP.ID_zamowienie_produkt
INNER JOIN Zamowienie_szczegol_pojazd AS ZSP ON ZP.ID_zamowienie_szczegol_pojazd = ZSP.ID_zamowienie_szczegol_pojazd
INNER JOIN Pojazd AS P ON ZSP.ID_pojazd = P.ID_pojazd
INNER JOIN Produkt AS Pr ON SZP.ID_produkt = Pr.ID_produkt
GROUP BY P.Nr_VIN, P.ID_pojazd
GO



