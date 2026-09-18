using System.Globalization;

double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double f = c * 9 / 5 + 32;
Console.WriteLine(f);

