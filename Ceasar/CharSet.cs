using System;
using System.Collections.Generic;
using System.Text;

namespace Ceasar
{
    public sealed class CharSet
    {
        private CharSet() { }

        public static string LowerCaseLatinLetters { get; } = "abcdefghijklmnopqrstuvwxyz";
        public static string UpperCaseLatinLetters { get; } = LowerCaseLatinLetters.ToUpper();
        public static string ArabicNumbers { get; } = "0123456789";
        public static string SpecialCharacters { get; } = "!\"§$%&/()=?`*'_:;><,.-#+´^~}][{|@µ ";
        public static string GermanSpecificCharacters { get; } = "ßäöüÖÄÜ";
    }
}
