// Problem accessible at https://www.codewars.com/kata/5aba780a6a176b029800041c/train/csharp
public class Kata
{
   public static int MaxMultiply(int divisor, int bound)
        {
            if (bound / divisor >= 1)
            {
                return bound - (bound % divisor);
            }
            else
            {
                return -1;
            }
        }
}
