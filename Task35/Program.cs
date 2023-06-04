// See https://aka.ms/new-console-template for more information
/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в
 отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
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
int FoundCheck(int[] array, int max, int min)
{
    int result = 0;
    foreach (int el in array) result += el >= max && el <= min ? 1 : 0;
    return result;
}
Console.Clear();
int size = Enter("Введите размер массива");
int min = Enter("Введите мин значение элемента");
int max = Enter("Введите максим значение элемента");
int minRange = Enter("Введите минимальное значение искомого диапазона");
int maxRange = Enter("Введите макс значение искомого диапазона");
int[] array = GetRanArr(size, min, max);
Console.WriteLine($"{String.Join(" ", array)} ==> {FoundCheck(array, minRange, maxRange)}");
