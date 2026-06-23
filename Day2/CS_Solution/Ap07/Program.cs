for (; ; )
{
    switch (Choice())
    {
        case "1":
            CalcScore();
            break;
        case "2":
            CalcTax();
            break;
        case "3":
            Exchange();
            break;
        case "4":
            DrawStar();
            break;
        case "5":
            CalcInterest();
            break;
        case "0":
            Console.WriteLine("bye.");
            return;
    }
    Console.Write("Press any key to continue...");
    Console.ReadKey();
}
string Choice()
{
    Console.Write(@"
1.成績計算
2.計算所得稅
3.匯率換算
4.畫星星
5.計算利息
0.離開
請選擇(0-5):");
    return Console.ReadLine();
}

void CalcScore()
{
    string? s;
    int score;

    Console.Write("Score:");
    s = Console.ReadLine();
    score = int.Parse(s);

    if (score < 60)
        Console.WriteLine("C-Class");
    else if (score < 80)
        Console.WriteLine("B-Class");
    else
        Console.WriteLine("A-Class");
}
void CalcTax()
{
    string s;
    int income, tax;

    Console.Write("年戶得收入:");
    s = Console.ReadLine();
    income = int.Parse(s);

    if (income <= 590000)
        tax = (int)(income * 0.05 + 0.5);
    else if (income <= 1330000)
        tax = (int)(income * 0.12 - 41300 + 0.5);
    else if (income <= 2660000)
        tax = (int)(income * 0.2 - 147700 + 0.5);
    else if (income <= 4980000)
        tax = (int)(income * 0.3 - 413700 + 0.5);
    else
        tax = (int)(income * 0.4 - 911700 + 0.5);

    Console.WriteLine($"年所得收入:{income:#,##0}, 應納所得稅:{tax:#,##0}");
}
void Exchange()
{
    string s, curr;
    int nt;
    decimal amt;

    Console.Write("台幣:");
    s = Console.ReadLine();
    nt = int.Parse(s);

    Console.Write("幣別(U=USD/J=JPY/E=EUR):");
    curr = Console.ReadLine();

    switch (curr)
    {
        case "U":
        case "u":
            amt = nt / 31.53M;
            break;
        case "J":
        case "j":
            amt = nt / 0.191M;
            break;
        case "E":
        case "e":
            amt = nt / 36M;
            break;
        default:
            amt = 0;
            break;
    }
    Console.WriteLine($"台幣:{nt:#,##0}, 可兌換外幣:{amt:#,##0.00}");
}

void DrawStar()
{
    string s;
    int n;

    Console.Write("n=");
    s = Console.ReadLine();
    n = int.Parse(s);

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
            Console.Write("*");
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int i = n; i >= 1; i--)
    {
        for (int j = 1; j <= i; j++)
            Console.Write("*");
        Console.WriteLine();
    }

    Console.WriteLine();

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n - i; j++)
            Console.Write(" ");
        for (int j = 1; j <= 2 * i - 1; j++)
            Console.Write("*");
        Console.WriteLine();
    }

}
void CalcInterest()
{
    string s;
    int principal, n;
    double rate;

    //輸入本金
    Console.Write("本金=");
    s = Console.ReadLine();
    principal = int.Parse(s);

    //輸入利率(%)
    Console.Write("利率(%)=");
    s = Console.ReadLine();
    rate = double.Parse(s);

    //輸入期數
    Console.Write("期數=");
    s = Console.ReadLine();
    n = int.Parse(s);

    Console.WriteLine("期數  本      金  利      息  合      計");
    Console.WriteLine("====  ==========  ==========  ==========");
    for (int i = 1; i <= n; i++)
    {
        int interest = (int)(principal * rate / 100 + 0.5);
        Console.WriteLine("{0,4}{1,12:#,##0}{2,12:#,##0}{3,12:#,##0}",
            i, principal, interest, principal + interest);
        principal += interest;
    }
    Console.WriteLine("====  ==========  ==========  ==========");

}