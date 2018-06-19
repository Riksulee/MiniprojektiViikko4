using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MiniprojektiViikko4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pelin lähtöasetelma:
            int kellonaika = 0;

			Sijainti rautatientori = new Sijainti("Rautatientori", "");

            Reppu reppu1 = new Reppu();

            // Tilanne 1
            Console.WriteLine("Ulric on saapunut Helsingin rautatieasemalle.");

            Console.WriteLine("Ulfricin astuu junasta, kun hän havaitsee että hänen puhelimensa soi. Ulfric vastaa puhelimeen, " +
				"\njossa on hänen hyvä ystävänsä Gereg joka haluaa sopia tapaamisen." +
	"			\nValitse, mitä haluat tehdä?");
            Console.WriteLine("A) Sovi tapaaminen Geregin kanssa Kauppakeskus Kamppiin 20 minuutin päästä.");
            Console.WriteLine("B) Vastaat ettet ehdi tavata Geregiä");
            Console.WriteLine("C) Pyydät Geregiä saapumaan Rautatieasemalle, jossa odotat häntä");

			Console.WriteLine("Anna valintasi (A, B tai C): ");
			string input1 = Console.ReadLine();


            if (input1 == "a" || input1 == "A")
            {
                Console.WriteLine("Gereg sanoo hyppäävänsä bussiin ja lupaa tavata sinut Kampin aukiolla 20 minuutin päästä");

            }

            else if (input1 == "b" || input1 == "B")
            {
                Console.WriteLine("Gereg pahoittaa mielensä, mutta ymmärtää tilanteesi.");
            }

            else if (input1 == "c" || input1 == "C")
            {
                Console.WriteLine("Gereg lupaa saapua 20 minuutin päästä Rautieasemalle.");
            }
            else
            {     
            Console.WriteLine("Ei hyväksyttävä toiminto. Yritä uudestaan");
            }
            
             Console.WriteLine("Astut Rautatieaseman rakennukseen ja katselet ympärille miettien, mitä sinun kannaattaa tehdä seuraavaksi.");

                 // Tilanne 2
           if (input1 == "a" || input1 == "A")
           { 
            Console.WriteLine("A) Käy ostamassa matkalippu automaatilta, jotta voit matkustaa julkisilla koko päivän ajan.");
            Console.WriteLine("B) Käyt äkkiä ostamassa Hesburgerista hampurilaisen, jotta olet kylläinen ja voimissasi työhaastattelussa. (Vie aikaa 5 - 15 minuuttia.)");
            Console.WriteLine("C) Päätät lähteä kävelemään Kamppia kohden. Et tiedä kuinka kauan kävely vie aikaa.");
            Console.WriteLine("D) Päätät matkustaa metrolla Kamppiin matkalippua ostamatta.");

                string input2 = Console.ReadLine();
            }

            

            if (input2 == "a" || input2 == "A")
            {
				Console.WriteLine("Menet ostamaan lippua automaatilta, mutta koska olet maalta sinulla on vaikeuksia lipun ostamisen kanssa. " +
					"\nSaat ostettua lipun loppujen lopuksi, mutta sinulla kuluu siihen aikaa 5 minuuttua.");
				var matkakortti = new Tavara("matkakortti", 0);
				reppu1.LisaaTavara(matkakortti);
				reppu1.RepunSisalto();
				kellonaika += 5;
            }
            else if (input2 == "b" || input2 == "B")
            {
            Console.WriteLine("Tilaamassasi hampurilaisessa kestää 12 minuuttia ja lopuksi sitä syödessäsi hampurilaisen välistä pursuaa kastiketta paidallesi.");
            kellonaika += 12;
            }
            else if (input2 == "c" || input2 == "C")
            {
            Console.WriteLine("Lähdet kävelemään kohti Kamppia ja Mannerheimintietä ylittäessä näet kuinka mummo jää auton alle.");
            }
            else if (input2 == "d"|| input2 == "D")
            {
            Console.WriteLine("Kuljet Rautieaseman metrolaiturille, kun havaitset smurffit metrolaiturilla. Saat sakon puuttuvasta \nmatkalipusta ja sakon selvittelyssä ja lipun ostamisessa aikaa menee 15 minuuttia.");
                var matkakortti = new Tavara("matkakortti", 0);
                reppu1.LisaaTavara(matkakortti);
                reppu1.RepunSisalto();

                kellonaika += 15;
            }
            else
            {
                Console.WriteLine("Ei hyväksyttävä toiminto. Yritä uudestaan");
            }

            if (input2 == "a" || input2 == "A")
            {
                
                Console.WriteLine("A) Käyt äkkiä ostamassa Hesburgerista hampurilaisen, jotta olet kylläinen ja voimissasi työhaastattelussa. (Vie aikaa 5 - 15 minuuttia.)");
                Console.WriteLine("B) Päätät lähteä kävelemään Kamppia kohden. Et tiedä kuinka kauan kävely vie aikaa.");
                Console.WriteLine("C) Päätät matkustaa metrolla Kamppiin juuri ostamallasi matkalipulla."

            }
            
            // Tilanne 8 siltsu
            if (input6 == "a" || input6 == "A" || input7 == "b" || input7 == "B")
            {
                Console.WriteLine("Olet kävelemässä kohti siskosi asuntoa hakeaksesi portfoliosi, kun törmäät kulmantakaa juosseeseen mieheen." +
                    "\n Törmäyksen myötä te molemmat kaadutte ja pudotatte reppunne. Ylös noustessasi tajuat sinun törmänneen miehen olevan Jari Sillanpää." +
                    "\n ennen kuin ehdit sanoa mitään Siltsu poimii reppunsa ja juoksee pois paikalta. Törmäyksestä aiheutuneen hölmistyksen hälvetessä tajuat vatsasi kurnivan ja mietit miten toimit.")

                Console.WriteLine("A) Jatkat kävellen siskosi luokse hakemaan portfoliota");
                Console.WriteLine("B) Menet syömään läheiseen ravintolaan päästäksesi eroon nälän tunteesta ja jotta pystyt keskittymään tulevaan työhaastatteluusi (Vie aikaa 10 - 20 minuuttia.)");
                Console.WriteLine("C) Et enää halua jäädä iskelmätähtien jyräämäksi, joten päätät jatkaa matkaasi siskosi luokse raitiovaunulla");
                

                string input8 = Console.ReadLine();
            }

            // Tilanne 10 siltsun jälkeen syömään
            if (input8 == "b" || input8 == "B")
            {
                Console.WriteLine("Astut sisään ravintolaan ja ryhdyt tarkastelemaan ruokavaihtoehtoja. Bongaat listalta Falafel-annoksen ja Kebab-annoksen" +
                    "\n Ryhdyt miettimään kumman annoksista haluat tilata.")
                 

                Console.WriteLine("A) Tilaat Falafel-annoksen");
                Console.WriteLine("B) Tilaat Kebab-annoksen");

                kellonaika =+ 18;

                string input10 = Console.ReadLine();
            }


            // Tilanne 11 putkaan
            if (input8 == "a" || input8 == "A")
            {
                Console.WriteLine("Jatkat matkaasi kävellen, kun vastaan juoksee poliisipartio huumekoiran kera. Koira reagoi sinuun vahvasti ja poliisit pysäyttävät sinut ja tutkivat reppusi." +
                    "Repusta löytyy kasa seksileluja, minigrip-pussillinen metamfetamiinia sekä piipun, johon on kaiverrettu nimikirjaimet: J.S" +
                    "Poliisit pidättävät sinut");
            

                Console.WriteLine("A) Selität poliiseille törmänneesi Siltsuun ja kerroit kuinka reppunne ovat varmasti vaihtuneet");
                Console.WriteLine("B) Haukut poliisia siaksi");
                Console.WriteLine("C) Olet hiljaa sillä uskot, että syyttömyytesi selviää poliisiasemalla");
              

              

                string input11 = Console.ReadLine();
            }
            if (input11 == "a" || input11 == "A" || input11 == "b" || input11 == "B" || input11 == "a" || input11 == "A")
            {
                Console.WriteLine("Jatkat matkaasi kävellen, kun vastaan juoksee poliisipartio huumekoiran kera. Koira reagoi sinuun vahvasti ja poliisit pysäyttävät sinut ja tutkivat reppusi." +
                    "Repusta löytyy kasa seksileluja, minigrip-pussillinen metamfetamiinia sekä piipun, johon on kaiverrettu nimikirjaimet: J.S" +
                    "Poliisit pidättävät sinut");


                Console.WriteLine("A) Selität poliiseille törmänneesi Siltsuun ja kerroit kuinka reppunne ovat varmasti vaihtuneet");
                Console.WriteLine("B) Haukut poliisia siaksi");
                Console.WriteLine("C) Olet hiljaa sillä uskot, että syyttömyytesi selviää poliisiasemalla");




                string input11 = Console.ReadLine();
            }
        } 


    }
}
