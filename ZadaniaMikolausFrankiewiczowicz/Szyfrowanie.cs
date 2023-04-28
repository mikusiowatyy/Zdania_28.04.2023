using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaMikolausFrankiewiczowicz
{
    public static class Szyfrowanie
    {
        public static string ZaszyfrujCezar(string tekst, int klucz)
        {
            string zaszyfrowanyTekst = "";
            foreach (char znak in tekst)
            {
                if (char.IsLetter(znak))
                {
                    char zaszyfrowanyZnak = (char)(((int)znak + klucz - 65) % 26 + 65);
                    zaszyfrowanyTekst += zaszyfrowanyZnak;
                }
                else
                {
                    zaszyfrowanyTekst += znak;
                }
            }
            return zaszyfrowanyTekst;
        }

        public static string OdszyfrujCezar(string szyfr, int klucz)
        {
            string odszyfrowanyTekst = "";
            foreach (char znak in szyfr)
            {
                if (char.IsLetter(znak))
                {
                    char odszyfrowanyZnak = (char)(((int)znak - klucz - 65 + 26) % 26 + 65);
                    odszyfrowanyTekst += odszyfrowanyZnak;
                }
                else
                {
                    odszyfrowanyTekst += znak;
                }
            }
            return odszyfrowanyTekst;
        }
    }
}
