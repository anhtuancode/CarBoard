using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using DAL;
namespace GUI
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        SqlConnection con = Connection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "")
            {
                MessageBox.Show("Username or password are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtComPassword.Text)
            {
                string role = "Staff"; // Mặc định là Staff

                try
                {
                    con.Open();
                    string register = "INSERT INTO tbl_users (username, password, role) VALUES (@username, @password, @role)";
                    cmd = new SqlCommand(register, con);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtComPassword.Text = "";

                    MessageBox.Show("Your Account has been Successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password does not match, Please try again", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cccd_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if(Showpassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtComPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
