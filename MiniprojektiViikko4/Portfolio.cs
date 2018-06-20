using System;
using System.Collections.Generic;
using System.Text;

namespace MiniprojektiViikko4
{
    public class Portfolio
    {
        public void PortfolioPuu(Peli peli)
        {
            string portfolio = peli.Portfolio();

            if (portfolio == "a" || portfolio == "A")
            {
                //Jatkaa matkaa ratikalle.


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
