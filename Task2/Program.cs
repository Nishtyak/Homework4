// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = EnterNumber();
int result = Sum(number);
Console.WriteLine($"{number} -> {result}");

int EnterNumber()
{
    int num = 0;
    Console.WriteLine("Введите число:");
    while(!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите число!");
    
    return num;
}

int Sum(int num) 
{
    int sum = 0;
    while(num >= 1)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}