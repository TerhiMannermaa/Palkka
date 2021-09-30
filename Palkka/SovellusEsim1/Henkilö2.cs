using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SovellusEsim1
{
    class Henkilö2
    {
        public string PalkkaTieto { get; init; }
        public string Nimi { get; init; }
        public string Ennakonpidätys { get; init; }
        public string Palkanmaksupäivä { get; init; }



        public Henkilö2(string palkkaTieto, string nimi, string palkanmaksupäivä, string ennakonpidätys)
        {
            PalkkaTieto = palkkaTieto;
            Nimi = nimi;
            Palkanmaksupäivä = palkanmaksupäivä;
            Ennakonpidätys = ennakonpidätys;

        }

        public override string ToString()
        {
            return $"{PalkkaTieto} {Nimi} {Ennakonpidätys} {Palkanmaksupäivä}";
        }
    }
}
