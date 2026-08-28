namespace PCAD21CodingSessions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack, Queue, and LinkedList implementation
            var fruitArray = new string[] { "apple", "banana", "cherry", "date", "elderberry" };
            int k = 2;

            foreach (var fruits in fruitArray)
            {
                Console.WriteLine(fruits);
            }

            var reversedFruitStack = fruitArray.ReverseFromKUsingStack(k);
            Console.WriteLine("Reversed Array: " + string.Join(", ", reversedFruitStack));
            Console.WriteLine("Original Array: " + string.Join(", ", fruitArray));

            var remainingFruits = fruitArray.RemoveUsingQueue(k);
            Console.WriteLine("Remaining Array after removing first " + k + " elements: " + string.Join(", ", remainingFruits));

            var kthElement = fruitArray.GetKthElementUsingLinkedList(k);
            Console.WriteLine("The " + k + "-th element in the remaining array is: " + kthElement);

            var rotatedArray = fruitArray.RotateFruitArrayUsingLinkedList(k);
            Console.WriteLine($"Rotated Array: {string.Join(", ", rotatedArray)}");

        }
    }
}
