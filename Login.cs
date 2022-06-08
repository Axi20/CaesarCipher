using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

      

        
        //Login button
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (username.Text == LoginType.usn && password.Text == LoginType.psw)
            {
                if(MessageBox.Show("Login success", "Login", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    
                    
                    Decrypt dec = new Decrypt();
                    this.Controls.Add(dec);
                    panel1.Hide();
                 
                    

                }
                else if (username.Text != LoginType.usn && password.Text == LoginType.psw)
                {
                    MessageBox.Show("Wrong username!", "Error");
                }
                else if (username.Text == LoginType.usn && password.Text != LoginType.psw)
                {
                    MessageBox.Show("Wrong password!", "Error");
                }
                else
                {
                    MessageBox.Show("Wrong username or password!", "Login failed");
                }
            }
        }

       
    }
}
