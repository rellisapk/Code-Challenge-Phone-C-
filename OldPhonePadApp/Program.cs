using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter input for OldPhonePad (end with #):");
        string input = Console.ReadLine();

        try
        {
            string output = OldPhonePad.Decode(input);
            Console.WriteLine($"Decoded output: {output}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
