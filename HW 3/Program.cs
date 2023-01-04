using System;
using System.Text;
class Programm
{
    public static void MethodTaskOne(string a)
    {
        //Выводим слово наоборот
        for (int i = a.Length - 1; i >= 0; i--)
            Console.Write(a[i]);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите слово: ");
        var inputValue = Console.ReadLine();
        MethodTaskOne(inputValue);
    }
}