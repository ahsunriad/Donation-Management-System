using Donation_Management_System_alpha_ver.Forms;
using Donation_Management_System_alpha_ver.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donation_Management_System_alpha_ver
{
    public partial class LoginForm : Form
    {
        LoginService login;
        public LoginForm()
        {
            InitializeComponent();
            login = new LoginService();

            pictureBox3.Hide(); //animation
            pictureBox5.Hide(); //animation
            pictureBox6.Hide(); //animation          
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


// login textbox manipulations (tb1=usern, tb2=passmask, tb3=passfinal, btn1=showpass, btn2=login)


        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            pictureBox6.Show(); //animation
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox6.Show(); //animation
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Hide();
            pictureBox6.Show(); //animation
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            textBox2.Hide();
            pictureBox6.Show(); //animation
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text;
            textBox2.Show();
            textBox3.Hide();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            textBox3.Show();
            textBox2.Hide();
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                int status = login.LoginServiceValidation(textBox1.Text, textBox3.Text); ; ///passtologinserv;
                if (status > 0)
                {
                    if (status == 1)
                    {
                        pictureBox2.BackColor = System.Drawing.Color.GreenYellow; // login success case
                        pictureBox3.Show(); //animation
                        MessageBox.Show("Login Successful");

                        Home home = new Home();
                        this.Hide();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("You do not have the priviledge");
                    }
                }
            }

            pictureBox2.BackColor = System.Drawing.Color.GreenYellow; // login success case
            pictureBox3.Show(); //animation
            MessageBox.Show("Login Successful");


            //pictureBox2.BackColor = System.Drawing.Color.Crimson; // login error case
            //pictureBox5.Show(); //animation
            //MessageBox.Show("Login Failed");

            //MessageBox.Show(textBox3.Text);  // password backdoor test (textBox2.Text)
            
            
            //home page
            //Home h = new Home();
            //h.Show();
            //this.Hide();

        }


//


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //registration page
            RegistrationForm rf = new RegistrationForm();
            rf.Show();
            this.Hide();
            
        }
    }
}
