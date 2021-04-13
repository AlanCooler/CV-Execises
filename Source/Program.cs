using CV_Tasks.Shapes;
using Source.Libs;
using System;

namespace CV_Tasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                IShape triangle = new Triangle(3, 5, 4);
                IShape circle = new Circle(15);

                Console.WriteLine(circle.CountArea());
            }
            catch(Exception ex)
            {
                
            }

        }
    }
}
