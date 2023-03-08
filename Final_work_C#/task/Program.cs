﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


System.Console.WriteLine("Введите размер массива");
int sizeArr = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizeArr];
var rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    int stringSize = rand.Next(1, 5);
    for (int j = 0; j < stringSize; j++)
    {
        array[i] += (char)rand.Next('a', 'z');
    }
}
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
int sizeSecondArr = 0;
string[] arrThreeSize = new string[sizeSecondArr];
for (int i = 0; i < arrey.Length; i++)
{
    if (array[i].Length == 3)
    {
        sizeSecondArr++;
        Array.Resize(ref arrThreeSize, sizeSecondArr);
        arrThreeSize[sizeSecondArr - 1] = array[i];
    }
}
System.Console.WriteLine("[" + string.Join(", ", arrThreeSize) + "]");
