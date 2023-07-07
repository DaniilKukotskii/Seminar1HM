Console.WriteLine("Input your number: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your number: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your number: ");
int Num3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (Num2 > Num1)
{
    max = Num2;
}
if (Num3 > max)
{
    max = Num3;
}
Console.WriteLine("Самое большое число: " + max);