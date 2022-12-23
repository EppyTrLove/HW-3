using System;
class Programm
{
    public static void MethodTaskEleven(int a)
    {
        string[] odin = new string[20] {"", "один", "два", "три", "четыре", "пять", "шесть",
            "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать",
            "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать","девятнадцать"};
        string[] desat = new string[10] {"", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят",
            "семьдесят", "восемьдесят", "девяносто"};
        string[] sotni = new string[10] {"", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот",
            "семьсот", "восемьсот", "девятьсот"}; 
        var e = a % 100;
        var b = a % 10;
        var d = a / 10 % 10;
        var c = a / 100;
        string result;
        if (a == 0)
            result = "ноль";
        else if (a == 1000)
            result = "тысяча";
        else
        {
            if (e < 20)
                result = sotni[c] + " " + odin[e];
            else
                result = sotni[c] + " " + desat[d] + " " + odin[b];
        }
        Console.WriteLine(result);
        Console.ReadKey();
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        var input1 = int.Parse(Console.ReadLine());
        MethodTaskEleven(input1);
        Console.ReadKey();
    }
}


