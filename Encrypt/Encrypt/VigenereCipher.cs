using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt.Encrypt
{
    public class VigenereCipher
    {
        char[,] vigenereTableDisplay = new char[26, 26];

        public char[,] VigenereTableDisplay { get => vigenereTableDisplay; }

        static char[,] GenerateVigenereTable()
        {
            char[,] vigenereTable = new char[26, 26];

            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    vigenereTable[i, j] = alphabet[(i + j) % 26];
                }
            }

            return vigenereTable;
        }

        public string EncryptVigenere(string plainText, string key)
        {
            this.vigenereTableDisplay = GenerateVigenereTable();
            string cipherText = "";
            int keyIndex = 0;

            foreach (char c in plainText)
            {
                if (char.IsLetter(c))
                {
                    int row = char.ToUpper(key[keyIndex]) - 'A';
                    int col = char.ToUpper(c) - 'A';
                    char encryptedChar = this.VigenereTableDisplay[row, col];
                    if (char.IsLower(c))
                        encryptedChar = char.ToLower(encryptedChar); // Giữ nguyên kiểu chữ
                    cipherText += encryptedChar;
                    keyIndex = (keyIndex + 1) % key.Length;
                }
                else
                {
                    cipherText += c;
                }
            }

            return cipherText;
        }

        public string DecryptVigenere(string cipherText, string key)
        {
            char[,] vigenereTable = GenerateVigenereTable();
            string plainText = "";
            int keyIndex = 0;

            foreach (char c in cipherText)
            {
                if (char.IsLetter(c))
                {
                    int row = char.ToUpper(key[keyIndex]) - 'A';
                    int col = Enumerable.Range(0, 26).First(i => vigenereTable[row, i] == char.ToUpper(c));
                    char decryptedChar = (char)('A' + col);
                    if (char.IsLower(c))
                        decryptedChar = char.ToLower(decryptedChar); // Giữ nguyên kiểu chữ
                    plainText += decryptedChar;
                    keyIndex = (keyIndex + 1) % key.Length;
                }
                else
                {
                    plainText += c;
                }
            }

            return plainText;
        }
    }


}
