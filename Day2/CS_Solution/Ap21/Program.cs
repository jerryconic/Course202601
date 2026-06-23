StreamWriter wr = new StreamWriter(@"C:\temp\test.txt");
for(int i = 0; i<10; i++)
    wr.WriteLine($"Hello {i}");
wr.Close();
Console.WriteLine("Write File Complete");