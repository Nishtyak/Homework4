// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int count = 8;
int min = EnterNumber("Введите минимальное число: ");
int max = EnterNumber("Введите максимальное число: ") + 1;
int[] array = CreateArray();
PrintArray(array);


int[] CreateArray()
{
    int[] arr = new int[count]; 
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

int EnterNumber(string message)
{
    int num = 0;
    Console.WriteLine(message);
    while(!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите число!");
    return num;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[count - 1]}]");
}