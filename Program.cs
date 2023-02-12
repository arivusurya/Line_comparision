using System;
using Lineequal;
namespace LineComparision{

    class Program{

        public static void Main(string[] args){
           Console.WriteLine("Enter the values for the first line:");
            Console.WriteLine("Enter X1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            MyLine line1 = new MyLine(x1, y1, x2, y2);

            Console.WriteLine("Enter the values for the second line:");
            Console.WriteLine("Enter X1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            MyLine line2 = new MyLine(x1, y1, x2, y2);
            Program.compare(line1,line2);

        
        }
          public static void compare(MyLine line1,MyLine line2){
            double m  = (line1.Y1-line1.Y2)/(line1.X1-line1.X2);
            double m1  = (line2.Y1-line2.Y2)/(line2.X1-line2.X2);
            if (m == m1){
                Console.WriteLine("lines are parallel");
            }else{
                      Console.WriteLine("lines are not parallel");
    }
    }

}
}



