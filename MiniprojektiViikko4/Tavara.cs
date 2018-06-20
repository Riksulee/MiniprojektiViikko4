using System;
using System.Collections.Generic;
using System.Text;

namespace MiniprojektiViikko4
{
   public class Tavara
    {
        public string Nimi { get; set; }
		public double Paino { get; set; }
		//int Kayttokerrat { get; set; }

        public Tavara(string nimi, double paino)
        {
            Nimi = nimi;
            Paino = paino;
           
        }
        public Tavara(string nimi)
        {
            Nimi = nimi;
            Paino = 0;            

        }
        
		public override string ToString()
		{
			return "Tavara: " + Nimi + " ja tavaran paino: " + Paino;
		}
	}
}
