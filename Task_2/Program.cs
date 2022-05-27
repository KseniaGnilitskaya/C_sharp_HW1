Console.WriteLine("Enter the first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (b > a) max = b;
if (c > a) max = c;

Console.Write("Max number is ");
Console.Write(max);
