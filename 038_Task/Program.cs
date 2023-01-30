// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int num = ReadNumber();
Console.Write("Исходный массив ");
double[] array = FillArray(num);
PrintArray(array);
SubtractionMaxMin(array);

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
double[] FillArray(int n) // Метод заполнения массива случайными вещественными числами
{
    double[] array = new double[n];
    Random number = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(number.NextDouble() * 100); // Приведение вещественного числа к целому виду
    }
    return array;
}
void SubtractionMaxMin(double[] arr) // Метод поиска экстремальных чисел и нахождение их разности
{
    double maxNumber = arr[0];
    double minNumber = arr[1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNumber) minNumber = arr[i];
        if (arr[i] > maxNumber) maxNumber = arr[i];
    }

    Console.WriteLine($"Разница между максимальным {maxNumber} и минимальным значением {minNumber} в массиве равна {maxNumber - minNumber}");
}
void PrintArray(double[] array) // Метод вывода массива в консоль
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}