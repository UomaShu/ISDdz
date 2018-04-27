using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook(4,"Samsung",3400);
            notebook.show();

        }
    }
    struct Notebook
    {
        public int model;
        public string manufacture;
        public double coast;
        public Notebook(int model, string manufacture, double coast)
        {
            this.model = model;
            this.manufacture = manufacture;
            this.coast = coast;

        }

        public void show()
        {
            Console.WriteLine(model);
            Console.WriteLine(manufacture);
            Console.WriteLine(coast);

        }
    }
}
