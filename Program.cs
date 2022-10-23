/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите 5 чисел: ");
int[] array = GetArray(5);
Console.WriteLine($"Среди введенных чисел {String.Join(", ", array)} положительных {CountPositiveNumber(array)}");

int CountPositiveNumber (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] GetArray (int size) 
{ 
    int[] res = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        res[i] = int.Parse(Console.ReadLine()!); 
    } 
    return res; 
} 
*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

(k1-k2)*x=b2-b1 => x=(b2-b1)/(k1-k2) => y=k1*(b2-b1)/(k1-k2)+b1

Вариант 1 - прямой

Console.WriteLine("Введите k1: ");
double k1 = int.Parse (Console.ReadLine ()!);
Console.WriteLine("Введите k2: ");
double k2 = int.Parse (Console.ReadLine ()!);
Console.WriteLine("Введите b1: ");
double b1 = int.Parse (Console.ReadLine ()!);
Console.WriteLine("Введите b2: ");
double b2 = int.Parse (Console.ReadLine ()!);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;
double[] array = {x, y};
Console.WriteLine ($"({String.Join(", ", array):f2}) - точка пересечения прямых, заданных уравнениями: y = {k1} * x + {b1} и y = {k2} * x + {b2}");

Вариант 2 - через метод

Console.WriteLine("Введите k1: ");
double k1 = int.Parse (Console.ReadLine ()!);
Console.WriteLine("Введите k2: ");
double k2 = int.Parse (Console.ReadLine ()!);
Console.WriteLine("Введите b1: ");
double b1 = int.Parse (Console.ReadLine ()!);
Console.WriteLine("Введите b2: ");
double b2 = int.Parse (Console.ReadLine ()!);
double[] array = CountCoordinat(k1, k2, b1, b2);
Console.WriteLine($"({String.Join(", ", array):f2}) - точка пересечения прямых, заданных уравнениями: y = {k1} * x + {b1} и y = {k2} * x + {b2}");

double[] CountCoordinat (double kx, double ky, double bx, double by)
{
    double[] arr = new double[2];
    arr[0] = (by - bx) / (kx - ky);
    arr[1] = (kx * (by - bx)) / (kx - ky) + bx;
    return arr;
}
*/
/*
Доп.Задача: Найти произведение всех элементов массива целых чисел, меньших заданного числа.
Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100.
*/
Console.WriteLine("Введите число N от 50 до 100:");
int N = int.Parse(Console.ReadLine()!);
int[] array = GetArray(10, 50, 100);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Произведение всех элементов массива меньших {N} составляет {MultElements (array, N)}");

int MultElements (int[] arr, int number)
{
    int mult = 1;
    // Вариант 1
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     if (arr[i] < number) mult = mult * arr[i];
    // }
    // Вариант 2
    foreach (var item in arr)
    {
        if (item < number) mult = mult * item;
    }
    return mult;
}

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue,maxValue);
    }
    return arr;
}
