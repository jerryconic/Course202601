/*

short a = 10000; //2 bytes
int b; //4 bytes
b = a;
Console.WriteLine($"a={a}, b={b}");

*/


int a = 1000000; //4 bytes
short b; //2 bytes
b = (short)a;
Console.WriteLine($"a={a}, b={b}");
Console.WriteLine($"a={a:x}, b={b:x}");