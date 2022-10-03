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

    }
}
