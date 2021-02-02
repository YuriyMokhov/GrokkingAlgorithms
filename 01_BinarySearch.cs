using System;
using System.Collections.Generic;
using System.Text;

namespace GrokkingAlgorithms
{
    public class BinarySearch
    {
        //11
        // 1,2,3,4,5,6,7,8,  9,10,11,12, 13,14,15,16
        public void Search(List<int> sortedList, int searchingNumber)
        {
        
            var low = sortedList[0];
            var high = sortedList[sortedList.Count - 1];
            bool isSearched = false;
            int inerationCount = 0;
            while (!isSearched)
            {
                inerationCount++;
                int delitel = (int)Math.Truncate((double)(high + low) / 2 + 1); 
                if (delitel == searchingNumber)
                {
                    isSearched = true;
                }

                if (searchingNumber > delitel)
                {
                    low = delitel;
                }
                else
                {
                    high = delitel - 1; 
                }

            }

    






        }
    }
}
