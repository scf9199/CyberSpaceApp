namespace CyberSpaceApp
{
    partial class SocialDestructionCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocialDestructionCategory));
            this.button1 = new System.Windows.Forms.Button();
            this.SDReturn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SocialDestructionCat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.button1.Location = new System.Drawing.Point(176, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 92);
            this.button1.TabIndex = 21;
            this.button1.Text = "Among\r\nUs\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SDReturn
            // 
            this.SDReturn.BackColor = System.Drawing.Color.Black;
            this.SDReturn.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.SDReturn.Location = new System.Drawing.Point(484, 585);
            this.SDReturn.Name = "SDReturn";
            this.SDReturn.Size = new System.Drawing.Size(342, 84);
            this.SDReturn.TabIndex = 12;
            this.SDReturn.Text = "Return to Categories";
            this.SDReturn.UseVisualStyleBackColor = false;
            this.SDReturn.Click += new System.EventHandler(this.SDReturn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(176, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 258);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // SocialDestructionCat
            // 
            this.SocialDestructionCat.AutoSize = true;
            this.SocialDestructionCat.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SocialDestructionCat.ForeColor = System.Drawing.Color.White;
            this.SocialDestructionCat.Location = new System.Drawing.Point(177, 37);
            this.SocialDestructionCat.Name = "SocialDestructionCat";
            this.SocialDestructionCat.Size = new System.Drawing.Size(979, 109);
            this.SocialDestructionCat.TabIndex = 9;
            this.SocialDestructionCat.Text = "Social Destruction";
            // 
            // SocialDestructionCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1322, 725);
            this.Controls.Add(this.SocialDestructionCat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SDReturn);
            this.DoubleBuffered = true;
            this.Name = "SocialDestructionCategory";
            this.Text = "SocialDestructionCategory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SocialDestructionCat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SDReturn;
        private System.Windows.Forms.Button button1;
    }
}