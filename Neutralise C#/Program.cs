using System;

class Program
{
    static string Neutralise(string s1, string s2)
    {
        string result = "";
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] == '+' && s2[i] == '+')
            {
                result += '+';
            }
            else if (s1[i] == '-' && s2[i] == '-')
            {
                result += '-';
            }
            else
            {
                result += '0';
            }
        }
        return result;
    }

    static void Main()
    {
        // مثال على الاستخدام
        Console.WriteLine(Neutralise("+-+", "+--") + " ➞ " + "+-0");
        Console.WriteLine(Neutralise("--++--", "++--++") + " ➞ " + "000000");
        Console.WriteLine(Neutralise("-+-+-+", "-+-+-+") + " ➞ " + "-+-+-+");
        Console.WriteLine(Neutralise("-++-", "-+-+") + " ➞ " + "-+00");
    }
}

