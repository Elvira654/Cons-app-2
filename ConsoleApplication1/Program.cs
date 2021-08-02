using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Napisati program koji za unijetih n brojeva određuje koliko ima pozitivnih, koliko negativnih i njihovu sumu.*/
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, pozitivni = 0, negativni = 0;
            Console.WriteLine("Unesite n: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Unesite " + (i + 1) + ". clan niza: ");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > 0)
                pozitivni += 1;
                else if (arr[i] < 0)
                negativni += 1;
            }
            Console.WriteLine("Pozitivnih brojeva ima " + pozitivni + ", a negativnih " + negativni + ".");
            Console.ReadKey();
        }
    }
}
