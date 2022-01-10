using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PatikaOdev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 adet sayı girin.");

            ArrayList asal = new ArrayList();
            ArrayList notAsal = new ArrayList();

            for (int i = 0; i < 4; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if ( num > 0)
                {
                    if(num % 2 == 0)
                    {
                        notAsal.Add(num);
                    }
                    else asal.Add(num);
                }
                else Console.WriteLine("Sıfırdan küçük sayı veya metin giremezsiniz.");
            }

            Console.Write("notAsal dizi : ");
            int notAsalCount = 0;
            notAsal.Sort();

            foreach (int num in notAsal)
            {
                Console.Write("{0}, ", num);
                notAsalCount += num;
            }

            Console.WriteLine("notAsal dizi {0} elemanlıdır ve dizi ortalaması {1} dir", notAsal.Count, notAsalCount/notAsal.Count );
            Console.WriteLine();

            Console.Write("asal dizi : ");
            int asalCount = 0;
            asal.Sort();

            foreach (int num in asal)
            {
                Console.Write("{0}, ", num);
                asalCount += num;
            }

            Console.WriteLine("asal dizi {0} elemanlıdır ve dizi ortalaması {1} dir", asal.Count, asalCount / asal.Count);

            Console.ReadLine();

        }
    }
}
