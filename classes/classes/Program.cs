using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> humanDict = createHuman();
            //Human Daniel = new Human(humanDict);

            //Programmer DanielProg = new Programmer("Daniel Soto", 30, "Python");
            //DanielProg.sayHi();
            //DanielProg.program();

            int baseOfTriangle;
            int heightOfTriangle;
            string baseOfTriangleString;
            string heightOfTriangleString;

            Console.Write("Provide me the base of the triangle");
            baseOfTriangleString = Console.ReadLine();
            baseOfTriangle = Convert.ToInt32(baseOfTriangleString);

            Console.Write("Provide me the height of the triangle");
            heightOfTriangleString = Console.ReadLine();
            heightOfTriangle = Convert.ToInt32(heightOfTriangleString);

            Triangle mytriangle = new Triangle(baseOfTriangle, heightOfTriangle);
            Double areaOFTriangle = mytriangle.calcArea();
            Console.WriteLine("The area of the triangle is {0}", areaOFTriangle);


        }


        public static Dictionary<string, string> createHuman()
        {
            Dictionary<string, string> humanToReturn = new Dictionary<string, string>(){
            {"name", "Luis Daniel"},
            {"age", "30"}};

            return humanToReturn;
        }
    }

   


    
}
