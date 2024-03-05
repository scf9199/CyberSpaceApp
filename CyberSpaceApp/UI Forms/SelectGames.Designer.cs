namespace CyberSpaceApp.UI_Forms
{
    partial class SelectGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectGames));
            this.checkListBox1 = new System.Windows.Forms.CheckedListBox();
            this.DisplayCheckedItemsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkListBox1
            // 
            this.checkListBox1.BackColor = System.Drawing.Color.Black;
            this.checkListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkListBox1.ForeColor = System.Drawing.Color.White;
            this.checkListBox1.FormattingEnabled = true;
            this.checkListBox1.Items.AddRange(new object[] {
            "Fortnite---  RAM Requirement: 8GB ,  CPU Requirement: Intel Core i5,  GPU Require" +
                "ment: NVIDIA GTX 1060,  Storage Requirement: 50 GB SSD",
            "The Sims 4--- RAM Requirement:4GB,  CPU Requirement:Intel Core 2 Duo,  GPU Requir" +
                "ement:Integrated Graphics,  Storage Requirement:25 GB HDD",
            "Valorant---     RAM Requirement:8GB, CPU Requirement:Intel Core i7,  GPU Requirem" +
                "ent:NVIDIA GTX 1650,  Storage Requirement:60 GB SSD",
            "Minecraft---    RAM Requirement:4GB, CPU Requirement:Intel Core i3, GPU Requireme" +
                "nt:Integrated Graphics, Storage Requirement:30 GB HDD",
            "Apex Legends---  RAM Requirement:12GB, CPU Requirement:AMD Ryzen 7, GPU Requireme" +
                "nt:NVIDIA RTX 2080, Storage Requirement:100 GB SSD",
            "Battlefield V---      RAM Requirement:16GB, CPU Requirement:Intel Core i9, GPU Re" +
                "quirement:NVIDIA RTX 3070, Storage Requirement:100 GB SSD",
            "Cities: Skylines II--- RAM Requirement:8GB, CPU Requirement:Intel Core i7, GPU Re" +
                "quirement:NVIDIA GTX 970, Storage Requirement:60 GB HDD",
            "Red Dead Redemption 2---  RAM Requirement:12GB, CPU Requirement:AMD Ryzen 5, GPU " +
                "Requirement:NVIDIA GTX 1660 Ti, Storage Requirement:150 GB SSD",
            "FIFA 22--- RAM Requirement:8GB, CPU Requirement:Intel Core i7, GPU Requirement:NV" +
                "IDIA GTX 1050 Ti, Storage Requirement:80 GB SSD",
            "The Witcher 3: Wild Hunt---  RAM Requirement:16GB, CPU Requirement:Intel Core i7," +
                " GPU Requirement:NVIDIA RTX 2080, Storage Requirement:100 GB SSD",
            "Overwatch---  RAM Requirement:8GB, CPU Requirement:Intel Core i5, GPU Requirement" +
                ":NVIDIA GTX 1660 Ti, Storage Requirement:70 GB SSD",
            "Rocket League---   RAM Requirement:16GB, CPU Requirement:Intel Core i9, GPU Requi" +
                "rement:NVIDIA RTX 3090, Storage Requirement:175 GB SSD",
            "World of Warcraft---   RAM Requirement:8GB, CPU Requirement:Intel Core i3, GPU Re" +
                "quirement:Integrated Graphics, Storage Requirement:50 GB HDD",
            "Assassins Creed Valhalla--- RAM Requirement:4GB, CPU Requirement:Intel Core i3, G" +
                "PU Requirement:Integrated Graphics, Storage Requirement:5 GB SSD",
            "Cyberpunk 2077--- RAM Requirement:8GB, CPU Requirement:Intel Core i5, GPU Require" +
                "ment:NVIDIA GTX 960, Storage Requirement:10 GB SSD",
            "Call of Duty Modern Warfare III---  RAM Requirement:8GB, CPU Requirement:Intel Co" +
                "re i5, GPU Requirement:NVIDIA GTX 660, Storage Requirement:20 GB SSD",
            "League of Legends--- RAM Requirement:16GB, CPU Requirement:Intel Core i7, GPU Req" +
                "uirement:NVIDIA RTX 3080, Storage Requirement:120 GB SSD",
            "Among Us---  RAM Requirement:4GB, CPU Requirement:Intel Core i3, GPU Requirement:" +
                "Integrated Graphics, Storage Requirement:5 GB SSD",
            "Minecraft Dungeons---  RAM Requirement:8GB, CPU Requirement:Intel Core i5, GPU Re" +
                "quirement:NVIDIA GTX 960, Storage Requirement:10 GB SSD",
            "Fall Guys---  RAM Requirement:8GB, CPU Requirement:Intel Core i5, GPU Requirement" +
                ":NVIDIA GTX 660, Storage Requirement:20 GB SSD"});
            this.checkListBox1.Location = new System.Drawing.Point(29, 92);
            this.checkListBox1.Name = "checkListBox1";
            this.checkListBox1.Size = new System.Drawing.Size(1459, 436);
            this.checkListBox1.TabIndex = 1;
            this.checkListBox1.SelectedIndexChanged += new System.EventHandler(this.checkListBox1_SelectedIndexChanged);
            // 
            // DisplayCheckedItemsButton
            // 
            this.DisplayCheckedItemsButton.BackColor = System.Drawing.Color.Black;
            this.DisplayCheckedItemsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCheckedItemsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.DisplayCheckedItemsButton.Location = new System.Drawing.Point(515, 580);
            this.DisplayCheckedItemsButton.Name = "DisplayCheckedItemsButton";
            this.DisplayCheckedItemsButton.Size = new System.Drawing.Size(329, 68);
            this.DisplayCheckedItemsButton.TabIndex = 2;
            this.DisplayCheckedItemsButton.Text = "Display Checked Items";
            this.DisplayCheckedItemsButton.UseVisualStyleBackColor = false;
            this.DisplayCheckedItemsButton.Click += new System.EventHandler(this.DisplayCheckedItemsButton_Click);
            // 
            // SelectGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1500, 683);
            this.Controls.Add(this.DisplayCheckedItemsButton);
            this.Controls.Add(this.checkListBox1);
            this.DoubleBuffered = true;
            this.Name = "SelectGames";
            this.Text = "SelectGames";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkListBox1;
        private System.Windows.Forms.Button DisplayCheckedItemsButton;
    }
}