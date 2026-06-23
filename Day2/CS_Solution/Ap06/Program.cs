for(; ; )
{
    switch(Choice())
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
    
}
void CalcTax()
{

}
void Exchange()
{

}

void DrawStar()
{

}
void CalcInterest()
{

}