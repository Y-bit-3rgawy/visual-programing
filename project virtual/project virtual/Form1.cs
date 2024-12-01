using System;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace project_virtual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\yelar\\OneDrive\\المستندات\\Users.mdf;Integrated Security=True;Connect Timeout=30");
        private void button2_Click(object sender, EventArgs e)
        {
            String Password = textBox2.Text;
            string username = textBox1.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            try
            {
                connection.Open();
                string query = "INSERT INTO users (Username, Password) VALUES  (@Username, @Password)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                  
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                
                    int rowsAffected = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (rowsAffected > 0)
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        MessageBox.Show("Registration successful!");
                       
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
       
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
            
        }
    }
}

