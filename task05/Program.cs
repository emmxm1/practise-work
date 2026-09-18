using System.Globalization;

double lenght = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = lenght * width;
Console.WriteLine(area);
