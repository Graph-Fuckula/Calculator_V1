using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    internal class GUIConsolApp
    {
        public double[] GetArray(double[] array)
        {
            array = new double[int.Parse (Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse (Console.ReadLine());
            }
                return array;
        }
    }
}
