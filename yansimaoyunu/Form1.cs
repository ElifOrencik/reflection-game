namespace yansimaoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.BackColor = Color.Magenta;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 1) { button1.BackColor = Color.RebeccaPurple; }
            if (i == 30) { button1.BackColor = Color.DarkGreen; }
            if (i == 60) { button1.BackColor = Color.GreenYellow; }
            if (i == 90) i = 0;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}