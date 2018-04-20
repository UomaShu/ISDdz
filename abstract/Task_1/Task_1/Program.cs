using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int a;
            XMLHandler xmlHandler = new XMLHandler();
            TXTHandler txtHandler = new TXTHandler();
            DOCHandler docHandler = new DOCHandler();
            Console.WriteLine("Выберите тип файла:1-TXT,2-DOC,3-XML");
            while(flag)
            {
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        int x;
                        Console.WriteLine("Что с ним нужно сделать:1-Открыть,2-Создать,3-Изменить,4-Сохранить");
                        x = int.Parse(Console.ReadLine());
                        switch (x)
                        {
                            case 1:
                                txtHandler.Open();
                                break;
                            case 2:
                                txtHandler.Create();
                                break;
                            case 3:
                                txtHandler.Chenge();
                                break;
                            case 4:
                                txtHandler.Save();
                                break;
                            default:
                                Console.WriteLine("Error!");
                                break;
                        }
                        break;
                    case 2:
                        int y;
                        Console.WriteLine("Что с ним нужно сделать:1-Открыть,2-Создать,3-Изменить,4-Сохранить");
                        y = int.Parse(Console.ReadLine());
                        switch (y)
                        {
                            case 1:
                                docHandler.Open();
                                break;
                            case 2:
                                docHandler.Create();
                                break;
                            case 3:
                                docHandler.Chenge();
                                break;
                            case 4:
                                docHandler.Save();
                                break;
                            default:
                                Console.WriteLine("Error!");
                                break;
                        }
                        break;
                    case 3:
                        int i;
                        Console.WriteLine("Что с ним нужно сделать:1-Открыть,2-Создать,3-Изменить,4-Сохранить");
                        i = int.Parse(Console.ReadLine());
                        switch (i)
                        {
                            case 1:
                                xmlHandler.Open();
                                break;
                            case 2:
                                xmlHandler.Create();
                                break;
                            case 3:
                                xmlHandler.Chenge();
                                break;
                            case 4:
                                xmlHandler.Save();
                                break;
                            default:
                                Console.WriteLine("Error!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }

        }
    }

    abstract class AbstractHandler
    {
        abstract public void Open();
        abstract public void Create();
        abstract public void Chenge();
        abstract public void Save();
    }

    class XMLHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Файл разширения XML открыт");
        }
        public override void Create()
        {
            Console.WriteLine("Файл разширения XML создан.");
        }
        public override void Chenge()
        {
            Console.WriteLine("Файл разширения XML изменен.");
        }
        public override void Save()
        {
            Console.WriteLine("Файл разширения XML сохранен.");
        }
    }
     class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Файл разширения TXT открыт");
        }
        public override void Create()
        {
            Console.WriteLine("Файл разширения TXT создан.");
        }
        public override void Chenge()
        {
            Console.WriteLine("Файл разширения TXT изменен.");
        }
        public override void Save()
        {
            Console.WriteLine("Файл разширения TXT сохранен.");
        }
    }
     class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Файл разширения DOC открыт");
        }
        public override void Create()
        {
            Console.WriteLine("Файл разширения DOC создан.");
        }
        public override void Chenge()
        {
            Console.WriteLine("Файл разширения DOC изменен.");
        }
        public override void Save()
        {
            Console.WriteLine("Файл разширения DOC сохранен.");
        }
    }

}
