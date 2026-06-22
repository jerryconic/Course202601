string s, curr;
int nt;
decimal amt;

Console.Write("台幣:");
s = Console.ReadLine();
nt = int.Parse(s);

Console.Write("幣別(U=USD/J=JPY/E=EUR):");
curr = Console.ReadLine();

switch(curr)
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