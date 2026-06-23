Random rnd = new Random();
int ans, guess, min=1, max = 99;
//產生1 – 99的亂數ans
ans = rnd.Next(1, 100);
//Console.WriteLine(ans);


do
{
    string s;
    Console.Write($"猜數字({min}-{max}):");
    s = Console.ReadLine();
    guess = int.Parse(s);

    if (guess == -1)
    {
        Console.WriteLine($"The answer is {ans}");
        break;
    }
    if (guess < min || guess > max)
    {
        Console.WriteLine("超出範圍");
        continue;
    }
    if (guess < ans)
        min = guess + 1;
    else if (guess > ans)
        max = guess - 1;
    else Console.WriteLine("猜對了");
} while (ans != guess);