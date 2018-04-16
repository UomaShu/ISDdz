using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{

    public class Employee
    {
        private string name;
        private string surname;
        private string position;
        private int experience;
        private double salary;
        private double tax;
        public Employee(string a, string b)
        {
            name = a;
            surname = b;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
        }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }
        public double Salary
        {
            get
            {
                return salary;
            }
        }
        public double Tax
        {
            get
            {
                return tax;
            }
        }
        public void setSalary(string position, int experience, double minSalary)
        {
            switch (position)
            {
                case "Техник":
                    if(experience>=0 && experience <= 3)
                    {
                        salary = minSalary;
                    }
                    else if (experience > 3 && experience <=10)
                    {
                        salary = minSalary + Math.Round(0.1 * minSalary, 2);
                    }
                    else if(experience>10 && experience <= 20)
                    {
                        salary = minSalary + Math.Round(0.2 * minSalary, 2);
                    }
                    else if(experience > 20)
                    {
                        salary = minSalary + Math.Round(0.3 * minSalary, 2);
                    }
                    tax = Math.Round(0.18 * salary,2);                 
                    break;
                case "Сварщик":
                    if (experience >= 0 && experience <= 3)
                    {
                        salary = 2*minSalary;
                    }
                    else if (experience > 3 && experience <= 10)
                    {
                        salary = 2*minSalary + Math.Round(0.1 * 2*minSalary, 2);
                    }
                    else if (experience > 10 && experience <= 20)
                    {
                        salary = 2*minSalary + Math.Round(0.2 * 2*minSalary, 2);
                    }
                    else if (experience > 20)
                    {
                        salary = 2*minSalary + Math.Round(0.3 * 2*minSalary, 2);
                    }
                    tax = Math.Round(0.18 * salary, 2);
                    break;
                case "Электрик":
                    if (experience >= 0 && experience <= 3)
                    {
                        salary = 3 * minSalary;
                    }
                    else if (experience > 3 && experience <= 10)
                    {
                        salary = 3 * minSalary + Math.Round(0.1 * 3 * minSalary, 2);
                    }
                    else if (experience > 10 && experience <= 20)
                    {
                        salary = 3 * minSalary + Math.Round(0.2 * 3 * minSalary, 2);
                    }
                    else if (experience > 20)
                    {
                        salary = 3 * minSalary + Math.Round(0.3 * 3 * minSalary, 2);
                    }
                    tax = Math.Round(0.18 * salary, 2);
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
            const int minSalary = 3723;
            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            surname = Console.ReadLine();
            Employee employee = new Employee(name,surname);
            Console.WriteLine("Приветствуем, сотрудник, введите вашу должность:");
            Console.WriteLine("-Техник");
            Console.WriteLine("-Сварщик");
            Console.WriteLine("-Электрик");
            employee.Position = Console.ReadLine();
            Console.WriteLine("Ведите ваш стаж:");
            employee.Experience = int.Parse(Console.ReadLine());
            if (employee.Position!="Техник" && employee.Position != "Сварщик" && employee.Position != "Электрик")
            {
                Console.WriteLine("Неверный ввод!");
            }
            else
            {
                employee.setSalary(employee.Position,employee.Experience,minSalary);
                Console.WriteLine("Имя:{0}", employee.Name);
                Console.WriteLine("Фамилия:{0}", employee.Surname);
                Console.WriteLine("Должность:{0}", employee.Position);
                Console.WriteLine("Оклад:{0}", employee.Salary);
                Console.WriteLine("Налоговый сбор:{0}", employee.Tax);

            }
            Console.ReadKey();
        }
    }
}
