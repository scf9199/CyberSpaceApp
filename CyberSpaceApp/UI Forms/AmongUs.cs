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
    public partial class AmongUs : Form
    {
        public AmongUs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReturntoGames_Click(object sender, EventArgs e)
        {
            Games gamesForm = new Games();
            gamesForm.Show();
            this.Hide();
        }

        private void amongusSpecs_Click(object sender, EventArgs e)
        {
            int amongusGameID = 18;

            // Create an instance of the DataAccess class with connection string
            CyberspaceApp.DataAccess.DataAccess dataAccess = new CyberspaceApp.DataAccess.DataAccess(@"Data Source=SHELBYS;Initial Catalog=CYBERRDB;Integrated Security=True");

            // Call the GetGameSpecs method to fetch system specs for Among Us
            SystemSpec gameSpecs = dataAccess.GetGameSpecs(amongusGameID);

            if (gameSpecs != null)
            {
                // Display system specs in a message box
                string specsMessage = $"RAM Requirement: {gameSpecs.RAMRequirement}GB\n" +
                                       $"CPU Requirement: {gameSpecs.CPURequirement}\n" +
                                       $"GPU Requirement: {gameSpecs.GPURequirement}\n" +
                                       $"Storage Requirement: {gameSpecs.StorageRequirement}";

                MessageBox.Show(specsMessage, "Among Us System Specifications", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("System specifications not found for Among Us.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
