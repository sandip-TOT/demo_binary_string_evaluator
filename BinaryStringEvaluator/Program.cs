using System;

public class BinaryStringEvaluator
{
    public static bool IsGoodBinaryString(string binaryString)
    {
        int countZero = 0;
        int countOne = 0;

        foreach (char c in binaryString)
        {
            if (c == '0')
            {
                countZero++;
            }
            else if (c == '1')
            {
                countOne++;
            }
            else
            {
                throw new ArgumentException("Input must be a binary string (only 0s and 1s).");
            }

            if (countZero > countOne)
            {
                return false;
            }
        }
        return countZero == countOne;
    }
    public static void Main(string[] args)
    {
        string[] testCases = { "1100", "1010", "111000", "000111", "1001", "010101", "0011" };

        foreach (var testCase in testCases)
        {
            bool result = IsGoodBinaryString(testCase);
            Console.WriteLine($"Binary string: {testCase}, is good: {result}");
        }
    }
}