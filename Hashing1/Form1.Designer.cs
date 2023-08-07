namespace Hashing1
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
            VerifyMacButton = new Button();
            ComputeMacButton = new Button();
            algorithComboBox = new ComboBox();
            keyTextBox = new TextBox();
            plainTextBox = new TextBox();
            MacTextBoxAscii = new TextBox();
            MacTextBoxHex = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // VerifyMacButton
            // 
            VerifyMacButton.Location = new Point(91, 234);
            VerifyMacButton.Name = "VerifyMacButton";
            VerifyMacButton.Size = new Size(145, 54);
            VerifyMacButton.TabIndex = 0;
            VerifyMacButton.Text = "Verify MAC";
            VerifyMacButton.UseVisualStyleBackColor = true;
            VerifyMacButton.Click += VerifyMacButton_Click;
            // 
            // ComputeMacButton
            // 
            ComputeMacButton.Location = new Point(91, 172);
            ComputeMacButton.Name = "ComputeMacButton";
            ComputeMacButton.Size = new Size(145, 56);
            ComputeMacButton.TabIndex = 1;
            ComputeMacButton.Text = "Compute MAC";
            ComputeMacButton.UseVisualStyleBackColor = true;
            ComputeMacButton.Click += ComputeMacButton_Click;
            // 
            // algorithComboBox
            // 
            algorithComboBox.FormattingEnabled = true;
            algorithComboBox.Items.AddRange(new object[] { "SHA1", "SHA256", "SHA512", "MD5" });
            algorithComboBox.Location = new Point(91, 80);
            algorithComboBox.Name = "algorithComboBox";
            algorithComboBox.Size = new Size(151, 28);
            algorithComboBox.TabIndex = 2;
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(394, 81);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(125, 27);
            keyTextBox.TabIndex = 3;
            // 
            // plainTextBox
            // 
            plainTextBox.Location = new Point(595, 81);
            plainTextBox.Name = "plainTextBox";
            plainTextBox.Size = new Size(125, 27);
            plainTextBox.TabIndex = 4;
            // 
            // MacTextBoxAscii
            // 
            MacTextBoxAscii.Location = new Point(394, 187);
            MacTextBoxAscii.Name = "MacTextBoxAscii";
            MacTextBoxAscii.Size = new Size(400, 27);
            MacTextBoxAscii.TabIndex = 5;
            // 
            // MacTextBoxHex
            // 
            MacTextBoxHex.Location = new Point(394, 234);
            MacTextBoxHex.Name = "MacTextBoxHex";
            MacTextBoxHex.Size = new Size(400, 27);
            MacTextBoxHex.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(433, 58);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 7;
            label1.Text = "Key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(619, 58);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 8;
            label2.Text = "Plain Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 164);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 9;
            label3.Text = "MAC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 83);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 10;
            label4.Text = "ASCII";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(545, 84);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 11;
            label5.Text = "ASCII";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 190);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 12;
            label6.Text = "ASCII";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(351, 237);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 13;
            label7.Text = "HEX";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MacTextBoxHex);
            Controls.Add(MacTextBoxAscii);
            Controls.Add(plainTextBox);
            Controls.Add(keyTextBox);
            Controls.Add(algorithComboBox);
            Controls.Add(ComputeMacButton);
            Controls.Add(VerifyMacButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button VerifyMacButton;
        private Button ComputeMacButton;
        private ComboBox algorithComboBox;
        private TextBox keyTextBox;
        private TextBox plainTextBox;
        private TextBox MacTextBoxAscii;
        private TextBox MacTextBoxHex;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}