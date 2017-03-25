# Tim23-Anonimusi
#Naziv tima: Anonimusi
#Tema : Kino
##Clanovi :
1. Melika Sisic
2. Raisa Seferagic
3. Amar Spahic

##Opis Teme :
Sistem omogućava vođenje evidencije i pregled filmova (sa opštim karakteistikama filma, kao što su
 nazivi glumaca, godina itd.) koji se prikazuju u kinu, te prodaju ulaznica za date filmove. Sistem je 
 namijenjen za upotrebu više kina jedne grupacije, a korisnici koji koriste aplikaciju za kupovinu ulaznica 
 mogu izabrati pregled filmova koji se prikazuju u kinima u gradu gdje se oni nalaze (ili u nekom drugom gradu). 
 Sistem takođe omogućava upravitelju kina (koji je ujedno i administrator sa svim privilegijima nad sistemom) 
 dodavanje novih projekcija na listu i dodavanje/brisanje zaposlenika kina. Pošto su sva kina iz iste grupacije, 
 rasporedi projekcija, termini projekcija, popusti, te cijene karata za pojedinačne projekcije su isti za sva kina, 
 samo su im različite lokacije. Razlog zašto bi neko unajmio ovaj sistem je jednostavna kupovina karata i dobro 
 razrađen sistem prodaje ulaznica, kao i široka ponuda filmova različitih žanrova da bi se zadovoljile želje 
 svakog ljubitelja filmova. Svakih 7 dana se mijenjaju termini projekcija i dodaju se nove projekcije, 
 a one najstarije prestaju s projekcijom (brišu se iz sistema).
 
 ##Procesi :
 **pregled filmova -** Korisnik sistema (preko odgovarajuće forme) bira grad u kojem se nalazi, 
 nakon čega mu se prikazuje lista kina koje se nalaze u tom gradu (zajedno sa mapom izabranog grada). 
 Nakon što je korisnik odabrao željenu lokaciju kina, prikazuje mu se spisak svih projekcija koje 
 su dostupne (koje se puštaju) te sedmice u izabranom kinu kao i vidljiva lokacija kina. 
 Pri izabiru određenog filma korisniku se prikazuju opšte informacije o filmu kao i slika, te trailer za odabrani film.
 
**kupovina ulaznica -** Kada korisnik odabere opciju da kupi ulaznice za određeni film, korisniku se prikazuje nova forma 
na kojoj može odabrati koliko ulaznica želi kupiti, te mogućnost izbora željenih sjedišta u kino sali od onih koja su 
slobodna za datu projekciju (zauzeta mjesta će biti prikazana crvenom bojom). Korisnik unosi i podatke da li je član 
kina (izbor DA/NE). Svi članovi kina imaju popust u iznosu 10% na redovne cijene ulaznica. Djeca mlađa od 12 godina 
kao i studenti takođe imaju ovu pogodnost popusta od 10% na redovne cijene ulaznica. Korisnik, pored prethodno 
navedenog, treba unijeti broj djece i studenata pri kupovini ulaznica, da bi se dobio potpuni uvid u konačnu cijenu 
karata (zajedno sa uračunatim mogućim popustima). Prije završetka kupovine korisnik mora unijeti validan 
broj i šifru kartice, te jedinstvenu šifru svoje članske kartice (ako istu posjeduje), da bi se finalizirala 
kupovina ulaznice/a. U ovoj fazi potrebno je obratiti pažnju na dijeljene resurse, kako dva korisnika ne bi pokušala 
zakupiti ista sjedišta. Nakon kupovine, sistem odobrava rezervaciju, te je čuva zajedno sa sljedećim informacijama: 
 broj sjedišta, broj sale, termin prikazivanja, naziv filma, te jedinstvena petocifrena šifra koju dodjeljuje sistem, 
 kako bi ih korisnik mogao bez problema preuzeti na kasi kina. Ulaznice se takođe mogu kupiti i na kasi kina, 
 pri čemu odgovorna osoba za prodaju ulaznica potvrđuje transakciju (uz eventualne popuste, ako su mogući),
 jer u tom slučaju ulaznice mogu biti plaćene gotovinom.
 
**upravljanje listom filmova -** Upravitelj kina dodaje nove filmove na listu. Prilikom dodavanja novog filma, 
upravnik popunjava sve informacije o filmu u odgovarajuće kreiranoj formi sa sljedećim informacijama : 
originalni naziv filma, naziv redatelja filma, žanr filma, trajanje filma, uloge, godinu, državu porijekla, kratak opis filma, 
sliku i link trailera, te obavezno datum premijere ovog/ovih filma/filmova i salu u kojoj će se isti prikazivati. 
Upravnik će ih dodavati posebno po salama, da ne bi došlo do preklapanja termina za dvije različite projekcije, 
zbog ograničenog broja sala (broj sala je manji od broja projekcija). Zatim se ti novi filmovi dodaju u posebnu sekciju 
pod nazivom „Najave“ i čeka se datum premijere, nakon čega se film ubacuje u raspored sa prethodno generisanim 
terminima za tu salu. Zbog fiksnog broja filmova koji se prikazuju u svakoj sedmici, prilikom dodavanja novih filmova, 
najstariji filmovi se prestaju prikazivati (trajno se brišu iz sistema).

