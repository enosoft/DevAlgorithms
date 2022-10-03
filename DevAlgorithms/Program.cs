//.Net 6.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enosoft.DevAlgorithms;
using enosoft.DevAlgorithms.BinarySearch;

Array myIntArray = Array.CreateInstance(typeof(int), 5);

myIntArray.SetValue(8, 0);
myIntArray.SetValue(2, 1);
myIntArray.SetValue(6, 2);
myIntArray.SetValue(3, 3);
myIntArray.SetValue(7, 4);

// Do the required sort first
Array.Sort(myIntArray);

// Displays the values of the Array.
Console.WriteLine("The int array contains the following:");
PrintValues(myIntArray);


Console.WriteLine("Hello, World!");

// Locates a specific object that does not exist in the Array.
object myObjectOdd = 1;

BinarySearch.FindMyObject(myIntArray, myObjectOdd);

// Locates an object that exists in the Array.
object myObjectEven = 6;
BinarySearch.FindMyObject(myIntArray, myObjectEven);

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