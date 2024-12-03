# Bitcoin Kalkulaator

## Ülevaade
Bitcoin Kalkulaator on rakendus, mis võimaldab kasutajal arvutada Bitcoin'i (BTC) väärtust erinevates valuutades, kasutades reaalajas andmeid CoinDesk API-st. Rakendus toetab järgmisi valuutasid:  
- EUR (euro)  
- USD (USA dollar)  
- EEK (Eesti kroon, ümberarvestus euro alusel)  
- GBP (Suurbritannia nael)  
- JPY (Jaapani jeen, ümberarvestus euro alusel)  

Kasutaja saab sisestada BTC koguse ja soovitud valuuta, mille väärtus arvutatakse automaatselt.

## Nõuded
- **Internetiühendus reaalajas andmete toomiseks CoinDesk API-st.**

## Paigaldamine
1. Lae alla lähtekood või valmisrakenduse failid.  
2. Ava lahendus Visual Studio's ja veendu, et kõik vajalikud sõltuvused on olemas.  

## Kasutamine
1. Ava rakendus.  
2. Sisesta:
   - Valuuta (nt EUR, USD, EEK, GBP, JPY).  
   - BTC kogus, mida soovid teisendada.  
3. Vajuta nuppu **Arvuta**, et näha tulemust.  
4. Tulemus kuvatakse ekraanil ja salvestatakse automaatselt faili `WriteLines.txt`, mis asub kaustas *Dokumendid*.  

### Näited
- **1 BTC = 34,000 EUR**  
- **0.5 BTC = 17,000 USD**

## Funktsioonid
- **Reaalajas kursid:** Kasutab CoinDesk API-t, et tuua kõige uuemad BTC kursid (EUR, USD, GBP).  
- **Faili salvestamine:** Iga arvutus salvestatakse automaatselt faili, et tulemused oleks hiljem kättesaadavad.  
- **Erinevad valuutad:** Toetab mitmeid valuutasid, sealhulgas ajaloolist Eesti krooni.  

## Rakenduse arendus
### Failid
- **`Form1.cs`:** Rakenduse põhilogika ja kasutajaliidese funktsionaalsus.  
- **`BitcoinRates.cs`:** Andmestruktuurid API vastuse deserialiseerimiseks.  

### Funktsioonid
- **`getRates()`:** Hangib CoinDesk API-st BTC kursid JSON-vormingus.  
- **Valuutade ümberarvestus:** Toetab erinevaid arvutusvalemeid vastavalt kasutaja sisendile.  

## Probleemid ja nende lahendused
### Tüüpilised vead:
1. **Viga API päringu tegemisel:** Kontrolli, kas internetiühendus on korras.  
2. **Vale sisend BTC koguse või valuuta puhul:** Rakendus kuvab veateate, kui sisestus ei ole korrektne.  

