namespace MyLib;
using System;
public class Ex
{
    public static int[] GetRandomArray(int size)
    {
        int[] result = new int[size];
        for(int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(100);
        }
        return result;
        
    }
    public static int[] GetRandomArray(int size, int minValue, int maxValue)
    {
        int[] result = new int[size];
        for(int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(minValue, maxValue);
        }
        return result;
        
    }

}
