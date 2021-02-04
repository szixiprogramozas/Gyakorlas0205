using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> Szamok = new List<int> {3,5,2,63,2,1,5,7,5,3,1,51,0,94,3};

            foreach (int Szam in Szamok)
	{
                Console.Write(Szam + " ");
	}



            Console.ReadKey();

        }
    }
}
