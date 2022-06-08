namespace Caesar
{
    partial class CreateAccount
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordCRTA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameCRTA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::Caesar.Properties.Resources.wp1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 763);
            this.panel1.TabIndex = 0;
            // 
            // nextButton
            // 
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(165, 339);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(112, 34);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // email
            // 
            this.email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.email.Location = new System.Drawing.Point(165, 220);
            this.email.Name = "email";
            this.email.PlaceholderText = "example@yahoo.com";
            this.email.Size = new System.Drawing.Size(242, 31);
            this.email.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // passwordCRTA
            // 
            this.passwordCRTA.Location = new System.Drawing.Point(165, 132);
            this.passwordCRTA.Name = "passwordCRTA";
            this.passwordCRTA.Size = new System.Drawing.Size(242, 31);
            this.passwordCRTA.TabIndex = 5;
            this.passwordCRTA.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // usernameCRTA
            // 
            this.usernameCRTA.Location = new System.Drawing.Point(165, 49);
            this.usernameCRTA.Name = "usernameCRTA";
            this.usernameCRTA.Size = new System.Drawing.Size(242, 31);
            this.usernameCRTA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(275, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(587, 81);
            this.label5.TabIndex = 9;
            this.label5.Text = "Create new account";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.usernameCRTA);
            this.panel2.Controls.Add(this.nextButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.email);
            this.panel2.Controls.Add(this.passwordCRTA);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(703, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 499);
            this.panel2.TabIndex = 10;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CreateAccount";
            this.Size = new System.Drawing.Size(1234, 843);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox email;
        private Label label4;
        private TextBox passwordCRTA;
        private Label label3;
        private TextBox usernameCRTA;
        private Button nextButton;
        private Label label5;
        private Panel panel2;
    }
}
