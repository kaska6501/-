using System;
using System.IO;
using System.Text;

namespace Файлы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //File.Create("test.txt"); //создание файла
            //if (File.Exists("test.txt")) //проверка на существование
            //    Console.WriteLine("Файл успешно создан!");
            //File.Delete("test.txt"); //удаление файла
            //if (!File.Exists("test.txt")) //проверка на отсутствие
            //    Console.WriteLine("Файл был удален");

            FileStream F1 = new FileStream("test.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(F1); //запись в файл
            //writer.Write("Лиза, вернись((( Настя из-за тебя сломала руку!");
            Random rnd = new Random();
            int number;
            for (int i = 0; i < 10; i++) 
            {
                number = rnd.Next(-20, 21); 
                writer.Write(number + "\t");
            }

            writer.Close(); //закрытие файла ОБЯЗАТЕЛЬНО
            Console.ReadKey();
        }
    }
}
