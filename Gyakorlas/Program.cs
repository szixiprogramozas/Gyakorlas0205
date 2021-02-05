using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gyakorlas
{
    class Program
    {
        static Dictionary<string, string> orszagok = new Dictionary<string, string>();
        struct Osztalynevsor
        {
            public string nev;
            public int ev;  
        }
        static void Main(string[] args)
        {
            Osztalynevsor[] nevsor = new Osztalynevsor[30];
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
                        otodikfeladat(Szamok);
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
                        nyolcasfeladat(nevsor);
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
                        Console.Write("Ország: ");
                        string orszag = Console.ReadLine();
                        Console.WriteLine(tizenotosfeladat(orszag));
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

        static void otodikfeladat(List<int> szamok)
        {
            Console.Write("Adja meg hányadik legnagyobb számot irassa ki: ");
            int index = int.Parse(Console.ReadLine());
            szamok.Sort();
            szamok.Reverse();
            Console.WriteLine(szamok[index - 1]);
        }
        static void hatodikfeladat()
        {
            Console.WriteLine("Van-e a tömben,ön által bekért szám? Adjon meg  egy számot:");
            int [] t = {8,5,7,4,9,1,2,3};
            int n = t.Length;
            int bekertszam = int.Parse(Console.ReadLine());
            int i = 0;
            while (i<n && t[i]!=bekertszam)
	               i++;
 
		       if(i<n)
			   Console.WriteLine("A szám benne van a tömbben. ");
		       else
			   Console.WriteLine("A szám nincs benne a tömbben"); 
        }
        static void hetedikfeladat()
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
        static void nyolcasfeladat(Osztalynevsor[]nevsor)
        {
            string sor = "";
            int sorszam = 0;
            StreamReader f = new StreamReader("nevsor.txt");

            while ((sor = f.ReadLine()) != null)
            {
                string[] temp = sor.Split(' ');
                nevsor[sorszam].nev = temp[0];
                nevsor[sorszam].ev = int.Parse(temp[1]);
                
                sorszam++;
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
            
            StreamReader sr = new StreamReader(@"orszagok.txt");

            string sor;
            while ((sor = sr.ReadLine()) != null)
            {
                string[] temp = sor.Split(';');
                if (temp.Length == 2)
                {
                    orszagok.Add(temp[0], temp[1]);
                }
            }

            Console.WriteLine("orszagok.txt sikeresen beolvasva!");
        }
        static void tizennegyesfeladat()
        {
            StreamReader be = new StreamReader(@"orszagok.txt");
            string sor = "";

            while ((sor = be.ReadLine()) != null)
            {
                string[] temp = sor.Split(';');
                Console.WriteLine(temp[0] + " "+ temp[1]);
            }
            be.Close();
        }
        static string tizenotosfeladat(string orszag)
        {
            StreamReader fajl = new StreamReader(@"orszagok.txt");
            string sor = "";
            string varos = "";

            while ((sor = fajl.ReadLine()) != null)
            {
                string[] temp = sor.Split(';');

                if (temp[0] == orszag)
                {
                    varos = temp[1];
                }
            }

            fajl.Close();

            return varos;
        }
        static void tizenhatosfeladat()
        {
             string kereses = "";
            Console.WriteLine("Add meg a vársonevet:");
            kereses = Console.ReadLine();
            foreach (KeyValuePair<string, string> item in orszagok)
            {
                if (item.Value.Contains(kereses))
                {
                    Console.WriteLine(item.Key);
                }
                else
                {
                    Console.WriteLine("Nincs ilyen város, vagy az UTF-8-as kódolás miatt nem adja ki");
                    break;
                }
            }
        }
    }
}