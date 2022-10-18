Console.Clear();
Console.Write("Введите два числа:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA>numberB)
{
    Console.Write(numberA);
    Console.Write(" = max");
}
if (numberB>numberA)
{
    Console.Write(numberB);
    Console.Write(" = max");
}