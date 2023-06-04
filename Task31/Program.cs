// See https://aka.ms/new-console-template for more information
/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.*/
int[] Array_Random(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i] = new Random().Next(min, max + 1);
    return array;
}
int Enter(string n)
{
    Console.WriteLine($"Введите {n}");
    int number = int.Parse(Console.ReadLine());
    return number;
}
int [] GetPosNeg(int[] array) //создет массив 1 элемент - сумма положительных, 0 - сумма отрицатльных
{
    int[] result = new int[2];
    foreach (int el in array)
    {
        result[1] += el > 0 ? el : 0; // if (el>0) result[1]=result[1]+el; else result[1]=result[1]+0; 
        result[0] += el < 0 ? el : 0;
    }
    return result;
}
int size = Enter("размер создаваемого массива");
int min = Enter("минимальное значение каждого из элементов создаваемого массива");
int max = Enter("максимальное знание каждого из элементов создаваемого массива");
int [] RandomArray = Array_Random(size, min, max);
//System.Console.WriteLine($"[ {String.Join("  ",GetPosNeg(RandomArray))} ]");
Console.Clear();
System.Console.WriteLine($"{String.Join(" ", RandomArray)}");
Console.WriteLine($"Сумма положительных элементов массива равна {GetPosNeg(RandomArray)[1]}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {GetPosNeg(RandomArray)[0]}");
