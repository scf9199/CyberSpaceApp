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
    public partial class TheSims4 : Form
    {
        public TheSims4()
        {
            InitializeComponent();
        }

        private void ReturntoGames_Click(object sender, EventArgs e)
        {
            Games gamesForm = new Games();
            gamesForm.Show();
            this.Hide();
        }

        private void FortniteSpecs_Click(object sender, EventArgs e)
        {
            int thesims4GameID = 2;

            // Create an instance of the DataAccess class with connection string
            CyberspaceApp.DataAccess.DataAccess dataAccess = new CyberspaceApp.DataAccess.DataAccess(@"Data Source=SHELBYS;Initial Catalog=CYBERRDB;Integrated Security=True");

            // Call the GetGameSpecs method to fetch system specs for The Sims 4
            SystemSpec gameSpecs = dataAccess.GetGameSpecs(thesims4GameID);

            if (gameSpecs != null)
            {
                // Display system specs in a message box
                string specsMessage = $"RAM Requirement: {gameSpecs.RAMRequirement}GB\n" +
                                       $"CPU Requirement: {gameSpecs.CPURequirement}\n" +
                                       $"GPU Requirement: {gameSpecs.GPURequirement}\n" +
                                       $"Storage Requirement: {gameSpecs.StorageRequirement}";

                MessageBox.Show(specsMessage, "The Sims 4 System Specifications", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("System specifications not found for The Sims 4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FortniteAddtoList_Click(object sender, EventArgs e)
        {
           
        }
    }
}
