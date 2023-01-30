// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int num = ReadNumber();
Console.Write("Исходный массив ");
int[] array = FillArray(num);
PrintArray(array);

Console.WriteLine("Количество четных чисел в массиве " + CountEven(array));

int ReadNumber() // Метод проверки соответствия вводимого числа условиям задачи
{
    while (true)
    {
        Console.Write("Введите количество элементов массива: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            return number;
        }
        else Console.WriteLine("Не удалось распознать требуемое число, попробуйте еще раз.");
    }
}
int[] FillArray(int n) // Метод заполнения массива случайными числами
{
    int[] array = new int[n];
    Random number = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = number.Next(100, 1000); // [100, 1000)
    }
    return array;
}
int CountEven(int[] arr) // Метод поиска четных чисел
{
    int countEven = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            countEven++;
        }
    }
    return countEven;
}
void PrintArray(int[] array) // Метод вывода массива в консоль
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}