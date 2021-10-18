using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* second way (For loop) */
            int[] myArray = new int[5];
            string tempString;
            int i;

            for(i=0; i< myArray.Length; i++)
            {
                Console.Write("Give me number {0}: ",i+1);
                tempString = Console.ReadLine();
                myArray[i] = Convert.ToInt32(tempString);
            }
           

           

            /* Extra code just to print what we have in the array */
            for (i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("The number {0} is {1}", i + 1, myArray[i]);
            }

        }


            /*
            myStruct thestruct = new myStruct("the struct");
            myClass theclass = new myClass("The class");
            thestruct.sayHi();
            theclass.sayHi();
            ModifyStruct(thestruct);
            ModifyClass(theclass);
            Console.WriteLine("Printing from Main");
            thestruct.sayHi();
            theclass.sayHi();

            */


      


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
