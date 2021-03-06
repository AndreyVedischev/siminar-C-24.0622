namespace MyLib;
using System;
public class Ex
{
    ///<summary>
    ///Metod 1
    ///</summary>    
    public static int[] GetRandomArray(int size)
    {
        int[] result = new int[size];
        for(int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(100);
        }
        return result;
        
    }

    ///<summary>
    ///Metod 2
    ///</summary>    
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
