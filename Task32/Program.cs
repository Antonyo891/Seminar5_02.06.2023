// See https://aka.ms/new-console-template for more information
/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/
int[] GetRandomArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++) result[i] = new Random().Next(min, max + 1);
    return result;
}
int[] Change(int[] array){
    int [] result = new int [array.Length];
    for (int i=0; i<array.Length; i++) result[i] =array[i]*-1;  
    return result;
    } 
int Enter(string n){
    System.Console.WriteLine(n);
    int result = int.Parse(Console.ReadLine());
    return result;
}
Console.Clear();
int size = Enter("Введите количество элементов массива");
int min = Enter("Введите минимальное значение каждого из элементов массива");
int max = Enter("Введите максимальное значение каждого из элементов массива");
int [] array = GetRandomArray(size,min,max);
Console.Write($" {string.Join(" ", array)} => [{string.Join(" ", Change(array))} ]");
System.Console.WriteLine();

