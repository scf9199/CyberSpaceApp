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
    public partial class FIFA22 : Form
    {
        public FIFA22()
        {
            InitializeComponent();
        }

        private void ReturntoGames_Click(object sender, EventArgs e)
        {
            Games gamesForm = new Games();
            gamesForm.Show();
            this.Hide();
        }

        private void Games2Pg_Click(object sender, EventArgs e)
        {

        }

        private void FIFASpecs_Click(object sender, EventArgs e)
        {
            int fifaGameID = 9;

            // Create instance of the DataAccess class with connection string
            CyberspaceApp.DataAccess.DataAccess dataAccess = new CyberspaceApp.DataAccess.DataAccess(@"Data Source=SHELBYS;Initial Catalog=CYBERRDB;Integrated Security=True");

            // Call the GetGameSpecs method to fetch system specs for FIFA 22
            SystemSpec gameSpecs = dataAccess.GetGameSpecs(fifaGameID);

            if (gameSpecs != null)
            {
                // Display system specs in a message box
                string specsMessage = $"RAM Requirement: {gameSpecs.RAMRequirement}GB\n" +
                                       $"CPU Requirement: {gameSpecs.CPURequirement}\n" +
                                       $"GPU Requirement: {gameSpecs.GPURequirement}\n" +
                                       $"Storage Requirement: {gameSpecs.StorageRequirement}";

                MessageBox.Show(specsMessage, "FIFA 22 System Specifications", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("System specifications not found for FIFA 22", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
