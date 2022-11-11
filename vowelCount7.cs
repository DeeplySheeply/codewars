 string str ="";
    string finalResult = "";    

    // This method takes the user input and counts the number of vowels in the given string
    // It works iteratively
        private void GetVowelCount()
    {
            str = str.ToLower();
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' ||
                    str[i] == 'e' ||
                    str[i] == 'i' ||
                    str[i] == 'o' ||
                    str[i] == 'u')
                {
                    count++;
                }
            }
            finalResult = count.ToString();
    }
