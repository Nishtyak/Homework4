// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int a = EnterNumber("Введите число A: ");
int b = EnterNumber("Введите число B: ");
double aPowerb = Power(a, b);
Console.WriteLine($"{a}, {b} -> {aPowerb}");

int EnterNumber(string message)
{
    int num = 0;
    Console.WriteLine(message);
    while(!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите число!");
    return num;
}

double Power (int a, int b)
{
    double result = Math.Pow(a, b);
    return result;
}

