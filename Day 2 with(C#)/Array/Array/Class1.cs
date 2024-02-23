using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Class1
    {
        void GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
        }
        public static void Main(string[] args)
        {
            Class1 obj = new Class1();
            int[] array = { 1, 2, 5, 6, 66, 77, 7, 8, 78, 7, 8 };
            int[] array2 = { 3, 657, 67, 8, 7, 8, 9, 8, 79, 7 };
            obj.GetArray(array);
        }
    }
   
}
