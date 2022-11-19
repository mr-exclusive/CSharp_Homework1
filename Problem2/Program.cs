Console.Clear();

Console.Write("Enter 1st number: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter 2nd number: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max = " + a);
}
else if (a < b)
{
    Console.WriteLine("max = " + b);
}
else
{
     Console.WriteLine("They are equal!");
}