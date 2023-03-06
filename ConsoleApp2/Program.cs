using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{

    // Написать метод для поиска индекса элемента массива (тип элемента в массиве - int)
    // метод должен вернуть идекс первого найденного элемента ( если он будет найден)
    internal class Program
    {
        
        static void IndexArray(int[] index, int a)
        {
            for (int i = 0; i < index.Length; i++) 
            {
                for (int j = a; j == index[i]; j++)
                {
                    if (index[i] == j)
                    {
                        Console.WriteLine($"Индекс под номером : {i}");
                        break;
                    }
                    
                }
                 if (index[i] != a)
                    Console.WriteLine("Такого индекса нет, поэтому как Ваня сказал, пишем исключение :) "+-1);
                break;
            }
        }
        static void Main(string[] args)
        {
            Random RandomIndexArray = new Random();
            int[] myArray = new int[RandomIndexArray.Next(5,25)]; // Создание массива с рандомным
                for ( int i = 0; i < myArray.Length; i++ )        // колличеством индексов
                {
                    myArray[i] = RandomIndexArray.Next(1,100); // рандомное значение элемента индекса
                Console.WriteLine($"Данные индекса под номером {i} :"+myArray[i]); // вывод значения определенного индекса
                }
            Console.WriteLine($"\nКакой индекс вывести? всего в массиве : "+ myArray.Length+ "  индексов");
            int Number = int.Parse(Console.ReadLine());
            IndexArray(myArray, Number);
           
        }
    }
}