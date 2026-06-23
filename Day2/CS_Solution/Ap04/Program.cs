SayHello();
SayHello();
SayHello();

Console.WriteLine(AddNumber(10, 20));
Console.WriteLine(AddNumber(50, 60));

void SayHello()
{
    Console.WriteLine("Hello");
    //return;
}

int AddNumber(int a, int b)
{
    Console.WriteLine($"a={a}, b={b}");
    return a + b;
}

