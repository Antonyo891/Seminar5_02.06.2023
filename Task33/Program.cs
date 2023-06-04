// See https://aka.ms/new-console-template for more information
/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/
int Enter(string n)
{
    System.Console.WriteLine(n);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int[] GetRanArr(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++) result[i] = new Random().Next(min, max + 1);
    return result;
}
String Found(int[] array, int n)
{
    string result = "Нет";
    foreach (int el in array) if (el == n) result = "Да";
    return result;
}
Console.Clear();
int size = Enter("Введите размер массива");
int min = Enter("Введите минимальное значение элементов массива");
int max = Enter("Введите максимальное значение элементов массива");
int found = Enter($"Введите искомое число в диапазоне от {min} до {max}");
while (found < min || found > max) found = Enter($"Введите число находящееся в диапазоне от {min} до {max}");
int[] array = GetRanArr(size, min, max);
Console.WriteLine($" [ {String.Join(" ", array)}] ==> {Found(array, found)}");
