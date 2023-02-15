using System;

class Program
{
    static public void Main (string[] args) {
        string text = "aaabbbcccc";
        int count = 0;
        char v = char.Parse(Console.ReadLine());

        foreach (char c in text.ToCharArray())
        {
            if (c == v) {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}