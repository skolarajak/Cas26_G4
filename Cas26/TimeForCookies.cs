using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cas26
{
    class TimeForCookies
    {
        //ucitavanje sa tastature
        public static DateTime GetDate()
        {
            //ispisivanje texta korisniku
            Console.Write("Unesite datum ");
            //ucitava sa tasture, konvertuje u datetime u formatu "dd/MM/yyyy" i to vraca u main klasu
            return DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
      
        }

        //za prosledjenu promenljivu date, vraca true ako je datum 25.12.GODINE ili ako je datum 7.1.GODINE
        public static bool TimeForMilk(DateTime date)
        {
            //promenljiva.Month nam vraca broj meseca u godini i dodeljuje tu vrednost promenljivoj strMonth
            int strMonth = date.Month;
            //promenljiva.Day nam vraca broj dana u mesecu (npr 13. ili 23.) i dodeljuje tu vrednost promenljivoj 
            //strDay
            int strDay = date.Day;
            //ispitujemo da li je mesec = 12 i dan = 25 ili mesec = 1 i dan = 7.
            //ako je ispunjen bilo koji od ta dva uslova, onda nam metoda TimeForMilk vraca true
            //u suprotnom nam vraca false.
            return (((strMonth == 12) && (strDay == 25)) || ((strMonth == 1) && (strDay == 7)));
        }

    }
}
