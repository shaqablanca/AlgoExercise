using System;

namespace AlgoExercise { 

    class Program { 
    
        public static void Main() {

            string s = "ababd";

            Console.WriteLine(LongestPalindrome(s));
                
        }

        private static string LongestPalindrome(string input)
        {
            int rightindx = 0; 
	        int leftindx = 0;
            List<string> palindList = new List<string>();
            string palindrome= string.Empty;

            for (int currentindx = 1; currentindx < input.Length - 1; currentindx++)
            {
                leftindx = currentindx - 1;
                rightindx = currentindx + 1;
                while (leftindx >= 0 && rightindx < input.Length)
                {
                    if (input[leftindx] != input[rightindx])
                    {
                        break;
                    }
                    palindrome = input.Substring(leftindx, rightindx - leftindx + 1);
                    palindList.Add(palindrome);
                    leftindx--;
                    rightindx++;
                }
            }
            var res= (from s in palindList
                     select s).OrderByDescending(w => w.Length).First();
            return res;
            
	    }

    }     
	
}