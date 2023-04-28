using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaMikolausFrankiewiczowicz
{
    class KonkretnyUzytkownik : Uzytkownik
    {
      
        public KonkretnyUzytkownik(string imie, string nazwisko) : base(imie, nazwisko)
        {
        
        }

       
        public override void ZmienLogin(string nowyLogin, string staryLoginOdUzytkownika)
        {
           
        }

        public override void ZmienHaslo(string noweHaslo, string stareHasloOdUzytkownika)
        {
          
        }
    }
}
