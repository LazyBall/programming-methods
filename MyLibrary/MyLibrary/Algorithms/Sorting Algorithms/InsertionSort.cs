﻿using System.Collections.Generic;

namespace MyLibrary.Algorithms
{
    public static class InsertionSort<T>
    {

        public static void Sort(T[] array)
        {
            Sort(array, Comparer<T>.Default);
        }

        public static void Sort(T[] array, IComparer<T> comparer)
        {

            for (int i = 1; i < array.Length; i++)
            {
                var item = array[i];
                int j = i - 1;

                while ((j >= 0) && (comparer.Compare(array[j], item) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = item;
            }

        }

    }
}