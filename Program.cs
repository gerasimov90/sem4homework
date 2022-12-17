/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.

int GetExp(int A, int B)
{
    int exponenta = 1;
    for (int i = 1; i <= B; i++)
    {
        exponenta = exponenta * A;
    }
    return exponenta;
}

Console.Write("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine()); // Идем от 1 до N: [1;N]
Console.Write("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число А в степени В: " + GetExp(a,b));
*/

/*
Задача 27: Напишите программу, которая принимает
на вход число и выдаёт сумму цифр в числе.


int GetSum(int A) 
{
    int sum = 0;

    while (A > 0)
    {
        int digit = A%10;
        sum = sum + digit;
        A = A / 10;
    }
    return sum;
}
Console.WriteLine("Введите число A: ");
int N = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Сумма чисел, составляющих число А: " + GetSum(N));
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8
элементов и выводит их на экран.
*/

int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }

    return array;
}
var str = string.Join(", ", GetArray());
Console.WriteLine("[" + str + "]");