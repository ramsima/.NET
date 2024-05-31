namespace WinFormsApp1
{
    public partial class Form1 : child1
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidateNumericInput(TextBox textBox)

        {

            if (!int.TryParse(textBox.Text, out _))

            {

                textBox.Text = string.Empty;

                MessageBox.Show("Please enter a Digit.");

            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateNumericInput(textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ValidateNumericInput(textBox2);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int z = x + y;
            textBox3.Text = z.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int z = x - y;
            textBox3.Text = z.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int z = x * y;
            textBox3.Text = z.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float x = int.Parse(textBox1.Text);
            float y = int.Parse(textBox2.Text);
            if (y == 0)
            {
                textBox3.Text = "Invalid";
            }
            else
            {
                float z = x / y;
                textBox3.Text = z.ToString();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
