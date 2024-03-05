namespace CyberSpaceApp
{
    partial class AdventureCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdventureCategory));
            this.button4 = new System.Windows.Forms.Button();
            this.ACReturn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ActionRPGCateg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.button4.Location = new System.Drawing.Point(145, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 86);
            this.button4.TabIndex = 17;
            this.button4.Text = "Minecraft";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ACReturn
            // 
            this.ACReturn.BackColor = System.Drawing.Color.Black;
            this.ACReturn.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.ACReturn.Location = new System.Drawing.Point(462, 578);
            this.ACReturn.Name = "ACReturn";
            this.ACReturn.Size = new System.Drawing.Size(365, 85);
            this.ACReturn.TabIndex = 12;
            this.ACReturn.Text = "Return to Categories";
            this.ACReturn.UseVisualStyleBackColor = false;
            this.ACReturn.Click += new System.EventHandler(this.ACReturn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(145, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 227);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // ActionRPGCateg
            // 
            this.ActionRPGCateg.AutoSize = true;
            this.ActionRPGCateg.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionRPGCateg.ForeColor = System.Drawing.Color.White;
            this.ActionRPGCateg.Location = new System.Drawing.Point(358, 31);
            this.ActionRPGCateg.Name = "ActionRPGCateg";
            this.ActionRPGCateg.Size = new System.Drawing.Size(606, 109);
            this.ActionRPGCateg.TabIndex = 3;
            this.ActionRPGCateg.Text = "Adventure";
            // 
            // AdventureCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1327, 730);
            this.Controls.Add(this.ActionRPGCateg);
            this.Controls.Add(this.ACReturn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Name = "AdventureCategory";
            this.Text = "AdventureCategory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ActionRPGCateg;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ACReturn;
        private System.Windows.Forms.Button button4;
    }
}