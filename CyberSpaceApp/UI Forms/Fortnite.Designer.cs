namespace CyberSpaceApp.UI_Forms
{
    partial class Fortnite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fortnite));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReturntoGames = new System.Windows.Forms.Button();
            this.FortniteSpecs = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Games2Pg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(138, 477);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 327);
            this.label1.TabIndex = 24;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturntoGames
            // 
            this.ReturntoGames.BackColor = System.Drawing.Color.Black;
            this.ReturntoGames.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoGames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.ReturntoGames.Location = new System.Drawing.Point(363, 525);
            this.ReturntoGames.Name = "ReturntoGames";
            this.ReturntoGames.Size = new System.Drawing.Size(353, 98);
            this.ReturntoGames.TabIndex = 22;
            this.ReturntoGames.Text = "Return to Games";
            this.ReturntoGames.UseVisualStyleBackColor = false;
            this.ReturntoGames.Click += new System.EventHandler(this.ReturntoGames_Click);
            // 
            // FortniteSpecs
            // 
            this.FortniteSpecs.BackColor = System.Drawing.Color.Black;
            this.FortniteSpecs.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FortniteSpecs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.FortniteSpecs.Location = new System.Drawing.Point(737, 525);
            this.FortniteSpecs.Name = "FortniteSpecs";
            this.FortniteSpecs.Size = new System.Drawing.Size(347, 98);
            this.FortniteSpecs.TabIndex = 20;
            this.FortniteSpecs.Text = "Display Specs";
            this.FortniteSpecs.UseVisualStyleBackColor = false;
            this.FortniteSpecs.Click += new System.EventHandler(this.FortniteSpecs_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(114, 144);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(217, 327);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // Games2Pg
            // 
            this.Games2Pg.AutoSize = true;
            this.Games2Pg.Font = new System.Drawing.Font("Broadway", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Games2Pg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.Games2Pg.Location = new System.Drawing.Point(511, 22);
            this.Games2Pg.Name = "Games2Pg";
            this.Games2Pg.Size = new System.Drawing.Size(484, 113);
            this.Games2Pg.TabIndex = 15;
            this.Games2Pg.Text = "Fortnite";
            // 
            // Fortnite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1244, 698);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FortniteSpecs);
            this.Controls.Add(this.ReturntoGames);
            this.Controls.Add(this.Games2Pg);
            this.DoubleBuffered = true;
            this.Name = "Fortnite";
            this.Text = "Fortnite";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Games2Pg;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button FortniteSpecs;
        private System.Windows.Forms.Button ReturntoGames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}