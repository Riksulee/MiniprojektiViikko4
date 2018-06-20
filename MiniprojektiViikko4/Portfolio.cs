using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MiniprojektiViikko4
{
    public class Portfolio
    {
        public void PortfolioPuu(Peli peli)
        {
            peli.LisääAikaa();
            string portfolio = peli.Portfolio();

            if ((portfolio == "a" || portfolio == "A") && (peli.reppu.tavarat.Count(t=>t.Nimi == "matkakortti") == 1))
            {
				peli.EhtiminenMakkaratalolle();

            }
            else if (portfolio=="b"|| portfolio == "B")
            {
                //Lähteä kävelemään Makkaratalolle.

            }
            else if (portfolio == "c"|| portfolio == "C")
            {
                //Etsiä kaupunkipyörä ja pyöräillä Makkaratalolle.

            }



        }
    }
}
