﻿string[] array = new string[] {"plus", "cat and dog", "+24", "hi", "world", "no!", "3"};
int counter = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
        counter++;
}
string[] array2 = new string[counter];
int j = 0;

for (int i = 0; i < array.Length; i++)
    if (array[i].Length < 4)
    {
        array2[j] = array[i];
        j++;
    }