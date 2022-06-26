using System;
using static System.Console;
Clear();

Write("Введите число: ");
WriteLine(string.Join(",",(NumFib(int.Parse(ReadLine())))));

int[] NumFib(int num)
{
   int[] result = new int[num];
   for(int i = 2; i < result.Length; i++)
   {
        result[0] = 0;
        result[1] = 1;
        result[i] = result[i - 1] + result[i - 2];
   }
   return result; 

}
