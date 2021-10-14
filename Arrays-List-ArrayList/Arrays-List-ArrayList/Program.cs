using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_List_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lets create an array of integers */
            int[] scores = new int[] { 2, 3, 4, 5, 6, 7, 8 };


            /* If you don't want to deal with a fixed amount of items..You can use a List */
            List <int> myListOfScores = new List<int>();
            myListOfScores.Add(2);
            myListOfScores.Add(3);

            /* If you want to work not only with integers (You want to mix other data types), you can
             * use an ArrayList */
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(2);
            myArrayList.Add("Hello World");
            myArrayList.Add(scores);


        }
    }
}
