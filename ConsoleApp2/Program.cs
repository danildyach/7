using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("36");
            zd36();
            Console.WriteLine("34");
            zd34();
            Console.WriteLine("38");
            zd38();
        }
        static void zd34()
        {
            //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.
            //[345, 897, 568, 234] -> 2
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int count = 0;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(100, 1000);
            }

            for (int i = 0; i < size; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(String.Join(" ", array));
            Console.WriteLine(count);


        }
        static void zd36()
        {
            //Задача 36: Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
            //[3, 7, 23, 12] -> 19
            //[-4, -6, 89, 6]-> 0
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int count = 0;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(100, 1000);
            }
            for (int i = 0; i < size; i++)
            {
                if (i % 2 != 0)
                {
                    count += array[i];

                }
            }
            Console.WriteLine(String.Join(" ", array));
            Console.WriteLine(count);
        }
        static void zd38()
        {
            //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            //[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
            int size = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[size];
            double max = 0;
            double min = 0;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(10, 1000);
            }
            for (int i = 0; i < size; i++)
            {
                max = array[0];
                min = array[0];

                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            double result = Math.Abs(max - min);
            Console.WriteLine($"max = {max}");
            Console.WriteLine($"min = {min}");
            Console.WriteLine($"разница = {result}");


        }
    }
}

