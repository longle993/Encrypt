using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt.Encrypt
{
    public class OneTimePad
    {
        private string plainText;
        private string keyword;
        private string[] alphabet = new string[26];
        private string[] formatKeyword;
        private int[] indexPlainText;
        private int[] indexKeyword;

        public string[] Alphabet { get => alphabet; }
        public string[] FormatKeyword { get => formatKeyword; }
        public int[] IndexPlainText { get => indexPlainText;  }
        public int[] IndexKeyword { get => indexKeyword;  }

        public OneTimePad(string plainText, string keyword)
        {
            this.plainText = plainText;
            this.keyword = keyword;
            GenerateAlphabet();
        }
        public OneTimePad()
        {
            GenerateAlphabet();
        }
        public string EncryptOneTimePad()
        {
            string cipherText = "";
            this.plainText = plainText.ToUpper();
            this.keyword = keyword.ToUpper();
            //Format Keyword cách 2
            formatKeyword = new string[plainText.Length];
            if (plainText.Length < keyword.Length)
            {
                for (int i = 0; i < plainText.Length; i++)
                    formatKeyword[i] += keyword[i];
            }
            else if (plainText.Length > keyword.Length)
            {
                for (int i = 0; i < plainText.Length; i++)
                {
                    if (i < keyword.Length)
                        formatKeyword[i] = keyword[i].ToString();
                    else
                        formatKeyword[i] = plainText[i - keyword.Length].ToString();
                }
            }

            //Mã hoá
            indexPlainText = new int[plainText.Length];
            indexKeyword = new int[formatKeyword.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                string charPlain = plainText[i].ToString();
                int index = Array.IndexOf(alphabet, charPlain);
                indexPlainText[i] = index;

                string charKey = formatKeyword[i].ToString();
                int indexKey = Array.IndexOf(alphabet, charKey);
                indexKeyword[i] = indexKey;
            }
            for (int i = 0; i < indexPlainText.Length; i++)
            {
                if (indexPlainText[i] != -1)
                {
                    int indexCipher = indexPlainText[i] + indexKeyword[i];
                    if (indexCipher < alphabet.Length)
                        cipherText += alphabet[indexCipher];
                    else
                        cipherText += alphabet[indexCipher - alphabet.Length];
                }
                else
                    cipherText += plainText[i];
                
            }
            return cipherText;
        }
        public string DecryptOTP(string cipherText)
        {
            string plainText = "";
            int[] indexCipher = new int[cipherText.Length];
            for(int i = 0; i<cipherText.Length;i++)
            {
                int index = Array.IndexOf(alphabet, cipherText[i].ToString());
                indexCipher[i] = index;
            }
            for(int i = 0; i < indexCipher.Length; i++)
            {
                if (indexCipher[1] != -1)
                    indexPlainText[i] = indexCipher[i] - indexKeyword[i];
                else
                    indexPlainText[i] = indexCipher[i];
            }

            for(int i = 0; i < indexPlainText.Length; i++)
            {
                if (indexPlainText[i] != -1)
                {
                    if (indexPlainText[i] < 0)
                        plainText += alphabet[alphabet.Length + indexPlainText[i]];
                    else
                        plainText += alphabet[indexPlainText[i]];
                }
                    
                else
                    plainText += cipherText[i];
            }


            return plainText;
        }
        private void GenerateAlphabet()
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = Convert.ToChar('A' + i).ToString();
            }
        }
    }

}
