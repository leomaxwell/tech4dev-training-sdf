namespace MethodsDemo
{
    internal class Program
    {
        //Program execution starts from here.
        static void Main(string[] args)
        {
            string first = "Leo";
            string last = "Maxwell";

            string fullName = GetFullName(first, last);

            Console.WriteLine("Hello " + fullName);
        }


        static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        static void PrintValues(int start = 0, int end = 10)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }

        static int CalculateRectangleArea(int length, int width)
        {
            int area = length * width;
            return area;
        }

        static void CalculateRectangleArea(double length, double width)
        {
            double area = length * width;
            Console.WriteLine("Area = " + area);
        }

        static void CalculateRectangleArea()
        {
            //Area of a Rectangle
            double area, length = 5, width = 6;
            area = length * width;

            Console.WriteLine(area);
        }

        static void PrintGreeting()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
