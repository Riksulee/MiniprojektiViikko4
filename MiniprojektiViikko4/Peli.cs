using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MiniprojektiViikko4
{
	public class Peli
	{

		public List<Tapahtuma> tapahtumat;

		public Reppu reppu;

		public Peli()
		{

			reppu = new Reppu();

			tapahtumat = new List<Tapahtuma>();

			Tapahtuma tarina1 = new Tapahtuma("Rautatieasema", "Ulfric on saapunut Helsingin rautatieasemalle." +
											  "\nUlfricin astuu junasta, kun hän havaitsee että hänen puhelimensa soi. Ulfric vastaa puhelimeen, " +
											  "\njossa on hänen hyvä ystävänsä Gereg joka haluaa sopia tapaamisen." +
											  "\nValitse, mitä haluat tehdä?" +
											  "\n(A) Sovi tapaaminen Geregin kanssa Kauppakeskus Kamppiin 20 minuutin päästä." +
											  "\n(B) Vastaat ettet ehdi tavata Geregiä" +
											  "\n(C) Pyydät Geregiä saapumaan Rautatieasemalle, jossa odotat häntä");

			Tapahtuma tarina2 = new Tapahtuma("Asemarakennus", "Astut Rautatieaseman rakennukseen ja katselet ympärille miettien, mitä sinun kannaattaa tehdä seuraavaksi." +
											  "\n(A) Käy ostamassa matkalippu automaatilta, jotta voit matkustaa julkisilla koko päivän ajan." +
											  "\n(B) Käyt äkkiä ostamassa Hesburgerista hampurilaisen, jotta olet kylläinen ja voimissasi työhaastattelussa. (Vie aikaa 5 - 15 minuuttia." +
											  "\n(C) Päätät lähteä kävelemään Kamppia kohden. Et tiedä kuinka kauan kävely vie aikaa.");
									

			Tapahtuma tarina3 = new Tapahtuma("Lipun osto", "Menet ostamaan lippua automaatilta, mutta koska olet maalta sinulla on vaikeuksia lipun ostamisen kanssa. " +
											  "\nSaat ostettua lipun loppujen lopuksi, mutta sinulla kuluu siihen aikaa 5 minuuttua." +
											  "\nLipun ostamisen jälkeen pohdit miten kuljet Kamppiin." +
											  "\n(A) Päätät käyttää juuri ostamaasi matkalippua ja matkustaa Kamppiin metrolla" +
											  "\n(B) Ulkona on kaunis päivä ja päätät kävellä Kamppiin siitä huolimatta, että juuri ostit matkalipun");



			Tapahtuma tarina4 = new Tapahtuma("Hesburger",
			 @"Ulfric astuu sisään rautatieaseman ovista ja näkee ensimmäisenä Hesburgerin siniset valot. 
Raumalle hampurilaisketjut eivät vielä ole  rantautuneet, ja Ulfric on vain kuullut huhuja siitä, 
miltä kerroshampurilainen maistuu. Parempaa kuin Big mac, kaverit hokivat toistamiseen, ja kateus
kasvoi Ulfricinin sisällä.

Kun Ulfricin vuoro tulee, hän joutuu vaikean valinnan eteen. Ottaako kerroshampurilainen, josta 
hän on kuullut niin paljon puhuttavan, vai kevyemmät, vireystasolle edullisemmat ranskanperunat?

A) Otat kerroshampurilaisen.
B) Hillitset itsesti ja otat ranskanperunat.");


			Tapahtuma tarina5 = new Tapahtuma("Stockmann",
	@"Ulfric muistaa äitinsä kertoneen ihmellisestä paikasta nimeltään Stockmann. Siellä
on kaikkea, mitä kuvitella saattaa, ja enemmänkin! Ulfric etsii tavaratalon kartasta ja kääntää suuntansa kohti
ostosparatiisia.

Stockmannilla Ulfric joutuu taas vaikeiden valintojen eteen. Myyjä esittelee hänelle kolme erilaista
paitaa, jotka kaikki näyttävät Ulfricista erittäin hyvältä.

A) Valitset jokaiseen tilanteeseen sopivan valkoisen kauluspaidan.
B) Majoneesi-episodi on vielä tuoreena mielessäsi. Päätät pelata varman päälle ja valitset mustan kauluspaidan.
C) Valitset mustan poolopaidan ja taianomaisesti muutut boheemiksi helsinkiläiseksi.");


			Tapahtuma tarina6 = new Tapahtuma("Kamppi", "Ulfric tapaa kaverinsa Geregin Kampissa. Teillä on ollut huiman hauskaa," +
										   "\nmutta nyt Ulfricin on aika jatkaa matkaansa. Ulfricin vatsa on kuitenkin alkanut kurnimaan, " +
										   "\nniin hauskaa heillä Geregin kanssa oli. Toisaalta hänen pitäisi lähteä hakemaan " +
										   "\nportofoliotaan Töölöstä työhaastattelua varten. Ilma on hieno, joten Ulfricin" +
										   "\ntekisi mieli kävellä. Toisaalta hänellä on pieni hoppu, joten raitiovaunu olisi nopeampi." +
										   "\nUlfric päättää" +
										   "\nA) Mennä syömään, sillä nälkä kalvaa hänen sieluaan." +
										   "\nB) Ottaa raitiovaunun ja lähteä pikimmiten Töölöön noutamaan portfoliotaan." +
										   "\nC) Lähteä Töölöön kävellen ja nauttia kauniista säästä, ei tässä vielä niin kiire ole!" +
										   "\nAnna valintasi: ");

			Tapahtuma tarina7 = new Tapahtuma("Ulfric syömässä Kampin jälkeen", "Ulfric huokaisee helpotuksesta, sillä nyt hän saa" +
											  "\nvatsaansa täytettä. Ruoka-annosta valitessaan häntä kuitenkin vaivaa ajatus siitä, että " +
											  "\nruokailu vie aikaa ja työhaastattelu lähestyy uhkaavasti. Vielä kerran hän pohtii ruokailun" +
											  "\nja portfolion hakemisen välillä. Lopulta" +
											  "\nA) Ulfric päättää ottaa lihapulla-annoksen. Nälkä on niin kova, että portfolio saa odottaa." +
											  "\nB) Ottaa raitiovaunun ja lähteä pikimmiten Töölöön noutamaan portfoliotaan." +
											  "\nAnna valintasi: ");

			Tapahtuma tarina8 = new Tapahtuma("Törmäys Siltsuun", "Olet kävelemässä kohti siskosi asuntoa hakeaksesi portfoliosi, kun törmäät kulmantakaa juosseeseen mieheen." +
											  "\n Törmäyksen myötä te molemmat kaadutte ja pudotatte reppunne. Ylös noustessasi tajuat sinun törmänneen" +
											  "\nmiehen olevan Jari Sillanpää. Ennen kuin ehdit sanoa mitään Siltsu poimii reppunsa ja juoksee pois paikalta." +
											  "\nTörmäyksestä aiheutuneen hölmistyksen hälvetessä tajuat vatsasi kurnivan ja mietit miten toimit." +
											  "\n(A) Jatkat kävellen siskosi luokse hakemaan portfoliota" +
											  "\n(B) Menet syömään läheiseen ravintolaan päästäksesi eroon nälän tunteesta ja" +
											  "\njotta pystyt keskittymään tulevaan työhaastatteluusi (Vie aikaa 10 - 20 minuuttia.)" +
											  "\n(C) Et enää halua jäädä iskelmätähtien jyräämäksi, joten päätät jatkaa matkaasi siskosi luokse raitiovaunulla");


			Tapahtuma tarina9 = new Tapahtuma("Syömisen aiheuttama sairaalareissu", "EIH! Ulfricia alkoi hekotuttaa muistellessaan hänen ja Geregin" +
											  "\nyhdessä viettämiä hetkiä ja hauskoja sattumuksia ja lihapulla livahti väärään kurkkuun!" +
											  "\nUlfric kiidätetään ambulanssilla Haartmanniin ja työhaastatelu menee plörinäksi." +
											  "\nHÄVISIT PELIN!");

			Tapahtuma tarina10 = new Tapahtuma("Ravintola", "Astut sisään ravintolaan ja ryhdyt tarkastelemaan ruokavaihtoehtoja.Bongaat listalta Falafel - annoksen ja Kebab - annoksen" +
											   "\nRyhdyt miettimään kumman annoksista haluat tilata." +
											   "\n(A) Tilaat Falafel-annoksen" +
											   "\n(B) Tilaat Kebab-annoksen");


			Tapahtuma tarina11 = new Tapahtuma("Putka", "Jatkat matkaasi kävellen, kun vastaan juoksee poliisipartio huumekoiran kera." +
												  "\nKoira reagoi sinuun vahvasti ja poliisit pysäyttävät sinut ja tutkivat reppusi." +
												  "\nRepusta löytyy liekkipipo, minigrip-pussillinen metamfetamiinia sekä piipun," +
												  "\njohon on kaiverrettu nimikirjaimet: J.S. Poliisit pidättävät sinut" +
												  "\n(A) Selität poliiseille törmänneesi Siltsuun ja kerroit kuinka reppunne ovat varmasti vaihtuneet" +
												  "\n(B) Haukut poliisia siaksi" +
												  "\n(C) Olet hiljaa sillä uskot, että syyttömyytesi selviää poliisiasemalla");

			// Tässä valinnan jälkeen tarkastetaan, onko Ulfricilla matkakorttia vai ei. Jos matkakorttia ei ole ja pelaaja valitsee joko ratikan tai kaupunkipyörän,
			// niin ainut vaihtoehto on todellisuudessa kävellä, eli mennään tarinaan 21. Jos taas Ulfricilla on matkakortti, pelaaja voi valita mitä tahansa
			Tapahtuma tarina12 = new Tapahtuma("Portfolio", @"Vihdoin saavut Siskon asuntoon Töölöön. Sisko ystävällisesti tarjoutuu keittämään kahvit, mutta kieltäydyt kohteliaasti. " +
											  "\nHaluat saada portfolion mahdollisimman nopeasti ja jatkaa matkaa. Otat portfolion ja katsot kelloa pois lähtiessäsi. Olet nyt Ruusulankadun Fafasin kohdalla. " +
											  "\nTyöhaastattelu on Makkaratalossa keskustassa. Matkaa jatkaaksesi sinulla on kolme vaihtoehtoa. " +
											  "\nA) Jatkaa matkaa ratikalle. " +
											  "\nB) Lähteä kävelemään Makkaratalolle. " +
											  "\nC) Etsiä kaupunkipyörä ja pyöräillä Makkaratalolle." +
											  "\nAnna valintasi: ");


			Tapahtuma tarina13 = new Tapahtuma("Huumeet", "Ryhdyt kaivelemaan varmistaaksesi että sinulla on kaikki tarvittava mukana," +
											   "\nkun löydät repustasi liekkipipon, minigrip-pussillisen metamfetamiinia sekä piipun," +
											   "\njohon on kaiverrettu nimikirjaimet: J.S. Tajuat heti, että reppusi on vaihtunut Siltsun" +
											   "\nrepun kanssa. Ryhdyt miettimään mitä teet huumeiden kanssa." +
											   "\n(A) Päätät ottaa yhteyttä Siltsuun voidaksesi palauttaa Siltsun repun ja saadaksesi oman repun takaisin" +
											   "\n(B) Päätät jatkaa matkaasi siskosi luokse väärästä repusta huolimatta." +
											   "\n(C) Näet oivan mahdollisuuden tienata rahaa myymällä huumeet. Päätät suunnata Kallioon etsimään ostajaa");


			Tapahtuma tarina14 = new Tapahtuma("Siltsun repun palautus", "Saavut läheiseen puistoon ja näet Siltsun odottelevan puun alla ympärilleen" +
												"\npälyillen. Vaihdatte reput nopeasti ja Siltsu tarkistaa oman reppunsa sisällön." +
												"\nKaiken sieltä löytyessä hän halaa ja kiittää sinua. Poistuessaan paikalta hän toivottaa" +
												"\nsinulle onnea työhaastatteluun. Mietit mitä seuraavaksi" +
												"\n(A) Lähdet kävelemään kohti työhaastattelua" +
												"\n(B) Päätät jatkaa matkaasi työhaastatteluun raitiovaunulla");

			Tapahtuma tarina15 = new Tapahtuma("Syömisen aiheuttama sairaalareissu2", "EIH! Ulfric hotki Falafel-pyöryköitä liian nopeasti," +
											  "\\njolloin pyörykkä meni väärään kurkkuun. Ulfric kiidätetään ambulanssilla Haartmanniin" +
											  "\nja työhaastatelu menee plörinäksi." +
											  "\nHÄVISIT PELIN!");

			Tapahtuma tarina16 = new Tapahtuma("putka2", "Poliisit runttelevat Ulfricin maijan perälle." +
											 "\\nUlfric kyyditetään Pasilan poliisiasemalle ja lukitaan putkaan. Työhaastattelun alkaessa" +
											 "\nUlfric on edelleen lukittuna putkassa ja työhaastatelu menee plörinäksi." +
											 "\nHÄVISIT PELIN!");

			Tapahtuma tarina17 = new Tapahtuma("Tien ylitys", "Mannerheimintietä ylittäessä Ulfric jää auton alle ja kuolee" +
											 "\nja työhaastattelu menee plörinäksi." +
											 "\nHÄVISIT PELIN!");

			Tapahtuma tarina18 = new Tapahtuma("Sanot Ei Geregille", "Gereg suuttuu ja sulkee puhelimen. Ulfric päättää" +
											  "\nsuoraan matkustaa siskonsa luokse hakemaan portfoliotaan." +
											  "\nUlfric pohtii mikä olisi paras tapa matkustaa siskonsa luoke." +
											  "\n(A) Ulfric kävelee siskonsa luokse töölöön" +
											  "\n(B) Ulfric kulkee bussilla siskonsa luokse");

			Tapahtuma tarina19 = new Tapahtuma("valeportfolio", "Saavut siskosi luokse ja saat portfoliosi." +
								  "\nUlfric muistaa , että hänen tulisi palauttaa kirja kirjastoon." +
								  "\nOnneksi kirjasto sijaitsee aivan lähellä." +
								  "\n(A) Mene kirjastoon palauttamaan lainaamasi kirja" +
								  "\n(B) Matkusta bussilla työhaastatteluun" +
								  "\n(C) Matkusta työhaastatteluun kävellen");

			Tapahtuma tarina20 = new Tapahtuma("kirjasto", "Saavut kirjastoon ennen kirjan palauttamista päätät." +
								  "\ntutustua kirjaston tarjontaan. Kirjoja lukiessa Ulfric menettää ajantajun" +
								  "\nja myöhästyy työhaastattelusta ja työhaastatelu menee plörinäksi. " +
								  "\nHÄVISIT PELIN!");

			// Mikäli Ulfricilla on matkakortti, niin hän ehtii työhaastatteluun makkaratalolle, eli tarinaan 21. Muutoin
			// hän myöhästyy, eli mennään tarinaan 22
			Tapahtuma tarina21 = new Tapahtuma("Ehtiminen Makkaratalolle", "HIENOA! Pääsit makkaratalolle asti! " +
											"\nUlfricia jännittää kuitenkin kovasti, hänen jalkansa tärisevät ja kämmenet" +
											"\nToisaalta tämä voi olla hänen elämänsä tilaisuus saada unelmien työpaikka. " +
											"\nUskaltaako Ulfric jatkaa työhaastatteluun? Kyllä = K, Ei = E");

			// Tässä Ulfric päätti olla menemättä haastatteluun ja peli päättyyy
			// Tälle ei tarvitse tehdä metodia
			Tapahtuma tarina22 = new Tapahtuma("Ulfric ei mene työhaastatteluun", "MITÄ!!! Ulfric jänisti, eikä mennyt" +
											   "\ntyöhaastatteluun! Hänen elämänsä tilaisuus lipui sormien välisti ja Ulfric" +
											   "HÄVISI ELÄMÄNSÄ PELIN!");

			// Ulfric meni työhaastatteluun ja peli päättyy
			// Tälle ei tarvitse tehdä metodia
			Tapahtuma tarina23 = new Tapahtuma("Ulfric menee työhaastatteluun", "UPEAA! Ulfric meni työhaastatteluun ja otti elämänsä" +
											   "kohtalon omiin käsiinsä. Työhaastattelu tuntui menevän mukavasti. Katsotaan vielä, mitä" +
											   "kaikkea Ulfricille on tarttunut mukaan matkan varrella");

			// Tämä kohta tulee, mikäli Ulfricilla ei ollut matkakorttia kohdassa 12 tai jos hän päättää kävellä. Peli päättyy
			// Tälle ei tarvitse tehdä metodia
			Tapahtuma tarina24 = new Tapahtuma("Myöhästyminen Makkaratalolta", "VOI EI!" +
					  "Koska Ulfricilla ei ollut matkakorttia, hän joutui kävelemään Makkaratalolle" +
					  "ja myöhästyi työhaasatttelusta. Parempi onni seuraavalla kerralla, sillä" +
					  "tällä kertaa HÄVISIT PELIN!");


			Tapahtuma tarina25 = new Tapahtuma("bussimatka", "Ulfric istahtaa pehmeälle bussinpenkille" +
								  "\n väsynyt Ulfric vahingossa nukahtaa bussiin ja ajaa pysäkin ohi aina varikolle asti." +
								  "\n Tämän vuoksi Ulfric myöhästyy työhaastattelusta ja työhaastatelu menee plörinäksi. " +
								  "\nHÄVISIT PELIN!");

			Tapahtuma tarina26 = new Tapahtuma("Gereg myöhästyy", "Ulfric odottaa Gereggiä pitkään." +
											  "\nLopulta Gereg soittaa ja kertoo, että ei myöhästyy tapaamisesta." +
											  "\n(A) Kerrot ettet voi odottaa Gereggiä yhtään enempää." +
											  "\n(B) Jäät odottamaan Gereggiä");


			Tapahtuma tarina27 = new Tapahtuma("Gereg ei saavu", "Ulfric odottaa Gereggiä vielä lisää." +
												"\nLopulta Ulfric tajuaa ettei enää ehdi hakea portfoliotaan siskonsa luota" +
												"\nUlfric tajuaa, että puuttuvuan portfolion myötä hänen mahdollisuutensa" +
												"\nsaada työpaikka ovat olemattomat. Ulfric masentuu ja palaa kotiin" +
												"\nHÄVISIT PELIN!");

			Tapahtuma tarina28 = new Tapahtuma("Siltsun palkkio", "Ulfric saapuu työhaastatteluun." +
												"\nHeti sisäänastuessa haastattelija kertoo palkkaavansa Ulfricin" +
												"\nsillä Jari Sillanpää oli soittanut ja antanut siunauksensa." +
												"\nUlfric sai toivomansa työpaikan." +
												"\nONNEKSI OLKOON, VOITIT PELIN!");


            Tapahtuma tarina29 = new Tapahtuma("huumeiden myynti", "Ulfric saapuu piritorin laidalle huumeiden kera." +
                                                "\nUlfric lähestyy huppupäistä rähjäistä miestä ja kysyy onko tällä tarvetta huumeille." +
                                                "\nHuppupäinen mies onkin Siltsu ja nähdessään Ulfricin kaupittelevan hänen huumeitaan hän päättää" +
                                                "\npuukottaa Ulfricia 28 kertaa vatsaan ja pukee liekkipipon päähänsä paikalta poistuessaan." +
                                                "\nUlfric kuolee paikalle ja myöhästyy työhaastattelusta ja työhaastatelu menee plörinäksi. " +
                                                "\nHÄVISIT PELIN!");

            tapahtumat.Add(tarina1);
			tapahtumat.Add(tarina2);
			tapahtumat.Add(tarina3);
			tapahtumat.Add(tarina4);
			tapahtumat.Add(tarina5);
			tapahtumat.Add(tarina6);
			tapahtumat.Add(tarina7);
			tapahtumat.Add(tarina8);
			tapahtumat.Add(tarina9);
			tapahtumat.Add(tarina10);
			tapahtumat.Add(tarina11);
			tapahtumat.Add(tarina12);
			tapahtumat.Add(tarina13);
			tapahtumat.Add(tarina14);
			tapahtumat.Add(tarina15);
			tapahtumat.Add(tarina16);
			tapahtumat.Add(tarina17);
			tapahtumat.Add(tarina18);
			tapahtumat.Add(tarina19);
			tapahtumat.Add(tarina20);
			tapahtumat.Add(tarina21);
			tapahtumat.Add(tarina22);
			tapahtumat.Add(tarina23);
			tapahtumat.Add(tarina24);
			tapahtumat.Add(tarina25);
			tapahtumat.Add(tarina26);
			tapahtumat.Add(tarina27);
			tapahtumat.Add(tarina28);
            tapahtumat.Add(tarina29);



        }
        public string Rautatieasema()
		{
			Console.WriteLine(tapahtumat[0].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusABC(kirjain);
		}
		public string Asemarakennus()
		{
			Console.WriteLine(tapahtumat[1].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusABC(kirjain);
		}
		public string LipunOsto()
		{
			Console.WriteLine(tapahtumat[2].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusAB(kirjain);
		}
		public string Hese()
		{
			Console.WriteLine(tapahtumat[3].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusABC(kirjain);
		}

		public string Stockmann()
		{
			Console.WriteLine(tapahtumat[4].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusABC(kirjain);

		}
		public string Kamppi()
		{
			Console.WriteLine(tapahtumat[5].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusABC(kirjain);

		}

		public string SyominenKampinJalkeen()
		{
			Console.WriteLine(tapahtumat[6].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusAB(kirjain);
		}
		public string TörmäysSiltsuun()
		{
			Console.WriteLine(tapahtumat[7].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusABC(kirjain);
		}
		public void SairaalaReissu()
		{
			Console.WriteLine(tapahtumat[8].tapahtuma);
		}
		public string Ravintola()
		{
			Console.WriteLine(tapahtumat[9].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusAB(kirjain);
		}
		public string Putka()
		{
			Console.WriteLine(tapahtumat[10].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusABC(kirjain);
		}
		public string Portfolio()
		{
			Console.WriteLine(tapahtumat[11].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusABC(kirjain);
		}
		public string Huumeet()
		{
			Console.WriteLine(tapahtumat[12].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusABC(kirjain);
		}
		public string SiltsunRepunPalautus()
		{
			Console.WriteLine(tapahtumat[13].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusABC(kirjain);
		}
		public void Sairaalareissu2()
		{
			Console.WriteLine(tapahtumat[14].tapahtuma);
		}
		public void Putka2()
		{
			Console.WriteLine(tapahtumat[15].tapahtuma);

		}
		public void TienYlitys()
		{
			Console.WriteLine(tapahtumat[16].tapahtuma);
		}

		public string SanotEiGeregille()
		{
			Console.WriteLine(tapahtumat[17].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusABC(kirjain);
		}
		public string Valeportfolio()
		{
			Console.WriteLine(tapahtumat[18].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusABC(kirjain);
		}

		public void kirjasto()
		{
			Console.WriteLine(tapahtumat[19].tapahtuma);
		}
		public void EhtiminenMakkaratalolle()
		{
			Console.WriteLine(tapahtumat[20].tapahtuma);
			string kirjain = Console.ReadLine();
			HaastatteluKyllaEi(kirjain);
		}

		public void MyöhästyminenMakkaratalolta()
		{
			Console.WriteLine(tapahtumat[23].tapahtuma);
		}
		public void bussimatka()
		{
			Console.WriteLine(tapahtumat[24].tapahtuma);
		}
		public string GeregMyöhästyy()
		{
			Console.WriteLine(tapahtumat[25].tapahtuma);
			string kirjain = Console.ReadLine();
			return TarkistusAB(kirjain);
		}
		public void GeregEiSaavu()
		{
			Console.WriteLine(tapahtumat[26].tapahtuma);
		}
		public void SiltsunPalkkio()
        {
            Console.WriteLine(tapahtumat[27].tapahtuma);
		}
        public void HuumeidenMyynti()
        {
            Console.WriteLine(tapahtumat[28].tapahtuma);
        }



        // Tarkistusmetodit
        // Tarkistavat, onko käyttäjän antama syöte
        // joko A, B, C tai D riippuen vaihtoehtojen 
        // määrästä ja palauttaa syötteen, mikäli
        // siinä on kaikki kunnossa. Muuten pyörii
        // while loopissa niin kauan, kunnes käyttäjä
        // antaa oikeanlaisen syötteen.
        public string TarkistusAB(string kirjain)
		{

			string s = "aAbB";

			while (!s.Contains(kirjain) || kirjain.Length > 1 || kirjain.Length == 0)
			{
				Console.WriteLine("Anna oikea valinta");
				kirjain = Console.ReadLine();
			}
			return kirjain;
		}
		public string TarkistusABC(string kirjain)
		{

			string s = "aAbBcC";

			while (!s.Contains(kirjain) || kirjain.Length > 1 || kirjain.Length == 0)
			{
				Console.WriteLine("Anna oikea valinta");
				kirjain = Console.ReadLine();
			}
			return kirjain;
		}
		public string TarkistusABCD(string kirjain)
		{

			string s = "aAbBcCdD";

			while (!s.Contains(kirjain) || kirjain.Length > 1 || kirjain.Length == 0)
			{
				Console.WriteLine("Anna oikea valinta");
				kirjain = Console.ReadLine();
			}
			return kirjain;
		}



		// Tässä tarkastetaan, onko syöte joko iso tai pieni k tai e. Jos syöte
		// on e, niin kerrotaan, että peli päättyy. Jos syöte on k, niin kerrotaan, että
		// Ulfric meni haastatteluun ja tarkistetaan repun sisällön tarkistukseen
		public void HaastatteluKyllaEi(string kirjain)
		{

			string s = "kKeE";

			while (!s.Contains(kirjain) || kirjain.Length > 1 || kirjain.Length == 0)
			{
				Console.WriteLine("Anna oikea valinta");
				kirjain = Console.ReadLine();
			}

			if (kirjain == "E" || kirjain == "e")
			{
				Console.WriteLine(tapahtumat[21]);
			}
			else if (kirjain == "K" || kirjain == "k")
			{
				Console.WriteLine(tapahtumat[22]);

				// Tarkastetaan repun sisältö käyttäen RepunSisalto()-metodia, joka on Reppu-luokassa
				reppu.RepunSisalto();

			}
		}
        public void LisääAikaa()
        {
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}