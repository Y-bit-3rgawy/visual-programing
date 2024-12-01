using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project_virtual
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\yelar\\OneDrive\\المستندات\\Users.mdf;Integrated Security=True;Connect Timeout=30");
        private void login_clic_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string password = textBox4.Text;

            if (username != "" && password != "")
            {
                string query = "select count(*) from Users where username='" + username + "'and password ='" + password + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int v = (int)cmd.ExecuteScalar();
                if (v != 1)
                {
                    MessageBox.Show("Please enter both username and password.");


                }
                else
                {
                    MessageBox.Show("welcome profile");
                    username = "";
                    password = "";
                }

            }
            else { MessageBox.Show("fill in the blanks"); }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
