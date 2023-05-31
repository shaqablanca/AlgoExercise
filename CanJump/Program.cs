using System;

namespace CanJump
{

    class Program
    {        
        public static void Main()
        {
            int[] nums = { 6, 0, 0, 1, 4 };
            Console.WriteLine(CanJump(nums));
        }
        public static bool CanJump(int[] arr)
        {

            int len = arr.Length;
            if (len == 0) return true;
            int indx = 0;
            for (int i = 0; i < (len - 1) && indx >= i; i++)
            {
                if (indx < i + arr[i])
                {
                    indx = i + arr[i];
                }
                if (indx >= (len - 1)) return true;
            }
            return false;

        }
    }

}