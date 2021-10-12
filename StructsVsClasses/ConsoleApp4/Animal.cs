using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Animal
    {

        protected string name;
        /* this is the constructor*/
        public Animal(string name)
        {
            
        }

        public void roarLouder()
        {
            Console.WriteLine("ROOOOAR");
        }

    }

    public struct myStruct
    {
        public string name;

        public myStruct(string name)
        {
            this.name = name;
        }

        public void sayHi()
        {
            Console.WriteLine("Hi my name is {0}", name);
        }

        public void sdfsdfsdfsdf()
        {

        }
    }

    public class myClass
    {
        public string name;

        public myClass(string name)
        {
            this.name = name;
        }

        public void sayHi()
        {
            Console.WriteLine("Hi my name is {0}", name);
        }
    }
}
