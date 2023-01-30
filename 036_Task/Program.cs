// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int num = ReadNumber();
Console.Write("Исходный массив ");
int[] array = FillArray(num);
PrintArray(array);

Console.WriteLine("Сумма элементов на нечетных позициях в массиве равна " + SumOdd(array));

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
        array[i] = number.Next(-100, 101); // [-100, 101)
    }
    return array;
}
int SumOdd(int[] arr) // Метод поиска четных чисел
{
    int sumOddPlaces = 0;
    for (int i = 1; i < arr.Length; i += 2) // Начинаем с нечетной позиции i=1, идем с шагом +2
    {
        sumOddPlaces += arr[i];
    }
    return sumOddPlaces;
}
void PrintArray(int[] array) // Метод вывода массива в консоль
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}