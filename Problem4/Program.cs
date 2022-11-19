Console.Clear();

Console.Write("Enter 1st number: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter 2nd number: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Enter 3rd number: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine("max = " + max);