using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_project
{
    public partial class login : Form
    {
        string user,pass;
        public login()
        {
            InitializeComponent();
            label3.Text = "";
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = textBox1.Text;
            pass = textBox2.Text;

            if (user == "Admin" && pass == "Admin")
            {

                label3.Text = "Login Successfull";
                Options o = new Options();
                o.Show();
                this.Hide();
            }
            else if (user == "admin" && pass == "admin")
            {
                label3.Text = "Login Successfull";
                Instructor_op o = new Instructor_op();
                o.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or password,Try Again");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

        }
    }
}
