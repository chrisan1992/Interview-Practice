using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Practice
{
    public class GenericArray<T>
    {
        private T[] array;
        private int lastIndex;

        public GenericArray()
        {
            array = new T[10];
            lastIndex = 0;
        }

        public void Add(T input)
        {
            if (lastIndex <= 9)
            {
                array[lastIndex] = input;
                ++lastIndex;
            }
        }

        public override String ToString()
        {
            String result = "";
            for (int i = 0; i <= lastIndex; ++i)
            {
                result += array[i] + "/n";
            }

            return result;
        }

    }
}
