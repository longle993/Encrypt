using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt.Encrypt
{
    public class Caesar
    {
        //Vị trí dời
        private int k;
        //Bảng chữ cái
        private string[] alphabet = new string[26];
        //Bảng chữ cái sau khi dời sang k vị trí
        private string[] alphabetDecrypt = new string[26];

        public Caesar()
        {
            GenerateAlphabet();
        }
        public Caesar(string k)
        {
            this.k = int.Parse(k.ToString());
            GenerateAlphabet();
        }

        public string[] Alphabet { get => alphabet;}
        public string[] AlphabetDecrypt { get => alphabetDecrypt; }

        public string EncryptCeasar(string plainText)
        {
            DecryptAlphabet(); //Xuất bảng chữ cái sau khi đã di dời vị trí
            string cipherText = "";
            plainText = plainText.ToUpper(); //Chuyển tất cả chữ sang chữ IN
            for (int i = 0; i < plainText.Length; i++)
            {
                string charPlain = plainText[i].ToString();
                int index = Array.IndexOf(alphabet, charPlain);
                //Nếu kí tự đó không tồn tại trong bảng chữ cái thì giữ nguyên
                if (index != -1)
                {
                    if (index + k < alphabet.Length)
                    {
                        cipherText += alphabet[index + k];
                    }
                    else
                    {
                        cipherText += alphabet[index + k - alphabet.Length];
                    }
                    
                }
                else
                    cipherText += charPlain;
            }
            return cipherText;
        }
        public string DecryptCaesar(string cipherText)
        {
            string plaintext = "";
            for(int i = 0; i< cipherText.Length; i++)
            {
                int index = Array.IndexOf(alphabet, cipherText[i].ToString());
                if (index != -1)
                {
                    if (index - k >= 0)
                        plaintext += alphabet[index - k];
                    else
                        plaintext += alphabet[alphabet.Length - index - k];
                }
                else
                    plaintext += cipherText[i];
            }
           
            return plaintext;
        }
        private void DecryptAlphabet()
        {
            for(int i = 0; i < alphabet.Length; i++)
            {
                if (i + this.k < alphabet.Length)
                    alphabetDecrypt[i] = alphabet[i + this.k];
                else
                    alphabetDecrypt[i] = alphabet[(i + this.k - alphabet.Length)];
            }
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
