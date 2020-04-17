using Ceasar;
using System;

class Program
{
    static void Main(string[] args)
    {
        Ceasar.Ceasar c = new Ceasar.Ceasar();

        while (true)
        {
            Console.WriteLine("1) Encrypt");
            Console.WriteLine("2) Decrypt");
            Console.WriteLine("3) Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(c.Encrypt(ReadString("Text"), ReadInt("Rotations"), CharSet.ArabicNumbers +
                                                                                          CharSet.LowerCaseLatinLetters +
                                                                                          CharSet.UpperCaseLatinLetters +
                                                                                          CharSet.SpecialCharacters +
                                                                                          CharSet.GermanSpecificCharacters));
                    break;
                case "2":
                    Console.WriteLine(c.Decrypt(ReadString("Text"), ReadInt("Rotations"), CharSet.ArabicNumbers +
                                                                                          CharSet.LowerCaseLatinLetters +
                                                                                          CharSet.UpperCaseLatinLetters +
                                                                                          CharSet.SpecialCharacters +
                                                                                          CharSet.GermanSpecificCharacters));
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
            }
        }

    }

    private static int ReadInt(string text)
    {

        while (true)
        {
            Console.Write(text + ": ");

            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch { Console.WriteLine("Invalid Input"); }
        }

    }

    private static string ReadString(string text)
    {
        Console.Write(text + ": ");

        return Console.ReadLine();
    }

}