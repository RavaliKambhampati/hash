using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearch
{
    class Program
    {
        public static int binarysearch(int[] arr,int searchitem)
        {
            int start = 0;
            int end = arr.Length - 1;
            while(start<=end)
            {
                int mid = (start + end) / 2;
                if(searchitem==arr[mid])
                {
                    return mid;
                }
                else if(searchitem<arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter a search item");
            int searchitem = int.Parse(Console.ReadLine());
            int[] arr = { 10, 20, 30, 40 };

            int result = binarysearch(arr, searchitem);
            if(result<0)
            {
                Console.WriteLine($"{searchitem} is not found");
            }
            else
            {
                Console.WriteLine($"{searchitem} is found:{result}");

            }
            Console.ReadLine();
        }
    }
}
