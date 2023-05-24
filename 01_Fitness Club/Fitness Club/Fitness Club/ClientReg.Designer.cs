namespace Fitness_Club
{
    partial class ClientReg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rpassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.passwordL = new System.Windows.Forms.Label();
            this.usernameL = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cash);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rpassword);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.passwordL);
            this.groupBox1.Controls.Add(this.usernameL);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(152, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 444);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cash
            // 
            this.cash.Location = new System.Drawing.Point(97, 273);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(288, 23);
            this.cash.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cash (no lying)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(245, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Repeate password";
            // 
            // rpassword
            // 
            this.rpassword.Location = new System.Drawing.Point(245, 216);
            this.rpassword.Name = "rpassword";
            this.rpassword.Size = new System.Drawing.Size(140, 23);
            this.rpassword.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(97, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(97, 156);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(288, 23);
            this.username.TabIndex = 0;
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
            // password
            // 
            this.password.Location = new System.Drawing.Point(97, 216);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(140, 23);
            this.password.TabIndex = 2;
            // 
            // ClientReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(740, 504);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientReg";
            this.Text = "ClientReg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox username;
        private Label passwordL;
        private Label usernameL;
        private TextBox password;
        private Label label1;
        private TextBox rpassword;
        private TextBox cash;
        private Label label2;
    }
}