for(; ; )
{
    Roll();
    Console.Write("Press any key to continue...");
    Console.ReadKey();
    Console.WriteLine();
}



void Roll()
{

    Random rnd = new Random();
    int[] dices = new int[4];
    //產生四個1 - 6的亂數
    for (int i = 0; i < 4; i++)
        dices[i] = rnd.Next(1, 7);

    //將陣列排序
    Array.Sort(dices);

    //由小至大顯示骰子的點數
    for (int i = 0; i < dices.Length; i++)
        Console.Write("{0} ", dices[i]);
    Console.WriteLine();

    if (dices[0] == dices[3])
        Console.WriteLine("一色");
    else if (dices[0] == dices[2] || dices[1] == dices[3])
        Console.WriteLine("沒點重擲");
    else if (dices[0] == dices[1])
        Console.WriteLine("{0}點", dices[2] + dices[3]);
    else if (dices[1] == dices[2])
        Console.WriteLine("{0}點", dices[0] + dices[3]);
    else if (dices[2] == dices[3])
        Console.WriteLine("{0}點", dices[0] + dices[1]);
    else
        Console.WriteLine("沒點重擲");


}
