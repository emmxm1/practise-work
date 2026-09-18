string s = Console.ReadLine().Trim();
int dotIndex = s.IndexOf('.');
int d1 = s[dotIndex + 1] - '0';
int d2 = s[dotIndex + 2] - '0';
Console.WriteLine(d1 + d2);
