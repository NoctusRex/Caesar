using System.Collections.Generic;
using System.Linq;

namespace Ceasar
{
    public sealed class Ceasar
    {
        private void RotateCharSet(List<char> charSet)
        {
            char lastElement = charSet.Last();

            for (int i = charSet.Count() - 1; i > 0; i--) charSet[i] = charSet[i - 1];

            charSet[0] = lastElement;
        }

        private void RotateCharSet(List<char> charSet, int rotations)
        {
            for (int i = 0; i < rotations; i++) RotateCharSet(charSet);
        }

        private string Resolve(string text, List<char> from, List<char> to)
        {
            string result = "";
            foreach (char c in text.ToCharArray()) result += to[from.IndexOf(c)];
            return result;
        }

        public string Encrypt(string text, int rotations, string charSet)
        {
            List<char> rotatedCharSet = charSet.ToCharArray().ToList();

            RotateCharSet(rotatedCharSet, rotations);

            return Resolve(text, charSet.ToCharArray().ToList(), rotatedCharSet);
        }

        public string Decrypt(string text, int rotations, string charSet)
        {
            List<char> rotatedCharSet = charSet.ToCharArray().ToList();

            RotateCharSet(rotatedCharSet, rotations);

            return Resolve(text, rotatedCharSet, charSet.ToCharArray().ToList());
        }
    }
}
