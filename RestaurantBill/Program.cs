//Initialize Variables
double mealCost = 44.50, taxRate = 0.0675, tipRate = 0.15;

//Defining relevant variables
double taxAmount, subTotal, tipAmount, totalBill;

//Performing Calculations
taxAmount = (mealCost * taxRate);
subTotal = (mealCost + taxAmount);
tipAmount = (subTotal * tipRate);
totalBill = (mealCost + taxAmount + tipAmount);

//Displaying the Result
Console.WriteLine("Restaurant Bill");
Console.WriteLine("----------------------------");
Console.WriteLine("Meal Cost   ......... " + mealCost.ToString("C"));
Console.WriteLine("Tax (6.75%) .........  " + taxAmount.ToString("C"));
Console.WriteLine("                      ------");
Console.WriteLine("Sub-Total ........... " + subTotal.ToString("C"));
Console.WriteLine("Tip (15%) ...........  " + tipAmount.ToString("C"));
Console.WriteLine("----------------------------");
Console.WriteLine("Total                 " + totalBill.ToString("C"));