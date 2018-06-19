using System;
using System.Collections.Generic;
using System.Text;

namespace MiniprojektiViikko4
{
    public class Peli
    {
       

        public Peli()
        {
            Tapahtumalista lista = new Tapahtumalista();
            string t1 = "jkljklj";
            lista.tapahtumat.Add(new Tapahtuma("Nimi", t1));


          
        }
    }
}
