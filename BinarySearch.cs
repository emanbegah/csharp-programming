using System;


namespace Week2
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
}

