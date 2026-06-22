string? s; 
int a, b; 

//輸入 a
Console.Write("a="); 
s = Console.ReadLine(); 
a = int.Parse(s); 

//輸入 b
Console.Write("b="); 
s = Console.ReadLine(); 
b = int.Parse(s); 

//計算 a +b 的結果
Console.WriteLine($"{a} + {b} = {a + b}");

Console.ReadLine();