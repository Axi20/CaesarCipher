namespace Caesar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.guestAccountButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::Caesar.Properties.Resources.wp1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.guestAccountButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.createAccountButton);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 763);
            this.panel1.TabIndex = 0;
            // 
            // guestAccountButton
            // 
            this.guestAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestAccountButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guestAccountButton.Location = new System.Drawing.Point(774, 381);
            this.guestAccountButton.Name = "guestAccountButton";
            this.guestAccountButton.Size = new System.Drawing.Size(308, 52);
            this.guestAccountButton.TabIndex = 5;
            this.guestAccountButton.Text = "Guest account";
            this.guestAccountButton.UseVisualStyleBackColor = true;
            this.guestAccountButton.Click += new System.EventHandler(this.guestAccountButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(840, 530);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(163, 47);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createAccountButton.Location = new System.Drawing.Point(774, 456);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(308, 52);
            this.createAccountButton.TabIndex = 3;
            this.createAccountButton.Text = "Create account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(840, 317);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(163, 48);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caesar Cipher Program";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 787);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button exitButton;
        private Button createAccountButton;
        private Button loginButton;
        private Label label1;
        private Button guestAccountButton;
    }
}