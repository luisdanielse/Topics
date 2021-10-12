using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{


    /****
     * 
     * I CANNOT CREATE AN INSTANCE OF AN ABSTRACT CLASS
     */
    public abstract class Figure
    {


        public abstract void calArea();

    }

    public class Triangle {
        
        public int base2;
        public int height;
        public double area;
        public Triangle(int base2, int height)
        {
            this.base2 = base2;
            this.height = height;
        }

        public double calcArea()
        {
            area = (base2* height)/2;
            return area;
        }

        
     }

    //public class Square : Figure, Interface1, Interface2
    //{
    //    public override void calArea()
    //    {

    //    }

    //    public void method1()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void method2()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void method3()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void methodF1111()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void methodF222()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void methodF33333()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


}
