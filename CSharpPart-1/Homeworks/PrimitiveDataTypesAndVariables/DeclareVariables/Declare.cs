﻿//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, 
//ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

class Declare
{
    static void Main()
    {
        ushort firstValue = 52130;
        sbyte secondValue = -115;
        int thirdValue = 4825932;
        byte fourthValue = 97;
        short fifthValue = -10000;
    }
}
