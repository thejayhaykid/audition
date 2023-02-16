using System;

namespace dotnet_audition
{
     /**
     * Read the following code and:
     * a) Explain what the code is supposed to do.
     * b) Write test case(s) to prove it.
     * c) If there are errors, explain them & provide a solution.
     */

    public class MysteryClass
    {
        public string Mystery(string num) 
        {
            if (num == null) {
                return "N/A";
            }

            var len = num.Length;
            var c = 0;
            var arrayLength = len + (len / 3);

            if (len % 3 == 0)
            {
                arrayLength--;
            }

            var sb = new char[arrayLength];
            
            for (var i = 0; i < len; i++) 
            {
                sb[c++] = num[i];
                if ((len - 1 - i) % 3 == 0 && i != len - 1) 
                {
                    sb[c++] = ',';
                }
            }
            
            return new string(sb);
        }
    }
}
