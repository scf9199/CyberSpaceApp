namespace CyberSpaceApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Button();
            this.Games = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Categories = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 32F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(97, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Broadway", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(131, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cyber Space";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(159, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gaming PC Builds";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 426);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Login);
            this.panel2.Controls.Add(this.Games);
            this.panel2.Controls.Add(this.Home);
            this.panel2.Controls.Add(this.Categories);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 426);
            this.panel2.TabIndex = 6;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Black;
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(531, 4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(140, 34);
            this.Login.TabIndex = 9;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.button3_Click);
            // 
            // Games
            // 
            this.Games.BackColor = System.Drawing.Color.Black;
            this.Games.ForeColor = System.Drawing.Color.White;
            this.Games.Location = new System.Drawing.Point(361, 4);
            this.Games.Name = "Games";
            this.Games.Size = new System.Drawing.Size(140, 34);
            this.Games.TabIndex = 8;
            this.Games.Text = "Games";
            this.Games.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Black;
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(18, 4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(140, 34);
            this.Home.TabIndex = 7;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Categories
            // 
            this.Categories.BackColor = System.Drawing.Color.Black;
            this.Categories.ForeColor = System.Drawing.Color.White;
            this.Categories.Location = new System.Drawing.Point(189, 4);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(140, 34);
            this.Categories.TabIndex = 6;
            this.Categories.Text = "Categories";
            this.Categories.UseVisualStyleBackColor = false;
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Categories;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Games;
        private System.Windows.Forms.Button Home;
    }
}

