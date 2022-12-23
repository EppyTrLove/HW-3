using System;
using ConsoleTables;
using System.IO;

class Programm {
    public static void Main(string[] args)
    {
            var table = new ConsoleTable("Word name", "How many times this word we met in text", "What percentage of this word started sentences");
    StreamReader sr = new StreamReader("C:\\Solvery\\Text.txt");
    while (sr.ReadLine() != null)
    {
        Console.WriteLine(sr.ReadLine());
        char[] delimiterChars = { ' ', ',', '-', ':', '.', ';', '\t' };
        var arr = sr.ReadLine().ToLower().Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
        var dict = new Dictionary<string, int>();
        foreach (var item in arr)
            if (dict.ContainsKey(item) && item.Length > 2)
                dict[item]++;
            else dict.Add(item, 1);
        foreach (KeyValuePair<string, int> kv in dict)
            table.AddRow(kv.Key, kv.Value.ToString(), "%");
        table.Write();
        Console.ReadKey();
    }
    table.Write();
    Console.ReadKey();
    }


    /*var rows = Enumerable.Repeat(new Something(), 10);

    ConsoleTable
        .From<Something>(rows)
        .Configure(o => o.NumberAlignment = Alignment.Right)
        .Write(Format.Alternative);

    Console.ReadKey();*/
}
 

    
