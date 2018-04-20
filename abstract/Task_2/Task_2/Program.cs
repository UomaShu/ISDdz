using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    interface IPlayable
    {
        void Play();
        void Pause(); 
        void Stop();
    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player:IPlayable,IRecordable
    {
        void IPlayable.Pause()
        {
            Console.WriteLine("Проигрывание поставлено на паузу.");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("Запись поставлена на паузу.");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Проигрывание остановлено.");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Запись остановлена.");
        }
        public void Play()
        {
            Console.WriteLine("Проигрывание начато.");
        }
        public void Record()
        {
            Console.WriteLine("Запись начата.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int choice;
            Player player = new Player();
            IPlayable playableMethods = player;
            IRecordable recordableMethods = player;
            Console.WriteLine("Добро пожаловать в плеер! Выберите, что вы хотите сделать:");
            Console.WriteLine("1.Начать проигрывание");
            Console.WriteLine("2.Поставить проигрывание на паузу");
            Console.WriteLine("3.Остановить проигрыывание");
            Console.WriteLine("4.Начать запись");
            Console.WriteLine("5.Поставить запись на паузу");
            Console.WriteLine("6.Остановить запись");
            Console.WriteLine("7.Выключить");
            while (flag)
            {

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        player.Play();
                        Console.WriteLine("Выберете следующие действие:");
                        break;
                    case 2:                        
                        playableMethods.Pause();
                        Console.WriteLine("Выберете следующие действие:");
                        break;
                    case 3:                       
                        playableMethods.Stop();
                        Console.WriteLine("Выберете следующие действие:");
                        break;
                    case 4:
                        player.Record();
                        Console.WriteLine("Выберете следующие действие:");
                        break;
                    case 5:
                        recordableMethods.Pause();
                        Console.WriteLine("Выберете следующие действие:");
                        break;
                    case 6:
                        recordableMethods.Stop();
                        Console.WriteLine("Выберете следующие действие:");
                        break;
                    case 7:
                        Console.WriteLine("Выключение");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод!");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
