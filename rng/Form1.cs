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
            Random rnd = new Random();

            
            int num = rnd.Next(a, b + 1);
            if (checkBox1.Checked )
            {


                if (num == 2 || num == 3 || num == 4 || num == 5) { num = 1; }
            }
            textBox1.Text = num.ToString();
        }
    }
}