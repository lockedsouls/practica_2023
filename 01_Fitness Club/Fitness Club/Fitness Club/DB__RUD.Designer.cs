namespace Fitness_Club
{
    partial class DB__RUD
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sub = new System.Windows.Forms.Button();
            this.serv = new System.Windows.Forms.Button();
            this.roles = new System.Windows.Forms.Button();
            this.pers = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableL = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sub);
            this.splitContainer1.Panel1.Controls.Add(this.serv);
            this.splitContainer1.Panel1.Controls.Add(this.roles);
            this.splitContainer1.Panel1.Controls.Add(this.pers);
            this.splitContainer1.Panel1.Controls.Add(this.client);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.tableL);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(971, 562);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 0;
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(16, 170);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(125, 35);
            this.sub.TabIndex = 9;
            this.sub.Text = "Subscriptions";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // serv
            // 
            this.serv.Location = new System.Drawing.Point(16, 131);
            this.serv.Name = "serv";
            this.serv.Size = new System.Drawing.Size(125, 35);
            this.serv.TabIndex = 8;
            this.serv.Text = "Services";
            this.serv.UseVisualStyleBackColor = true;
            this.serv.Click += new System.EventHandler(this.serv_Click);
            // 
            // roles
            // 
            this.roles.Location = new System.Drawing.Point(16, 92);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(125, 35);
            this.roles.TabIndex = 7;
            this.roles.Text = "Roles";
            this.roles.UseVisualStyleBackColor = true;
            this.roles.Click += new System.EventHandler(this.roles_Click);
            // 
            // pers
            // 
            this.pers.Location = new System.Drawing.Point(16, 53);
            this.pers.Name = "pers";
            this.pers.Size = new System.Drawing.Size(125, 35);
            this.pers.TabIndex = 6;
            this.pers.Text = "Personal";
            this.pers.UseVisualStyleBackColor = true;
            this.pers.Click += new System.EventHandler(this.pers_Click);
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(16, 14);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(125, 35);
            this.client.TabIndex = 5;
            this.client.Text = "Clients";
            this.client.UseVisualStyleBackColor = true;
            this.client.Click += new System.EventHandler(this.client_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(783, 474);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tableL
            // 
            this.tableL.AutoSize = true;
            this.tableL.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableL.Location = new System.Drawing.Point(15, 7);
            this.tableL.Name = "tableL";
            this.tableL.Size = new System.Drawing.Size(57, 25);
            this.tableL.TabIndex = 12;
            this.tableL.Text = "NULL";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DB__RUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(971, 562);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DB__RUD";
            this.Text = "DB__RUD";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button sub;
        private Button serv;
        private Button roles;
        private Button pers;
        private Button client;
        private Button button2;
        private Button button1;
        private Label tableL;
        private DataGridView dataGridView1;
    }
}