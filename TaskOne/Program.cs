Console.Write("Enter your first number: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your second number: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (Num1 < Num2)

{
    max = Num2;
    Console.WriteLine("Большее число: " + max);
}
else if (Num1 == Num2)
{
    Console.Write("Числа равны.");
}
else
{
    max = Num1;
   Console.WriteLine("Большее число: " + Num1);
}