﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 132343242;
int b1 = 213423412;
int c1 = 39344232;
int a2 = 123423432;
int b2 = 13234235;
int c2 = 123324232;
int a3 = 333343243;
int b3 = 223242332;
int c3 = 223234322;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

System.Console.WriteLine(max);