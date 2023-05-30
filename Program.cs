// Задача 64. Задайте значение N. Напишите программу, Которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N=5 -> '5,4,3,2,1'
// N=8 -> '8,7,6,5,4,3,2,1'

// ввод числа 
int Promt (string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse (ReadInput);
    return result;
}

// вывод чисел без рекурсии для проверки
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i=b; i >=a; i--)
    {
        result += $"{i} ";
    }
    return result;
}

// вывод чисел с рекурсией
string NumbersRec(int a, int b)
{
    if (a<=b) return NumbersRec(a+1, b)+$"{a} ";
    else return String.Empty;
}

int n = Promt("Введите число N  :");
Console.WriteLine("Числа полученные без рекурсии");
Console.WriteLine(NumbersFor(1,n));
Console.WriteLine("Числа полученные с рекурсией");
Console.WriteLine(NumbersRec(1,n));


