using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Data;

namespace Caesar
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            //this.textbox = int.Parse(textBox1.Text);
            InitializeComponent();
        }

        //Login button
        private void loginButton_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Controls.Add(log);
            panel1.Hide();
        }

       

        //Create account button
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccount crta = new CreateAccount();
            this.Controls.Add(crta);
            panel1.Hide();
        }


        //Guest account button
        private void guestAccountButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You can use this program with a guest account but you can't save your work. Do you want to continue?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Decrypt dec = new Decrypt();
                this.Controls.Add(dec);
                panel1.Hide();
                LoginType.setValueForType1 = "Login with Guest account";
            }
        }

        //Exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}