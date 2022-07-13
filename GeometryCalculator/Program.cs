#nullable disable

//Declaring relevant variables
string choice = "";
string input = "";

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
if (choice == "1")
{
    //AREA OF A CIRCLE
    Console.WriteLine("\n\nArea of a Circle");

    //Defining relevant variables
    double radius, area;

    //Collect the radius from the user.
    Console.Write("Enter Radius: ");
    input = Console.ReadLine();
    double.TryParse(input, out radius);

    //Calculating the Area
    area = Math.PI * Math.Pow(radius, 2);

    //Displaying the Area
    Console.WriteLine($"Area = {area.ToString("0.00")}");
}
else if (choice == "2")
{
    //AREA OF A RECTANGLE
    Console.WriteLine("\n\nArea of a Rectangle");

    //Defining relevant variables
    double length, width, area;

    //Collect the length and width from the user.
    Console.Write("Enter Length: ");
    input = Console.ReadLine();
    double.TryParse(input, out length);

    Console.Write("Enter Width: ");
    input = Console.ReadLine();
    double.TryParse(input, out width);

    //Calculating the Area
    area = length * width;

    //Displaying the Area
    Console.WriteLine($"Area = {area.ToString("0.00")}");
}
else if (choice == "3")
{
    //AREA OF A TRIANGLE
    Console.WriteLine("\n\nArea of a Triangle");

    //Defining relevant variables
    double triangleBase, triangleHeight, triangleArea;

    //Collecting the base and height from the user
    Console.Write("Enter Base: ");
    input = Console.ReadLine();
    double.TryParse(input, out triangleBase);

    Console.Write("Enter Height: ");
    input = Console.ReadLine();
    double.TryParse(input, out triangleHeight);

    triangleArea = (triangleBase * triangleHeight) / 2;

    Console.WriteLine($"Area = {triangleArea.ToString("0.00")}");
}
else if (choice == "4")
{
    Console.WriteLine("Quitting Program...");
}
else
{
    Console.WriteLine("Invalid Choice !");
}