// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Функция создания массива
int[] RandomeArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
// Создание массива с заданными в условиях параметрами
Console.Write("Введите количество элементов в массиве: ");
int size = int.Parse(Console.ReadLine());
int[] array = RandomeArray(size, 100, 999);

// Если нужно вывести созданный массив
Console.WriteLine($"[ {String.Join(" ,", array)} ]");

// Функция счетчика четных чисел в массиве
int CountEvenElements(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0) count++;
    }
    return count;
}

// Вывод результата работы программы
Console.WriteLine($"Количество четных элементов массива равно {CountEvenElements(array)}");

// Или вот так
// int a = CountEvenElements(array);
// Console.WriteLine($"Количество четных элементов массива равно {a}");