Console.Write("Type the number: ");
int number = int.Parse(Console.ReadLine());

int m =1;
for (int i= m; i <= number; i++)
if (i % 2 == 0){
    Console.Write(i);
}