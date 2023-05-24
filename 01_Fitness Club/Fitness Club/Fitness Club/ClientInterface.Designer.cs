namespace Fitness_Club
{
    partial class ClientInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameL = new System.Windows.Forms.Label();
            this.subscriptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(169, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome back";
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameL.Location = new System.Drawing.Point(355, 44);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(226, 37);
            this.usernameL.TabIndex = 1;
            this.usernameL.Text = "[username here]";
            // 
            // subscriptions
            // 
            this.subscriptions.BackColor = System.Drawing.Color.Honeydew;
            this.subscriptions.FlatAppearance.BorderSize = 2;
            this.subscriptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subscriptions.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subscriptions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subscriptions.Location = new System.Drawing.Point(29, 105);
            this.subscriptions.Name = "subscriptions";
            this.subscriptions.Size = new System.Drawing.Size(195, 56);
            this.subscriptions.TabIndex = 3;
            this.subscriptions.Text = "Membership info";
            this.subscriptions.UseVisualStyleBackColor = false;
            this.subscriptions.Click += new System.EventHandler(this.subscriptions_Click);
            // 
            // ClientInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(740, 504);
            this.Controls.Add(this.subscriptions);
            this.Controls.Add(this.usernameL);
            this.Controls.Add(this.label1);
            this.Name = "ClientInterface";
            this.Text = "ClientInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label usernameL;
        private Button subscriptions;
    }
}