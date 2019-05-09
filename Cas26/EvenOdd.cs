using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas26
{
    class EvenOdd
    {
        //metoda koja vraca true ili false u zavisnosti od toga da li je ulazni broj paran ili neparan.
        public static bool IsEven(int number)
        {
            //prvi nacin
            //return (number % 2 == 0);

            //2gi nacin
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
