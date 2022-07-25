using System;

namespace BolumleriBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi=0;
            Console.WriteLine("Bölenlerini bulmak istediğiniz sayıyı giriniz");
            sayi=Convert.ToInt32(Console.ReadLine());
           for (int i = 1; i <= sayi; i++)
			{
                if (sayi%i==0)
	            {
                    Console.WriteLine(i);
	            }
			}

           Console.ReadKey();
        }
    }
}
