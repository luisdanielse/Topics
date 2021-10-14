using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            myStruct thestruct = new myStruct("the struct");
            myClass theclass = new myClass("The class");
            thestruct.sayHi();
            theclass.sayHi();
            ModifyStruct(thestruct);
            ModifyClass(theclass);
            Console.WriteLine("Printing from Main");
            thestruct.sayHi();
            theclass.sayHi();

 

        }


        public static void ModifyStruct(myStruct thestruct)
        {
            thestruct.name = "name of struct modified";
            Console.WriteLine("Printing from ModifyStruct");
            thestruct.sayHi();

        }

        public static void ModifyClass(myClass theclass)
        {
            theclass.name = "name of class modified";
            Console.WriteLine("Printing from ModifyClass");
            theclass.sayHi();
        }
    }


}
