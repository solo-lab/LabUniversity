using System;
using System.Threading.Channels;

namespace Lab_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 
            int a = 1;
            int b = 10;
            int c = 59;
            Ininterval(a);
            Ininterval(b);
            Ininterval(c);


            //2
            int up = 0;
            int left = 0;
            int right = 0;

            int Parametrtringle = a + b + c;
            Console.WriteLine(Parametrtringle);
            int s = 10;
            double Areatringle = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine(Areatringle);
            //3
            int[] x = new int[39] ;
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i;
                Console.WriteLine(x[i]);
                
            }
            
            //4
            x = new int[39];
            int[] Y = new int[x.Length];
            int count = 0; 
            
            Console.Write("Введіть модуль (M): ");
            int M = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < x.Length; i++)
            {
                
                if (Math.Abs(x[i]) > M)
                {
                    
                    Y[count] = x[i];
                    count++;
                }
            }
            Console.WriteLine("\nМасив X:");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }

            Console.WriteLine("\n\nМасив Y:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(Y[i] + " ");
            }

        }

        static void Ininterval(int num)
        {
            if (1 < num && num < 39 )
            {
                Console.WriteLine(num);
            }     
        }
    }
}