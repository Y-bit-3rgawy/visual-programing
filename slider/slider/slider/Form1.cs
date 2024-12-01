namespace slider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int count = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (count < 28)
            {
                count++;
            }
            label3.Text = (count + 1).ToString();
            pictureBox1.Image = imageList1.Images[count];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }
            label3.Text = (count + 1).ToString();
            pictureBox1.Image = imageList1.Images[count];

        }
    }
}