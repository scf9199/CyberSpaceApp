namespace CyberSpaceApp
{
    partial class MMORPGCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMORPGCategory));
            this.button4 = new System.Windows.Forms.Button();
            this.MMORPGReturn = new System.Windows.Forms.Button();
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
            this.button4.Location = new System.Drawing.Point(141, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 96);
            this.button4.TabIndex = 19;
            this.button4.Text = "World \r\nof \r\nWarcraft\r\n";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MMORPGReturn
            // 
            this.MMORPGReturn.BackColor = System.Drawing.Color.Black;
            this.MMORPGReturn.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMORPGReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.MMORPGReturn.Location = new System.Drawing.Point(451, 531);
            this.MMORPGReturn.Name = "MMORPGReturn";
            this.MMORPGReturn.Size = new System.Drawing.Size(335, 68);
            this.MMORPGReturn.TabIndex = 12;
            this.MMORPGReturn.Text = "Return to Categories";
            this.MMORPGReturn.UseVisualStyleBackColor = false;
            this.MMORPGReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(141, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 245);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // ActionRPGCateg
            // 
            this.ActionRPGCateg.AutoSize = true;
            this.ActionRPGCateg.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionRPGCateg.ForeColor = System.Drawing.Color.White;
            this.ActionRPGCateg.Location = new System.Drawing.Point(349, 42);
            this.ActionRPGCateg.Name = "ActionRPGCateg";
            this.ActionRPGCateg.Size = new System.Drawing.Size(521, 109);
            this.ActionRPGCateg.TabIndex = 6;
            this.ActionRPGCateg.Text = "MMORPG";
            // 
            // MMORPGCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1237, 653);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.MMORPGReturn);
            this.Controls.Add(this.ActionRPGCateg);
            this.DoubleBuffered = true;
            this.Name = "MMORPGCategory";
            this.Text = "MMORPGCategory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ActionRPGCateg;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button MMORPGReturn;
        private System.Windows.Forms.Button button4;
    }
}