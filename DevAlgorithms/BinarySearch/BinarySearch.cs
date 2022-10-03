using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enosoft.DevAlgorithms.BinarySearch
{
    /// <summary>
    /// 
    /// </summary>
    public class BinarySearch
    {
        public static void FindMyObject(Array myArr, object myObject)
        {
            int myIndex = Array.BinarySearch(myArr, myObject);
            if (myIndex < 0)
            {
                Console.WriteLine("The object to search for ({0}) is not found. The next larger object is at index {1}.", myObject, ~myIndex);
            }
            else
            {
                Console.WriteLine("The object to search for ({0}) is at index {1}.", myObject, myIndex);
            }
        }



        //Iterative Binary Search
        /*
         What is Iteration Algorithm?
In the case of Iterative algorithms, a certain set of statements are repeated a certain number of time.An Iterative algorithm will use looping statements such as for loop, while loop or do-while loop to repeat the same steps number of time.
         */
        public static int IterativeBinarySearch(int[] A, int x)
        {
            int low = 0, high = A.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (x == A[mid])
                {
                    return mid;
                }
                else if (x < A[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        //Recursive Binary Search
        /*
         What is Recursive Algorithm?
Recursive algorithm, a function calls itself again and again till the base condition(stopping condition) is satisfied.
         */
        public static int RecursiveBinarySearch(int[] A, int low, int high, int x)
        {
            if (low > high)
            {
                return -1;
            }
            int mid = (low + high) / 2;
            if (x == A[mid])
            {
                return mid;
            }
            else if (x < A[mid])
            {
                return RecursiveBinarySearch(A, low, mid - 1, x);
            }
            else
            {
                return RecursiveBinarySearch(A, mid + 1, high, x);
            }
        }

    }
}
