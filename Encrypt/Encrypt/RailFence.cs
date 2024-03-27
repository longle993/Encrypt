using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt.Encrypt
{
    public class RailFence
    {
        private int Depth;
        public char[,] railfenceMatrix;
        public RailFence(int Depth)
        {
            this.Depth = Depth;
        }
        public string Encrypt(string plainText)
        {
            plainText = plainText.Replace(" ", "");
            char[,] fence = new char[Depth, plainText.Length];
            string cipherText = "";
            int row = 0;
            int col = 0;
            bool down = false;
            for (int i = 0; i < Depth; i++)
            {
                for (int j = 0; j < plainText.Length; j++)
                {
                    fence[i, j] = ' ';
                }
            }
            for (int i = 0; i < plainText.Length; i++)
            {
                if (row == 0 || row == Depth - 1)
                    down = !down;
                fence[row, col++] = plainText[i];
                if (down) row++;
                else row--;
            }
            railfenceMatrix = fence;
            foreach (char x in fence)
            {
                if (x != ' ')
                {
                    cipherText += x;
                }
            }
            return cipherText.ToUpper();
        }

        public string Decrypt(string cipherText)
        {
            char[,] fence = new char[Depth, cipherText.Length];
            int row = 0;
            int col = 0;
            bool down = false;
            string plainText = "";

            for (int i = 0; i < Depth; i++)
            {
                for (int j = 0; j < cipherText.Length; j++)
                {
                    fence[i, j] = ' ';
                }
            }

            for (int i = 0; i < cipherText.Length; i++)
            {
                if (row == 0 || row == Depth - 1)
                    down = !down;
                fence[row, col++] = '*';
                if (down) row++;
                else row--;
            }

            int index = 0;
            for (int i = 0; i < Depth; i++)
            {
                for (int j = 0; j < cipherText.Length; j++)
                {
                    if (fence[i, j] == '*' && index < cipherText.Length)
                    {
                        fence[i, j] = cipherText[index++];
                    }

                }
            }
            railfenceMatrix = fence;
            row = 0; col = 0;
            down = false;
            for (int i = 0; i < cipherText.Length; i++)
            {
                if (row == 0 || row == Depth - 1)
                    down = !down;
                if (fence[row,col] != '*')
                    plainText += fence[row, col++];
                if (down) row++;
                else row--;
            }
            return plainText;
        }
    }

}
