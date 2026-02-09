Console.Write("Enter principal amount: ");
double p = double.Parse(Console.ReadLine());
Console.Write("Enter rate of interest: ");
double r = double.Parse(Console.ReadLine());
Console.Write("Enter time in years: ");
int t = int.Parse(Console.ReadLine());
Console.WriteLine("Simple Interest: {0:F2}", (p * r * t) / 100);
