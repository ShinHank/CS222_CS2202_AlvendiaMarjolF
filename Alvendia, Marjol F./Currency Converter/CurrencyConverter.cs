Console.Write("Enter amount in USD: ");
double usd = double.Parse(Console.ReadLine());
Console.Write("Enter exchange rate from USD to EUR: ");
double er = double.Parse(Console.ReadLine());

Console.WriteLine("Simple Interest: {0:F2}", usd*er);
