// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int sum (int a, int b)
{
 int sum = a + b;
    return sum;
}

bool test (int a, int b)
{
    return (a >=b)? true:false;
}

int res = sum(2 ,3);
Console.WriteLine($"Le résultat est : {res} ");

bool testv = test(6, 3);

Console.WriteLine($"It's {testv}");