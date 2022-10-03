//.Net 6.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enosoft.DevAlgorithms;
using enosoft.DevAlgorithms.BinarySearch;

int[] A = { 2, 5, 6, 8, 9, 10 };

// Do the required sort first
Array.Sort(A);

// Displays the values of the Array.
Console.WriteLine("The int array contains the following:");
PrintValues(A);


Console.WriteLine("Hello, World!");

// Locates a specific object that does not exist in the Array.
object myObjectOdd = 1;

BinarySearch.FindMyObject(A, myObjectOdd);

// Locates an object that exists in the Array.
int myObjectEven = 6;
BinarySearch.FindMyObject(A, myObjectEven);

Console.WriteLine("IterativeBinarySearch : " + BinarySearch.IterativeBinarySearch(A, myObjectEven));

int low = 0;
int high = A.Length - 1;

Console.WriteLine("RecursiveBinarySearch : " + BinarySearch.RecursiveBinarySearch(A,low,high, myObjectEven));

void PrintValues(Array myArr)
{
    int i = 0;
    int cols = myArr.GetLength(myArr.Rank - 1);
    foreach (object o in myArr)
    {
        if (i < cols)
        {
            i++;
        }
        else
        {
            Console.WriteLine();
            i = 1;
        }
        Console.Write("\t{0}", o);
    }
    Console.WriteLine();
}