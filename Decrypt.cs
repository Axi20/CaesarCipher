using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*  char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm','n','o','p','q','r','s','t','u','v','w','x','y','z'};
    
    ENCRYPTION  C = E = (p + k) mod 26      DECRYPTION  p = D = (C - k) mod 26

    C = cipher     
    E = encrypt
    p = plain text 
    k = key        
    26 = letters of the abc
   
    https://www.youtube.com/watch?v=JtbKh_12ctg  */
namespace Caesar
{
    public partial class Decrypt : UserControl
    {
        class keyInput
        {
            public string textbox { get; set; }
        }

       
        public Decrypt()
        {
            InitializeComponent();
        }

        static string CaesarEncryption(string text, int SHIFT_KEY)
        {
            string encryptedText = string.Empty;
            char outChar;
            char lowerLimit;
            char upperLimit;

            char[] letters = text.ToCharArray();

            foreach (Char ch in letters)
            {
                if (Char.IsLetter(ch) == false)
                    outChar = ch;
                else
                {
                    outChar = (char)(ch + SHIFT_KEY);
                    if (Char.IsLower(ch))
                    {
                        lowerLimit = 'a';
                        upperLimit = 'z';
                    }
                    else
                    {
                        lowerLimit = 'A';
                        upperLimit = 'Z';
                    }
                    if (outChar > upperLimit)
                        outChar = (char)(outChar - 26);
                    else if (outChar < lowerLimit)
                        outChar = (char)(outChar + 26);
                }
                encryptedText = encryptedText + outChar;
            }
            return encryptedText;
        }

        private void Encryption(string text)
        {
            /* keyInput = int.Parse(textBox1.Text);   
             string inputText = richTextBox1.Text;
             string cipherText = CaesarEncryption(inputText, keyInput);
             richTextBox2.Text = cipherText.ToString();
             richTextBox2.Visible = false;*/

            try
            {
                keyInput key = new keyInput();
                key.textbox = textBox1.Text;

                //keyInput = int.Parse(textBox1.Text);
                string inputText = richTextBox1.Text;
                string cipherText = CaesarEncryption(inputText, int.Parse(key.textbox));
                richTextBox2.Text = cipherText.ToString();
                richTextBox2.Visible = false;
            }
            catch (Exception)
            {

                if (textBox1.Text == "")
                    MessageBox.Show("Please enter a key number");
            }
        }

        //Encrypt button
        private void encryptButton_Click(object sender, EventArgs e)
        {
            keyInput key = new keyInput();
            key.textbox = textBox1.Text.ToString();

            if (int.Parse(key.textbox) > 0 && int.Parse(key.textbox) <= 26)
                Encryption(richTextBox1.Text);
            else
                MessageBox.Show("The key cannot be smaller than 0 and cannot be larger than 26");

            //richTextBox3.Text = "Click the show button below to see the encrypted text";
            //richTextBox3.Visible = false;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a key number");
            }
        }

        //Decrypt button
        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            richTextBox1.Text = string.Empty;
            richTextBox2.Text = String.Empty;
        }

        private void Decrypt_Load(object sender, EventArgs e) 
        {
            label5.Text = LoginType.setValueForType1;
            
            /*Auth auth = new Auth();
            label6.Text = auth.usernameClass;
            label7.Text = auth.passwordClass;
            label8.Text = auth.emailClass;*/
        }

        //Show button
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
        }

        //Hide button
        private void hideButton_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
        }

        //Exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
