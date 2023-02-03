using System;


namespace BinarySearchAlgorithm
{
	public class BinarySearch
	{
		public static int Search(int[] array, int valueToFind)
		{
			// Assign Pointers
			int start = array[0];
			int end = array.Length - 1;

			int notFound = -1;

			// Conduct search while segment is not empty
			while (start <= end)
			{
				int middle = (start + end) / 2;

				// Search segment and check middle value
				if (valueToFind == array[middle]) { return middle; }
				else
				{
					// Search lower segment
					if (valueToFind < array[middle])
					{
						end = middle - 1;
					}

					// Search upper segment
					else
					{
						if (valueToFind > array[middle])
						{
							start = middle + 1;
						}
					}
				}
			}
			return notFound; // Value not found
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

        int[] intArray = { 3, 7, 8, 15, 19, 30, 31, 45 };

        // Store value being searched for
        int valueToFind = 31;

        int result = BinarySearch.Search(intArray, valueToFind);

        // Display result
        Console.WriteLine("The TARGET VALUE is: " + valueToFind);
        Console.WriteLine("The INDEX of the Target Value is: " + result);
    }

	*/

}

