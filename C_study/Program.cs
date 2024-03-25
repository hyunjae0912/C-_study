using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_study
{

    class globla
    {
        public static int count = 0;
    }

    class ClassA
    {
        public ClassA() {
            globla.count++;
        }
    }

    class ClassB{
        public ClassB()
        {
            globla.count++;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(globla.count);

            new ClassA();


            Console.WriteLine(globla.count);

            new ClassB();

            Console.WriteLine(globla.count);

        }
    }
}
