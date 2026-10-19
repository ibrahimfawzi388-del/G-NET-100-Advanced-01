using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class SafeList<T>
    {
        private List<T>? list;
        public T Get(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                return default(T);
            }
            else
            {
                return list[index];
            }
        }
    }
}
