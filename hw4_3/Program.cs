﻿int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 99);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}