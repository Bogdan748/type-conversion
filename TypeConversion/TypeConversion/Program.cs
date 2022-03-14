using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //[X=10,Y=20]
            //Conversion

            

            Point p = new Point
            {
                X = 10,
                Y = 20
            };

            string pointAsText = p;
            Console.WriteLine($"Conversie implicita: {pointAsText}");


            int i = 10;
            i.ToString();
            string a = "10";
            int.TryParse(a, out int result);

            Console.WriteLine(p.ToString());

            string someOtherPoint = "[X=50,Y=90]";
            if (Point.TryParse(someOtherPoint, out Point point))
            {
                Console.WriteLine(point.ToString());
               
            }
            else
            {
                Console.WriteLine("nu mere");
            }


            Point otherPoint = (Point)"[X=30,Y=30]";
            Console.WriteLine(otherPoint);

            Point pointSum = p + otherPoint;
            Console.WriteLine(pointSum.ToString());
        }
    }
}
