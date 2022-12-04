using System;

namespace dyunamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a, b, c ;
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = Sum(a, b);
            //Console.WriteLine(c);

            int k ,p , l ,d ;
            k = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            l = int.Parse(Console.ReadLine());


            
            d = cikl(k, p, l);
            Console.WriteLine(d);
        }
        static int Sum(int a, int b)
        {
            int result = a * b;
            return result;
        }
        static int cikl(int k, int p, int l)
        {
            int arjeq = k /l+ p / l;
            return arjeq;
        }

    }
}
