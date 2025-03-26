// See https://aka.ms/new-console-template for more information
Console.WriteLine("Clerentin le GOAT (ses amphis me manquent deja T_T )");
Console.WriteLine("Message de bienvenue");
int sum (int a, int b)
{
 int sum = a + b;
    return sum;
}

bool test (int a, int b)
{
    return (a >=b)? true:false;
}

int oppo (int a)
{
    int res = a - (2 * a);
    return res;
}

int res = sum(2 ,3);
Console.WriteLine($"La somme de 2 et 3 est : {res} ");

bool testv = test(6, 3);

Console.WriteLine($"It's {testv}");

int oppov = oppo(-7);

Console.WriteLine($"Le res est inverse de 7 est {oppov}");