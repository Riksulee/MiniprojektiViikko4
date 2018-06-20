using System;
using System.Collections.Generic;
using System.Text;

namespace MiniprojektiViikko4
{
    public class Tapahtuma
    {
		public string nimi;
		public string tapahtuma;

		public Tapahtuma(string n, string t)
		{
			nimi = n;
			tapahtuma = t;
		}

		public override string ToString()
		{
			return "Tarinan nimi: " + nimi + ", Tarina: " + tapahtuma;
		}
	}
}
