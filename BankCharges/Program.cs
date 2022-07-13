//Declaring variables
double fixedMonthlyFee = 10.00;
int totalChecksIssued = 0;
double feePerCheck = 0.00;
double totalCheckFee = 0.00;
double totalCharge = 0.00;

string input = "";

//Displaying prompt
Console.WriteLine("Mercy Bank");
Console.WriteLine("------------------------------");
Console.Write("Enter total checks issued:");

//Collecting data from user
input = Console.ReadLine();

int.TryParse(input, out totalChecksIssued);

/*Determining the fee per check 
  based on total checks issued */
if (totalChecksIssued < 20)
{
    feePerCheck = 0.10;
}
else if (totalChecksIssued < 40)
{
    feePerCheck = 0.08;
}
else if (totalChecksIssued < 60)
{
    feePerCheck = 0.06;
}
else
{
    feePerCheck = 0.04;
}

//Calculating the total check fee
totalCheckFee = totalChecksIssued * feePerCheck;

//Calculating the total charge
totalCharge = fixedMonthlyFee + totalCheckFee;
Console.WriteLine();
Console.WriteLine("Fixed Monthly Charge = " + fixedMonthlyFee.ToString("0.00"));
Console.WriteLine("Check Processing Fee =  " + totalCheckFee.ToString("0.00"));
Console.WriteLine("\t\t       ------");
Console.WriteLine("Total Charge\t =     " + totalCharge.ToString("0.00"));