#nullable disable

string input;
double fahrenheit, celsius;

Console.WriteLine("Celsius to Fahrenheit Converter");
Console.Write("Input Celcius: ");

//Collecting the degree in celsius from the user
input = Console.ReadLine();
double.TryParse(input, out celsius);

//Calculating the degree in fahrenheit
fahrenheit = ((9.0 / 7.0) * celsius) + 32.0;

//Displaying the degree in fahrenheit
Console.WriteLine("Fahrenheit = " + fahrenheit.ToString("0.0"));