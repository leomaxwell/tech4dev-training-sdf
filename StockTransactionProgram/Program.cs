//Setting fixed variable values
int totalShares = 100;
double sharePurchasePrice = 32.87;
double commissionPercentage = 0.02;
double shareSalePrice = 33.92;

//Performing calculations
double sharePurchaseAmount = totalShares * sharePurchasePrice;
double purchaseCommission = sharePurchaseAmount * commissionPercentage;

double shareSaleAmount = totalShares * shareSalePrice;
double saleCommission = shareSaleAmount * commissionPercentage;
double totalAmountInvested = sharePurchaseAmount + purchaseCommission;
double netEarnings = shareSaleAmount - saleCommission;
double profileLoss = netEarnings - totalAmountInvested;

//Preparing program output
Console.WriteLine("Stock Transaction Program");
Console.WriteLine("Customer: Joe Peters");
Console.WriteLine("---------------------------------");
Console.WriteLine("Details:");
Console.WriteLine("Share Purchase Price:\t" + sharePurchasePrice.ToString("C"));
Console.WriteLine("Share Sale Price:\t" + shareSalePrice.ToString("C"));
Console.WriteLine("Broker Commission (2%):\t" + commissionPercentage);
Console.WriteLine("Total Shares:\t\t" + totalShares);

Console.WriteLine();
Console.WriteLine("Investment:");
Console.WriteLine("Share:\t\t\t" + sharePurchaseAmount.ToString("C"));
Console.WriteLine("Broker Commission (2%):\t+  " + purchaseCommission.ToString("C"));
Console.WriteLine("---------------------------------");
Console.WriteLine("Total:\t\t\t" + totalAmountInvested.ToString("C"));

Console.WriteLine();
Console.WriteLine("Earnings:");
Console.WriteLine("Share:\t\t\t" + shareSaleAmount.ToString("C"));
Console.WriteLine("Broker Commission (2%):\t-  " + saleCommission.ToString("C"));
Console.WriteLine("---------------------------------");
Console.WriteLine("Net:\t\t\t" + netEarnings.ToString("C"));

Console.WriteLine();
Console.WriteLine("Profit / Loss:");
Console.WriteLine("Net Earnings:\t\t" + netEarnings.ToString("C"));
Console.WriteLine("Amt Invested:\t       -" + totalAmountInvested.ToString("C"));
Console.WriteLine("---------------------------------");
Console.WriteLine("\t\t\t " + profileLoss.ToString("C"));