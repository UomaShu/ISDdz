using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year, nextYear;
            Console.WriteLine("Введите день рождения:");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведите число месяца рождения:");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведите год рождения:");
            year = int.Parse(Console.ReadLine());
            DateTime dateOfBirth = new DateTime(year,month,day);
            DateTime todayDate = DateTime.Today;
            Console.WriteLine("Вы родились {0}", dateOfBirth.ToShortDateString());
            DateTime dateNext;
            if (dateOfBirth.Month.CompareTo(todayDate.Month)<0 || (dateOfBirth.Month.CompareTo(todayDate.Month)==0 && dateOfBirth.Day.CompareTo(todayDate.Day)<0))
            {
                nextYear = Convert.ToInt32(todayDate.Year)+1;
                dateNext = new DateTime(nextYear, month, day);
                Console.WriteLine("Дней до следующего дня рождения:{0}", (dateNext.Subtract(todayDate)).TotalDays);
            }
            else if (dateOfBirth.Month.CompareTo(todayDate.Month) > 0 || (dateOfBirth.Month.CompareTo(todayDate.Month) == 0 && dateOfBirth.Day.CompareTo(todayDate.Day) >= 0))
            {
                nextYear = Convert.ToInt32(todayDate.Year);
                dateNext = new DateTime(nextYear, month, day);
                Console.WriteLine("Дней до следующего дня рождения:{0}", (dateNext.Subtract(todayDate)).TotalDays);
            }      
            //DateTime dateNext = new DateTime(Convert.ToInt32(DateTime.Today.Year),month, day);
            //Console.WriteLine("Дней до следующего дня рождения:{0}",(dateNext.Subtract(todayDate)).TotalDays);
            Console.ReadKey();
        }
    }
}
