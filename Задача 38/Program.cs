// Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Функция создания массива
// Ограничения по максимальному и минимальному элементу введены только для того, чтобы было легче проверить
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
Console.Write("Введите значение допустимого минимального элемента массива: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите значение допустимого максимального элемента массива: ");
int maxValue = int.Parse(Console.ReadLine());
int[] array = RandomeArray(size, minValue, maxValue);

// Если нужно вывести созданный массив
Console.WriteLine($"[ {String.Join(" ,", array)} ]");

// Функция нахождения разности между максимальным и минимальным элементом массива
int DifMaxMinElements(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) { min = array[i]; }
        if (array[i] > max) { max = array[i]; }

    }
    int result = max - min;
    return result;
}

// Вывод результата работы программы
Console.WriteLine($"Разность между максимальным и минимальным элементом массива равна {DifMaxMinElements(array)}");

// Или вот так
// int res = DifMaxMinElements(array);
// Console.WriteLine($"Разность между максимальным и минимальным элементом массива равна {res}");