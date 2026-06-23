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

do
{
    Console.Write("b=");
    s = Console.ReadLine();
    iscorrect = int.TryParse(s, out b);
    if (!iscorrect) Console.WriteLine("b必須是整數");
} while (!iscorrect);

Console.WriteLine($"{a} + {b} = {a + b}");

