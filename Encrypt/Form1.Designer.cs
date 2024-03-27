namespace Encrypt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControl = new TabControl();
            CaesarTab = new TabPage();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            btnDecryptCaesar = new Button();
            txtAlphabetDecrypt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtAlphabet = new TextBox();
            txtCipherText = new TextBox();
            panel1 = new Panel();
            btnEncryptCaesar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPlainText = new TextBox();
            txtInputK = new TextBox();
            label1 = new Label();
            MonoalphabeticTab = new TabPage();
            btnInstructionManual = new Button();
            groupBox2 = new GroupBox();
            label16 = new Label();
            txtPlainText_Decrypt = new TextBox();
            btnDecryptMono = new Button();
            label15 = new Label();
            label18 = new Label();
            txtCipherText_Decrypt = new TextBox();
            txtKey_Decrypt = new TextBox();
            groupBox1 = new GroupBox();
            label17 = new Label();
            txtCipherText_Encrypt = new TextBox();
            btnEncryptMono = new Button();
            lblKeyMono = new Label();
            lblAlphabet = new Label();
            label14 = new Label();
            btnGenerateKey = new Button();
            label13 = new Label();
            txtPlainText_Encrypt = new TextBox();
            txtKey_Encrypt = new TextBox();
            label12 = new Label();
            VigenereTab = new TabPage();
            dataVigenereTable = new DataGridView();
            txtResult_Vigenere = new TextBox();
            btnDecryptVigenere = new Button();
            btnEncryptVigenere = new Button();
            label34 = new Label();
            txtKeyVigenere = new TextBox();
            label35 = new Label();
            txtPlainTextVigenere = new TextBox();
            label33 = new Label();
            PlayfairTab = new TabPage();
            panel_Playfair = new Panel();
            txtResult_Playfair = new TextBox();
            btnDecryptPlayfair = new Button();
            btnEncryptPlayfair = new Button();
            label32 = new Label();
            txtKeyPlayfair = new TextBox();
            label31 = new Label();
            txtPlainTextPlayfair = new TextBox();
            label30 = new Label();
            OTPTab = new TabPage();
            panel4 = new Panel();
            label29 = new Label();
            txtCipherTextOTP = new TextBox();
            label28 = new Label();
            txtIndexFinalOTP = new TextBox();
            label27 = new Label();
            txtAlphabetOTP = new TextBox();
            label26 = new Label();
            btnDecryptOTP = new Button();
            txtIndexKeyOTP = new TextBox();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            txtFinalKeyOTP = new TextBox();
            txtIndexPlainOTP = new TextBox();
            panel3 = new Panel();
            btnEncryptOTP = new Button();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            txtPlainTextOTP = new TextBox();
            txtKeyOTP = new TextBox();
            label19 = new Label();
            RailfenceTab = new TabPage();
            label38 = new Label();
            label37 = new Label();
            panel_RailFence = new Panel();
            txtResult_RailFence = new TextBox();
            btnDecryptRailfence = new Button();
            btnEncryptRailfence = new Button();
            txtDepth = new TextBox();
            label36 = new Label();
            txtPlainTextRailfence = new TextBox();
            TabControl.SuspendLayout();
            CaesarTab.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            MonoalphabeticTab.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            VigenereTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataVigenereTable).BeginInit();
            PlayfairTab.SuspendLayout();
            OTPTab.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            RailfenceTab.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(CaesarTab);
            TabControl.Controls.Add(MonoalphabeticTab);
            TabControl.Controls.Add(VigenereTab);
            TabControl.Controls.Add(PlayfairTab);
            TabControl.Controls.Add(OTPTab);
            TabControl.Controls.Add(RailfenceTab);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1041, 773);
            TabControl.TabIndex = 0;
            // 
            // CaesarTab
            // 
            CaesarTab.Controls.Add(label11);
            CaesarTab.Controls.Add(label10);
            CaesarTab.Controls.Add(label9);
            CaesarTab.Controls.Add(label8);
            CaesarTab.Controls.Add(panel2);
            CaesarTab.Controls.Add(panel1);
            CaesarTab.Controls.Add(label1);
            CaesarTab.Location = new Point(4, 29);
            CaesarTab.Name = "CaesarTab";
            CaesarTab.Padding = new Padding(3);
            CaesarTab.Size = new Size(1033, 614);
            CaesarTab.TabIndex = 0;
            CaesarTab.Text = "Caesar";
            CaesarTab.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(150, 514);
            label11.Name = "label11";
            label11.Size = new Size(145, 23);
            label11.TabIndex = 9;
            label11.Text = "k nên nhỏ hơn 26";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(150, 473);
            label10.Name = "label10";
            label10.Size = new Size(417, 23);
            label10.TabIndex = 8;
            label10.Text = "không được chứa các kí tự đặc biệt hay khoảng trắng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(150, 450);
            label9.Name = "label9";
            label9.Size = new Size(485, 23);
            label9.TabIndex = 7;
            label9.Text = "Plain text chỉ được chứa chữ cái trong bảng chữ cái Tiếng Anh";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(77, 445);
            label8.Name = "label8";
            label8.Size = new Size(67, 28);
            label8.TabIndex = 7;
            label8.Text = "Lưu ý:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnDecryptCaesar);
            panel2.Controls.Add(txtAlphabetDecrypt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtAlphabet);
            panel2.Controls.Add(txtCipherText);
            panel2.Location = new Point(428, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 337);
            panel2.TabIndex = 4;
            // 
            // btnDecryptCaesar
            // 
            btnDecryptCaesar.Location = new Point(227, 254);
            btnDecryptCaesar.Name = "btnDecryptCaesar";
            btnDecryptCaesar.Size = new Size(170, 42);
            btnDecryptCaesar.TabIndex = 7;
            btnDecryptCaesar.Text = "Decrypt";
            btnDecryptCaesar.UseVisualStyleBackColor = true;
            btnDecryptCaesar.Click += btnDecrypt_Click;
            // 
            // txtAlphabetDecrypt
            // 
            txtAlphabetDecrypt.BackColor = Color.White;
            txtAlphabetDecrypt.Font = new Font("Segoe UI", 10F);
            txtAlphabetDecrypt.ForeColor = SystemColors.WindowText;
            txtAlphabetDecrypt.Location = new Point(112, 122);
            txtAlphabetDecrypt.Name = "txtAlphabetDecrypt";
            txtAlphabetDecrypt.ReadOnly = true;
            txtAlphabetDecrypt.Size = new Size(446, 30);
            txtAlphabetDecrypt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 206);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 6;
            label5.Text = "Cipher text:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 70);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 5;
            label6.Text = "Alphabet:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(276, 9);
            label7.Name = "label7";
            label7.Size = new Size(77, 28);
            label7.TabIndex = 4;
            label7.Text = "Output";
            // 
            // txtAlphabet
            // 
            txtAlphabet.BackColor = Color.White;
            txtAlphabet.Font = new Font("Segoe UI", 10F);
            txtAlphabet.Location = new Point(112, 67);
            txtAlphabet.Name = "txtAlphabet";
            txtAlphabet.ReadOnly = true;
            txtAlphabet.Size = new Size(446, 30);
            txtAlphabet.TabIndex = 1;
            // 
            // txtCipherText
            // 
            txtCipherText.BackColor = Color.White;
            txtCipherText.Font = new Font("Segoe UI", 10F);
            txtCipherText.Location = new Point(110, 199);
            txtCipherText.Name = "txtCipherText";
            txtCipherText.ReadOnly = true;
            txtCipherText.Size = new Size(448, 30);
            txtCipherText.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnEncryptCaesar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPlainText);
            panel1.Controls.Add(txtInputK);
            panel1.Location = new Point(36, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 337);
            panel1.TabIndex = 3;
            // 
            // btnEncryptCaesar
            // 
            btnEncryptCaesar.Location = new Point(84, 254);
            btnEncryptCaesar.Name = "btnEncryptCaesar";
            btnEncryptCaesar.Size = new Size(170, 42);
            btnEncryptCaesar.TabIndex = 4;
            btnEncryptCaesar.Text = "Encrypt";
            btnEncryptCaesar.UseVisualStyleBackColor = true;
            btnEncryptCaesar.Click += btnEncryptCaesar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 206);
            label4.Name = "label4";
            label4.Size = new Size(22, 23);
            label4.TabIndex = 6;
            label4.Text = "k:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 67);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 5;
            label3.Text = "Plain text:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(135, 9);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 4;
            label2.Text = "Input";
            // 
            // txtPlainText
            // 
            txtPlainText.Font = new Font("Segoe UI", 10F);
            txtPlainText.Location = new Point(135, 67);
            txtPlainText.Multiline = true;
            txtPlainText.Name = "txtPlainText";
            txtPlainText.Size = new Size(183, 116);
            txtPlainText.TabIndex = 1;
            // 
            // txtInputK
            // 
            txtInputK.Font = new Font("Segoe UI", 10F);
            txtInputK.Location = new Point(135, 203);
            txtInputK.Name = "txtInputK";
            txtInputK.Size = new Size(183, 30);
            txtInputK.TabIndex = 0;
            txtInputK.KeyPress += txtInputK_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(405, 19);
            label1.Name = "label1";
            label1.Size = new Size(169, 31);
            label1.TabIndex = 2;
            label1.Text = "Mã hoá Caesar";
            // 
            // MonoalphabeticTab
            // 
            MonoalphabeticTab.Controls.Add(btnInstructionManual);
            MonoalphabeticTab.Controls.Add(groupBox2);
            MonoalphabeticTab.Controls.Add(groupBox1);
            MonoalphabeticTab.Controls.Add(label12);
            MonoalphabeticTab.Location = new Point(4, 29);
            MonoalphabeticTab.Name = "MonoalphabeticTab";
            MonoalphabeticTab.Padding = new Padding(3);
            MonoalphabeticTab.Size = new Size(1033, 614);
            MonoalphabeticTab.TabIndex = 1;
            MonoalphabeticTab.Text = "Đơn bảng";
            MonoalphabeticTab.UseVisualStyleBackColor = true;
            // 
            // btnInstructionManual
            // 
            btnInstructionManual.Location = new Point(842, 26);
            btnInstructionManual.Name = "btnInstructionManual";
            btnInstructionManual.Size = new Size(170, 42);
            btnInstructionManual.TabIndex = 17;
            btnInstructionManual.Text = "Instruction manual";
            btnInstructionManual.UseVisualStyleBackColor = true;
            btnInstructionManual.Click += btnInstructionManual_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txtPlainText_Decrypt);
            groupBox2.Controls.Add(btnDecryptMono);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(txtCipherText_Decrypt);
            groupBox2.Controls.Add(txtKey_Decrypt);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(562, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 485);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Decrypt";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(47, 337);
            label16.Name = "label16";
            label16.Size = new Size(86, 23);
            label16.TabIndex = 16;
            label16.Text = "Plain Text:";
            // 
            // txtPlainText_Decrypt
            // 
            txtPlainText_Decrypt.Font = new Font("Segoe UI", 10F);
            txtPlainText_Decrypt.Location = new Point(47, 363);
            txtPlainText_Decrypt.Multiline = true;
            txtPlainText_Decrypt.Name = "txtPlainText_Decrypt";
            txtPlainText_Decrypt.Size = new Size(342, 52);
            txtPlainText_Decrypt.TabIndex = 15;
            // 
            // btnDecryptMono
            // 
            btnDecryptMono.Location = new Point(140, 278);
            btnDecryptMono.Name = "btnDecryptMono";
            btnDecryptMono.Size = new Size(170, 42);
            btnDecryptMono.TabIndex = 14;
            btnDecryptMono.Text = "Decrypt";
            btnDecryptMono.UseVisualStyleBackColor = true;
            btnDecryptMono.Click += btnDecryptMono_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(47, 211);
            label15.Name = "label15";
            label15.Size = new Size(41, 23);
            label15.TabIndex = 12;
            label15.Text = "Key:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(47, 57);
            label18.Name = "label18";
            label18.Size = new Size(99, 23);
            label18.TabIndex = 9;
            label18.Text = "Cipher Text:";
            // 
            // txtCipherText_Decrypt
            // 
            txtCipherText_Decrypt.Font = new Font("Segoe UI", 10F);
            txtCipherText_Decrypt.Location = new Point(47, 83);
            txtCipherText_Decrypt.Multiline = true;
            txtCipherText_Decrypt.Name = "txtCipherText_Decrypt";
            txtCipherText_Decrypt.Size = new Size(342, 52);
            txtCipherText_Decrypt.TabIndex = 7;
            // 
            // txtKey_Decrypt
            // 
            txtKey_Decrypt.Font = new Font("Segoe UI", 10F);
            txtKey_Decrypt.Location = new Point(114, 208);
            txtKey_Decrypt.Name = "txtKey_Decrypt";
            txtKey_Decrypt.Size = new Size(275, 30);
            txtKey_Decrypt.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(txtCipherText_Encrypt);
            groupBox1.Controls.Add(btnEncryptMono);
            groupBox1.Controls.Add(lblKeyMono);
            groupBox1.Controls.Add(lblAlphabet);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(btnGenerateKey);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtPlainText_Encrypt);
            groupBox1.Controls.Add(txtKey_Encrypt);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(33, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 485);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Encrypt";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(44, 389);
            label17.Name = "label17";
            label17.Size = new Size(98, 23);
            label17.TabIndex = 18;
            label17.Text = "Cipher text:";
            // 
            // txtCipherText_Encrypt
            // 
            txtCipherText_Encrypt.Font = new Font("Segoe UI", 10F);
            txtCipherText_Encrypt.Location = new Point(44, 415);
            txtCipherText_Encrypt.Multiline = true;
            txtCipherText_Encrypt.Name = "txtCipherText_Encrypt";
            txtCipherText_Encrypt.Size = new Size(342, 52);
            txtCipherText_Encrypt.TabIndex = 17;
            // 
            // btnEncryptMono
            // 
            btnEncryptMono.Location = new Point(124, 334);
            btnEncryptMono.Name = "btnEncryptMono";
            btnEncryptMono.Size = new Size(170, 42);
            btnEncryptMono.TabIndex = 13;
            btnEncryptMono.Text = "Encrypt";
            btnEncryptMono.UseVisualStyleBackColor = true;
            btnEncryptMono.Click += btnEncryptMono_Click;
            // 
            // lblKeyMono
            // 
            lblKeyMono.AutoSize = true;
            lblKeyMono.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKeyMono.Location = new Point(44, 278);
            lblKeyMono.Name = "lblKeyMono";
            lblKeyMono.Size = new Size(41, 23);
            lblKeyMono.TabIndex = 12;
            lblKeyMono.Text = "Key:";
            // 
            // lblAlphabet
            // 
            lblAlphabet.AutoSize = true;
            lblAlphabet.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlphabet.Location = new Point(133, 215);
            lblAlphabet.Name = "lblAlphabet";
            lblAlphabet.Size = new Size(284, 23);
            lblAlphabet.TabIndex = 11;
            lblAlphabet.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(44, 215);
            label14.Name = "label14";
            label14.Size = new Size(83, 23);
            label14.TabIndex = 10;
            label14.Text = "Alphabet:";
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.Location = new Point(124, 150);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.Size = new Size(170, 42);
            btnGenerateKey.TabIndex = 8;
            btnGenerateKey.Text = "Generate Key";
            btnGenerateKey.UseVisualStyleBackColor = true;
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(44, 57);
            label13.Name = "label13";
            label13.Size = new Size(85, 23);
            label13.TabIndex = 9;
            label13.Text = "Plain text:";
            // 
            // txtPlainText_Encrypt
            // 
            txtPlainText_Encrypt.Font = new Font("Segoe UI", 10F);
            txtPlainText_Encrypt.Location = new Point(44, 83);
            txtPlainText_Encrypt.Multiline = true;
            txtPlainText_Encrypt.Name = "txtPlainText_Encrypt";
            txtPlainText_Encrypt.Size = new Size(342, 52);
            txtPlainText_Encrypt.TabIndex = 7;
            // 
            // txtKey_Encrypt
            // 
            txtKey_Encrypt.Font = new Font("Segoe UI", 10F);
            txtKey_Encrypt.Location = new Point(111, 275);
            txtKey_Encrypt.Name = "txtKey_Encrypt";
            txtKey_Encrypt.Size = new Size(275, 30);
            txtKey_Encrypt.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(401, 29);
            label12.Name = "label12";
            label12.Size = new Size(203, 31);
            label12.TabIndex = 3;
            label12.Text = "Mã hoá đơn bảng";
            // 
            // VigenereTab
            // 
            VigenereTab.Controls.Add(dataVigenereTable);
            VigenereTab.Controls.Add(txtResult_Vigenere);
            VigenereTab.Controls.Add(btnDecryptVigenere);
            VigenereTab.Controls.Add(btnEncryptVigenere);
            VigenereTab.Controls.Add(label34);
            VigenereTab.Controls.Add(txtKeyVigenere);
            VigenereTab.Controls.Add(label35);
            VigenereTab.Controls.Add(txtPlainTextVigenere);
            VigenereTab.Controls.Add(label33);
            VigenereTab.Location = new Point(4, 29);
            VigenereTab.Name = "VigenereTab";
            VigenereTab.Padding = new Padding(3);
            VigenereTab.Size = new Size(1033, 740);
            VigenereTab.TabIndex = 2;
            VigenereTab.Text = "Vigenere";
            VigenereTab.UseVisualStyleBackColor = true;
            // 
            // dataVigenereTable
            // 
            dataVigenereTable.ColumnHeadersHeight = 29;
            dataVigenereTable.Location = new Point(46, 238);
            dataVigenereTable.Name = "dataVigenereTable";
            dataVigenereTable.RowHeadersWidth = 51;
            dataVigenereTable.Size = new Size(951, 479);
            dataVigenereTable.TabIndex = 21;
            // 
            // txtResult_Vigenere
            // 
            txtResult_Vigenere.BackColor = Color.White;
            txtResult_Vigenere.Font = new Font("Segoe UI", 10F);
            txtResult_Vigenere.Location = new Point(649, 63);
            txtResult_Vigenere.Multiline = true;
            txtResult_Vigenere.Name = "txtResult_Vigenere";
            txtResult_Vigenere.ReadOnly = true;
            txtResult_Vigenere.Size = new Size(348, 156);
            txtResult_Vigenere.TabIndex = 20;
            // 
            // btnDecryptVigenere
            // 
            btnDecryptVigenere.Location = new Point(445, 167);
            btnDecryptVigenere.Name = "btnDecryptVigenere";
            btnDecryptVigenere.Size = new Size(170, 42);
            btnDecryptVigenere.TabIndex = 19;
            btnDecryptVigenere.Text = "Decrypt";
            btnDecryptVigenere.UseVisualStyleBackColor = true;
            btnDecryptVigenere.Click += btnDecryptVigenere_Click;
            // 
            // btnEncryptVigenere
            // 
            btnEncryptVigenere.Location = new Point(445, 76);
            btnEncryptVigenere.Name = "btnEncryptVigenere";
            btnEncryptVigenere.Size = new Size(170, 42);
            btnEncryptVigenere.TabIndex = 18;
            btnEncryptVigenere.Text = "Encrypt";
            btnEncryptVigenere.UseVisualStyleBackColor = true;
            btnEncryptVigenere.Click += btnEncryptVigenere_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label34.Location = new Point(46, 141);
            label34.Name = "label34";
            label34.Size = new Size(41, 23);
            label34.TabIndex = 17;
            label34.Text = "Key:";
            // 
            // txtKeyVigenere
            // 
            txtKeyVigenere.Font = new Font("Segoe UI", 10F);
            txtKeyVigenere.Location = new Point(46, 167);
            txtKeyVigenere.Multiline = true;
            txtKeyVigenere.Name = "txtKeyVigenere";
            txtKeyVigenere.Size = new Size(342, 52);
            txtKeyVigenere.TabIndex = 16;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label35.Location = new Point(46, 50);
            label35.Name = "label35";
            label35.Size = new Size(85, 23);
            label35.TabIndex = 15;
            label35.Text = "Plain text:";
            // 
            // txtPlainTextVigenere
            // 
            txtPlainTextVigenere.Font = new Font("Segoe UI", 10F);
            txtPlainTextVigenere.Location = new Point(46, 76);
            txtPlainTextVigenere.Multiline = true;
            txtPlainTextVigenere.Name = "txtPlainTextVigenere";
            txtPlainTextVigenere.Size = new Size(342, 52);
            txtPlainTextVigenere.TabIndex = 14;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.Location = new Point(420, 26);
            label33.Name = "label33";
            label33.Size = new Size(195, 31);
            label33.TabIndex = 5;
            label33.Text = "Mã hoá Vigenere";
            // 
            // PlayfairTab
            // 
            PlayfairTab.Controls.Add(panel_Playfair);
            PlayfairTab.Controls.Add(txtResult_Playfair);
            PlayfairTab.Controls.Add(btnDecryptPlayfair);
            PlayfairTab.Controls.Add(btnEncryptPlayfair);
            PlayfairTab.Controls.Add(label32);
            PlayfairTab.Controls.Add(txtKeyPlayfair);
            PlayfairTab.Controls.Add(label31);
            PlayfairTab.Controls.Add(txtPlainTextPlayfair);
            PlayfairTab.Controls.Add(label30);
            PlayfairTab.Location = new Point(4, 29);
            PlayfairTab.Name = "PlayfairTab";
            PlayfairTab.Padding = new Padding(3);
            PlayfairTab.Size = new Size(1033, 614);
            PlayfairTab.TabIndex = 3;
            PlayfairTab.Text = "Playfair";
            PlayfairTab.UseVisualStyleBackColor = true;
            // 
            // panel_Playfair
            // 
            panel_Playfair.Location = new Point(205, 340);
            panel_Playfair.Name = "panel_Playfair";
            panel_Playfair.Size = new Size(652, 236);
            panel_Playfair.TabIndex = 17;
            // 
            // txtResult_Playfair
            // 
            txtResult_Playfair.BackColor = Color.White;
            txtResult_Playfair.Font = new Font("Segoe UI", 10F);
            txtResult_Playfair.Location = new Point(626, 156);
            txtResult_Playfair.Multiline = true;
            txtResult_Playfair.Name = "txtResult_Playfair";
            txtResult_Playfair.ReadOnly = true;
            txtResult_Playfair.Size = new Size(348, 156);
            txtResult_Playfair.TabIndex = 16;
            // 
            // btnDecryptPlayfair
            // 
            btnDecryptPlayfair.Location = new Point(411, 270);
            btnDecryptPlayfair.Name = "btnDecryptPlayfair";
            btnDecryptPlayfair.Size = new Size(170, 42);
            btnDecryptPlayfair.TabIndex = 15;
            btnDecryptPlayfair.Text = "Decrypt";
            btnDecryptPlayfair.UseVisualStyleBackColor = true;
            btnDecryptPlayfair.Click += btnDecryptPlayfair_Click;
            // 
            // btnEncryptPlayfair
            // 
            btnEncryptPlayfair.Location = new Point(411, 156);
            btnEncryptPlayfair.Name = "btnEncryptPlayfair";
            btnEncryptPlayfair.Size = new Size(170, 42);
            btnEncryptPlayfair.TabIndex = 14;
            btnEncryptPlayfair.Text = "Encrypt";
            btnEncryptPlayfair.UseVisualStyleBackColor = true;
            btnEncryptPlayfair.Click += btnEncryptPlayfair_Click;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label32.Location = new Point(42, 234);
            label32.Name = "label32";
            label32.Size = new Size(41, 23);
            label32.TabIndex = 13;
            label32.Text = "Key:";
            // 
            // txtKeyPlayfair
            // 
            txtKeyPlayfair.Font = new Font("Segoe UI", 10F);
            txtKeyPlayfair.Location = new Point(42, 260);
            txtKeyPlayfair.Multiline = true;
            txtKeyPlayfair.Name = "txtKeyPlayfair";
            txtKeyPlayfair.Size = new Size(342, 52);
            txtKeyPlayfair.TabIndex = 12;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.Location = new Point(42, 120);
            label31.Name = "label31";
            label31.Size = new Size(85, 23);
            label31.TabIndex = 11;
            label31.Text = "Plain text:";
            // 
            // txtPlainTextPlayfair
            // 
            txtPlainTextPlayfair.Font = new Font("Segoe UI", 10F);
            txtPlainTextPlayfair.Location = new Point(42, 146);
            txtPlainTextPlayfair.Multiline = true;
            txtPlainTextPlayfair.Name = "txtPlainTextPlayfair";
            txtPlainTextPlayfair.Size = new Size(342, 52);
            txtPlainTextPlayfair.TabIndex = 10;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(411, 29);
            label30.Name = "label30";
            label30.Size = new Size(182, 31);
            label30.TabIndex = 4;
            label30.Text = "Mã hoá playfair";
            // 
            // OTPTab
            // 
            OTPTab.Controls.Add(panel4);
            OTPTab.Controls.Add(panel3);
            OTPTab.Controls.Add(label19);
            OTPTab.Location = new Point(4, 29);
            OTPTab.Name = "OTPTab";
            OTPTab.Padding = new Padding(3);
            OTPTab.Size = new Size(1033, 614);
            OTPTab.TabIndex = 4;
            OTPTab.Text = "OneTimePad";
            OTPTab.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label29);
            panel4.Controls.Add(txtCipherTextOTP);
            panel4.Controls.Add(label28);
            panel4.Controls.Add(txtIndexFinalOTP);
            panel4.Controls.Add(label27);
            panel4.Controls.Add(txtAlphabetOTP);
            panel4.Controls.Add(label26);
            panel4.Controls.Add(btnDecryptOTP);
            panel4.Controls.Add(txtIndexKeyOTP);
            panel4.Controls.Add(label23);
            panel4.Controls.Add(label24);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(txtFinalKeyOTP);
            panel4.Controls.Add(txtIndexPlainOTP);
            panel4.Location = new Point(426, 94);
            panel4.Name = "panel4";
            panel4.Size = new Size(582, 419);
            panel4.TabIndex = 5;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(0, 311);
            label29.Name = "label29";
            label29.Size = new Size(98, 23);
            label29.TabIndex = 14;
            label29.Text = "Cipher text:";
            // 
            // txtCipherTextOTP
            // 
            txtCipherTextOTP.BackColor = Color.White;
            txtCipherTextOTP.Font = new Font("Segoe UI", 10F);
            txtCipherTextOTP.Location = new Point(106, 308);
            txtCipherTextOTP.Name = "txtCipherTextOTP";
            txtCipherTextOTP.ReadOnly = true;
            txtCipherTextOTP.Size = new Size(448, 30);
            txtCipherTextOTP.TabIndex = 13;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.Location = new Point(0, 265);
            label28.Name = "label28";
            label28.Size = new Size(93, 23);
            label28.TabIndex = 12;
            label28.Text = "Index final:";
            // 
            // txtIndexFinalOTP
            // 
            txtIndexFinalOTP.BackColor = Color.White;
            txtIndexFinalOTP.Font = new Font("Segoe UI", 10F);
            txtIndexFinalOTP.Location = new Point(106, 262);
            txtIndexFinalOTP.Name = "txtIndexFinalOTP";
            txtIndexFinalOTP.ReadOnly = true;
            txtIndexFinalOTP.Size = new Size(448, 30);
            txtIndexFinalOTP.TabIndex = 11;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.Location = new Point(15, 63);
            label27.Name = "label27";
            label27.Size = new Size(83, 23);
            label27.TabIndex = 10;
            label27.Text = "Alphabet:";
            // 
            // txtAlphabetOTP
            // 
            txtAlphabetOTP.BackColor = Color.White;
            txtAlphabetOTP.Font = new Font("Segoe UI", 10F);
            txtAlphabetOTP.Location = new Point(108, 60);
            txtAlphabetOTP.Name = "txtAlphabetOTP";
            txtAlphabetOTP.ReadOnly = true;
            txtAlphabetOTP.Size = new Size(446, 30);
            txtAlphabetOTP.TabIndex = 9;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(10, 158);
            label26.Name = "label26";
            label26.Size = new Size(88, 23);
            label26.TabIndex = 8;
            label26.Text = "Index Key:";
            // 
            // btnDecryptOTP
            // 
            btnDecryptOTP.Location = new Point(210, 358);
            btnDecryptOTP.Name = "btnDecryptOTP";
            btnDecryptOTP.Size = new Size(170, 42);
            btnDecryptOTP.TabIndex = 7;
            btnDecryptOTP.Text = "Decrypt";
            btnDecryptOTP.UseVisualStyleBackColor = true;
            btnDecryptOTP.Click += btnDecryptOTP_Click;
            // 
            // txtIndexKeyOTP
            // 
            txtIndexKeyOTP.BackColor = Color.White;
            txtIndexKeyOTP.Font = new Font("Segoe UI", 10F);
            txtIndexKeyOTP.ForeColor = SystemColors.WindowText;
            txtIndexKeyOTP.Location = new Point(108, 158);
            txtIndexKeyOTP.Name = "txtIndexKeyOTP";
            txtIndexKeyOTP.ReadOnly = true;
            txtIndexKeyOTP.Size = new Size(446, 30);
            txtIndexKeyOTP.TabIndex = 7;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(0, 212);
            label23.Name = "label23";
            label23.Size = new Size(98, 23);
            label23.TabIndex = 6;
            label23.Text = "Index plain:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(17, 106);
            label24.Name = "label24";
            label24.Size = new Size(81, 23);
            label24.TabIndex = 5;
            label24.Text = "Final Key:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(276, 9);
            label25.Name = "label25";
            label25.Size = new Size(77, 28);
            label25.TabIndex = 4;
            label25.Text = "Output";
            // 
            // txtFinalKeyOTP
            // 
            txtFinalKeyOTP.BackColor = Color.White;
            txtFinalKeyOTP.Font = new Font("Segoe UI", 10F);
            txtFinalKeyOTP.Location = new Point(108, 103);
            txtFinalKeyOTP.Name = "txtFinalKeyOTP";
            txtFinalKeyOTP.ReadOnly = true;
            txtFinalKeyOTP.Size = new Size(446, 30);
            txtFinalKeyOTP.TabIndex = 1;
            // 
            // txtIndexPlainOTP
            // 
            txtIndexPlainOTP.BackColor = Color.White;
            txtIndexPlainOTP.Font = new Font("Segoe UI", 10F);
            txtIndexPlainOTP.Location = new Point(106, 209);
            txtIndexPlainOTP.Name = "txtIndexPlainOTP";
            txtIndexPlainOTP.ReadOnly = true;
            txtIndexPlainOTP.Size = new Size(448, 30);
            txtIndexPlainOTP.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnEncryptOTP);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(txtPlainTextOTP);
            panel3.Controls.Add(txtKeyOTP);
            panel3.Location = new Point(34, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(347, 419);
            panel3.TabIndex = 4;
            // 
            // btnEncryptOTP
            // 
            btnEncryptOTP.Location = new Point(84, 308);
            btnEncryptOTP.Name = "btnEncryptOTP";
            btnEncryptOTP.Size = new Size(170, 42);
            btnEncryptOTP.TabIndex = 4;
            btnEncryptOTP.Text = "Encrypt";
            btnEncryptOTP.UseVisualStyleBackColor = true;
            btnEncryptOTP.Click += btnEncryptOTP_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(65, 203);
            label20.Name = "label20";
            label20.Size = new Size(41, 23);
            label20.TabIndex = 6;
            label20.Text = "Key:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(21, 67);
            label21.Name = "label21";
            label21.Size = new Size(85, 23);
            label21.TabIndex = 5;
            label21.Text = "Plain text:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(135, 9);
            label22.Name = "label22";
            label22.Size = new Size(61, 28);
            label22.TabIndex = 4;
            label22.Text = "Input";
            // 
            // txtPlainTextOTP
            // 
            txtPlainTextOTP.Font = new Font("Segoe UI", 10F);
            txtPlainTextOTP.Location = new Point(135, 67);
            txtPlainTextOTP.Multiline = true;
            txtPlainTextOTP.Name = "txtPlainTextOTP";
            txtPlainTextOTP.Size = new Size(183, 116);
            txtPlainTextOTP.TabIndex = 1;
            // 
            // txtKeyOTP
            // 
            txtKeyOTP.Font = new Font("Segoe UI", 10F);
            txtKeyOTP.Location = new Point(135, 203);
            txtKeyOTP.Multiline = true;
            txtKeyOTP.Name = "txtKeyOTP";
            txtKeyOTP.Size = new Size(183, 72);
            txtKeyOTP.TabIndex = 0;
            txtKeyOTP.KeyPress += txtKeyOTP_KeyPress;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(389, 25);
            label19.Name = "label19";
            label19.Size = new Size(247, 31);
            label19.TabIndex = 3;
            label19.Text = "Mã hoá One Time Pad";
            // 
            // RailfenceTab
            // 
            RailfenceTab.Controls.Add(label38);
            RailfenceTab.Controls.Add(label37);
            RailfenceTab.Controls.Add(panel_RailFence);
            RailfenceTab.Controls.Add(txtResult_RailFence);
            RailfenceTab.Controls.Add(btnDecryptRailfence);
            RailfenceTab.Controls.Add(btnEncryptRailfence);
            RailfenceTab.Controls.Add(txtDepth);
            RailfenceTab.Controls.Add(label36);
            RailfenceTab.Controls.Add(txtPlainTextRailfence);
            RailfenceTab.Location = new Point(4, 29);
            RailfenceTab.Name = "RailfenceTab";
            RailfenceTab.Padding = new Padding(3);
            RailfenceTab.Size = new Size(1033, 614);
            RailfenceTab.TabIndex = 5;
            RailfenceTab.Text = "Rail fence";
            RailfenceTab.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label38.Location = new Point(50, 193);
            label38.Name = "label38";
            label38.Size = new Size(61, 23);
            label38.TabIndex = 26;
            label38.Text = "Depth:";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label37.Location = new Point(407, 19);
            label37.Name = "label37";
            label37.Size = new Size(205, 31);
            label37.TabIndex = 25;
            label37.Text = "Mã hoá Rail fence";
            // 
            // panel_RailFence
            // 
            panel_RailFence.Location = new Point(213, 299);
            panel_RailFence.Name = "panel_RailFence";
            panel_RailFence.Size = new Size(652, 268);
            panel_RailFence.TabIndex = 24;
            // 
            // txtResult_RailFence
            // 
            txtResult_RailFence.BackColor = Color.White;
            txtResult_RailFence.Font = new Font("Segoe UI", 10F);
            txtResult_RailFence.Location = new Point(634, 115);
            txtResult_RailFence.Multiline = true;
            txtResult_RailFence.Name = "txtResult_RailFence";
            txtResult_RailFence.ReadOnly = true;
            txtResult_RailFence.Size = new Size(348, 156);
            txtResult_RailFence.TabIndex = 23;
            // 
            // btnDecryptRailfence
            // 
            btnDecryptRailfence.Location = new Point(419, 229);
            btnDecryptRailfence.Name = "btnDecryptRailfence";
            btnDecryptRailfence.Size = new Size(170, 42);
            btnDecryptRailfence.TabIndex = 22;
            btnDecryptRailfence.Text = "Decrypt";
            btnDecryptRailfence.UseVisualStyleBackColor = true;
            btnDecryptRailfence.Click += btnDecryptRailfence_Click;
            // 
            // btnEncryptRailfence
            // 
            btnEncryptRailfence.Location = new Point(419, 115);
            btnEncryptRailfence.Name = "btnEncryptRailfence";
            btnEncryptRailfence.Size = new Size(170, 42);
            btnEncryptRailfence.TabIndex = 21;
            btnEncryptRailfence.Text = "Encrypt";
            btnEncryptRailfence.UseVisualStyleBackColor = true;
            btnEncryptRailfence.Click += btnEncryptRailfence_Click;
            // 
            // txtDepth
            // 
            txtDepth.Font = new Font("Segoe UI", 10F);
            txtDepth.Location = new Point(50, 219);
            txtDepth.Multiline = true;
            txtDepth.Name = "txtDepth";
            txtDepth.Size = new Size(342, 52);
            txtDepth.TabIndex = 20;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label36.Location = new Point(50, 79);
            label36.Name = "label36";
            label36.Size = new Size(85, 23);
            label36.TabIndex = 19;
            label36.Text = "Plain text:";
            // 
            // txtPlainTextRailfence
            // 
            txtPlainTextRailfence.Font = new Font("Segoe UI", 10F);
            txtPlainTextRailfence.Location = new Point(50, 105);
            txtPlainTextRailfence.Multiline = true;
            txtPlainTextRailfence.Name = "txtPlainTextRailfence";
            txtPlainTextRailfence.Size = new Size(342, 52);
            txtPlainTextRailfence.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 773);
            Controls.Add(TabControl);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            TabControl.ResumeLayout(false);
            CaesarTab.ResumeLayout(false);
            CaesarTab.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            MonoalphabeticTab.ResumeLayout(false);
            MonoalphabeticTab.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            VigenereTab.ResumeLayout(false);
            VigenereTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataVigenereTable).EndInit();
            PlayfairTab.ResumeLayout(false);
            PlayfairTab.PerformLayout();
            OTPTab.ResumeLayout(false);
            OTPTab.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            RailfenceTab.ResumeLayout(false);
            RailfenceTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage CaesarTab;
        private TabPage MonoalphabeticTab;
        private TabPage VigenereTab;
        private TabPage PlayfairTab;
        private TabPage OTPTab;
        private TabPage RailfenceTab;
        private Label label1;
        private TextBox txtPlainText;
        private TextBox txtInputK;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAlphabet;
        private TextBox txtCipherText;
        private Button btnEncryptCaesar;
        private TextBox txtAlphabetDecrypt;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnDecryptCaesar;
        private Label label12;
        private GroupBox groupBox1;
        private Button btnGenerateKey;
        private Label label13;
        private TextBox txtPlainText_Encrypt;
        private TextBox txtKey_Encrypt;
        private Button btnEncryptMono;
        private Label lblKeyMono;
        private Label lblAlphabet;
        private Label label14;
        private GroupBox groupBox2;
        private Button btnDecryptMono;
        private Label label15;
        private Label label18;
        private TextBox txtCipherText_Decrypt;
        private TextBox txtKey_Decrypt;
        private Button btnInstructionManual;
        private Label label16;
        private TextBox txtPlainText_Decrypt;
        private Label label17;
        private TextBox txtCipherText_Encrypt;
        private Label label19;
        private Panel panel4;
        private Button btnDecryptOTP;
        private TextBox txtIndexKeyOTP;
        private Label label23;
        private Label label25;
        private TextBox txtIndexPlainOTP;
        private Panel panel3;
        private Button btnEncryptOTP;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox txtPlainTextOTP;
        private TextBox txtKeyOTP;
        private Label label27;
        private TextBox txtAlphabetOTP;
        private Label label26;
        private Label label29;
        private TextBox txtCipherTextOTP;
        private Label label28;
        private TextBox txtIndexFinalOTP;
        private Label label24;
        private TextBox txtFinalKeyOTP;
        private Label label30;
        private Label label32;
        private TextBox txtKeyPlayfair;
        private Label label31;
        private TextBox txtPlainTextPlayfair;
        private TextBox txtResult_Playfair;
        private Button btnDecryptPlayfair;
        private Button btnEncryptPlayfair;
        private Panel panel_Playfair;
        private Label label33;
        private TextBox txtResult_Vigenere;
        private Button btnDecryptVigenere;
        private Button btnEncryptVigenere;
        private Label label34;
        private TextBox txtKeyVigenere;
        private Label label35;
        private TextBox txtPlainTextVigenere;
        private DataGridView dataVigenereTable;
        private Label label38;
        private Label label37;
        private Panel panel_RailFence;
        private TextBox txtResult_RailFence;
        private Button btnDecryptRailfence;
        private Button btnEncryptRailfence;
        private TextBox txtDepth;
        private Label label36;
        private TextBox txtPlainTextRailfence;
    }
}
