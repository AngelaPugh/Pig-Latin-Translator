using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pigLatinTranslatorPart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string firstletter;
            string restOfTheWord;
            firstletter = wordToTranslateBox.Text[0].ToString().ToLower();
            string strText = wordToTranslateBox.Text;
            string[] Array = strText.Split();
            int CharCount = strText.Length;
            
            


            for (int index = 0; index < strText.Length; index += 1)
            {
                

                if (firstletter == "a" || firstletter == "e" || firstletter == "i" || firstletter == "o" || firstletter == "u" || firstletter == "y")
                {
                    pigLatinWordTextBox.Text = strText + "way";
                }
                else
                {
                    restOfTheWord = strText.Substring(1, CharCount - 1);
                    pigLatinWordTextBox.Text = restOfTheWord + firstletter + "ay";
                }
            }

            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            wordToTranslateBox.Text = "";
            pigLatinWordTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string EncryptedString = "";
            
            int Key = int.Parse(encryptKeyBox.Text);

            foreach (char Letter in pigLatinWordTextBox.Text)
            {
                char EncryptedLetter = Convert.ToChar(Letter + Key);
                EncryptedString += EncryptedLetter;
                
            }
                encryptedTextBox.Text = EncryptedString;
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string DecryptedString = "";
            int Key = int.Parse(encryptKeyBox.Text);
            

            foreach (char Letter in encryptedTextBox.Text)
            {
                char DecryptedLetter = Convert.ToChar(Letter - Key);
                DecryptedString += DecryptedLetter;
            }
            encryptedTextBox.Text = DecryptedString;
        }
    }
}
