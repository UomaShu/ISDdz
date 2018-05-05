using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"Task_2.txt";
            FileInfo file = new FileInfo(fileName);
            using (StreamWriter fileWriter = file.CreateText())
            {
                fileWriter.WriteLine("Эта строка, записанная в файл.");
                fileWriter.WriteLine("Еще одна строка, записанная в файл.");
                fileWriter.Close();
            }
            using (StreamReader fileReader = file.OpenText())
            {
                string str;
                while ((str = fileReader.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
                fileReader.Close();
            }
            Console.ReadKey();
        }
    }
}

