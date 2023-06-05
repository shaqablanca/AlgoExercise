using System;

namespace AlgoExercise {

    class Program
    {

        public static void Main()
        {
            string[] romanDates = { "MLXXI", "MCDLIII", "MMXXIII" };

            foreach (var i in romanDates)
            {

                Console.WriteLine(RomanConvertTo(i));
            }
        }

        public static int RomanConvertTo(string romanNumber) {
	     
            Dictionary<char, int> romanIntegers = new Dictionary<char, int>
            {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
            };
            var res = 0;

            for (int i = 0; i < romanNumber.Length - 1; i++)
            {
                if (romanIntegers[romanNumber[i]] < romanIntegers[romanNumber[i + 1]])
                    res -= romanIntegers[romanNumber[i]];
                else
                    res += romanIntegers[romanNumber[i]];
            }

            return res + romanIntegers[romanNumber[romanNumber.Length - 1]];

        }
	
	  
    }
    
}