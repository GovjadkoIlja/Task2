using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static int find(int n)
        {
            int i=1;
            int s = 0;
            while (s + i < n)
            {
                s += i;
                i++;
            }
            return (s == n - 1 ? 1 : 0);
        }
        static void Main(string[] args)
        {
            int i;
            int j;
            int n;
            int m;
            n=Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            for (i = 0; i < n; i++)
                mass[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                m = find(mass[i]);
                Console.Write(m + " ");
            }
            Console.ReadKey();
        }
    }
}
