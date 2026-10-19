using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal static class Helper
    {
        public static void Swap<T>(ref T val1,ref T val2)
        {
            T temp = val1;
            val1= val2;
            val2 = temp;
        }

        public static T FindMax<T>(T first,T second)where T :IComparable<T>
        {
            return first.CompareTo(second) >= 0 ? first : second;
        }
    }
}
