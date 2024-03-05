using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberSpaceApp.UI_Forms
{
    public partial class WOW : Form
    {
        public WOW()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void ReturntoGames_Click(object sender, EventArgs e)
        {
            Games gamesForm = new Games();
            gamesForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Games2Pg_Click(object sender, EventArgs e)
        {

        }

        private void wowSpecs_Click(object sender, EventArgs e)
        {
            int wowGameID = 13;

            // Create an instance of the DataAccess class with connection string
            CyberspaceApp.DataAccess.DataAccess dataAccess = new CyberspaceApp.DataAccess.DataAccess(@"Data Source=SHELBYS;Initial Catalog=CYBERRDB;Integrated Security=True");

            // Call the GetGameSpecs method to fetch system specs for WOW
            SystemSpec gameSpecs = dataAccess.GetGameSpecs(wowGameID);

            if (gameSpecs != null)
            {
                // Display system specs in a message box
                string specsMessage = $"RAM Requirement: {gameSpecs.RAMRequirement}GB\n" +
                                       $"CPU Requirement: {gameSpecs.CPURequirement}\n" +
                                       $"GPU Requirement: {gameSpecs.GPURequirement}\n" +
                                       $"Storage Requirement: {gameSpecs.StorageRequirement}";

                MessageBox.Show(specsMessage, "World of Warcraft System Specifications", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("System specifications not found for World of Warcraft.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
