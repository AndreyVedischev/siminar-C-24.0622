using System;
using static System.Console;
Clear();

Write("Введите число: ");
int number10 = int.Parse(ReadLine());
int size = $"{number10}".Length;
WriteLine(BinNumber(number10));

string BinNumber(int number)
{
    string bin_number = " ";
    while(number > 0)
    {
        if(number%2 == 0)
        {
            bin_number += "1";
        }
        else
        {
            bin_number += "0";
        }
        number/=2;

    }
    return bin_number;

}
