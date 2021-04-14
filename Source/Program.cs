using CV_Tasks.Libs;
using CV_Tasks.Shapes;
using System;

namespace CV_Tasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                double triangleArea = new Triangle(10, 10, 10).CountArea();
                Console.WriteLine(triangleArea);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
