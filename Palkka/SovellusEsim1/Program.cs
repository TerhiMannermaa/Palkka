using System;
using System.Collections.Generic;

namespace SovellusEsim1
{
    class Program
    {
        static string ohje = "0.Lopetus\n1.Lisää\n2.Listaa\n3.Palkanmaksupäivät\n4.Poista työntekijä";

        static void Main(string[] args)
        {
            Sovellus app = new Sovellus();

            Console.WriteLine(ohje);
            string komento = Console.ReadLine();
            while (!komento.StartsWith("0"))   // ! tarkoittaa NOT
            {
                switch (komento)
                {
                    case "1":
                        Console.WriteLine("Anna työntekijän nimi");
                        var nimi = Console.ReadLine();

                        Console.WriteLine("Anna palkkatiedot");
                        var palkkatiedot = Console.ReadLine();

                        Console.WriteLine("Anna ennakonpidätysprosentti");
                        var Ennakonpidätys = Console.ReadLine();

                        Console.WriteLine("Anna palkanmaksupäivä");
                        var Palkanmaksupäivä = Console.ReadLine();



                        var työntekijä = new Työntekijä(palkkatiedot,nimi,Ennakonpidätys,Palkanmaksupäivä);                        

                        app.LisääTyöntekijä(työntekijä);
                        break;

                    case "2":
                        Console.WriteLine(app.ListaaTyöntekijät());
                        break;

                    default:        // kaikissa muissa tapauksissa
                        break;

                    case "3":
                        Console.WriteLine(app.ListaaPalkkapäivät());
                        break;

                    case "4":
                        Console.WriteLine("Valitse poistettava työntekijä");
                        Console.WriteLine(app.ListaaTyöntekijät());
                        var poistettava = Console.ReadLine();
                        Console.WriteLine(app.PoistaTyöntekijä());
                        
                        break;
                }
                Console.WriteLine(ohje);
                komento = Console.ReadLine();
            }
        }
    }
}
