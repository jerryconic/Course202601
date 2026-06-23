string s;
int score;

Console.Write("Score:");
s = Console.ReadLine();
score = int.Parse(s);

Console.WriteLine(score < 60 ? "不及格" : "及格");
Console.WriteLine(score < 60 ? "C-Class" : score < 80 ? "B-Class" : "A-Class");
