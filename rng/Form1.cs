namespace rng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = (int)numericUpDown1.Value;
            int b = (int)numericUpDown2.Value;
            string[] c = textBox2.Lines;
            Random rnd = new Random();

            int num = rnd.Next(a, b + 1);

            if (checkBox1.Checked)
            {
                while (c.Contains(num.ToString()))
                {
                    num = rnd.Next(a, b + 1);
                }
            }
            label5.Visible = true;
            label5.Text = num.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            label5.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
            }

        }
    }
}