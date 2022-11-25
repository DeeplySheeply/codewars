//Problem found at: https://www.codewars.com/kata/59590976838112bfea0000fa
// Demonstrates knowledge of mathemtical logic and arrays

public static int[] Beggars(int[] values, int n)
        {
            int[] shares = new int[n];
            int count = 0;
            for (int i = 0; i < shares.Length; i++)

            {
                for (int k = count; k < values.Length; k += n)
                {
                    shares[i] = shares[i] + values[k];
                }

                count++;
            }           
            return shares;
        }
