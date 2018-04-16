using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    public class Invoice
    {
        int account;
        string customer;
        string provider;
        private string article;
        private int quantity;
        public Invoice()
        {
            account = 1234;
            customer = "Клиент";
            provider = "Поставщик";
        }
        public int Account
        {
            get
            {
                return account;
            }
        }
        public string Customer
        {
            get
            {
                return customer;
            }
        }
        public string Provider
        {
            get
            {
                return provider;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public string Article
        {
            get
            {
                return article;
            }
            set
            {
                article = value;
            }
        }
        public void Cost(double price)
        {
                    Console.WriteLine("Стоимость {0} единиц {1}", quantity, article);
                    Console.WriteLine("С НДС:{0}", price*quantity+0.2*(price*quantity));
                    Console.WriteLine("Без НДС:{0}",price*quantity);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            Invoice productCost = new Invoice();
            Console.WriteLine("Уважаемый вас приветствует. Лицевой счет . У нас вы можете заказать такие товары:");
            Console.WriteLine("1.Кисточка, 32 грн.");
            Console.WriteLine("2.Гуашь, 56 грн.");
            Console.WriteLine("3.Альбом, 100 грн.");
            Console.WriteLine("Введите название товара:");
            productCost.Article = Console.ReadLine();
            Console.WriteLine("Введите количество:");
            productCost.Quantity = int.Parse(Console.ReadLine());
            switch (productCost.Article)
            {
                case "Кисточка":
                    price = 32;
                    productCost.Cost(price);
                    break;
                case "Гуашь":
                    price = 56;
                    productCost.Cost(price);
                    break;
                case "Альбом":
                    price = 100;
                    productCost.Cost(price);
                    break;
                default:
                    Console.WriteLine("Некорректный ввод!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
