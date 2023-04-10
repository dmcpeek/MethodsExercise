using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal static class Methods
    {
        public static string Name()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }

        public static string Color()
        {
            Console.WriteLine("What is your color?");
            return Console.ReadLine();
        }

        public static string Animal()
        {
            Console.WriteLine("What is your favorite animal?");
            return Console.ReadLine();
        }

        public static string Band()
        {
            Console.WriteLine("What is your favorite band?");
            return Console.ReadLine();
        }

        public static int Addition(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Subtraction(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;
        }

        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;
        }

        public static double Divide(float num1, float num2)
        {
            var answer = num1 / num2;
            return answer;
        }

        public static int Modulus(int num1, int num2)
        {
            var answer = num1 % num2;
            return answer;
        }

        public static void Sum(params int[] list)
            {
            int sum = 0;
                for (int i = 0; i < list.Length; i++) 
                {
                    sum = sum + list[i];
                    if (i == 0)
                        Console.Write($"{sum}");
                    else
                        Console.Write($" + {sum}");
            }
            Console.WriteLine($" = {sum}");
            }

    }
}
