using System;

namespace LineComparision{

    class Lengthofline{

        public static void Linelegth(double x1,double y1, double x2,double y2 ){
           double length= Math.Sqrt( Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2) );
           Console.WriteLine("The length of the line is {0}",length);
        }


    }

}