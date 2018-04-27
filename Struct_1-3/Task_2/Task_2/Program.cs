using System;
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
            
            Train[] arr = new Train[8];
            int a;
            for(int i = 0;i<arr.Length;i++)
            {
                Console.WriteLine("Заполните расписание поездов: {0}й поезд:",i+1);
                Console.WriteLine("Место назначеня:");
                arr[i].punkt = Console.ReadLine();
                Console.WriteLine("Номер вагона:");
                arr[i].number = int.Parse(Console.ReadLine());
                Console.WriteLine("Время прибытия:");
                arr[i].time = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите номер поезда расписание которого вы хотите посмотреть");
            a = int.Parse(Console.ReadLine());
            switch(a)
            {
                case 1:
                    {
                        arr[0].show();
                        break;
                    }
                case 2:
                    {
                        arr[1].show();
                        break;
                    }
                case 3:
                    {
                        arr[2].show();
                        break;
                    }
                case 4:
                    {
                        arr[3].show();
                        break;
                    }
                case 5:
                    {
                        arr[4].show();
                        break;
                    }
                case 6:
                    {
                        arr[5].show();
                        break;
                    }
                case 7:
                    {
                        arr[6].show();
                        break;
                    }
                case 8:
                    {
                        arr[7].show();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error!");
                        break;
                    }
            }
            
            

        }        
     }
 }
struct Train
{
    public string punkt;
    public int number;
    public double time;
    public void show()
    {
        Console.WriteLine("Вы прибудете в {0}",punkt);
        Console.WriteLine("Номер вагона {0}",number);
        Console.WriteLine("Время прибытия {0}",time);
    }
}

