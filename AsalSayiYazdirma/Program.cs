using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayiYazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int sayi = 2; sayi <= 10000; sayi++)
            {
                bool asalMi = true;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
                if (asalMi)
                    Console.Write(" " + sayi);
            }
            Console.ReadLine();
        } 
        
    }
}
