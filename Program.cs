using System;

namespace return_of_the_sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] num = new int[number];

            for (int i = 0; i < num.Length; i++)
                num[i] = int.Parse(Console.ReadLine());
            if (num[0] > num[1] && num[1] > num[2] && num[2] > num[3] && num[3] > num[4] && num[4] > num[5]) 
            {
                Console.WriteLine("Arigato {0}  {1} {2} {3} {4} {5}", num[0], num[1], num[2], num[3], num[4], num[5]);
            }
            else if (num[5] > num[4] && num[4] > num[3] && num[3] > num[2] && num[2] > num[1] && num[1] > num[0]) ;
            {
                Console.WriteLine("Omaewa {0}  {1} {2} {3} {4} {5}", num[5], num[4], num[3], num[2], num[1], num[0]);
            }
            Console.ReadKey();



        }
    }
}
