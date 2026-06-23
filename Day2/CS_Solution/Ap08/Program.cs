/*
int[] ar = new int[5];
ar[0] = 17;
ar[1] = 31;
ar[2] = 42;
ar[3] = 21;
ar[4] = 5;

Array.Sort(ar);

int totall = 0;
for (int i = 0; i < ar.Length; i++)
{
    totall += ar[i];
    Console.WriteLine(ar[i]);
}
Console.WriteLine($"Total={totall}");
*/

int[] ar = { 17, 31, 42, 21, 5 };
int total = 0;

Array.Sort(ar);

foreach(int n in ar)
{
    total += n;
    Console.WriteLine(n);
}
Console.WriteLine($"Total={total}");