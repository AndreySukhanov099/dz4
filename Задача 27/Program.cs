// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
int Sum =0;
A = Math.Abs(A);
while (A > 9)
    {
    Sum = Sum + A %10;
    A = A/10;
    }
Console.WriteLine(Sum+A%10);