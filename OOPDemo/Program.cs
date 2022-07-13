using OOPDemo;

/****************************************************************************/
//Working with Employee Object.
Employee employeeObject = new Employee();

employeeObject.Name = "James";
employeeObject.HourlyRate = 175.00;
employeeObject.HoursWorked = 15;

Console.WriteLine($"Name: {employeeObject.Name}");
Console.WriteLine($"Hourly Rate: {employeeObject.HourlyRate}");
Console.WriteLine($"Hours Worked: {employeeObject.HoursWorked}");
Console.WriteLine($"Gross Pay: {employeeObject.GetPay()}");



/****************************************************************************/
//Working with Rectangle Object.
Rectangle myRectangle = new Rectangle();

myRectangle.Width = 5;
myRectangle.Length = 6;

//Get area and parameter of original rectangle
Console.WriteLine("Original Rectangle");
Console.WriteLine($"Width: {myRectangle.Width}");
Console.WriteLine($"Length: {myRectangle.Length}");
Console.WriteLine($"Area: {myRectangle.GetArea()}");
Console.WriteLine($"Parameter: {myRectangle.GetParameter()}");
Console.WriteLine();

//Scaling Up Rectangle
Console.WriteLine("Englared Rectangle");
myRectangle.EnglargeByFactor(2);
Console.WriteLine($"Width: {myRectangle.Width}");
Console.WriteLine($"Length: {myRectangle.Length}");
Console.WriteLine($"Area: {myRectangle.GetArea()}");
Console.WriteLine($"Parameter: {myRectangle.GetParameter()}");
Console.WriteLine();

//Shrinking Rectangle
Console.WriteLine("Shrinking Rectangle");
myRectangle.ShrinkByFactor(3);
Console.WriteLine($"Width: {myRectangle.Width}");
Console.WriteLine($"Length: {myRectangle.Length}");
Console.WriteLine($"Area: {myRectangle.GetArea()}");
Console.WriteLine($"Parameter: {myRectangle.GetParameter()}");


//Static Methods
var areaStatic = Rectangle.GetAreaStatic(8, 5);

Console.WriteLine($"Area Static: {areaStatic}");


/*****************************************************/
//Generating Random Values
Random random = new Random();
Console.WriteLine(random.Next());