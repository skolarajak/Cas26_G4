using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas26
{
    class Program
    {
        static void Main(string[] args)
        {
            ////broj se unosi sa tastature i proveravate da li je uneseni broj paran ili neparan.
            ////radite preko klase
            ////u ovom redu pozivamo GetInput metodu i dodeljujemo promenljivoj number vrednost koju je korisnik uneo sa
            ////tastature
            //int number = UserInput.GetInput();
            ////u ovom redu pozivamo IsEven metodu iz klase EvenOdd, prosledjujemo metodi broj number i dobijamo true ili 
            ////false  u zavisnosti od toga da li je broj paran ili neparan
            //bool IsEven = EvenOdd.IsEven(number);
            ////ako je broj paran
            //if (IsEven)
            //{
            //    //konzola ispisuje da je broj paran
            //    Console.WriteLine("Number {0} is even ",number);
            //}
            ////u suprotnom
            //else
            //{
            //    //konzola ispisuje da broj nije paran
            //    Console.WriteLine("Number {0} is odd ", number);
            //}

            //Console.ReadKey();

            //2gi zadatak
            //Za uneti datum proveriti da li je Bozic, ako jeste napisati vreme je za mleko, ako nije napisati nije vreme!
            //radite preko klasa
            DateTime strDate = TimeForCookies.GetDate();
            bool isItTimeForMilk = TimeForCookies.TimeForMilk(strDate);
            if (isItTimeForMilk){
                Console.WriteLine("Time for milk :D !");
            }
            else
            {
                Console.WriteLine("Not milk time :( !");
            }

            Console.ReadKey();
        }
    }
}


// metoda1 = Unos podataka sa tastature -> metoda2 = obrada podataka i provera -> u main metodi samo ispisujemo ono
//sto nam je potrebno







































