Random rnd = new Random(); 
int ans, guess; 
//產生1 – 99的亂數ans
ans = rnd.Next(1, 100);
Console.WriteLine(ans);


do 
{ 
    string s; 
    Console.Write("猜數字(1-99):"); 
    s = Console.ReadLine(); 
    guess = int.Parse(s);

    if (guess == -1)
    {
        Console.WriteLine($"The answer is {ans}");
        break;
    }
    if(guess < 0 || guess > 99)
    {
        Console.WriteLine("1-99");
        continue;
    }
    if(guess < ans) 
        Console.WriteLine("高一點"); 
    else if(guess > ans) 
        Console.WriteLine("低一點"); 
    else Console.WriteLine("猜對了"); 
} while (ans!=guess);