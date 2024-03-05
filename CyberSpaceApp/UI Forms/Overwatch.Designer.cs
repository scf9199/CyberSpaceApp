namespace CyberSpaceApp.UI_Forms
{
    partial class Overwatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overwatch));
            this.Games2Pg = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OverwatchSpecs = new System.Windows.Forms.Button();
            this.ReturntoGames = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Games2Pg
            // 
            this.Games2Pg.Font = new System.Drawing.Font("Broadway", 40F);
            this.Games2Pg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.Games2Pg.Location = new System.Drawing.Point(313, 87);
            this.Games2Pg.Name = "Games2Pg";
            this.Games2Pg.Size = new System.Drawing.Size(797, 86);
            this.Games2Pg.TabIndex = 30;
            this.Games2Pg.Text = "Overwatch 2";
            this.Games2Pg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(240, 191);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(222, 277);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(500, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 277);
            this.label1.TabIndex = 39;
            this.label1.Text = "Overwatch 2 is a free-to-play, always-on, and ever-evolving live game. \r\nTeam up " +
    "with friends regardless of platform and jump\r\n into the reimagined PvP experienc" +
    "e.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OverwatchSpecs
            // 
            this.OverwatchSpecs.BackColor = System.Drawing.Color.Black;
            this.OverwatchSpecs.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverwatchSpecs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.OverwatchSpecs.Location = new System.Drawing.Point(826, 510);
            this.OverwatchSpecs.Name = "OverwatchSpecs";
            this.OverwatchSpecs.Size = new System.Drawing.Size(302, 69);
            this.OverwatchSpecs.TabIndex = 41;
            this.OverwatchSpecs.Text = "Display Specs";
            this.OverwatchSpecs.UseVisualStyleBackColor = false;
            this.OverwatchSpecs.Click += new System.EventHandler(this.OverwatchSpecs_Click);
            // 
            // ReturntoGames
            // 
            this.ReturntoGames.BackColor = System.Drawing.Color.Black;
            this.ReturntoGames.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoGames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.ReturntoGames.Location = new System.Drawing.Point(500, 510);
            this.ReturntoGames.Name = "ReturntoGames";
            this.ReturntoGames.Size = new System.Drawing.Size(303, 69);
            this.ReturntoGames.TabIndex = 42;
            this.ReturntoGames.Text = "Return to Games";
            this.ReturntoGames.UseVisualStyleBackColor = false;
            this.ReturntoGames.Click += new System.EventHandler(this.ReturntoGames_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(299, 494);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Overwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1272, 701);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ReturntoGames);
            this.Controls.Add(this.OverwatchSpecs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Games2Pg);
            this.DoubleBuffered = true;
            this.Name = "Overwatch";
            this.Text = "Overwatch";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Games2Pg;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OverwatchSpecs;
        private System.Windows.Forms.Button ReturntoGames;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}