**preuzimanje ulaznica -**  Za ulaznice rezervisane putem interneta, korisnik pri dolasku po karte, 
na kasi predaje jedinstvenu šifru svoje rezervacije (koja mu je prethodno dodijeljena prilikom rezervacije 
na internet stranici kina) osobi odgovornoj za prodaju ulaznica, nakon čega ona unosi istu u sistem koji provjerava 
validnost šifre. Ako je šifra validna, postoji rezervacija i kupcu se uručuju karte, nakon čega se rezervacija i njena 
jedinstvena šifra brišu, a dodijeljena sjedišta nisu više dostupna za taj termin projekcije.  Odgovorna osoba ima 
uvid u rezervacije samo za kino u kojem radi. Ako ulaznice pak nisu prethodno rezervisane, odgovorna osoba 
popunjava odgovarajuću formu, u koju unosi iduće podatke: broj ulaznica, naziv projekcije, salu i sjedišta koje je 
kupac odabrao. Provjeravaju se, a zatim unose takođe i dodatne pogodnosti za djecu i studente (ako postoje). 
I u ovom slučaju, nakon što je kupac odabrao sjedišta, odabrana sjedišta više nisu dostupna za taj termin 
projekcije i dalje će se prikazivati crvenom bojom.

**vođenje i ažuriranje liste uposlenih u kinu -**  Upravnik kina može da dodaje nove uposlene koji su odgovorni za 
prodaju ulaznica i druge upravnike kina. Svakom uposlenom se dodjeljuje jedinstveno korisničko ime i šifra.

**administracija i vođenje sistema -** Administrator sistema može dodavati nova kina u sistem i brisati postojeća, 
u slučaju promjene njihove lokacije. Administrator je jedinstvena ličnost, koja je ujedno i upravnik/upravitelj svih kina. 
Pri dodavanju novog kina, administrator(upravnik) unosi informacije o nazivu i lokaciji kina, 
te spisak zaposlenih u tom kinu. Svako kino ima pridružen jedinstveni identifikacioni broj, koji mu dodjeljuje sam sistem,
 radi lakšeg upravljanja i pretrage kina pojedinačno u budućnosti. 
 
**dodavanje članova kluba –** Svi korisnici sistema koji izvrše transakciju veću od 30 KM postaju članovi kluba, 
te im se dodjeljuje članska kartica sa jedinstvenom šifrom, pomoću koje mogu ostvariti svoje pogodnosti 
popusta od 10% za svaku projekciju. Uvažavajući preference naših kupaca, bit će im ponuđeno, 
nakon transakcije od 30KM ili više, da se samovoljno izraze da li žele biti članovi našeg kina ili ne.

##Funkcionalnosti :
*	dodavanje i brisanje zaposlenih
*	dodavanje filmova
*	dodavanje projekcija
*	preuzimanje ulaznica
*	odabir grada
*	odabir kina
*	odabir sjedišta
*	obračunavanje popusta
*	registrovanje članova kluba
*	mogućnost rezervisanja karti za filmove
*	dodavanje i brisanje kina
*	mogućnost elektronskog plaćanja karte
*	prikaz svih filmova koji se prikazuju u kinu narednih mjesec dana
*	mogućnost pretraživanja trenutnih i skorih projekcija

##Akteri :

**Korisnici sistema -** korisnici sistema su osobe koje kupuju ulaznice za filmove preko interneta ili direkntno na kasi kina

**Upravnik kina -** osoba koja je zadužena za administriranje čitavim sistemom i date su mu sve privilegije, 
te jedini/a može dodavati i brisati kina. Upravnik takođe upravlja svim funkcijama kina i ima ovlasti 
dodavanja i brisanja uposlenih u svakom kinu. Takođe su mu dodijeljene ovlasti dodavanja filmova 
koji se prikazuju u kinu i termina projekcija filmova, te sale u kojim se projekcije odvijaju/će se odvijati. 

**Odgovorna osoba za prodaju ulaznica -** je osoba koja radi na kasi kina i odogovorna je za 
predaju ulaznica kao i potvrdu transakcija, u slučaju da se prodaja ulaznica vrši na kasi kina ili putem rezervacije. 


