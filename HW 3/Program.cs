using System;
using System.Text;
class Programm
{
    public static void MethodTaskFive(string a)
    {
        //Выводим слово наоборот
        Console.WriteLine(a.Reverse().ToArray()); 
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите слово: ");
        var inputValue = Console.ReadLine();
        MethodTaskFive(inputValue);
    }
}