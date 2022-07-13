#nullable disable

//Declaring relevant variables
string choice = "";
string input = "";
double area = 0.00;

//Displaying the menu to the user 
Console.WriteLine("Geometry Calculator");
Console.WriteLine("1. Calculate the Area of a Circle");
Console.WriteLine("2. Calculate the Area of a Rectangle");
Console.WriteLine("3. Calculate the Area of a Triangle");
Console.WriteLine("4. Quit");

//Retrieving the user choice
Console.Write("Enter your choice (1-4): ");
choice = Console.ReadLine();

//Executing the respective code block based on the user choice
switch (choice)
{
    case "1":
        Console.WriteLine("\n\nArea of a Circle");
        double radius;
        Console.Write("Enter Radius: ");
        input = Console.ReadLine();
        double.TryParse(input, out radius);
        area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Area = {area.ToString("0.00")}");
        break;
    case "2":
        Console.WriteLine("\n\nArea of a Rectangle");
        double length, width;
        Console.Write("Enter Length: ");
        input = Console.ReadLine();
        double.TryParse(input, out length);
        Console.Write("Enter Width: ");
        input = Console.ReadLine();
        double.TryParse(input, out width);
        area = length * width;
        Console.WriteLine($"Area = {area.ToString("0.00")}");
        break;
    case "3":
        Console.WriteLine("\n\nArea of a Triangle");
        double triangleBase, triangleHeight;
        Console.Write("Enter Base: ");
        input = Console.ReadLine();
        double.TryParse(input, out triangleBase);
        Console.Write("Enter Height: ");
        input = Console.ReadLine();
        double.TryParse(input, out triangleHeight);
        area = (triangleBase * triangleHeight) / 2;
        Console.WriteLine($"Area = {area.ToString("0.00")}");
        break;
    case "4":
        Console.WriteLine("Quitting Program...");
        break;
    default:
        Console.WriteLine("Invalid Choice !");
        break;
}
