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
F01 | Registracija korisnika | Omogućavamo administratoru da regisitra svoje nove konobare i dodjeljuje svakom konobaru (zaposleniku) korisničko ime i lozinku. | Andrija Slavić
F02 | Prijava u aplikaciju | Registrirani korisnici se početkom rada moraju prijaviti u aplikaciju uz pomoć dobivenog korisničkog imena i lozinke. | Ivan Gadžić
F03 | Generiranje QR koda | Generiranje članske iskzanice sa QR kodom, kojim će se kupci moći prijaviti u aplikaciju. | Robert Habdija
F04 | Pregled zaliha | Administrator uvijek ima uvid u stanje dostupnih pića na zalihi te uvijek može napraviti ispis trenutnog stanja. | Andrija Slavić
F05 | Plaćanje naručenih pića | Konobar ima pregled narudžbi po stolovima i izradu računa na temelju odabrane narudžbe. | Karlo Ipša
F06 | Upravljanje korisnicima | Administrator se može u bilo kojem trenutku prijaviti i vidjeti koji zaposlenik trenutno radi i može raditi izmjene u slučaju greške i kreirati raspored za zaposlenike. | Ivan Gadžić
F07 | Narudžba kupca | Kupac odabire u katalogu željeno piće koje stiže konobaru za izradu. | Karlo Ipša
F08 | Prijava manjka robe | Glavni konobar ima mogučnost naručivanje robe koja je manjka na zalihama i ispis narudžbenice. | Robert Habdija
F09 | Automatsko slanje upita dobavljačima | Sustav vodi evidenciju robe po dobavljačima te uz pomoć prijavljenih manjkova automatski generira i šalje upite dobavljačima na zadani datum te u zadanoj količini. | Ivan Gadžić
F10 | Rezervacija stola | Kupac se QR kodom prijavi, dobiva uvid slobodnih stolova koji se mogu rezervirati. | Andrija Slavić
F11 | Sanje obavijesti članskim kupcima o novim promocijama | Članski kupci će primati obavijesti o novim promocijama kafića, kako bi uvijek znali koje su aktualne promocije. | Karlo Ipša
F12 | Inventura | Administrator može provesti inventuru usporedbom prodane robe, trenugnog stanja i početnog, odnosno naručene robe. | Robert Habdija


## Tehnologije i oprema
Visual Studio 2022. C#, .NET Framework, Microsoft SQL Server, GitHub, Microsoft Word, Microsoft Project Professional, GitHub Desktop.

