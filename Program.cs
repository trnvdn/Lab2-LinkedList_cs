using System;

namespace Lab2LinkedList;

internal class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        LinkedList list = new LinkedList();
        list.Insert(1);
        list.Insert(2);
        list.Insert(-3);
        list.Insert(4);
        list.Insert(-4);
        list.Insert(4);
        list.Insert(-4);
        list.Insert(4);
        list.Insert(-5);
        list.Insert(6);
        list.Insert(-7);
        list.Print();
        ///////////////////
        Console.WriteLine("Вставлення елементу після введеного індексу");
        list.AddAfter(20,100);
        list.Print();
        Console.WriteLine("Видаленя усіх парних чисел");
        list.RemoveAllEvenNumbers();
        list.Print();
        Console.WriteLine("Видаленя останнього числа");
        list.RemoveLast();
        list.Print();
        Console.WriteLine("Сума додатніх чисел");
        list.SumOfPositiveNums();
        Console.WriteLine("перевизначення оператора /");
        list.Print();
        list = list / 2;
        list.Print();
        Console.WriteLine("перевизначення оператора +");
        list.Print();
        list = list + 10;
        list.Print();
        Console.WriteLine("Створення копії списку");
        LinkedList copy = new LinkedList();
        copy.GetHead(new Node(list.ReturnHead()));
        copy.Print();
        Console.WriteLine(copy.Second);
        Console.WriteLine(copy.Second = 2000);
        copy.Print();
    }
}