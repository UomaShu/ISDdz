using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker:DocumentWorker
    {
        public override void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
    class ExpertDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("1.Открыть документ");
            Console.WriteLine("2.Редактировать документ");
            Console.WriteLine("3.Сохранить документ");
            Console.WriteLine("4.Выйти");
        }
        static void Main(string[] args)
        {
            string key;
            int choice;
            bool flag = true;
            Console.WriteLine("Введите ключ (если не имеете ключа просто нажмите Enter):");
            key = Console.ReadLine();
            switch (key)
            {
                case "":
                    DocumentWorker documentLite = new DocumentWorker();
                    Console.WriteLine("Добро пожаловать в Lite версию!");
                    Menu();
                    while(flag)
                    {
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                documentLite.OpenDocument();
                                break;
                            case 2:
                                documentLite.EditDocument();
                                break;
                            case 3:
                                documentLite.SaveDocument();
                                break;
                            case 4:
                                flag = false;
                                break;                           
                        }                                                                        
                    }                    
                    break;
                case "pro":
                    DocumentWorker documentPro = new ProDocumentWorker();
                    Console.WriteLine("Добро пожаловать в Pro версию!");
                    Menu();
                    while (flag)
                    {
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                documentPro.OpenDocument();
                                break;
                            case 2:
                                documentPro.EditDocument();
                                break;
                            case 3:
                                documentPro.SaveDocument();
                                break;
                            case 4:
                                flag = false;
                                break;
                        }
                    }
                    break;
                case "exp":
                    DocumentWorker documentExp = new ExpertDocumentWorker();
                    Console.WriteLine("Добро пожаловать в Expert версию!");
                    Menu();
                    while (flag)
                    {
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                documentExp.OpenDocument();
                                break;
                            case 2:
                                documentExp.EditDocument();
                                break;
                            case 3:
                                documentExp.SaveDocument();
                                break;
                            case 4:
                                flag = false;
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Неверный ввод!");
                    break;             
            }
            Console.ReadKey();
        }
    }
}
