StreamReader rd = new StreamReader(@"C:\temp\test.txt");
string s = rd.ReadToEnd();
rd.Close();
Console.WriteLine(s);