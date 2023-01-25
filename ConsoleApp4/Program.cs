using System;

namespace Brogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till personinmatningssystemet. skriv upp till tusen namn");
            string svar = "j";
            string[] namn = new string[1000];
            int x = 0;
            while (svar == "j")
            {
                Console.Write("Skriv ett namn: ");
                namn[x] = Console.ReadLine();
                Console.Write("Vill du mata in ett till namn j/n ? ");
                svar = Console.ReadLine();
                x++;
            }
            Console.Write("Sök upp ett namn bland de du nyss skrev ? ");
            string NameSearch = Console.ReadLine();
            int y = 0;
            foreach(string s in namn)
            {
                if (s == NameSearch)
                {
                    y++;
                }
            }
            Console.WriteLine("Namnet: " + NameSearch + " Förekomm: " + y + " Gånger");

        }
    }
}