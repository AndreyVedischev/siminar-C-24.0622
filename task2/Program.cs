using System;
using static System.Console;
Clear();

int size = 3;
int[] array = GetRandomArray(size);
WriteLine($"[{String.Join(",",array)}]");
string ansver = DefTri(array)? "Треугольник" : "Не треугольник";
WriteLine($"{ansver}");

int[] GetRandomArray(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

bool DefTri(int[] arr)
{
    int a = arr[0];
    int b = arr[1];
    int c = arr[2];
    return ((a + b) > c && (a + c) > b && (b + c) > a);   
}