namespace CyberSpaceApp.UI_Forms
{
    partial class TheSims4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheSims4));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Games2Pg = new System.Windows.Forms.Label();
            this.Sims4Specs = new System.Windows.Forms.Button();
            this.ReturntoGames = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(203, 141);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(220, 301);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // Games2Pg
            // 
            this.Games2Pg.AutoSize = true;
            this.Games2Pg.Font = new System.Drawing.Font("Broadway", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Games2Pg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.Games2Pg.Location = new System.Drawing.Point(498, 61);
            this.Games2Pg.Name = "Games2Pg";
            this.Games2Pg.Size = new System.Drawing.Size(502, 91);
            this.Games2Pg.TabIndex = 19;
            this.Games2Pg.Text = "The Sims 4";
            // 
            // Sims4Specs
            // 
            this.Sims4Specs.BackColor = System.Drawing.Color.Black;
            this.Sims4Specs.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sims4Specs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.Sims4Specs.Location = new System.Drawing.Point(762, 463);
            this.Sims4Specs.Name = "Sims4Specs";
            this.Sims4Specs.Size = new System.Drawing.Size(275, 74);
            this.Sims4Specs.TabIndex = 24;
            this.Sims4Specs.Text = "Display Specs";
            this.Sims4Specs.UseVisualStyleBackColor = false;
            this.Sims4Specs.Click += new System.EventHandler(this.FortniteSpecs_Click);
            // 
            // ReturntoGames
            // 
            this.ReturntoGames.BackColor = System.Drawing.Color.Black;
            this.ReturntoGames.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoGames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.ReturntoGames.Location = new System.Drawing.Point(463, 463);
            this.ReturntoGames.Name = "ReturntoGames";
            this.ReturntoGames.Size = new System.Drawing.Size(275, 74);
            this.ReturntoGames.TabIndex = 26;
            this.ReturntoGames.Text = "Return to Games";
            this.ReturntoGames.UseVisualStyleBackColor = false;
            this.ReturntoGames.Click += new System.EventHandler(this.ReturntoGames_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(463, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 246);
            this.label1.TabIndex = 27;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(273, 463);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // TheSims4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1228, 639);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturntoGames);
            this.Controls.Add(this.Sims4Specs);
            this.Controls.Add(this.Games2Pg);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.Name = "TheSims4";
            this.Text = "TheSims4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Games2Pg;
        private System.Windows.Forms.Button Sims4Specs;
        private System.Windows.Forms.Button ReturntoGames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}