using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt.Encrypt
{
    internal class Playfair
    {
        private const string Alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        public char[,] playfairMatrix;
        public Playfair(string key)
        {
            playfairMatrix = GeneratePlayfairMatrix(key);
        }
        private char[,] GeneratePlayfairMatrix(string key)
        {
            key = key.ToUpper().Replace("J", "I");
            key = key.Replace(" ", "");
            string keyAl = key + Alphabet;
            int k = 0;
            char[,] Matrix = new char[5, 5];
            string array = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (!array.Contains(keyAl[k]))
                    {
                        array += keyAl[k];
                        Matrix[i, j] = keyAl[k];
                        k++;
                    }
                    else
                    {
                        while (array.Contains(keyAl[k]))
                        {
                            k++;
                        }
                        array += keyAl[k];
                        Matrix[i, j] = keyAl[k];
                        k++;
                    }
                }
            }
            return Matrix;
        }
        private Tuple<int, int> GetPosition(char x)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (playfairMatrix[i, j] == x)
                    {
                        return Tuple.Create(i, j);
                    }
                }
            }
            return null;
        }
        private char GetChar(int row, int col)
        {
            return playfairMatrix[row, col];
        }
        public string Encrypt(string plainText)
        {
            plainText = plainText.ToUpper().Replace("J", "I");
            plainText = plainText.Replace(" ", "");
            string cipherText = "";
            int index = plainText.Length;

            for (int i = 0; i < index - 1; i += 2)
            {
                char char1 = plainText[i];
                char char2 = plainText[i + 1];
                if (char1 == char2)
                {
                    plainText = plainText.Insert(i + 1, "X");
                    index += 1;
                }
            }
            if (plainText.Length % 2 != 0)
            {
                plainText = plainText.Insert(plainText.Length, "X");
                index += 1;
            }

            for (int i = 0; i < plainText.Length; i += 2)
            {
                char char1 = plainText[i];
                char char2 = plainText[i + 1];

                var pos1 = GetPosition(char1);
                var pos2 = GetPosition(char2);

                int row1 = pos1.Item1, col1 = pos1.Item2;
                int row2 = pos2.Item1, col2 = pos2.Item2;

                if (row1 == row2)
                {
                    cipherText += GetChar(row1, (col1 + 1) % 5);
                    cipherText += GetChar(row2, (col2 + 1) % 5);
                }
                else if (col1 == col2)
                {
                    cipherText += GetChar((row1 + 1) % 5, col1);
                    cipherText += GetChar((row2 + 1) % 5, col2);
                }
                else
                {
                    cipherText += GetChar(row1, col2);
                    cipherText += GetChar(row2, col1);
                }
            }

            return cipherText;
        }
        public string Decrypt(string cipherText)
        {
            cipherText = cipherText.ToUpper().Replace(" ", "");
            string plainText = "";
            for (int i = 0; i < cipherText.Length; i += 2)
            {
                char char1 = cipherText[i];
                char char2 = cipherText[i + 1];

                var pos1 = GetPosition(char1);
                var pos2 = GetPosition(char2);

                int row1 = pos1.Item1, col1 = pos1.Item2;
                int row2 = pos2.Item1, col2 = pos2.Item2;

                if (row1 == row2)
                {
                    plainText += GetChar(row1, (col1 + 4) % 5);
                    plainText += GetChar(row2, (col2 + 4) % 5);
                }
                else if (col1 == col2)
                {
                    plainText += GetChar((row1 + 4) % 5, col1);
                    plainText += GetChar((row2 + 4) % 5, col2);
                }
                else
                {
                    plainText += GetChar(row1, col2);
                    plainText += GetChar(row2, col1);
                }
            }

            return plainText;
        }
    }

}
