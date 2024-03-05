namespace CyberSpaceApp.UI_Forms
{
    partial class Minecraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minecraft));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Games2Pg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MinecraftSpecs = new System.Windows.Forms.Button();
            this.ReturntoGames = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(210, 154);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(177, 283);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // Games2Pg
            // 
            this.Games2Pg.AutoSize = true;
            this.Games2Pg.Font = new System.Drawing.Font("Broadway", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Games2Pg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.Games2Pg.Location = new System.Drawing.Point(516, 43);
            this.Games2Pg.Name = "Games2Pg";
            this.Games2Pg.Size = new System.Drawing.Size(461, 91);
            this.Games2Pg.TabIndex = 23;
            this.Games2Pg.Text = "Minecraft";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(448, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 283);
            this.label1.TabIndex = 29;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinecraftSpecs
            // 
            this.MinecraftSpecs.BackColor = System.Drawing.Color.Black;
            this.MinecraftSpecs.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinecraftSpecs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.MinecraftSpecs.Location = new System.Drawing.Point(757, 471);
            this.MinecraftSpecs.Name = "MinecraftSpecs";
            this.MinecraftSpecs.Size = new System.Drawing.Size(291, 69);
            this.MinecraftSpecs.TabIndex = 31;
            this.MinecraftSpecs.Text = "Display Specs";
            this.MinecraftSpecs.UseVisualStyleBackColor = false;
            this.MinecraftSpecs.Click += new System.EventHandler(this.FortniteSpecs_Click);
            // 
            // ReturntoGames
            // 
            this.ReturntoGames.BackColor = System.Drawing.Color.Black;
            this.ReturntoGames.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoGames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.ReturntoGames.Location = new System.Drawing.Point(448, 471);
            this.ReturntoGames.Name = "ReturntoGames";
            this.ReturntoGames.Size = new System.Drawing.Size(291, 69);
            this.ReturntoGames.TabIndex = 32;
            this.ReturntoGames.Text = "Return to Games";
            this.ReturntoGames.UseVisualStyleBackColor = false;
            this.ReturntoGames.Click += new System.EventHandler(this.ReturntoGames_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(258, 454);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // Minecraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1228, 647);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ReturntoGames);
            this.Controls.Add(this.MinecraftSpecs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Games2Pg);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.Name = "Minecraft";
            this.Text = "Minecraft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Games2Pg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MinecraftSpecs;
        private System.Windows.Forms.Button ReturntoGames;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}