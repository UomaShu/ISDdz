using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private string date;
        public User()
        {
            date = DateTime.Today.ToString("dd MMMM yyyy");
        }
        public int Age
        {
            get
            {
                if (age < 0)
                    return 1;
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Date
        {
            get
            {
                return date;
            }
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Ведите логин:");
            user.Login = Console.ReadLine();
            Console.WriteLine("Ведите имя:");
            user.Name = Console.ReadLine();
            Console.WriteLine("Ведите фамилию:");
            user.Surname = Console.ReadLine();
            Console.WriteLine("Ведите возраст:");
            user.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Информация о пользователе:");
            Console.WriteLine("Логин: {0}",user.Login);
            Console.WriteLine("Имя: {0}",user.Name);
            Console.WriteLine("Фамилия: {0}",user.Surname);
            Console.WriteLine("Возраст: {0}",user.Age);
            Console.WriteLine("Дата заполнения анкеты: {0}",user.Date);
            Console.ReadKey();
        }
    }
}
