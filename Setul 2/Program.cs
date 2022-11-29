using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2
{
    internal class Program
    {
        static void p1()
        {
            int nr = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    nr++;
            }
            Console.WriteLine(nr);
        }

        static void p2()
        {
            int nrnegative = 0;
            int nrzero = 0;
            int nrpozitive = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 0)
                    nrnegative++;
                if (x == 0)
                    nrzero++;
                if (x > 0)
                    nrpozitive++;
            }
            Console.WriteLine("In secventa alaturata se gasesc " + nrnegative + " numere negative,  " + nrpozitive + " numere pozitive, iar numarul zero apare de   " + nrzero);
        }

        static void p3()
        {
            int suma = 0;
            int produs = 1;

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                suma = suma + i;
                produs = produs * i;
            }
            Console.WriteLine(suma);
            Console.WriteLine(produs);
        }

        static void p4()
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int poz = -1;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse((Console.ReadLine()));
                if (x == a)
                    poz = i;

            }
            if (poz == -1)
                Console.WriteLine(poz);
            else
                Console.WriteLine("Pozitia lui " + a + " este " + poz);
        }

        static void p5()
        {
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == i)
                    nr++;
            }
            Console.WriteLine(nr);
        }

        static void p6()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            bool ok = true;
            for (int i = 1; i < n; i++)
            {

                int y = int.Parse(Console.ReadLine());
                if (x > y)
                    ok = false;
                x = y;


            }
            if (ok)
                Console.WriteLine($"Numerele sunt in ordine crescatoare");
            else
                Console.WriteLine($"Nnumerele nu sunt in ordine crescatoare");

        }

        static void p7()
        {
            int n = int.Parse(Console.ReadLine());
            int i;
            int y = int.Parse(Console.ReadLine());
            int maxim = y;
            int minim = y;
            for (i = 1; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (maxim <= x)
                    maxim = x;
                if (minim >= x)
                    minim = x;

            }
            Console.WriteLine("Cea mai mare valoare este " + maxim + ", iar cea mai mica valoare este " + minim);
        }

    
        static void p8()
        {
            int n = int.Parse(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            int fn = 0;
            for (int i = 2; i < n; i++)
            {
                fn = f1 + f2;
                f1 = f2;
                f2 = fn;

            }
            Console.WriteLine(fn);
        }

        static void p9()
        {
            int n = int.Parse(Console.ReadLine());
            bool crescator = true;
            bool descrescator = true;
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (a > b)
                    crescator = false;
                if (a < b)
                    descrescator = false;

                a = b;
            }
            if (crescator || descrescator)
                Console.WriteLine("Sirul este monoton");
            else
                Console.WriteLine("Sirul nu este monoton");
        }

        static void p10()
        {
            int n = int.Parse(Console.ReadLine());
            int nrmax = 0;
            int nr = 1;
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (a == b)
                    nr++;
                else
                    nr = 1;

                a = b;
                if (nrmax < nr)
                    nrmax = nr;
            }

            Console.WriteLine("Numarul maxim de numere consecutive egale din secventa este " + nrmax);
        }

        static void p11()
        {
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int inv = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                inv = 0;
                while (a > 0)
                {
                    inv = inv * 10 + a % 10;
                    a = a / 10;
                }
                suma = suma + inv;
            }
            Console.WriteLine(suma);
        }

        static void p12()
        {
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            int a = int.Parse(Console.ReadLine());
            if (a != 0)
                nr++;
            for (int i = 1; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (b != 0 && a == 0)
                    nr++;
                a = b;
            }
            Console.WriteLine(nr);
        }

        static void p13()
        {
            int n = int.Parse(Console.ReadLine());
            int x1 = int.Parse(Console.ReadLine());
            int prim = x1;
            int bec = 0;
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x1 > x2)
                {
                    bec++;
                }
                x1 = x2;
            }
            if (bec == 1 && prim > x1)
            {
                Console.WriteLine($"Secventa este crescatoare rotita");
            }
            else Console.WriteLine($"Secventa nu este crescatoare rotita");
        }

        static void p14()
        {
            int n = int.Parse(Console.ReadLine());
            int x1 = int.Parse(Console.ReadLine());
            int prim = x1;
            int bec1 = 0;
            int bec2 = 0;
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x1 > x2)
                {
                    bec1++;
                }
                if (x1 < x2)
                {
                    bec2++;
                }
                x1 = x2;
            }
            if ((bec1 == 1 && prim > x1) ^ (bec2 == 1 && prim < x1))
            {
                Console.WriteLine($"Secventa este monotona rotita");
            }
            else Console.WriteLine($"Secventa nu este monotona rotita");
        }



        static void p17()
        {
            string[] t = Console.ReadLine().Split(' ');
            int zero = 0;
            int unu = 0;
            int a = 0;
            int incuibare = 0;
            int incuibaremax = 0;
            for (int i = 0; i < t.Length; i++)
            {
                a = int.Parse(t[i]);
                if (a == 0)
                {
                    zero++;
                    incuibare++;
                }
                if (a == 1)
                {
                    unu++;
                    if (i == 0) { break; }
                    incuibare = 0;
                }
                if (incuibare > incuibaremax)
                    incuibaremax = incuibare;
            }
            if (unu == zero && a != 0)
                Console.WriteLine($"Secventa este corecta");
            if (t[0] == "1" || t[t.Length - 1] == "0")
                Console.WriteLine($"Secventa este incorecta");
            else if (unu == zero && a != 0)
                Console.WriteLine($"Secventa este corecta si incuibarea maxima este {incuibaremax}");
            else
                Console.WriteLine($"Secventa este incorecta");
        }
        static void Main(string[] args)
     {
            Console.WriteLine("Introduceti numarul problemei:");
            int nrp = int.Parse(Console.ReadLine());
            if (nrp == 1)
            {
                Console.WriteLine("Problema " + nrp);
                p1();
            }
            if (nrp == 2)
            {
                Console.WriteLine("Problema " + nrp);
                p2();
            }
            if (nrp == 3)
            {
                Console.WriteLine("Problema " + nrp);
                p3();
            }
            if (nrp == 4)
            {
                Console.WriteLine("Problema " + nrp);
                p4();
            }
            if (nrp == 5)
            {
                Console.WriteLine("Problema " + nrp);
               p5();
            }
            if (nrp == 6)
            {
                Console.WriteLine("Problema " + nrp);
                p6();
            }
            if (nrp == 7)
            {
                Console.WriteLine("Problema " + nrp);
                p7();
            }
            if (nrp == 8)
            {
                Console.WriteLine("Problema " + nrp);
                p8();
            }
            if (nrp == 9)
            {
                Console.WriteLine("Problema " + nrp);
               p9();
            }
            if (nrp == 10)
            {
                Console.WriteLine("Problema " + nrp);
                p10();
            }
            if (nrp == 11)
            {
                Console.WriteLine("Problema " + nrp);
                p11();
            }
            if (nrp == 12)
            {
                Console.WriteLine("Problema " + nrp);
                p12();
            }
            if (nrp == 13)
            {
                Console.WriteLine("Problema " + nrp);
                p13();
            }
            if (nrp == 14)
            {
                Console.WriteLine("Problema " + nrp);
                p14();
            }
            if (nrp == 15)
            {
                Console.WriteLine("Problema " + nrp);
                //p15();
            }
            if (nrp == 16)
            {
                Console.WriteLine("Problema " + nrp);
                //p16();
            }
            if (nrp == 17)
            {
                Console.WriteLine("Problema " + nrp);
               p17();
            }
            
           
            Console.ReadKey();
     }
    }
}
