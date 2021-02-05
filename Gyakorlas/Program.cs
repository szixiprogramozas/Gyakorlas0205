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
// NEM MINDEGYIK LESZ ELJÁRÁS, VAN AMELYIK FÜGGVÉNY LESZ. (B.I.)
// MENÜ IS KÉNE. Kiválaszt egyet, lefut és vissza a menübe.		
		
		
            Console.WriteLine("\n");
            Console.WriteLine("2. Feladat: ");
            double atlag = 0;
            masodikfeladat(Szamok, atlag);
            Console.WriteLine();
            Console.WriteLine("3. Feladat: ");
            harmadikfeladat(Szamok);
            Console.WriteLine();
            Console.WriteLine("4. Feladat: ");
            negyedikfeladat();
            Console.WriteLine();
            Console.WriteLine("5. Feladat: ");
            otodikfeladat();
            Console.WriteLine();
            Console.WriteLine("6. Feladat: ");
            hatodikfeladat();
            Console.WriteLine();
            Console.WriteLine("7. Feladat: ");
            hetedikfeladat();
            Console.WriteLine();
            Console.WriteLine("8. Feladat: ");
            nyolcasfeladat();
            Console.WriteLine();
            Console.WriteLine("9. Feladat: ");
            kilencesfeladat();
            Console.WriteLine();
            Console.WriteLine("10. Feladat: ");
            tizesfeladat();
            Console.WriteLine();
            Console.WriteLine("11. Feladat: ");
            tizenegyesfeladat();
            Console.WriteLine();
            Console.WriteLine("12. Feladat: ");
            tizenkettesfeladat();
            Console.WriteLine();
            Console.WriteLine("13. Feladat: ");
            tizenharmasfeladat();
            Console.WriteLine();
            Console.WriteLine("14. Feladat: ");
            tizennegyesfeladat();
            Console.WriteLine();
            Console.WriteLine("15. Feladat: ");
            tizenotosfeladat();
            Console.WriteLine();
            Console.WriteLine("16. Feladat: ");
            tizenhatosfeladat();

            Console.ReadKey();
        }

        static double masodikfeladat(List<int> szamok, double atlag)
        {
            double osszeg = 0;
            foreach (var item in szamok)
	{
                osszeg+=item;
	}           
            atlag = osszeg/15;
            Console.WriteLine("A számok átlaga: "+ Math.Round(atlag,2));
            return atlag;
        }

        static void harmadikfeladat(List<int> szamok)
        {
            int max = szamok[0];
            int min = szamok[0];

            for (int i = 0; i < szamok.Count; i++)
			{
                if (szamok[i] < min)
	{
                    min = szamok[i];
	}
			}
            for (int i = 0; i < szamok.Count; i++)
			{
                if (szamok[i] > max)
	{
                    max = szamok[i];
	}
			}
            Console.WriteLine("A legnagyobb és a legkisebb szám különbsége: " + (max - min));
        }

        static void negyedikfeladat()
        {

        }

        static void otodikfeladat()
        {

        }
        static void hatodikfeladat()
        {

        }
        static void hetedikfeladat()
        {

        }
        static void nyolcasfeladat()
        {

        }
        static void kilencesfeladat()
        {

        }
        static void tizesfeladat()
        {

        }
        static void tizenegyesfeladat()
        {


        }
        static void tizenkettesfeladat()
        {

        }
        static void tizenharmasfeladat()
        {

        }
        static void tizennegyesfeladat()
        {

        }
        static void tizenotosfeladat()
        {

        }
        static void tizenhatosfeladat()
        {

        }
    }
}
