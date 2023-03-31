namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tal1 =int.Parse(textBox1.Text);
            int tal2 =int.Parse(textBox2.Text);

            int Tal = tal1 + tal2;

            string text = Tal.ToString();

            label4.Text = text;
            BackColor = Color.AliceBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);

            int Tal = tal1 - tal2;

            string text = Tal.ToString();

            label4.Text = text;
            BackColor = Color.DarkRed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);

            int Tal = tal1 * tal2;

            string text = Tal.ToString();

            label4.Text = text;
            BackColor = Color.Tan;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);

            double Tal = tal1 / tal2;

            string text = Tal.ToString();

            label4.Text = text;
            BackColor = Color.LightGreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Khaki;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(textBox3.Text);

            float x = tal++;

            string text = tal.ToString();
            label7.Text = text;
        }
    }
}