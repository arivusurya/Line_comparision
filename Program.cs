using System;

namespace LineComparision{

    class Program{

        public static void Main(string[] args){
            Console.WriteLine("enter the value of two coordinates : ");
            Console.WriteLine("enter the value of X1 coordinate : ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the value of y1 coordinate : ");
            double y1 =  Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the value of X2 coordinate : ");
            double x2 =  Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the value of y2 coordinate : ");
            double y2 =  Convert.ToDouble(Console.ReadLine());
            Lengthofline.Linelegth(x1,y1,x2,y2);
        }
    }

}



