using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    internal class Math
    {
        public double sum(double num1, double num2)
        {
            double result = (num1 + num2);
            return result;

        }

        public double minus(double num1, double num2)
        {
            double result = (num1 - num2);
            return result;

        }

        public double division(double num1, double num2)
        {
            double result = (num1 / num2);
            return result;

        }

        public double multiplication(double num1, double num2)
        {
            double result = (num1 * num2);
            return result;

        }

        public double percent(double num1, double num2)
        {
            double result = (num1 * (num2 / 100));
            return result;

        }
        public double depercent(double num1, double num2)
        {
            double result = ((num1 / 100) * num2);
            return result;

        }

        public double factorial_num1(double num1)
        {
            var result = 0;
            if (num1 < 0)
            {
                Console.WriteLine("Классический факториал вычислить нельзя.");
            }
            else if (num1 == 1)
            {
                  result = (1);
               
            }
            else if (num1 > 1)
            {
                result = 1;
                for (int f = 2; f <= num1; f++)
                {
                    result *= f;
                }
                 return result;   
            }
            return result;
        }
        public double factorial_num2(double num2)
        {
            var result = 0;
            if (num2 < 0)
            {
                Console.WriteLine("Классический факториал вычислить нельзя.");
            }
            else if (num2 == 1)
            {
                result = (1);

            }
            else if (num2 > 1)
            {
                result = 1;
                for (int f = 2; f <= num2; f++)
                {
                    result *= f;
                }
                return result;
            }
            return result;
        }
        public double Sum(double[] numbers)
        {
            double result = 0.0;
            foreach (double number in numbers)
            {
                result += number;
            }
            return result;
        }
        public int Count (double[] numbers)
        {
            return numbers.Length;
        }
        public double Max(double[] numbers)
        {
            double result = 0.0;
            foreach (double number in numbers)
            {
                if (number > result)
                {
                    result = number;
                }
            }
            return result;
        }
        public double Min(double[] numbers)
        {
            double result = 999.9;
            foreach (double number in numbers)
            {
                if (number < result)
                {
                    result = number;
                }
            }
            return result;
        }


    } 


   
    
}
