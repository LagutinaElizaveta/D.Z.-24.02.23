// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19         [-4, -6, 89, 6] -> 0

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

// Функция нахождения суммы элементов на нечетных позициях
int SumOddElements(int[] array)
{
    int i = 1;
    int sum = 0;
    while (i < array.Length)
    {
        sum = sum + array[i];
        i = i + 2;
    }
    return sum;
}

// Вывод результата работы программы
Console.WriteLine($"Сумма элементов массива на нечетных позициях равна {SumOddElements(array)}");

// Или вот так
// int a = SumOddElements(array);
// Console.WriteLine($"Сумма элементов массива на нечетных позициях равна {a}");