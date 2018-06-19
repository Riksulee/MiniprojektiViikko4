using System;
using System.Collections.Generic;
using System.Text;

namespace MiniprojektiViikko4

{
    public class Reppu
    {
        public List<Tavara> tavarat { get; set; }

        public Reppu()
        {
            tavarat = new List<Tavara>();
        }

        public void LisaaTavara(Tavara tavara)
        {
            tavarat.Add(tavara);
        }

        public string PoistaTavara(string nimi)
        {
            //return tavarat.Remove(tavara);

            for (int i = 0; i < tavarat.Count; i++)
            {
                if (tavarat[i].Nimi == nimi)
                {
                    tavarat.RemoveAt(i);
                    return "Tavara on poistettu";
                }
            }
            return "Kyseistä tuotetta ei ole repussa";
        }

        public void RepunSisalto()
        {
			foreach (var item in tavarat)
			{
				Console.WriteLine(item);
			}
		}
    }
}