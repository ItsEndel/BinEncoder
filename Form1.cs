namespace BinEncoder
{
    public partial class Form1 : Form
    {
        int seed = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void seedTextBox_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            foreach (char i in seedTextBox.Text)
            {
                num += i;
            }
            seed = num % 14 + 1;
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = encoder.encode(textBox.Text, encoder.seedParam(seed));
            }
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = encoder.decode(textBox.Text, encoder.seedParam(seed));
            }
        }
    }
}
