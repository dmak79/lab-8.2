using System;
using System.IO;
using System.Text;
namespace readwriteapp
//
{
    class Class1
    {
        static void Main(string[] args)
        {
            string path = ("E:\\ITMO_BIM_2021-2022\\_Задания\\08\\Lab 8.2\\F1.txt");
            StreamWriter sw = File.CreateText(path); //создаем массив sw, 
                                                     //а при помощи метода File.CreateText создаем файл 
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(100)); //Записываем случайные 10 чисел в наш файл
                }
            }
            sw.Close();
            string[] strNumbers = File.ReadAllLines(path);
            int count = 0;
            foreach (string strNumber in strNumbers)
            {
                if (Int32.TryParse(strNumber, out int number))
                {
                    count = count + number;
                }
            }
            Console.WriteLine("Сумма элементов из файла равна: " + count);
            Console.ReadKey();
        }

    }
}