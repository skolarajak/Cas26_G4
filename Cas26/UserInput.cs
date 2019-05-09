using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas26
{
    class UserInput
    {
        //metoda koja sluzi da ucita ono sto je korisnik uneo preko tastature
        public static int GetInput()
        {
            //ispisuje tekst korisniku
            Console.Write("Unesite broj ");
            //ucitava ono sto je korisnik uneo sa tastature, konvertuje u int i vraca vrednost u main metodu
            return Convert.ToInt32(Console.ReadLine());

        }
    }
}
