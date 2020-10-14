using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace sort_text
{
    public class Sorting
    {
        public string QuickSort(string data)
        {
            if (string.IsNullOrEmpty(data))
                return "";

            char[] dataArray =  data.ToLower().ToCharArray().Where(c => Char.IsLetterOrDigit(c)).ToArray();
            
            Sort(dataArray, 0, dataArray.Length - 1);

            return new string(dataArray);
        }

         
        public void Sort(char[] array, int l, int r)
        {
            if (l >= r)
                return;

            var p = Partition(array, l, r);

            Sort(array, l, p - 1);
            Sort(array, p + 1, r);

        }

        private int Partition(char[] array, int l, int r)
        {
            var pivot = array[r];
            var i = l;

            for (int j = l; j < r; j++)
            {
                if (array[j] <= pivot)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }

            var pivotTemp = array[i];
            array[i] = array[r];
            array[r] = pivotTemp;

            return i;
        }
    }
}
