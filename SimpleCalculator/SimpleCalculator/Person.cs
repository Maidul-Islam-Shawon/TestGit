using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Person
    {
        private int _age;
        static private string name = "Jony";


        public int getAge()
        {
            return _age;
        }

        public void setAge(int NewAge)
        {
            _age = NewAge;
        }

        static public void greet()
        {
            Console.WriteLine("Welcome ! " + name);
        }
    }
}
