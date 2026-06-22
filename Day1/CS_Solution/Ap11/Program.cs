string s;
int income, tax;

Console.Write("年戶得收入:");
s = Console.ReadLine();
income = int.Parse(s);

if (income <= 590000)
    tax = (int)(income * 0.05 + 0.5);
else if(income <=1330000)
    tax = (int)(income * 0.12  - 41300 + 0.5);
else if(income <= 2660000)
    tax = (int)(income * 0.2 - 147700 + 0.5);
else if (income <= 4980000)
    tax = (int)(income * 0.3 - 413700 + 0.5);
else 
    tax = (int)(income * 0.4 - 911700 + 0.5);

Console.WriteLine($"年所得收入:{income:#,##0}, 應納所得稅:{tax:#,##0}");