using System;
using System.Collections.Generic;
using System.Text;


namespace MiniprojektiViikko4
{
    public class SiltsuSilmukka
    {
		public void SiltsuSilmukkaMetodi(Peli peli)
		{

			//Siltsu tulee vastaan
			string siltsu = peli.TörmäysSiltsuun();
			//tarina 8, haara a, siskon luo
			if (siltsu == "a" || siltsu == "A")
			{
				//tarina 11, poliisit, haarat A, B, C kaikki vievät putkaan
				string putka = peli.Putka();

				if (putka == "a" || putka == "A" || putka == "b" || putka == "B" || putka == "c" || putka == "C")
				{
					peli.Putka2();
				}

			}
			//tarina8, haara b, syömään
			else if (siltsu == "b" || siltsu == "B")
			{

				//tarina 10, haarat A, B

				string rav = peli.Ravintola();

				// falafelin tilaus
				if (rav == "a" || rav == "A")
				{
					peli.Sairaalareissu2();
				}

				// kebabin tilaus
				else if (rav == "b" || rav == "B")
				{

					//Tarina13, haarat A, B, C
					string huu = peli.Huumeet();
					// Yhteys siltsuun
					if (huu == "a" || huu == "A")
					{
						// tarina14, haarat A, B
						string rpl = peli.SiltsunRepunPalautus();
						//kävellen tai raitiovaunulla työhaastatteluun
						if (rpl == "a" || rpl == "A" || rpl == "b" || rpl == "B")
						{
							peli.SiltsunPalkkio();
						}
					}
					//siskon luo
					else if (huu == "b" || huu == "B")
					{
						//goto Portfolio;
					}
					//huumeiden myyminen
					else if (huu == "c" || huu == "C")
					{
						peli.HuumeidenMyynti();
					}
				}
			}


			//Tarina 8, haara c, siskon luo syömään
			else if (siltsu == "c" || siltsu == "C")
			{
				//goto Portfolio;
			}
		}
	}

}
