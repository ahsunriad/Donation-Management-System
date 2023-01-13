using Donation_Management_System_alpha_ver.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donation_Management_System_alpha_ver.Forms
{
    public partial class RegistrationForm : Form
    {
        string status="";

        public RegistrationForm()
        {
            InitializeComponent();

            //picbox 2-7 tb confirmation & valid check //animation
            pictureBox2.Hide(); 
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            
            pictureBox9.Hide();

            //picbox 10-15 tb wrong & invalid check //animation
            //pictureBox10.Hide();
            //pictureBox11.Hide();
            //pictureBox12.Hide();
            //pictureBox13.Hide();
            //pictureBox14.Hide();
            //pictureBox15.Hide();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private bool PhoneNumberCheck(string number)
        {
            //throw new NotImplementedException();
            if (Regex.Match(number, @"(013[0-9]{8})$").Success) { return true; }
            else if (Regex.Match(number, @"(014[0-9]{8})$").Success) { return true; }
            else if (Regex.Match(number, @"(015[0-9]{8})$").Success) { return true; }
            else if (Regex.Match(number, @"(016[0-9]{8})$").Success) { return true; }
            else if (Regex.Match(number, @"(017[0-9]{8})$").Success) { return true; }
            else if (Regex.Match(number, @"(018[0-9]{8})$").Success) { return true; }
            else if (Regex.Match(number, @"(019[0-9]{8})$").Success) { return true; }
            else { return false; }
        }

        private bool EmailCheck(string email)
        {
            //throw new NotImplementedException();
            if (Regex.Match(email, @"([a-z0-9]{1,20}@[a-z]{1,10}.[a-z]{3})$").Success){ return true; }
            else { return false; }
        }

        private void UserTypeCheck()
        {
            //throw new NotImplementedException();
            if (radioButton1.Checked)
            {
                status = "donor";

                pictureBox7.Show(); //animation
                pictureBox15.Hide(); //animation

                pictureBox9.Show(); //animation
            }
            else if (radioButton2.Checked)
            {
                status = "volunteer";

                pictureBox7.Show(); //animation
                pictureBox15.Hide(); //animation

                pictureBox9.Show(); //animation

            }
            else
            {
                pictureBox15.Show(); //animation
                pictureBox7.Hide(); //animation

                MessageBox.Show("User type not selected! ");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                pictureBox2.Show(); //animation
                pictureBox10.Hide(); //animation

                pictureBox9.Show(); //animation
            }
            else
            {
                pictureBox10.Show(); //animation
                pictureBox2.Hide(); //animation
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {  // int x;
        //IsPhoneNumber(x)?;
            //Regex.Match();
            if (textBox2.Text != "" && PhoneNumberCheck(textBox2.Text) == true)
            {
                pictureBox3.Show(); //animation
                pictureBox11.Hide(); //animation

                pictureBox9.Show(); //animation

                //PhoneNumberCheck();
                //MessageBox.Show("valid");
            }
            else
            {
                pictureBox11.Show(); //animation
                pictureBox3.Hide(); //animation

                MessageBox.Show("Invalid number !");
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && EmailCheck(textBox3.Text) == true)
            {
                pictureBox4.Show(); //animation
                pictureBox12.Hide(); //animation

                pictureBox9.Show(); //animation

                //check emails
            }
            else
            {
                pictureBox12.Show(); //animation
                pictureBox4.Hide(); //animation

                MessageBox.Show("Invalid email !");
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox4.Text == textBox5.Text)
            {
                pictureBox5.Show(); //animation
                pictureBox13.Hide(); //animation

                pictureBox6.Show(); //animation
                pictureBox14.Hide(); //animation

                pictureBox9.Show(); //animation
            }
            else
            {
                pictureBox13.Show(); //animation
                pictureBox5.Hide(); //animation

                pictureBox14.Show(); //animation
                pictureBox6.Hide(); //animation
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox4.Text == textBox5.Text)
            {
                pictureBox6.Show(); //animation
                pictureBox14.Hide(); //animation

                pictureBox5.Show(); //animation
                pictureBox13.Hide(); //animation

                pictureBox9.Show(); //animation
            }
            else
            {
                pictureBox14.Show(); //animation
                pictureBox6.Hide(); //animation

                pictureBox13.Show(); //animation
                pictureBox5.Hide(); //animation
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox4.Text == textBox5.Text && status !="")
            {
                //pictureBox7.Show(); //animation
                pictureBox9.Show(); //animation
                pictureBox9.BackColor = System.Drawing.Color.GreenYellow; // login success case
                MessageBox.Show(textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + status);
                MessageBox.Show("Done");

                // send to db
            }
            else
            {
                pictureBox9.Show(); //animation
                pictureBox9.BackColor = System.Drawing.Color.Crimson; // login success case
                MessageBox.Show(textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + status);
                MessageBox.Show(" error");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // send to login

            //LoginForm lf = new LoginForm();
            //base.Show();
            //this.Hide();
           // Home hf = new Home();
            //hf.Show();
        }

        private void radioButton1_Leave(object sender, EventArgs e)
        {
            UserTypeCheck();
        }

        private void radioButton2_Leave(object sender, EventArgs e)
        {
            UserTypeCheck();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            status = "admin";
            pictureBox7.Show(); //animation
            pictureBox15.Hide(); //animation
        }


    }
}
