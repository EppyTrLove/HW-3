using System;
using System.Text;
using System.Text.RegularExpressions;
class Programm
{
    public static void MethodTaskSeven(string a)
    {
        a.ToCharArray();
        var list = new List<char>();
        // выводим все цифры
        for (var j = 0; j < a.Length; j++) 
            if (char.IsDigit(a[j]))
            {
                Console.Write(a[j]);
                list.Add(a[j]);
            }
        //определяем кол-во цифр
        Console.WriteLine($"\n{list.Count}");
        //получаем максимальное значение
        Console.WriteLine(list.Max());
        //определяем наибольшее количество идущих подряд цифр.
        var count = 1;
        var max = 1;
        for (var j = 0; j < list.Count - 1; j++)
            if (list[j] == list[j + 1])
                count++;
            else
                count = 1;
            if (count > max)
                 max = count;
        Console.WriteLine(max);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите текст: ");
        var input = Console.ReadLine();
        MethodTaskSeven(input);
        Console.ReadKey();
    }
}
