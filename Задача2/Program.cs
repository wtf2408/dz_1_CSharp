Console.Clear();
Console.Write("Введите два числа:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB>numberA)
{
    Console.Write(numberB);
    Console.Write(" = max");
}

if (numberA == numberB)
{
    Console.Write("наибольшего  числа нет");
    
}
if (numberA>numberB)
{
    Console.Write(numberB);
     Console.Write(" = max");
}

