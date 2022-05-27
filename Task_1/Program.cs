Console.WriteLine("Type the first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Type the second number: ");
int b = int.Parse(Console.ReadLine());

if (a > b){
    Console.Write("Max number is ");
    Console.Write(a);
} 
else{
    Console.Write("Max number is ");
    Console.Write(b);
}