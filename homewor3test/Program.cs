using System;

namespace homewor3test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ededinizi daxil edin: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number<50)
            {
                Console.Write("\n uce bolunen regemler: ");
                for (int i = 0; i < number; i++)
                {
                    if (i%3==0)
                    {
                        int numsize = (i / 3+1);
                        int[] olacaq = new int[numsize];
                        Console.Write(i+" " );
                    }
                }
            }
            if (number > 50&&number<100)
            {
                Console.Write("\n bese bolunen regemler: ");
                for (int i = 0; i < number; i++)
                {
                    if (i % 5 == 0)
                    {
                        int numsize = (i / 5 + 1);
                        int[] olacaq = new int[numsize];
                        Console.Write(i+" ");
                    }
                }
            }
            if (number > 100)
            {
                Console.Write("\n sekkize bolunen regemler: ");
                for (int i = 0; i < number; i++)
                {
                    if (i % 8 == 0)
                    {
                        int numsize = (i / 8 + 1);
                        int[] olacaq = new int[numsize];
                        Console.Write(i+ " ");
                    }
                }
            }
        }
    }
}
