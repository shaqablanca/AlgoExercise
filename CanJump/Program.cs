
using System;

namespace CanJump{ 

    class Program {

        

        public static void Main() {

            int[] nums = { 6, 0, 0, 1, 4};
       
            Console.WriteLine(CanJump(nums));
            
        }
    


	    public  static bool CanJump(int[] arr) {
	   
            int len = arr.Length;
   
            if (len == 0) return true; 
	        
	        int ind = 0;
            for ( int i = 0; i < (len - 1) && ind>=i; i++) {
                if (ind < i + arr[i]) {
                    ind = i + arr[i];
		        }
                if (ind >= (len - 1)) return true;
	        }
            return false;
           
	}
    }

}