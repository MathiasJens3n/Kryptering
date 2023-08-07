using System.Text;

namespace Hashing1
{
    public partial class Form1 : Form
    {
        Hasher hasher;
        string plainText;
        string key;
        string algorithm;
        public Form1()
        {
            InitializeComponent();
        }

        private void ComputeMacButton_Click(object sender, EventArgs e)
        {
            algorithm = algorithComboBox.Text;
            plainText = plainTextBox.Text;
            key = keyTextBox.Text;

            hasher = new Hasher(algorithm);
            MacTextBoxAscii.Text = BitConverter.ToString(hasher.ComputeMAC(Encoding.ASCII.GetBytes(plainText), Encoding.ASCII.GetBytes(key)));

            MacTextBoxHex.Text = Convert.ToHexString(hasher.ComputeMAC(Encoding.ASCII.GetBytes(plainText), Encoding.ASCII.GetBytes(key)));


        }

        private void VerifyMacButton_Click(object sender, EventArgs e)
        {

        }
    }
}