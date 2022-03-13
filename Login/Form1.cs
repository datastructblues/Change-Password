using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((newPasswordText1.MaskFull && newPasswordText2.MaskFull) == false)
            {
                MessageBox.Show("Missing Character");
            }
            else
            {
                if (newPasswordText2.Text == newPasswordText1.Text)
                {
                    MessageBox.Show("Password has changed.");
                    passwordText.Text = newPasswordText1.Text;
                    newPasswordText1.Clear();
                    newPasswordText2.Clear();
                }
                else
                {
                    MessageBox.Show("Passwords are not same");

                }
            }
         

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true){
                newPasswordText1.PasswordChar = '\0';
                newPasswordText2.PasswordChar = '\0';
            }
            else
            {
                newPasswordText1.PasswordChar = '*';
                newPasswordText2.PasswordChar = '*';
            }
           
           }

      
    }
}
