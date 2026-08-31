namespace PCAD21CodingSessions
{
    public static class StackQueueLinkedLists
    {
        /*
          You are given an array of strings representing different fruits and an integer k. 
           Your task is to reverse the array starting from the k-th element using a stack.
        
            Write a function ReverseFromKUsingStack that takes an array of strings fruitArray and an integer k, 
            and returns the array reversed starting from the k-th element.
        
        Example: 
            Input: ["apple", "banana", "cherry", "date", "elderberry"], k = 2
           Output: ["apple", "banana", "elderberry", "date", "cherry"]
        
            Reversed Array starting from the 2-th element: ["apple", "banana", "elderberry", "date", "cherry"]
        
        Constraints
        The array fruitArray can contain up to 10^5 elements.
        Each element in fruitArray is a non-empty string.
        k is a non-negative integer and less than the length of fruitArray.
         */
        public static string[] ReverseFromKUsingStack(this string[] fruitArray, int k)
        {
            try
            {
                //guard clause
                if (fruitArray == null || k >= fruitArray.Length)
                {
                    return fruitArray;
                }

                Stack<string> fruitStack = new Stack<string>();

                for(int i = k; i < fruitArray.Length; i++)
                {
                    /*
                     * elderberry
                     * date
                     cherry
                     */
                    fruitStack.Push(fruitArray[i]);
                }

                for(int i = k; i < fruitArray.Length; i++)
                {

                    fruitArray[i] = fruitStack.Pop();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Invalid index: " + ex.Message);
            }
            catch (Exception ex)
            {
               Console.WriteLine("An error occurred while processing the input: " + ex.Message);
            }

            return fruitArray;
        }


        /*
         * You are given an array of strings representing different fruits. 
         * Your task is to remove the first n elements from the array using a queue and return the remaining array.

            Write a function RemoveUsingQueue that takes an array of strings fruitArray and an integer n, 
            and returns the remaining array after removing the first n elements.
        Example:
            Input: ["elderberry", "date", "cherry", "banana", "apple"], n = 2
            Output: ["cherry", "banana", "apple"]

            Remaining Array after removing first 2 elements: ["cherry", "banana", "apple"]
        
        Constraints:
            The array fruitArray can contain up to 10^5 elements.
            Each element in fruitArray is a non-empty string.
            n is a non-negative integer.
         */
        // tong
        // 
        // Some hints from Tyler for this one, Tong...
        // Remember a.) a queue can take an array as a parameter on its constructor
        // b.) a queue has a method `ToArray()`
        public static string[] RemoveUsingQueue(this string[] fruitArray, int n)
        {
            throw new NotImplementedException();
        }


        /*
         * You are given an array of strings representing different fruits. 
         * Your task is to store the elements in a linked list and return the k-th element from the linked list.

            Write a function GetKthElementUsingLinkedList that takes an array of strings fruitArray and an integer k, 
            and returns the k-th element from the linked list.
        Example:
            Input: ["elderberry", "date", "cherry", "banana", "apple"], k = 2
            Output: "date"

            Remaining Array stored in LinkedList: ["elderberry", "date", "cherry", "banana", "apple"]
            The 2-th element in the linked list is: "date"

        Constraints:
            The array fruitArray can contain up to 10^5 elements.
            Each element in fruitArray is a non-empty string.
            k is a non-negative integer.
         */
        // Clark
        public static string GetKthElementUsingLinkedList(this string[] fruitArray, int k)
        {
            LinkedList<string> list = new();
            /*
            Make a list
            if the list is smaller than k return false
            if
            */
            
            throw new NotImplementedException();
        }

        /*
         * You are given an array of strings representing different fruits and an integer k. 
         * Your task is to rotate the array to the right by k steps. 
         * Convert the array to a linked list and then perform the rotation. 
         * Return the rotated array as a string array.

            Write a function RotateFruitArrayUsingLinkedList that takes an array of strings fruitArray and an integer k, 
            and returns the rotated array as a string array.
        Example:
            Input: ["apple", "banana", "cherry", "date", "elderberry"], k = 2
            Output: ["date", "elderberry", "apple", "banana", "cherry"]

            Rotated Array: ["date", "elderberry", "apple", "banana", "cherry"]

        Constraints:
            The array fruitArray can contain up to 10^5 elements.
            Each element in fruitArray is a non-empty string.
            k is a non-negative integer.
         */
         //Matt
         //Rotate Array: find item at kth element, put items in front on kth elements at
         //the beginning of array

         //Constraints: use linked list
         //Linked List: each item point at next

         //Strategy - Reversing linked list: "break" link at kth
         //element, make kth+1 element head of array, and point last item of array to
         //original head

       // mattheus
        public static string[] RotateFruitArrayUsingLinkedList(this string[] fruitArray, int k)
        {
            try
            {
                // Guard clauses
                if (fruitArray == null || k < 0 || k >= fruitArray.Length)
                {
                    return fruitArray;
                }

                var modifiedArray = new LinkedList<string>(fruitArray);

                //initalize kthNode to the first node of the linked list and then iterate through the linked list to get to the k-th node
                var kthNode = modifiedArray.First;
                for (int i = 0; i < k; i++)
                {
                    kthNode = kthNode!.Next;
                }

                //Sets the new head to the k+1 node
                var newHead = kthNode!.Next;

                // Move nodes from first part of list to the end
                while (modifiedArray.First != newHead) //limits while loop to only go until kth node
                {
                    var firstValue = modifiedArray.First!.Value;
                    modifiedArray.RemoveFirst(); //removes the current first node
                    modifiedArray.AddLast(firstValue); //adds it to the end of the list
                }

                return modifiedArray.ToArray(); //because the method is of string[] type, we convert the linked list back to an array.
            }
            catch (Exception ex) 
            { 
                throw new NotImplementedException();
            }
        }
    }
}