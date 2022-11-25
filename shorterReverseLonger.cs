 // Global variables
    string a = "";
    string b = "";
    string finalResult = "";

    private void ShorterReverseLongerMethod()
    {
        // Local variables 
        int longest = a.Length;
        int shortest = b.Length;
        string temp = "";

        // Check for nulls
        if (string.IsNullOrEmpty(a))
        {
            a = "";
        }

        if (string.IsNullOrEmpty(b))
        {
            b = "";
        }        

        // If statement to solve the challenge
        if (shortest > longest)
        {
            temp = temp + a;
            a = b;
            b = temp;
        }

         finalResult = string.Concat(b, string.Concat(a.Reverse()), b);
    }
