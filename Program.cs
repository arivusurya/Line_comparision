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
            double len1= LineComparision.Lengthofline.Linelegth(line1.X1,line1.Y1,line1.X2,line1.Y2);
            double len2=Lengthofline.Linelegth(line2.X1,line2.Y1,line2.X2,line2.Y2);
            Console.WriteLine(len1);
            Console.WriteLine(len2);
            if (len1 == len2){
                Console.WriteLine("equal");
            }else if(len1 > len2){
                Console.WriteLine("line1 is greater");
            }else{
                Console.WriteLine("line2 is greater");
            }
        }
         

}
}



