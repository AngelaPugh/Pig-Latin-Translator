namespace pigLatinTranslatorPart2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.instructionLabel1 = new System.Windows.Forms.Label();
            this.wordToTranslateBox = new System.Windows.Forms.TextBox();
            this.pigLatinWordlabel = new System.Windows.Forms.Label();
            this.pigLatinWordTextBox = new System.Windows.Forms.TextBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.encryptDecryptLabel = new System.Windows.Forms.Label();
            this.encryptedTextBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptKeyBox = new System.Windows.Forms.TextBox();
            this.encryptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionLabel1
            // 
            this.instructionLabel1.AutoSize = true;
            this.instructionLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel1.Location = new System.Drawing.Point(10, 17);
            this.instructionLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionLabel1.Name = "instructionLabel1";
            this.instructionLabel1.Size = new System.Drawing.Size(1053, 52);
            this.instructionLabel1.TabIndex = 0;
            this.instructionLabel1.Text = "Please enter an English word to be translated into Pig Latin below :";
            // 
            // wordToTranslateBox
            // 
            this.wordToTranslateBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordToTranslateBox.Location = new System.Drawing.Point(200, 73);
            this.wordToTranslateBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wordToTranslateBox.Multiline = true;
            this.wordToTranslateBox.Name = "wordToTranslateBox";
            this.wordToTranslateBox.Size = new System.Drawing.Size(610, 75);
            this.wordToTranslateBox.TabIndex = 1;
            // 
            // pigLatinWordlabel
            // 
            this.pigLatinWordlabel.AutoSize = true;
            this.pigLatinWordlabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pigLatinWordlabel.Location = new System.Drawing.Point(124, 250);
            this.pigLatinWordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pigLatinWordlabel.Name = "pigLatinWordlabel";
            this.pigLatinWordlabel.Size = new System.Drawing.Size(801, 51);
            this.pigLatinWordlabel.TabIndex = 2;
            this.pigLatinWordlabel.Text = "This is the word you entered translated to Pig Latin :";
            // 
            // pigLatinWordTextBox
            // 
            this.pigLatinWordTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pigLatinWordTextBox.Location = new System.Drawing.Point(200, 302);
            this.pigLatinWordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pigLatinWordTextBox.Multiline = true;
            this.pigLatinWordTextBox.Name = "pigLatinWordTextBox";
            this.pigLatinWordTextBox.Size = new System.Drawing.Size(610, 75);
            this.pigLatinWordTextBox.TabIndex = 3;
            // 
            // translateButton
            // 
            this.translateButton.BackColor = System.Drawing.Color.DarkGray;
            this.translateButton.Font = new System.Drawing.Font("Monotype Corsiva", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateButton.Location = new System.Drawing.Point(276, 160);
            this.translateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(186, 85);
            this.translateButton.TabIndex = 4;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = false;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkGray;
            this.clearButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(564, 162);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(186, 85);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkGray;
            this.exitButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(412, 806);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(186, 85);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // encryptDecryptLabel
            // 
            this.encryptDecryptLabel.AutoSize = true;
            this.encryptDecryptLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptDecryptLabel.Location = new System.Drawing.Point(142, 523);
            this.encryptDecryptLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.encryptDecryptLabel.Name = "encryptDecryptLabel";
            this.encryptDecryptLabel.Size = new System.Drawing.Size(539, 51);
            this.encryptDecryptLabel.TabIndex = 7;
            this.encryptDecryptLabel.Text = "Click the encrypt or decrypt button.";
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedTextBox.Location = new System.Drawing.Point(200, 673);
            this.encryptedTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.encryptedTextBox.Multiline = true;
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.Size = new System.Drawing.Size(610, 75);
            this.encryptedTextBox.TabIndex = 8;
            // 
            // encryptButton
            // 
            this.encryptButton.BackColor = System.Drawing.Color.DarkGray;
            this.encryptButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.Location = new System.Drawing.Point(276, 577);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(186, 85);
            this.encryptButton.TabIndex = 9;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = false;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.Color.DarkGray;
            this.decryptButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.Location = new System.Drawing.Point(564, 577);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(186, 85);
            this.decryptButton.TabIndex = 10;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptKeyBox
            // 
            this.encryptKeyBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptKeyBox.Location = new System.Drawing.Point(200, 438);
            this.encryptKeyBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.encryptKeyBox.Multiline = true;
            this.encryptKeyBox.Name = "encryptKeyBox";
            this.encryptKeyBox.Size = new System.Drawing.Size(610, 75);
            this.encryptKeyBox.TabIndex = 11;
            // 
            // encryptLabel
            // 
            this.encryptLabel.AutoSize = true;
            this.encryptLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptLabel.Location = new System.Drawing.Point(142, 385);
            this.encryptLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.encryptLabel.Name = "encryptLabel";
            this.encryptLabel.Size = new System.Drawing.Size(405, 51);
            this.encryptLabel.TabIndex = 12;
            this.encryptLabel.Text = "Enter an Encryption Key.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1064, 931);
            this.Controls.Add(this.encryptLabel);
            this.Controls.Add(this.encryptKeyBox);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.encryptedTextBox);
            this.Controls.Add(this.encryptDecryptLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.pigLatinWordTextBox);
            this.Controls.Add(this.pigLatinWordlabel);
            this.Controls.Add(this.wordToTranslateBox);
            this.Controls.Add(this.instructionLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Pig Latin Translator App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel1;
        private System.Windows.Forms.TextBox wordToTranslateBox;
        private System.Windows.Forms.Label pigLatinWordlabel;
        private System.Windows.Forms.TextBox pigLatinWordTextBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label encryptDecryptLabel;
        private System.Windows.Forms.TextBox encryptedTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox encryptKeyBox;
        private System.Windows.Forms.Label encryptLabel;
    }
}

