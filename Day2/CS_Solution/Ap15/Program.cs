string s;
int a, b;
bool iscorrect;

do
{
    Console.Write("a=");
    s = Console.ReadLine();
    iscorrect = int.TryParse(s, out a );
    if(!iscorrect) Console.WriteLine("a必須是整數");
} while (!iscorrect);
Console.Write("b=");
s = Console.ReadLine();
b = int.Parse(s);

Console.WriteLine($"{a} + {b} = {a + b}");

