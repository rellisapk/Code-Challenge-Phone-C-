using System;
using System.Collections.Generic;
using System.Text;

public class OldPhonePad
{
    public static string Decode(string messages)
    {
        StringBuilder result = new StringBuilder();
        Dictionary<char, string> keys = new()
        {
            {'0', " "}, {'1', " "}, {'2', "ABC"}, {'3', "DEF"}, {'4', "GHI"},
            {'5', "JKL"}, {'6', "MNO"}, {'7', "PQRS"}, {'8', "TUV"}, {'9', "WXYZ"}
        };

        char lastChar = ' ';
        int count = 0;

        foreach (char item in messages)
        {
            if (item == '#') break; // Stop processing when '#' is found
            if (item == '*') 
            {  
                if (result.Length > 0) result.Remove(result.Length - 1, 1); // Remove last character
                continue;
            }

            if (item == lastChar)
            {
                count++;  // Count consecutive presses
            }
            else
            {
                if (keys.ContainsKey(lastChar))
                {
                    int index = (count - 1) % keys[lastChar].Length;
                    result.Append(keys[lastChar][index]); // Append the correct letter
                }
                lastChar = item;
                count = 1;
            }
        }

        // Add last character
        if (keys.ContainsKey(lastChar))
        {
            int index = (count - 1) % keys[lastChar].Length;
            result.Append(keys[lastChar][index]);
        }

        return result.ToString();
    }
}
