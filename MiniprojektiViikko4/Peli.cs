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
											  "\nUlfricin astuu junasta, kun h�n havaitsee ett� h�nen puhelimensa soi. Ulfric vastaa puhelimeen, " +
											  "\njossa on h�nen hyv� yst�v�ns� Gereg joka haluaa sopia tapaamisen." +
											  "\nValitse, mit� haluat tehd�?" +
											  "\n(A) Sovi tapaaminen Geregin kanssa Kauppakeskus Kamppiin 20 minuutin p��st�." +
											  "\n(B) Vastaat ettet ehdi tavata Geregi�" +
											  "\n(C) Pyyd�t Geregi� saapumaan Rautatieasemalle, jossa odotat h�nt�");

			Tapahtuma tarina2 = new Tapahtuma("Asemarakennus", "Astut Rautatieaseman rakennukseen ja katselet ymp�rille miettien, mit� sinun kannaattaa tehd� seuraavaksi." +
											  "\n(A) K�y ostamassa matkalippu automaatilta, jotta voit matkustaa julkisilla koko p�iv�n ajan." +
											  "\n(B) K�yt �kki� ostamassa Hesburgerista hampurilaisen, jotta olet kyll�inen ja voimissasi ty�haastattelussa. (Vie aikaa 5 - 15 minuuttia." +
											  "\n(C) P��t�t l�hte� k�velem��n Kamppia kohden. Et tied� kuinka kauan k�vely vie aikaa.");
									

			Tapahtuma tarina3 = new Tapahtuma("Lipun osto", "Menet ostamaan lippua automaatilta, mutta koska olet maalta sinulla on vaikeuksia lipun ostamisen kanssa. " +
											  "\nSaat ostettua lipun loppujen lopuksi, mutta sinulla kuluu siihen aikaa 5 minuuttua." +
											  "\nLipun ostamisen j�lkeen pohdit miten kuljet Kamppiin." +
											  "\n(A) P��t�t k�ytt�� juuri ostamaasi matkalippua ja matkustaa Kamppiin metrolla" +
											  "\n(B) Ulkona on kaunis p�iv� ja p��t�t k�vell� Kamppiin siit� huolimatta, ett� juuri ostit matkalipun");



			Tapahtuma tarina4 = new Tapahtuma("Hesburger",
			 @"Ulfric astuu sis��n rautatieaseman ovista ja n�kee ensimm�isen� Hesburgerin siniset valot. 
Raumalle hampurilaisketjut eiv�t viel� ole  rantautuneet, ja Ulfric on vain kuullut huhuja siit�, 
milt� kerroshampurilainen maistuu. Parempaa kuin Big mac, kaverit hokivat toistamiseen, ja kateus
kasvoi Ulfricinin sis�ll�.

Kun Ulfricin vuoro tulee, h�n joutuu vaikean valinnan eteen. Ottaako kerroshampurilainen, josta 
h�n on kuullut niin paljon puhuttavan, vai kevyemm�t, vireystasolle edullisemmat ranskanperunat?

A) Otat kerroshampurilaisen.
B) Hillitset itsesti ja otat ranskanperunat.");


			Tapahtuma tarina5 = new Tapahtuma("Stockmann",
	@"Ulfric muistaa �itins� kertoneen ihmellisest� paikasta nimelt��n Stockmann. Siell�
on kaikkea, mit� kuvitella saattaa, ja enemm�nkin! Ulfric etsii tavaratalon kartasta ja k��nt�� suuntansa kohti
ostosparatiisia.

Stockmannilla Ulfric joutuu taas vaikeiden valintojen eteen. Myyj� esittelee h�nelle kolme erilaista
paitaa, jotka kaikki n�ytt�v�t Ulfricista eritt�in hyv�lt�.

A) Valitset jokaiseen tilanteeseen sopivan valkoisen kauluspaidan.
B) Majoneesi-episodi on viel� tuoreena mieless�si. P��t�t pelata varman p��lle ja valitset mustan kauluspaidan.
C) Valitset mustan poolopaidan ja taianomaisesti muutut boheemiksi helsinkil�iseksi.");


			Tapahtuma tarina6 = new Tapahtuma("Kamppi", "Ulfric tapaa kaverinsa Geregin Kampissa. Teill� on ollut huiman hauskaa," +
										   "\nmutta nyt Ulfricin on aika jatkaa matkaansa. Ulfricin vatsa on kuitenkin alkanut kurnimaan, " +
										   "\nniin hauskaa heill� Geregin kanssa oli. Toisaalta h�nen pit�isi l�hte� hakemaan " +
										   "\nportofoliotaan T��l�st� ty�haastattelua varten. Ilma on hieno, joten Ulfricin" +
										   "\ntekisi mieli k�vell�. Toisaalta h�nell� on pieni hoppu, joten raitiovaunu olisi nopeampi." +
										   "\nUlfric p��tt��" +
										   "\nA) Menn� sy�m��n, sill� n�lk� kalvaa h�nen sieluaan." +
										   "\nB) Ottaa raitiovaunun ja l�hte� pikimmiten T��l��n noutamaan portfoliotaan." +
										   "\nC) L�hte� T��l��n k�vellen ja nauttia kauniista s��st�, ei t�ss� viel� niin kiire ole!" +
										   "\nAnna valintasi: ");

			Tapahtuma tarina7 = new Tapahtuma("Ulfric sy�m�ss� Kampin j�lkeen", "Ulfric huokaisee helpotuksesta, sill� nyt h�n saa" +
											  "\nvatsaansa t�ytett�. Ruoka-annosta valitessaan h�nt� kuitenkin vaivaa ajatus siit�, ett� " +
											  "\nruokailu vie aikaa ja ty�haastattelu l�hestyy uhkaavasti. Viel� kerran h�n pohtii ruokailun" +
											  "\nja portfolion hakemisen v�lill�. Lopulta" +
											  "\nA) Ulfric p��tt�� ottaa lihapulla-annoksen. N�lk� on niin kova, ett� portfolio saa odottaa." +
											  "\nB) Ottaa raitiovaunun ja l�hte� pikimmiten T��l��n noutamaan portfoliotaan." +
											  "\nAnna valintasi: ");

			Tapahtuma tarina8 = new Tapahtuma("T�rm�ys Siltsuun", "Olet k�velem�ss� kohti siskosi asuntoa hakeaksesi portfoliosi, kun t�rm��t kulmantakaa juosseeseen mieheen." +
											  "\n T�rm�yksen my�t� te molemmat kaadutte ja pudotatte reppunne. Yl�s noustessasi tajuat sinun t�rm�nneen" +
											  "\nmiehen olevan Jari Sillanp��. Ennen kuin ehdit sanoa mit��n Siltsu poimii reppunsa ja juoksee pois paikalta." +
											  "\nT�rm�yksest� aiheutuneen h�lmistyksen h�lvetess� tajuat vatsasi kurnivan ja mietit miten toimit." +
											  "\n(A) Jatkat k�vellen siskosi luokse hakemaan portfoliota" +
											  "\n(B) Menet sy�m��n l�heiseen ravintolaan p��st�ksesi eroon n�l�n tunteesta ja" +
											  "\njotta pystyt keskittym��n tulevaan ty�haastatteluusi (Vie aikaa 10 - 20 minuuttia.)" +
											  "\n(C) Et en�� halua j��d� iskelm�t�htien jyr��m�ksi, joten p��t�t jatkaa matkaasi siskosi luokse raitiovaunulla");


			Tapahtuma tarina9 = new Tapahtuma("Sy�misen aiheuttama sairaalareissu", "EIH! Ulfricia alkoi hekotuttaa muistellessaan h�nen ja Geregin" +
											  "\nyhdess� viett�mi� hetki� ja hauskoja sattumuksia ja lihapulla livahti v��r��n kurkkuun!" +
											  "\nUlfric kiid�tet��n ambulanssilla Haartmanniin ja ty�haastatelu menee pl�rin�ksi." +
											  "\nH�VISIT PELIN!");

			Tapahtuma tarina10 = new Tapahtuma("Ravintola", "Astut sis��n ravintolaan ja ryhdyt tarkastelemaan ruokavaihtoehtoja.Bongaat listalta Falafel - annoksen ja Kebab - annoksen" +
											   "\nRyhdyt miettim��n kumman annoksista haluat tilata." +
											   "\n(A) Tilaat Falafel-annoksen" +
											   "\n(B) Tilaat Kebab-annoksen");


			Tapahtuma tarina11 = new Tapahtuma("Putka", "Jatkat matkaasi k�vellen, kun vastaan juoksee poliisipartio huumekoiran kera." +
												  "\nKoira reagoi sinuun vahvasti ja poliisit pys�ytt�v�t sinut ja tutkivat reppusi." +
												  "\nRepusta l�ytyy liekkipipo, minigrip-pussillinen metamfetamiinia sek� piipun," +
												  "\njohon on kaiverrettu nimikirjaimet: J.S. Poliisit pid�tt�v�t sinut" +
												  "\n(A) Selit�t poliiseille t�rm�nneesi Siltsuun ja kerroit kuinka reppunne ovat varmasti vaihtuneet" +
												  "\n(B) Haukut poliisia siaksi" +
												  "\n(C) Olet hiljaa sill� uskot, ett� syytt�myytesi selvi�� poliisiasemalla");

			// T�ss� valinnan j�lkeen tarkastetaan, onko Ulfricilla matkakorttia vai ei. Jos matkakorttia ei ole ja pelaaja valitsee joko ratikan tai kaupunkipy�r�n,
			// niin ainut vaihtoehto on todellisuudessa k�vell�, eli menn��n tarinaan 21. Jos taas Ulfricilla on matkakortti, pelaaja voi valita mit� tahansa
			Tapahtuma tarina12 = new Tapahtuma("Portfolio", @"Vihdoin saavut Siskon asuntoon T��l��n. Sisko yst�v�llisesti tarjoutuu keitt�m��n kahvit, mutta kielt�ydyt kohteliaasti. " +
											  "\nHaluat saada portfolion mahdollisimman nopeasti ja jatkaa matkaa. Otat portfolion ja katsot kelloa pois l�htiess�si. Olet nyt Ruusulankadun Fafasin kohdalla. " +
											  "\nTy�haastattelu on Makkaratalossa keskustassa. Matkaa jatkaaksesi sinulla on kolme vaihtoehtoa. " +
											  "\nA) Jatkaa matkaa ratikalle. " +
											  "\nB) L�hte� k�velem��n Makkaratalolle. " +
											  "\nC) Etsi� kaupunkipy�r� ja py�r�ill� Makkaratalolle." +
											  "\nAnna valintasi: ");


			Tapahtuma tarina13 = new Tapahtuma("Huumeet", "Ryhdyt kaivelemaan varmistaaksesi ett� sinulla on kaikki tarvittava mukana," +
											   "\nkun l�yd�t repustasi liekkipipon, minigrip-pussillisen metamfetamiinia sek� piipun," +
											   "\njohon on kaiverrettu nimikirjaimet: J.S. Tajuat heti, ett� reppusi on vaihtunut Siltsun" +
											   "\nrepun kanssa. Ryhdyt miettim��n mit� teet huumeiden kanssa." +
											   "\n(A) P��t�t ottaa yhteytt� Siltsuun voidaksesi palauttaa Siltsun repun ja saadaksesi oman repun takaisin" +
											   "\n(B) P��t�t jatkaa matkaasi siskosi luokse v��r�st� repusta huolimatta." +
											   "\n(C) N�et oivan mahdollisuuden tienata rahaa myym�ll� huumeet. P��t�t suunnata Kallioon etsim��n ostajaa");


			Tapahtuma tarina14 = new Tapahtuma("Siltsun repun palautus", "Saavut l�heiseen puistoon ja n�et Siltsun odottelevan puun alla ymp�rilleen" +
												"\np�lyillen. Vaihdatte reput nopeasti ja Siltsu tarkistaa oman reppunsa sis�ll�n." +
												"\nKaiken sielt� l�ytyess� h�n halaa ja kiitt�� sinua. Poistuessaan paikalta h�n toivottaa" +
												"\nsinulle onnea ty�haastatteluun. Mietit mit� seuraavaksi" +
												"\n(A) L�hdet k�velem��n kohti ty�haastattelua" +
												"\n(B) P��t�t jatkaa matkaasi ty�haastatteluun raitiovaunulla");

			Tapahtuma tarina15 = new Tapahtuma("Sy�misen aiheuttama sairaalareissu2", "EIH! Ulfric hotki Falafel-py�ryk�it� liian nopeasti," +
											  "\\njolloin py�rykk� meni v��r��n kurkkuun. Ulfric kiid�tet��n ambulanssilla Haartmanniin" +
											  "\nja ty�haastatelu menee pl�rin�ksi." +
											  "\nH�VISIT PELIN!");

			Tapahtuma tarina16 = new Tapahtuma("putka2", "Poliisit runttelevat Ulfricin maijan per�lle." +
											 "\\nUlfric kyyditet��n Pasilan poliisiasemalle ja lukitaan putkaan. Ty�haastattelun alkaessa" +
											 "\nUlfric on edelleen lukittuna putkassa ja ty�haastatelu menee pl�rin�ksi." +
											 "\nH�VISIT PELIN!");

			Tapahtuma tarina17 = new Tapahtuma("Tien ylitys", "Mannerheimintiet� ylitt�ess� Ulfric j�� auton alle ja kuolee" +
											 "\nja ty�haastattelu menee pl�rin�ksi." +
											 "\nH�VISIT PELIN!");

			Tapahtuma tarina18 = new Tapahtuma("Sanot Ei Geregille", "Gereg suuttuu ja sulkee puhelimen. Ulfric p��tt��" +
											  "\nsuoraan matkustaa siskonsa luokse hakemaan portfoliotaan." +
											  "\nUlfric pohtii mik� olisi paras tapa matkustaa siskonsa luoke." +
											  "\n(A) Ulfric k�velee siskonsa luokse t��l��n" +
											  "\n(B) Ulfric kulkee bussilla siskonsa luokse");

			Tapahtuma tarina19 = new Tapahtuma("valeportfolio", "Saavut siskosi luokse ja saat portfoliosi." +
								  "\nUlfric muistaa , ett� h�nen tulisi palauttaa kirja kirjastoon." +
								  "\nOnneksi kirjasto sijaitsee aivan l�hell�." +
								  "\n(A) Mene kirjastoon palauttamaan lainaamasi kirja" +
								  "\n(B) Matkusta bussilla ty�haastatteluun" +
								  "\n(C) Matkusta ty�haastatteluun k�vellen");

			Tapahtuma tarina20 = new Tapahtuma("kirjasto", "Saavut kirjastoon ennen kirjan palauttamista p��t�t." +
								  "\ntutustua kirjaston tarjontaan. Kirjoja lukiessa Ulfric menett�� ajantajun" +
								  "\nja my�h�styy ty�haastattelusta ja ty�haastatelu menee pl�rin�ksi. " +
								  "\nH�VISIT PELIN!");

			// Mik�li Ulfricilla on matkakortti, niin h�n ehtii ty�haastatteluun makkaratalolle, eli tarinaan 21. Muutoin
			// h�n my�h�styy, eli menn��n tarinaan 22
			Tapahtuma tarina21 = new Tapahtuma("Ehtiminen Makkaratalolle", "HIENOA! P��sit makkaratalolle asti! " +
											"\nUlfricia j�nnitt�� kuitenkin kovasti, h�nen jalkansa t�risev�t ja k�mmenet" +
											"\nToisaalta t�m� voi olla h�nen el�m�ns� tilaisuus saada unelmien ty�paikka. " +
											"\nUskaltaako Ulfric jatkaa ty�haastatteluun? Kyll� = K, Ei = E");

			// T�ss� Ulfric p��tti olla menem�tt� haastatteluun ja peli p��ttyyy
			// T�lle ei tarvitse tehd� metodia
			Tapahtuma tarina22 = new Tapahtuma("Ulfric ei mene ty�haastatteluun", "MIT�!!! Ulfric j�nisti, eik� mennyt" +
											   "\nty�haastatteluun! H�nen el�m�ns� tilaisuus lipui sormien v�listi ja Ulfric" +
											   "H�VISI EL�M�NS� PELIN!");

			// Ulfric meni ty�haastatteluun ja peli p��ttyy
			// T�lle ei tarvitse tehd� metodia
			Tapahtuma tarina23 = new Tapahtuma("Ulfric menee ty�haastatteluun", "UPEAA! Ulfric meni ty�haastatteluun ja otti el�m�ns�" +
											   "kohtalon omiin k�siins�. Ty�haastattelu tuntui menev�n mukavasti. Katsotaan viel�, mit�" +
											   "kaikkea Ulfricille on tarttunut mukaan matkan varrella");

			// T�m� kohta tulee, mik�li Ulfricilla ei ollut matkakorttia kohdassa 12 tai jos h�n p��tt�� k�vell�. Peli p��ttyy
			// T�lle ei tarvitse tehd� metodia
			Tapahtuma tarina24 = new Tapahtuma("My�h�styminen Makkaratalolta", "VOI EI!" +
					  "Koska Ulfricilla ei ollut matkakorttia, h�n joutui k�velem��n Makkaratalolle" +
					  "ja my�h�styi ty�haasatttelusta. Parempi onni seuraavalla kerralla, sill�" +
					  "t�ll� kertaa H�VISIT PELIN!");


			Tapahtuma tarina25 = new Tapahtuma("bussimatka", "Ulfric istahtaa pehme�lle bussinpenkille" +
								  "\n v�synyt Ulfric vahingossa nukahtaa bussiin ja ajaa pys�kin ohi aina varikolle asti." +
								  "\n T�m�n vuoksi Ulfric my�h�styy ty�haastattelusta ja ty�haastatelu menee pl�rin�ksi. " +
								  "\nH�VISIT PELIN!");

			Tapahtuma tarina26 = new Tapahtuma("Gereg my�h�styy", "Ulfric odottaa Gereggi� pitk��n." +
											  "\nLopulta Gereg soittaa ja kertoo, ett� ei my�h�styy tapaamisesta." +
											  "\n(A) Kerrot ettet voi odottaa Gereggi� yht��n enemp��." +
											  "\n(B) J��t odottamaan Gereggi�");


			Tapahtuma tarina27 = new Tapahtuma("Gereg ei saavu", "Ulfric odottaa Gereggi� viel� lis��." +
												"\nLopulta Ulfric tajuaa ettei en�� ehdi hakea portfoliotaan siskonsa luota" +
												"\nUlfric tajuaa, ett� puuttuvuan portfolion my�t� h�nen mahdollisuutensa" +
												"\nsaada ty�paikka ovat olemattomat. Ulfric masentuu ja palaa kotiin" +
												"\nH�VISIT PELIN!");

			Tapahtuma tarina28 = new Tapahtuma("Siltsun palkkio", "Ulfric saapuu ty�haastatteluun." +
												"\nHeti sis��nastuessa haastattelija kertoo palkkaavansa Ulfricin" +
												"\nsill� Jari Sillanp�� oli soittanut ja antanut siunauksensa." +
												"\nUlfric sai toivomansa ty�paikan." +
												"\nONNEKSI OLKOON, VOITIT PELIN!");


            Tapahtuma tarina29 = new Tapahtuma("huumeiden myynti", "Ulfric saapuu piritorin laidalle huumeiden kera." +
                                                "\nUlfric l�hestyy huppup�ist� r�hj�ist� miest� ja kysyy onko t�ll� tarvetta huumeille." +
                                                "\nHuppup�inen mies onkin Siltsu ja n�hdess��n Ulfricin kaupittelevan h�nen huumeitaan h�n p��tt��" +
                                                "\npuukottaa Ulfricia 28 kertaa vatsaan ja pukee liekkipipon p��h�ns� paikalta poistuessaan." +
                                                "\nUlfric kuolee paikalle ja my�h�styy ty�haastattelusta ja ty�haastatelu menee pl�rin�ksi. " +
                                                "\nH�VISIT PELIN!");

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
		public string T�rm�ysSiltsuun()
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

		public void My�h�styminenMakkaratalolta()
		{
			Console.WriteLine(tapahtumat[23].tapahtuma);
		}
		public void bussimatka()
		{
			Console.WriteLine(tapahtumat[24].tapahtuma);
		}
		public string GeregMy�h�styy()
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
        // Tarkistavat, onko k�ytt�j�n antama sy�te
        // joko A, B, C tai D riippuen vaihtoehtojen 
        // m��r�st� ja palauttaa sy�tteen, mik�li
        // siin� on kaikki kunnossa. Muuten py�rii
        // while loopissa niin kauan, kunnes k�ytt�j�
        // antaa oikeanlaisen sy�tteen.
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



		// T�ss� tarkastetaan, onko sy�te joko iso tai pieni k tai e. Jos sy�te
		// on e, niin kerrotaan, ett� peli p��ttyy. Jos sy�te on k, niin kerrotaan, ett�
		// Ulfric meni haastatteluun ja tarkistetaan repun sis�ll�n tarkistukseen
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

				// Tarkastetaan repun sis�lt� k�ytt�en RepunSisalto()-metodia, joka on Reppu-luokassa
				reppu.RepunSisalto();

			}
		}
        public void Lis��Aikaa()
        {
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}