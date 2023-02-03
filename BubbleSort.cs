using System;
using System.Collections;

namespace Week2
{
	public class BubbleSort
	{
		public static void Sort(int[] array)
		{
			int temp;

			// Nested FOR loop, iterates through each element in array
			for (int i=0; i < array.Length - 1; i++)
			{
				for (int j=0; j < array.Length - 1; j++)
				{
					// Conduct pairwise comparison and swap if necessary
					if (array[j] > array[j + 1])
					{
						temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
			}
		}
	}


    /*
    static void Main(string[] args)
    {
        Console.WriteLine(
            "++ Binary Search Algorithm ++\n"
            + "Author: Emmanuel Begah\n"
            + "Date: 01/02/2023\n"
            );

        int[] intArray = { 9, 7, 1, 15, 3, 2, 21, 11 };

        // Display unsorted array
        Console.WriteLine("-*- UNSORTED Array -*-");
        for (int i = 0; i < intArray2.Length; i++)
        {
            if (i == intArray.Length - 1)
            {
                Console.Write(intArray[i] + "\n");
            }

            else { Console.Write(intArray[i] + " "); }
        }

        // Invoke Bubble Sort method
        BubbleSort.Sort(intArray2);
        Console.WriteLine();

        // Display sorted array
        Console.WriteLine("-*- SORTED Array -*-");
        for (int i = 0; i < intArray.Length; i++)
        {
            if (i == intArray.Length - 1)
            {
                Console.Write(intArray[i] + "\n");
            }

            else { Console.Write(intArray[i] + " "); }
        }

    */


}

