namespace Fitness_Club
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleL = new System.Windows.Forms.Label();
            this.loginB = new System.Windows.Forms.Button();
            this.regB = new System.Windows.Forms.Button();
            this.jobB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(137, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(202, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleL
            // 
            this.titleL.AutoSize = true;
            this.titleL.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleL.Location = new System.Drawing.Point(352, 164);
            this.titleL.Name = "titleL";
            this.titleL.Size = new System.Drawing.Size(170, 37);
            this.titleL.TabIndex = 1;
            this.titleL.Text = "Fitness Club";
            this.titleL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginB
            // 
            this.loginB.BackColor = System.Drawing.Color.Honeydew;
            this.loginB.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginB.FlatAppearance.BorderSize = 2;
            this.loginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginB.Location = new System.Drawing.Point(40, 243);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(175, 56);
            this.loginB.TabIndex = 2;
            this.loginB.Text = "Login";
            this.loginB.UseVisualStyleBackColor = false;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // regB
            // 
            this.regB.BackColor = System.Drawing.Color.Honeydew;
            this.regB.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regB.FlatAppearance.BorderSize = 2;
            this.regB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regB.Location = new System.Drawing.Point(250, 243);
            this.regB.Name = "regB";
            this.regB.Size = new System.Drawing.Size(195, 56);
            this.regB.TabIndex = 3;
            this.regB.Text = "Become member";
            this.regB.UseVisualStyleBackColor = false;
            this.regB.Click += new System.EventHandler(this.regB_Click);
            // 
            // jobB
            // 
            this.jobB.BackColor = System.Drawing.Color.Honeydew;
            this.jobB.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jobB.FlatAppearance.BorderSize = 2;
            this.jobB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jobB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jobB.Location = new System.Drawing.Point(482, 243);
            this.jobB.Name = "jobB";
            this.jobB.Size = new System.Drawing.Size(210, 56);
            this.jobB.TabIndex = 4;
            this.jobB.Text = "Become employee";
            this.jobB.UseVisualStyleBackColor = false;
            this.jobB.Click += new System.EventHandler(this.jobB_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(740, 504);
            this.Controls.Add(this.jobB);
            this.Controls.Add(this.regB);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.titleL);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label titleL;
        private Button loginB;
        private Button regB;
        private Button jobB;
    }
}