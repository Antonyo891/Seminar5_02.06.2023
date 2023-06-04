// See https://aka.ms/new-console-template for more information
/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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
int [] MultiArr(int [] array)
{
    int [] result = new int [array.Length/2];
    for (int i=0;i<array.Length/2;i++) result[i]=array[i]*array[array.Length-1-i];
    return result;
}
Console.Clear();
int size = Enter("Введите размер массива");
while (size%2==1) size = Enter("Число элементов долно быть четное. Введите размер массива");
int min = Enter("Введите мин значение элемента");
int max = Enter("Введите максим значение элемента");
int[] array = GetRanArr(size, min, max);
Console.WriteLine($"{String.Join(" ", array)}");
System.Console.WriteLine(String.Join(" ",MultiArr(array)));

