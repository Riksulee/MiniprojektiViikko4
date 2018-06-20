using System;
using System.Collections.Generic;
using System.Text;

namespace MiniprojektiViikko4
{
    class Aloituskuva
    {
        public void Kuva()
        {


            string nimi = "Ulfricin kohtalon hetket";
            string kuva = @"
  /\___/\
 (  o o  )              - Hei! Olen Ulfric. Olen ensimmäistä kertaa Helsingissä,
 /   *   \              ja minun pitäisi löytää tieni työhaastatteluun.
 \__\_/__/              Voitko auttaa minua?
   /   \
  / ___ \
  \/___\/";


            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("  _______________________________________________________________________________________");
            Console.SetCursorPosition(35, 1);
            Console.WriteLine(nimi);
            Console.WriteLine("  _______________________________________________________________________________________");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.SetCursorPosition(90, 1);
            Console.WriteLine("|");
            Console.SetCursorPosition(90, 2);
            Console.WriteLine("|");
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(kuva);
            Console.WriteLine();

            bool kysyUudelleen = true;
            while (kysyUudelleen)
            {
                string vastaus = Console.ReadLine();

                if (vastaus == "e" || vastaus == "E")
                {
                    kysyUudelleen = false;
                    Environment.Exit(0);
                }

                else if (vastaus == "k" || vastaus == "K")
                {
                    kysyUudelleen = false;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Valitse k tai e");

                }
            }
        }
    }
}