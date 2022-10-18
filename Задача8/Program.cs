Console.Clear();
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int count=0;
int i = 1;

while (count<n)
{
    if(i %2 == 0)
    {
        Console.Write(i);
        Console.Write(",");
    }
    i+=1;
    count+=1;
}
