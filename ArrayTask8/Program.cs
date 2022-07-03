using System;

namespace ArrayTask8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arraySize = 10;
            int itemMinValue = 0;
            int itemMaxValue = 10;
            int[] array = new int[arraySize];
            int offset = 0;

            Console.WriteLine("Исходный массив");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(itemMinValue, itemMaxValue);
                Console.Write(array[i] + " ");
            }

            Console.Write("Введите число, на которое будет выполнено смещение: ");
            offset = Convert.ToInt32(Console.ReadLine());         

            for (int i = 0; i < offset; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }

            Console.WriteLine($"Массив со сдвигом в лево на {offset} элементов"); 

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
