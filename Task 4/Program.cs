using System;
using ConsoleTables;
using System.IO;

class Programm {
    public static void Main(string[] args)
    {
    var table = new ConsoleTable("Word name", "How many times this word we met in text", 
                "What percentage of this word started sentences");
    var sr = File.ReadAllText(@"C:\Solvery\Text.txt");
        string line;
        do
        {
            Console.WriteLine(sr);
            char[] delimiterChars = { ' ', ',', '-', ':', '.', ';', '\t' };
            var arr = sr.ToLower().Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            var dict = new Dictionary<string, int>();
            foreach (var item in arr)
                if (dict.ContainsKey(item) && item.Length > 2)
                    dict[item]++;
                else dict.Add(item, 1);
            foreach (var kv in dict)
                table.AddRow(kv.Key, kv.Value.ToString(), "%");
            table.Write();
            Console.ReadKey();
        }        
        while (sr != null);
    }
}
 

    
