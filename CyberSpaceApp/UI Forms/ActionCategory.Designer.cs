namespace CyberSpaceApp
{
    partial class ActionCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionCategory));
            this.ActionCateg = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ActionReturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionCateg
            // 
            this.ActionCateg.AutoSize = true;
            this.ActionCateg.Font = new System.Drawing.Font("Broadway", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionCateg.ForeColor = System.Drawing.Color.White;
            this.ActionCateg.Location = new System.Drawing.Point(453, 25);
            this.ActionCateg.Name = "ActionCateg";
            this.ActionCateg.Size = new System.Drawing.Size(397, 113);
            this.ActionCateg.TabIndex = 1;
            this.ActionCateg.Text = "Action";
            this.ActionCateg.Click += new System.EventHandler(this.ActionCateg_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(140, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // ActionReturn
            // 
            this.ActionReturn.BackColor = System.Drawing.Color.Black;
            this.ActionReturn.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.ActionReturn.Location = new System.Drawing.Point(444, 519);
            this.ActionReturn.Name = "ActionReturn";
            this.ActionReturn.Size = new System.Drawing.Size(406, 93);
            this.ActionReturn.TabIndex = 12;
            this.ActionReturn.Text = "Return to Categories";
            this.ActionReturn.UseVisualStyleBackColor = false;
            this.ActionReturn.Click += new System.EventHandler(this.ActionReturn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.button1.Location = new System.Drawing.Point(140, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 107);
            this.button1.TabIndex = 13;
            this.button1.Text = "Red Dead \r\nRedemption II";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ActionCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1316, 660);
            this.Controls.Add(this.ActionReturn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ActionCateg);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Name = "ActionCategory";
            this.Text = "ActionCategory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ActionCateg;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ActionReturn;
        private System.Windows.Forms.Button button1;
    }
}