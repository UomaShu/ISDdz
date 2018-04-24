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
            YourClass your = new YourClass("Эжемесячныеее");
            String get = your.Substring(3, 11);
            Console.WriteLine(get);

            Console.WriteLine(your.IndexOf("мес"));
            String temp = your.replace("мес", "замес");
            Console.WriteLine(temp);
        }
    }
    class YourClass
    {
        String name;
        public YourClass(String name)
        {
            this.name = name;
        }
        public String Substring(int left, int right)
        {
            char[] temp = name.ToCharArray();
            String tempStr = null;
            int pos = 0;
            for (int i = left; i < right; i++)
            {
                tempStr += temp[i].ToString();
                pos++;
            }
            return tempStr;
        }
        public int IndexOf(String temp)
        {
            char[] userString = name.ToCharArray();
            char[] myString = temp.ToCharArray();
            int count = 0;

            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] == myString[count])
                {
                    count++;
                    if (count == myString.Length)
                    {
                        return i - count + 1;
                    }
                }

            }
            return -1;
        }
        public String replace(String first, String second)
        {
            char[] firstString = first.ToCharArray();
            char[] secondString = second.ToCharArray();
            char[] nameString = name.ToCharArray();
            String temp = "";
            int count = 0, found = 0;
            for (int i = 0; i < nameString.Length; i++)
            {
                if (nameString[i] == firstString[count])
                {
                    count++;
                    if (count == first.Length)
                    {
                        temp += name.Substring(found, i - first.Length) + second;
                        count = 0;
                        found = i;
                    }
                }

            }
            temp += name.Substring(found);
            return temp;
        }
    }
}

