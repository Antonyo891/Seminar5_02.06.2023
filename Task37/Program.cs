﻿// See https://aka.ms/new-console-template for more information
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
int[] MultiArr(int[] array)
{
    int Length = array.Length / 2;
    if (array.Length % 2 == 1) Length = array.Length / 2 + 1;
    int[] result = new int[Length];
    for (int i = 0; i < Length; i++) result[i] = i == array.Length - 1 - i ? array[i] : array[i] * array[array.Length - 1 - i];
    return result;
}
/*int [] InAr (string array)
{
    string [] Nums = array.Split(" ");
    int [] NumInt = new int[Nums.Length];
    for (int i = 0; i<Nums.Length; i++) NumInt[i]=int.Parse(Nums[i]);
    return NumInt;
}*/
/*void PrintAr(int [] array)
{
    for (int i =0; i<array.Length; i++) System.Console.Write($" {array[i]} ");
    System.Console.WriteLine();
}*/
Console.Clear();
int size = Enter("Введите размер массива");
//while (size%2==1) size = Enter("Число элементов долно быть четное. Введите размер массива");
int min = Enter("Введите мин значение элемента");
int max = Enter("Введите максим значение элемента");
int[] array = GetRanArr(size, min, max);
//System.Console.WriteLine("Введите массив");
//String S = Console.ReadLine();
//int [] array = InAr(S);
//PrintAr(array);
Console.WriteLine($"{String.Join(" ", array)}");
System.Console.WriteLine(String.Join(" ", MultiArr(array)));

