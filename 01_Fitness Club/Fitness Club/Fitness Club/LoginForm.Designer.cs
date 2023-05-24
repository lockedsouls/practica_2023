namespace Fitness_Club
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.TextBox();
            this.usernameL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(97, 156);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(288, 23);
            this.username.TabIndex = 0;
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameL.Location = new System.Drawing.Point(97, 132);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(81, 21);
            this.usernameL.TabIndex = 1;
            this.usernameL.Text = "Username";
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordL.Location = new System.Drawing.Point(97, 192);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(76, 21);
            this.passwordL.TabIndex = 3;
            this.passwordL.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(97, 216);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(288, 23);
            this.password.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(97, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.passwordL);
            this.groupBox1.Controls.Add(this.usernameL);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(139, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 444);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(740, 504);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox username;
        private Label usernameL;
        private Label passwordL;
        private TextBox password;
        private Button button1;
        private GroupBox groupBox1;
    }
}