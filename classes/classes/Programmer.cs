using System;

namespace classes
{
    class Programmer: Human
    {
        public string programmingLanguage;
        public Programmer(string name, int age, string programmingLanguage) : base(name, age)
        {
            this.programmingLanguage = programmingLanguage;
            Console.WriteLine("A new programmer has been created");
        }

        public void program()
        {
            Console.WriteLine("I am writing Code in {0}", programmingLanguage);
        }

        public override void sayHi()
        {
            Console.WriteLine("Hi name is {0}. I am {1} years old and I am an expert in {2}", Name, Age, programmingLanguage);
        }


    }
}
