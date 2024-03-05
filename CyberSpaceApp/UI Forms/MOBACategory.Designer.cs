namespace CyberSpaceApp
{
    partial class MOBACategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MOBACategory));
            this.button4 = new System.Windows.Forms.Button();
            this.MOBAReturn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ActionRPGCateg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.button4.Location = new System.Drawing.Point(122, 463);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 105);
            this.button4.TabIndex = 18;
            this.button4.Text = "League\r\nof\r\nLegends\r\n";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MOBAReturn
            // 
            this.MOBAReturn.BackColor = System.Drawing.Color.Black;
            this.MOBAReturn.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOBAReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.MOBAReturn.Location = new System.Drawing.Point(446, 584);
            this.MOBAReturn.Name = "MOBAReturn";
            this.MOBAReturn.Size = new System.Drawing.Size(363, 82);
            this.MOBAReturn.TabIndex = 12;
            this.MOBAReturn.Text = "Return to Categories";
            this.MOBAReturn.UseVisualStyleBackColor = false;
            this.MOBAReturn.Click += new System.EventHandler(this.MOBAReturn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(122, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 274);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // ActionRPGCateg
            // 
            this.ActionRPGCateg.AutoSize = true;
            this.ActionRPGCateg.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionRPGCateg.ForeColor = System.Drawing.Color.White;
            this.ActionRPGCateg.Location = new System.Drawing.Point(465, 45);
            this.ActionRPGCateg.Name = "ActionRPGCateg";
            this.ActionRPGCateg.Size = new System.Drawing.Size(533, 164);
            this.ActionRPGCateg.TabIndex = 5;
            this.ActionRPGCateg.Text = "MOBA";
            // 
            // MOBACategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1290, 726);
            this.Controls.Add(this.ActionRPGCateg);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.MOBAReturn);
            this.DoubleBuffered = true;
            this.Name = "MOBACategory";
            this.Text = "MOBACategory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ActionRPGCateg;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button MOBAReturn;
        private System.Windows.Forms.Button button4;
    }
}