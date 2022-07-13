//Initializing variables
double purchasePrice = 52.00;
double stateTaxRate = 0.04;
double countyTaxRate = 0.02;

//Defining Variables
double totalAmount;
double stateTaxAmount;
double countyTaxAmount;

//Calculating relevant values
stateTaxAmount = purchasePrice * stateTaxRate;
countyTaxAmount = purchasePrice * countyTaxRate;
totalAmount = purchasePrice + stateTaxAmount + countyTaxAmount;

//Display the Results
Console.WriteLine("Receipt");
Console.WriteLine("--------------------------------");
Console.WriteLine("Purchase Price  ......... $" + purchasePrice.ToString("0.00"));
Console.WriteLine("State Tax (4%)  ......... $ " + stateTaxAmount);
Console.WriteLine("County Tax (2%) ......... $ " + countyTaxAmount);
Console.WriteLine("--------------------------------");
Console.WriteLine("Total                     $" + totalAmount);
