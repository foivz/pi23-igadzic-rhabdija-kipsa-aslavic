# Aplikacija za kafiće 

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Ivan Gadžić   | igadzic@foi.hr      | 0016140379 | geki07
Robert Habdija | rhabdija@foi.hr    | 0016142191 | HabacJr
Andrija Slavić | aslavic@foi.hr     | 0016143295 | weis25
Karlo Ipša     | kipsa@foi.hr       | 0016145835 | Bajastera

## Opis domene
Projekt će se baviti izradom dinamične okoline u svrhu omogućavanja korisnicima aplikacije ispis proizvoda u kafiću, naručivanja pića od veleprodajnih dobavljača slanjem upita te mogućnost pregleda obavijesti vezanih uz ponude i plaćanje nabave.

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija korisnika | Omogućavamo administratoru da regisitra svoje nove korisnike i dodjeljuje svakom korisniku (zaposleniku) njegov ID. | Ivan Gadžić
F02 | Prijava u aplikaciju | Registrirani korisnici se početkom rada moraju prijaviti u aplikaciju uz pomoć dobivenog ID broja i lozinke. | Ivan Gadžić
F03 | Početna stranica | Nakon prijave se svaki zaposlenik nalazi na početnoj stranici gdje može izvršiti željene aktivnosti. | Robert Habdija
F04 | Pregled zaliha | Administrator uvijek ima uvid u stanje dostupnih pića na zalihi te uvijek može napraviti ispis trenutnog stanja. | Andrija Slavić
F05 | Plaćanje naručenih pića | Korisnik odabire naručena pića i izdaje račun te se vrši radnja ispisa trenutno naručenih pića. | Karlo Ipša
F06 | Upravljanje korisnicima | Administrator se može u bilo kojem trenutku prijaviti i vidjeti koji zaposlenik trenutno radi i može raditi izmjene u slučaju greške. | Ivan Gadžić
F07 | Kreiranje rasporeda | Adiminstrator ili voditelj smjene ima mogućnost kreiranja rasporeda kako bi zaposlenici mogli znati koji dan i u kojem vremenskom periodu moraju raditi. | Karlo Ipša
F08 | Prijava manjka robe | Registrirani korisnici imaju mogućnost prijaviti manjak određene robe kako bi se ista naručila od dobavljača. | Robert Habdija
F09 | Automatsko slanje upita dobavljačima | Sustav vodi evidenciju robe po dobavljačima te uz pomoć prijavljenih manjkova automatski generira i šalje upite dobavljačima na zadani datum te u zadanoj količini. | Robert Habdija
F10 | Interna tablica minimuma robe | Unutar sustava postoji tablica unutar koje se zapisuju minimalne potrebne količine robe koja mora biti na zalihi. | Andrija Slavić
F11 | Pregled dobivenih ponuda | Pri zaprimanju ponuda od strane dobavljača, sustav ih prikazuje u tabličnom obliku uzimajući u obzir sve troškove nabave. | Karlo Ipša
F12 | Pregled prometa | Sustav vodi evidenciju prodanih pića po danu te može prikazati ukupnu mjesečnu sumu prometa. | Andrija Slavić


## Tehnologije i oprema
Visual Studio 2022. C#, .NET Framework, Microsoft SQL Server, GitHub, Microsoft Word, Microsoft Project Professional, GitHub Desktop.

