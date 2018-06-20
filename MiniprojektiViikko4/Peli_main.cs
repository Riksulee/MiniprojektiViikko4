using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MiniprojektiViikko4
{
	public class Program
	{
		static void Main(string[] args)
		{

			var ruokaindeksi = 0;
			Peli peli = new Peli();
			var jartsa = new SiltsuSilmukka();


			//Tässä lähetään tarinaan
			string a = peli.Rautatieasema();
			if (a == "a" || a == "A")
			{
				string b = peli.Asemarakennus();
				if (b == "a" || b == "A")
				{

					var matkakortti = new Tavara("matkakortti", 0);
					peli.reppu.LisaaTavara(matkakortti);
					string c = peli.LipunOsto();
					if (c == "a" || c == "A")

					{
						//Käy ostamassa matkalippu automaatilta, jotta voit matkustaa julkisilla koko päivän ajan.
						string kamppi1 = peli.Kamppi();
						if (kamppi1 == "a" || kamppi1 == "A")
						{
							//Vaihtoehto a eli syömässä kampin jälkeen
							string syominen = peli.SyominenKampinJalkeen();
							if (syominen == "a" || syominen == "A")
							{
								//Vaihtoehto a eli Ulfric päättää ottaa lihapulla-annoksen. Nälkä on niin kova, että portfolio saa odottaa.
								peli.SairaalaReissu();
								//valmis
							}
							else if (syominen == "b" || syominen == "B")
							{
								goto Portfolio;
							}


						}
						else if (kamppi1 == "b" || kamppi1 == "B")
						{
							//Ottaa raitiovaunun ja lähteä pikimmiten Töölöön noutamaan portfoliotaan.
							goto Portfolio;
						}
						else if (kamppi1 == "c" || kamppi1 == "C")
						{
							jartsa.SiltsuSilmukkaMetodi(peli);
						}
						else if (c == "b" || c == "B")
						{
							//Ulkona on kaunis päivä ja päätät kävellä Kamppiin siitä huolimatta, että juuri ostit matkalipun
							peli.TienYlitys();
							//valmis
						}

					}
					else if (b == "c" || b == "C" || b == "d" || b == "D")
					{
						//Vaihtoehto c ja d eli kamppiin
						string kamppi1 = peli.Kamppi();
						if (kamppi1 == "a" || kamppi1 == "A")
						{
							//Vaihtoehto a eli syömässä kampin jälkeen
							string syominen = peli.SyominenKampinJalkeen();
							if (syominen == "a" || syominen == "A")
							{
								//Vaihtoehto a eli Ulfric päättää ottaa lihapulla-annoksen. Nälkä on niin kova, että portfolio saa odottaa.
								peli.SairaalaReissu();
								//valmis
							}
							else if (syominen == "b" || syominen == "B")
							{
								goto Portfolio;
							}


						}
						else if (kamppi1 == "b" || kamppi1 == "B")
						{
							//Ottaa raitiovaunun ja lähteä pikimmiten Töölöön noutamaan portfoliotaan.
							goto Portfolio;
						}
						else if (kamppi1 == "c" || kamppi1 == "C")
						{
							//Lähteä Töölöön kävellen ja nauttia kauniista säästä, ei tässä vielä niin kiire ole!

							jartsa.SiltsuSilmukkaMetodi(peli);

						}
						else if (b == "b" || b == "B")
						{
							ruokaindeksi++;
							string hese = peli.Hese();

							if (hese == "a" || hese == "A")
							{
								Console.WriteLine("Harmi! Kokemattomana hampurilaisen syöjänä kaikki majoneesit valuvat paidallesi. " +
								"\nEt ole varautunut tilanteeseen ja seuraavaksi sinun on etsittävä uusi paita.");

								string stock = peli.Stockmann();
								// vaihtoehdot a, b ja c vievät kaikki porfolioon
								if (stock == "a" || stock == "A")
								{
									Console.WriteLine("Kannatti ottaa riski. Valkoinen paita sopii tilanteeseen kuin tilanteeseen." +
									"\nPidä kuitenkin kiirettä. Haastatteluun on  enää hetki aikaa, eikä sinulla ole vielä portfoliota!");
									Console.ReadKey();
									goto Portfolio;
								}

								else if (stock == "b" || stock == "C" || stock == "c" || stock == "C")
								{
									Console.WriteLine("Musta väri ei ole huudossa Helsingissä. Se tuo ikävästi mieleen syrjäseutujen gootit." +
									"\nÄlä kuitenkaan menetä toivoasi. Hae portolio ja ota vastaan se, mikä tulee!");
									Console.ReadKey();
									goto Portfolio;
								}

							}

							else if (hese == "b" || hese == "B")
							{
								Console.WriteLine("Vatsassasi on juuri sopivasti ruokaa ja pääset jatkamaan matkaasi Töölöön, jossa " +
								"\nsinun on määrä etsiä portfoliosi.");
								goto Portfolio;
							}

						}

					}

				}
				else if (a == "b" || a == "B")
				{
					//Puu: 1 tarina, B haara
					string ei = peli.SanotEiGeregille();

					if (ei == "a" || ei == "A")
					{
						jartsa.SiltsuSilmukkaMetodi(peli);
					}

					else if (ei == "b" || ei == "B")
					{
						//tarina 19
						// Saavut siskosi luokse ja saat portfoliosi." +
						//Ulfric muistaa , että hänen tulisi palauttaa kirja kirjastoon." +
						//Onneksi kirjasto sijaitsee aivan lähellä
						string valeportfolio = peli.Valeportfolio();

						// Kirjoja lukiessa Ulfric menettää ajantajun
						if (valeportfolio == "a" || valeportfolio == "A")
						{
							peli.kirjasto();
						}
						//Ulfric vahingossa nukahtaa bussiin
						else if (valeportfolio == "b" || valeportfolio == "B")
						{
							peli.bussimatka();
						}
						//Ulfric jää auton alle
						else if (valeportfolio == "c" || valeportfolio == "C")
						{
							peli.TienYlitys();
						}

					}

				}
				//1. tarina, C-haara
				else if (a == "c" || a == "C")
				{
					var geregMyohastyy = peli.GeregMyöhästyy();
					if (geregMyohastyy == "a" || geregMyohastyy == "A")
					{
						jartsa.SiltsuSilmukkaMetodi(peli);
					}

				}

					Portfolio:
					Console.WriteLine("portfolio");



			}

		}

	}
}


