# Grupa6-RahatBook

![image](https://user-images.githubusercontent.com/80125386/111361705-44a3de00-868e-11eb-80aa-d470279da3b6.png)

## Članovi tima:
1. [Sanina Herak](https://github.com/sherak1)
2. [Emina Masleša](https://github.com/emaslesa1)
3. [Alen Mrdović](https://github.com/amrdovic1)
4. [Nejra Mustafić](https://github.com/nmustafic1)

## Opis teme:
Svi žele putovati svijetom. Putovati zaista znači razvijati se. Svijet je knjiga, a Vi ste sami svoj autor. Ako ste odabrali svoju destinaciju za odmor, prepustite se ovoj aplikaciji, napišite vlastito djelo i popunite stranice sa nezaboravnim uspomenama! Sve je spakirano i krećete na put, ali još uvijek niste našli smještaj. 
RahatBook predstavlja aplikaciju koja omogućava jednostavan pregled svih raspoloživih smještajnih jedinica za odabranu destinaciju, kao i prikaz cijena te usluga koje smještajne jedinice nude. Ova aplikacija omogućava i rezervaciju željenog smještaja i direktnu komunikaciju sa osobljem hotela. Cilj je spojiti ponudu i potražnju na jednom mjestu. Dakle, pored korisnika koji su u potrazi za smještajem, ova aplikacija pruža mogućnost malim i velikim preduzećima iz oblasti turizma da promovišu svoju ponudu i unaprijede poslovanje.

## Funkcionalnosti:
* Registracija 
* Prijava
* Pregled svih dostupnih smještajnih jedinica
* Rezervacija smještaja
* Odabir načina plaćanja
* Mogućnost štampanja potvrde o rezervaciji
* Automatski odgovor na rezervaciju
* Otkazivanje rezervacije
* Ocjenjivanje smještaja
* Ostavljanje komentara na smještaj i usluge
* Postavljanje pitanja
* Odgovaranje na postavljena pitanja

## Nefunkcionalni zahtjevi:
* Prilagodljivost za upotrebu aplikacije na svim operativnim sistemima
* Restrikcije pri registraciji korisnika:
  * Korisnik mora dati neke osnovne podatke o sebi - ime i prezime, spol, naziv accounta, mail i datum rođenja
  * Korisnik mora dati dovoljno sigurnu lozinku, što će biti provjeravano preko progress bara
  * Korisnik koji se registruje ne može biti maloljetna osoba
  * Korisnik mora pristati na uslove korištenja aplikacije (Terms & Conditions)
* Datum dolaska može najranije biti sutrašnji datum u odnosu na tekući
* Datum odlaska mora biti barem jedan dan nakon datuma dolaska
* Rezervacija se može otkazati najkasnije 24 sata prije datuma dolaska
* Komentar na smještaj i usluge može se ostaviti tek kada smještajne jedinice budu imale evidenciju da je korisnik zaista koristio njihove usluge u posljednjih godinu dana
* Korisnik može ocjenjivati usluge tek kada smještajne jedinice budu imale evidenciju da je korisnik zaista koristio njihove usluge u posljednjih godinu dana
* Komentari na smještaj i usluge ne smiju biti uvredljivi, neosnovani ili nerelevantni, u suprotnom administrator ima pravo banovanja takvih korisnika
* Ista napomena vrijedi i za postavljanje pitanja
* Odgovorna osoba mora odgovoriti na postavljeno pitanje u roku od 24 sata 

## Akteri i procesi:
**Neregistrovani korisnik:**
 * Ima najmanje privilegija od svih korisnika
 * Ima uvid u sve ponude, te može naći sve detalje vezano za iste
 * Ima uvid u ocjene i komentare registrovanih korisnika
 * Moze navesti check-in i check-out datum, te lokaciju za smještaj i dobiti rezultate pretrage
 * Može filtrirati rezultate pretrage po svojim preferencijama

**Registrovani korisnik:**
 * Pri registraciji bira da li je obični korisnik ili turistička agencija
 * Navodi check-in i check-out datum, te lokaciju za smještaj i dobija rezultate pretrage
 * Filtrira smještajne jedinice po svojim preferencijama
 * Bira smještajnu jedinicu koja mu odgovara i započinje s procesom rezervacije
 * Vrši rezervaciju u nekoliko koraka
 * Ocjenjuje smještaj
 * Ostavlja komentare
 * Šalje pitanja hotelima-korisnicima


**Smještajna jedinica:**
 * Predstavlja pravno lice
 * Pri registraciji, navodi naziv, lokaciju uz GPS prikaz, tip smještaja i kontakt informacije
 * Bira karakteristike koje opisuju njihovu ponudu iz skupa kriterija pretrage
 * Opcionalno i preporučljivo - daje kratki opis o sebi, te stavlja nekoliko slika koje opisuju smještaj
 * Mora dobiti odobrenje za registraciju od administratora
 * Dobija mail o odobrenju ili odbijanju registracije, uz obrazloženje administratora
 * Ima uvid u sve rezervacije za svoju matičnu smjestajnu jedinicu
 * Prihvata/odbija rezervacije gostiju koji nisu ispunili uslove prijave
 * Određuje cijene i popuste na svoje ponude
 * Odgovara na postavljena pitanja


**Administrator:**
 * Ima mogućnost upravljanja radom aplikacije
 * Upravlja sitemskim aspektima aplikacije i implementacijskim detaljima
 * Ima mogućnost prihvatanja ili odbijanja registracijskih zahtjeva smještajnih jedinica
 * Ima mogućnost uklanjanja (banovanja) korisnika
