namespace Week2;
class Program
{
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
}

