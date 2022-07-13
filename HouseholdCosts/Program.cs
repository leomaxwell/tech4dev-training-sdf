#nullable disable

string input;
double rent, phone, internet, television, electricity, water;
double totalMonthlyExpense, totalAnnualExpense;

Console.WriteLine("Household Expense Calculator.");
Console.WriteLine("Enter the cost of the following monthly expeses:");

//Collecting the Rent expense
Console.Write("Rent: \t\t");
input = Console.ReadLine();
double.TryParse(input, out rent);

//Collecting the Phone expense
Console.Write("Phone: \t\t");
input = Console.ReadLine();
double.TryParse(input, out phone);

//Collecting the Internet expense
Console.Write("Internet: \t");
input = Console.ReadLine();
double.TryParse(input, out internet);

//Collecting the Television expense
Console.Write("Television: \t");
input = Console.ReadLine();
double.TryParse(input, out television);

//Collecting the Electicity expense
Console.Write("Electricity: \t");
input = Console.ReadLine();
double.TryParse(input, out electricity);

//Collecting the Water expense
Console.Write("Water: \t\t");
input = Console.ReadLine();
double.TryParse(input, out water);


//Calculating Total Monthly Expense
totalMonthlyExpense = rent + phone + internet + television + electricity + water;

//Calculating Total Annual Expense
totalAnnualExpense = totalMonthlyExpense * 12;

Console.WriteLine();
Console.WriteLine("Monthly Household Expenses");
Console.WriteLine("..........................");
Console.WriteLine("Detail            Amount($)");
Console.WriteLine("1. Rent .......... " + rent.ToString("0.00"));
Console.WriteLine("2. Phone ......... " + phone.ToString("0.00"));
Console.WriteLine("3. Internet ...... " + internet.ToString("0.00"));
Console.WriteLine("4. Television .... " + television.ToString("0.00"));
Console.WriteLine("5. Eletricity .... " + electricity.ToString("0.00"));
Console.WriteLine("6. Water ......... " + water.ToString("0.00"));
Console.WriteLine("---------------------------");
Console.WriteLine("Total  ........... " + totalMonthlyExpense.ToString("0.00"));
Console.WriteLine("Total Annul ...... " + totalAnnualExpense.ToString("0.00"));