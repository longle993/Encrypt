using Encrypt.Encrypt;
using System.Reflection;
using System.Windows.Forms;

namespace Encrypt
{
    public partial class Form1 : Form
    {
        OneTimePad oneTimePad;
        VigenereCipher vigenere = new VigenereCipher();

        public Form1()
        {
            InitializeComponent();
        }

        #region Caesar
        private void txtInputK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEncryptCaesar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(txtInputK.Text) > 26)
            {
                MessageBox.Show("k nhập vào nên nhỏ hơn 26"); return;
            }

            Caesar caesar = new Caesar(txtInputK.Text);
            txtCipherText.Text = caesar.EncryptCeasar(txtPlainText.Text);
            txtPlainText.Text = "";

            foreach (var item in caesar.Alphabet)
            {
                txtAlphabet.Text += item.ToString() + " ";
            }
            for (int i = 0; i < caesar.AlphabetDecrypt.Length; i++)
            {
                txtAlphabetDecrypt.Text += caesar.AlphabetDecrypt[i] + " ";
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Caesar caesar = new Caesar(txtInputK.Text);
            txtPlainText.Text = caesar.DecryptCaesar(txtCipherText.Text);
        }
        #endregion

        #region Mono
        private void btnInstructionManual_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "1. Encrypt:\n" +
                "- Enter the text into \"Plain text\" that needs to be encrypted\r\n- Click \"Generate key\" to create the key\r\n- Click \"Encrypt\" to encrypt \"Plain text\" into \"Cipher text\"\n" +
                "2. Decrypt\n" +
                "- Enter the text \"Cipher text\" from the \"Encrypt\" group into the \"Decrypt\" group\r\n- Copy key from \"Encrypt\" group to \"Decrypt\" group\r\n- Click \"Decrypt\" to decrypt \"Cipher text\" into \"Plain text\"",
                "Instruction Manual",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnDecryptMono_Click(object sender, EventArgs e)
        {
            string plainText = MonoCipher.Decrypt(txtCipherText_Decrypt.Text.ToLower(), txtKey_Decrypt.Text.ToLower()).ToUpper();
            txtPlainText_Decrypt.Text = plainText;
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            string key = MonoCipher.GenerateRandomKey().ToUpper();
            txtKey_Encrypt.Text = key;
        }

        private void btnEncryptMono_Click(object sender, EventArgs e)
        {
            string cypherText = MonoCipher.Encrypt(txtPlainText_Encrypt.Text.ToLower(), txtKey_Encrypt.Text.ToLower()).ToUpper();
            txtCipherText_Encrypt.Text = cypherText;
        }

        #endregion

        #region Vigenere
        private void btnEncryptVigenere_Click(object sender, EventArgs e)
        {
            txtResult_Vigenere.Text = vigenere.EncryptVigenere(txtPlainTextVigenere.Text, txtKeyVigenere.Text);
            GenerateAndDisplayVigenereTable();

        }
        private void btnDecryptVigenere_Click(object sender, EventArgs e)
        {
            txtResult_Vigenere.Text = vigenere.DecryptVigenere(txtResult_Vigenere.Text, txtKeyVigenere.Text);
        }

        private void GenerateAndDisplayVigenereTable()
        {
            char[,] vigenereTable = vigenere.VigenereTableDisplay;

            // Đặt số hàng và cột cho DataGridView
            dataVigenereTable.RowCount = 26;
            dataVigenereTable.ColumnCount = 26;

            // Hiển thị mảng Vigenère trong DataGridView
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    dataVigenereTable.Rows[i].Cells[j].Value = vigenereTable[i, j];
                }
            }
        }
        #endregion

        #region Playfair

        private void CreateGrid(Panel panel, char[,] data)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.ColumnStyles.Clear();

            int rows = data.GetLength(0);
            int columns = data.GetLength(1);

            int cellWidth = panel.Width / columns;
            int cellHeight = panel.Height / rows;

            for (int i = 0; i < rows; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, cellHeight));
            }
            for (int i = 0; i < columns; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellWidth));
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Label label = new Label();
                    label.Text = data[i, j].ToString();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.ForeColor = Color.Red;
                    label.Font = new Font(label.Font.FontFamily, 10, FontStyle.Bold);
                    label.Dock = DockStyle.Fill;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    tableLayoutPanel.Controls.Add(label, j, i);
                }
            }

            panel.Controls.Add(tableLayoutPanel);
        }
        private void btnEncryptPlayfair_Click(object sender, EventArgs e)
        {
            panel_Playfair.Controls.Clear();
            Playfair playfair = new Playfair(txtKeyPlayfair.Text);
            string x = playfair.Encrypt(txtPlainTextPlayfair.Text);
            txtResult_Playfair.Text = x;
            CreateGrid(panel_Playfair, playfair.playfairMatrix);
        }
        private void btnDecryptPlayfair_Click(object sender, EventArgs e)
        {
            Playfair playfair = new Playfair(txtKeyPlayfair.Text);
            string x = playfair.Decrypt(txtResult_Playfair.Text);
            txtResult_Playfair.Text = x;
        }


        #endregion

        #region OTP

        private void txtKeyOTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEncryptOTP_Click(object sender, EventArgs e)
        {
            this.oneTimePad = new OneTimePad(txtPlainTextOTP.Text, txtKeyOTP.Text);
            txtCipherTextOTP.Text = oneTimePad.EncryptOneTimePad();
            for (int i = 0; i < oneTimePad.Alphabet.Length; i++)
            {
                txtAlphabetOTP.Text += oneTimePad.Alphabet[i] + " ";
            }
            for (int i = 0; i < oneTimePad.FormatKeyword.Length; i++)
            {
                txtFinalKeyOTP.Text += oneTimePad.FormatKeyword[i] + " ";
            }
            for (int i = 0; i < oneTimePad.IndexKeyword.Length; i++)
            {
                txtIndexKeyOTP.Text += oneTimePad.IndexKeyword[i] + " ";
                txtIndexPlainOTP.Text += oneTimePad.IndexPlainText[i] + " ";
                txtIndexFinalOTP.Text += (oneTimePad.IndexKeyword[i] + oneTimePad.IndexPlainText[i]) + " ";
            }
            txtPlainTextOTP.Text = "";
        }

        private void btnDecryptOTP_Click(object sender, EventArgs e)
        {
            txtPlainTextOTP.Text = this.oneTimePad.DecryptOTP(txtCipherTextOTP.Text);
        }
        #endregion
        #region RailFence
        private void btnEncryptRailfence_Click(object sender, EventArgs e)
        {
            panel_RailFence.Controls.Clear();
            RailFence railFence = new RailFence(int.Parse(txtDepth.Text));
            string x = railFence.Encrypt(txtPlainTextRailfence.Text);
            txtResult_RailFence.Text = x;
            CreateGrid(panel_RailFence, railFence.railfenceMatrix);
        }

        private void btnDecryptRailfence_Click(object sender, EventArgs e)
        {
            panel_RailFence.Controls.Clear();
            RailFence railFence = new RailFence(int.Parse(txtDepth.Text));
            string x = railFence.Decrypt(txtPlainTextRailfence.Text);
            txtResult_RailFence.Text = x;
            CreateGrid(panel_RailFence, railFence.railfenceMatrix);
        }
        #endregion




    }
}
