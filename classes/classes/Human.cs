using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Human
    {

        private string name;
        private int age;


        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Human(Dictionary<string, string> HumanDict)
        {
            string temporaryName = HumanDict["name"];
            int temporaryAge = Int32.Parse(HumanDict["age"]);

            this.name = temporaryName;
            this.age = temporaryAge;
            //Console.WriteLine("The name is {0} and the age is {1}", temporaryName, temporaryAge);
        }


        public virtual void sayHi()
        {
            Console.WriteLine("Hi my name is {0} and I am {1} years old", name, age);
        }

        public string Name
        {
            get { return name; }   // get method
            set { name = value; }  // set metho
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void setName(string name)
        {
            this.name = name;
        }

    }
}
