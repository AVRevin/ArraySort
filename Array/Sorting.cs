using System;
using System.Collections.Generic;
using System.Text;

namespace ArraySort
{
    class Sorting
    {
        static public int[] Sort(int[] array)
        {

            int k = array.Length;
            int temp;

            while (k >= 1)
            {
                k = k / 2;

                for (int i = 0; i < array.Length - k; i++)
                {

                    if (array[i] > array[i + k])
                    {
                        temp = array[i + k];
                        array[i + k] = array[i];
                        array[i] = temp;
                    }

                    for (int j = 0; j <= i; j++)
                    {
                        if (array[j] > array[j + k])
                        {
                            temp = array[j + k];
                            array[j + k] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            return array;
        }
    }
}
