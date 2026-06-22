string? s;
int score;

Console.Write("Score:");
s = Console.ReadLine();
score = int.Parse(s);

if(score < 60)
    Console.WriteLine("不及格");
else
    Console.WriteLine("及格");