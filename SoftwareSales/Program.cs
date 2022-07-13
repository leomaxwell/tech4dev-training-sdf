#nullable disable

//Defining necessary variables
double retailPrice = 99.00;
int unitsPurchased = 0;
double grossTotal = 0.00;
double discountPercent = 0.00;
double discountAmount = 0.00;
double netTotal = 0.00;

string input = "";

//Collecting Units Purchase from the user.
Console.WriteLine("Mercy Software");
Console.WriteLine("-----------------------------------------");
Console.Write("Enter number of packages purchased: ");

input = Console.ReadLine();
int.TryParse(input, out unitsPurchased);


//Input validation: Units must not be less than 0
if (unitsPurchased < 0)
{
    Console.WriteLine("Input Invalid: Quantity cannot be less than 0.");
    return;
}

//Determine Discount Percent based on Units Purchased
if (unitsPurchased >= 10 && unitsPurchased <= 19)
{
    discountPercent = 20;
}
else if (unitsPurchased >= 20 && unitsPurchased <= 49)
{
    discountPercent = 30;
}
else if (unitsPurchased >= 50 && unitsPurchased <= 99)
{
    discountPercent = 40;
}
else if (unitsPurchased >= 100)
{
    discountPercent = 50;
}

//Calculate the Gross Total
grossTotal = retailPrice * unitsPurchased;

//Calculate the Discount Amount
discountAmount = (grossTotal * discountPercent) / 100;

//Calculate the Net Total
netTotal = grossTotal - discountAmount;


Console.WriteLine();
Console.WriteLine("Purchase Details");
Console.WriteLine("----------------------------------------");
Console.WriteLine("Item\t\t Price \t Qty. \t Amount");

Console.WriteLine($"Software Package {retailPrice} \t {unitsPurchased} \t {grossTotal.ToString("0.00")}");
Console.WriteLine($"Discount ({discountPercent}%) \t\t\t- {discountAmount.ToString("0.00")}");
Console.WriteLine("----------------------------------------");
Console.WriteLine($"Total \t\t\t\t {netTotal.ToString("0.00")}");