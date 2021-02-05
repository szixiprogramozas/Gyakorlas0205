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

            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Adja meg a feladat sorszámát: ");
                int feladatsorszam = int.Parse(Console.ReadLine());

                switch (feladatsorszam)
                {
                    case 2:
                        Console.WriteLine("2. Feladat: ");
                        double atlag = 0;
                        masodikfeladat(Szamok, atlag);                        
                        break;
                    case 3:
                        Console.WriteLine("3. Feladat: ");
                        harmadikfeladat(Szamok);
                        break;
                    case 4:
                        Console.WriteLine("4. Feladat: ");
                        negyedikfeladat(Szamok);
                        break;
                    case 5:
                        Console.WriteLine("5. Feladat: ");
                        otodikfeladat();
                        break;
                    case 6:
                        Console.WriteLine("6. Feladat: ");
                        hatodikfeladat();
                        break;
                    case 7:
                        Console.WriteLine("7. Feladat: ");
                        hetedikfeladat();
                        break;
                    case 8:
                        Console.WriteLine("8. Feladat: ");
                        nyolcasfeladat();
                        break;
                    case 9:
                        Console.WriteLine("9. Feladat: ");
                        kilencesfeladat();
                        break;
                    case 10:
                        Console.WriteLine("10. Feladat: ");
                        tizesfeladat();
                        break;
                    case 11:
                        Console.WriteLine("11. Feladat: ");
                        tizenegyesfeladat();
                        break;
                    case 12:
                        Console.WriteLine("12. Feladat: ");
                        tizenkettesfeladat();
                        break;
                    case 13:
                        Console.WriteLine("13. Feladat: ");
                        tizenharmasfeladat();
                        break;
                    case 14:
                        Console.WriteLine("14. Feladat: ");
                        tizennegyesfeladat();
                        break;
                    case 15:
                        Console.WriteLine("15. Feladat: ");
                        tizenotosfeladat();
                        break;
                    case 16:
                        Console.WriteLine("16. Feladat: ");
                        tizenhatosfeladat();
                        break;
                    default:
                        Console.WriteLine("Hiba! Olyan feladat sorszámát adta meg amely nem létezik!");
                        break;

                }
            }
            

            
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

        static void negyedikfeladat(List<int> szamok)
        {
            List<int> paros = new List<int>();
            List<int> paratlan = new List<int>();

            foreach (int num in szamok)
            {
                if (num % 2 == 0)
                {
                    paros.Add(num);
                }
                else if (num % 2 != 0)
                {
                    paratlan.Add(num);
                }
            }
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
             Console.WriteLine("Háromszög szerkesztése!");
            Console.WriteLine("Add meg az a oldalt: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a b oldalt: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a c oldalt: ");
            int c = int.Parse(Console.ReadLine());
            if (a+b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("A háromszöget meg lehet szerkeszteni!");
            }
            else
            {
                Console.WriteLine("A háromszöget nem lehet megszerkeszteni!");
            }
            
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
