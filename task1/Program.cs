using System;
using static System.Console;
Clear();

Write("Введите элементы массива через пробел: ");
int[] array = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(",",array)}]");

int[] GetArrayFromString(string arrayStr)
{
    string[] arS = arrayStr.Split(new char[]{' ','&','!','*',','},StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[arS.Length];
    for(int i = 0; i < arS.Length; i++)
    {
        result[i] = int.Parse(arS[i]);

    }
    return result;

}

int[] ReversArray1(int[] array)
{
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - i - 1];
    }
    return result;

}