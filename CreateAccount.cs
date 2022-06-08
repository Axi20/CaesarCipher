using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Caesar
{
    public partial class CreateAccount : UserControl
    {
        
        public CreateAccount()
        {
            InitializeComponent();
           
        }

        bool usnValid;
        bool pswValid;
        bool emailValid;
      
        public void emailValidation()
        {
           // Auth auth = new Auth();
            try
            {
                new System.Net.Mail.MailAddress(this.email.Text);
                //Auth auth = new Auth();
                //auth.emailClass = email.Text;
                emailValid = true;
            }
            catch (ArgumentException)
            {
                //textBox is empty
                MessageBox.Show("Empty email field", "Invalid", MessageBoxButtons.OK);
                emailValid = false;
            }
            catch (FormatException)
            {
                //textBox contains no valid mail address
                MessageBox.Show("Give a valid email address!", "Invalid", MessageBoxButtons.OK);
                emailValid = false;
            }
        }

        public void passwordValidation()
        {
            if (string.IsNullOrEmpty(passwordCRTA.Text))
            {
                MessageBox.Show("Empty password field", "Invalid", MessageBoxButtons.OK);
                pswValid = false;
                return;
            }
            else
            {
                 //Auth auth = new Auth();
                //auth.passwordClass = passwordCRTA.Text;
                pswValid = true;
            }
        }

        public void usernameValidation()
        {
            if (string.IsNullOrEmpty(usernameCRTA.Text))
            {
                MessageBox.Show("Empty username field", "Invalid", MessageBoxButtons.OK);
                usnValid = false;
                return;
            }
            else
            {
                //Auth auth = new Auth();
                //auth.usernameClass = usernameCRTA.Text;
                usnValid = true;
            }
        }

        //Next button 
        private void nextButton_Click(object sender, EventArgs e)
        {
            //Auth auth = new Auth();
            emailValidation();
            passwordValidation();
            usernameValidation();
            if(emailValid == true && usnValid == true && pswValid == true)
            {
                StreamWriter sw = new StreamWriter("Credentials.txt", true, Encoding.UTF8);
                Auth auth = new Auth();
                auth.usernameClass = usernameCRTA.Text;
                sw.WriteLine(usernameCRTA.Text);
                auth.passwordClass = passwordCRTA.Text;
                sw.WriteLine(passwordCRTA.Text);
                auth.emailClass = email.Text;
                sw.WriteLine(email.Text);
                sw.Dispose();
                //sw.AutoFlush();
                sw.Close();
                Decrypt dec = new Decrypt();
                this.Controls.Add(dec);
                panel1.Hide();
            }
        }

        
    }
}
