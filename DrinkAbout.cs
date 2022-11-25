// Problem available here: https://www.codewars.com/kata/56170e844da7c6f647000063/train/csharp
// This displays knowledge of basic logic and conditional statements

public class Kata
{
  public static string PeopleWithAgeDrink(int old)
  {
     if (old < 14)
            {
                return "drink toddy";
            }
            else if (old < 18)
            {
                return "drink coke";
            }
            else if (old < 21)
            {
                return "drink beer";
            }            
            else
            {
                return "drink whisky";
            } 
  }
}
