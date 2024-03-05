using CyberspaceApp.DataAccess;
using CyberSpaceApp.Models;
using System;
using System.Windows.Forms;

namespace CyberSpaceApp.UI_Forms
{
    public partial class Fortnite : Form
    {
        private DataAccess dataAccess; 
        private TextBox textBoxGameName; 
        private TextBox textBoxSpecifications; 

       
       

        public Fortnite()
        {
            InitializeComponent();
            dataAccess = new DataAccess(@"Data Source=SHELBYS;Initial Catalog=CYBERRDB;Integrated Security=True");
            textBoxGameName = new TextBox(); 
            textBoxSpecifications = new TextBox();

            
        }

        private void ReturntoGames_Click(object sender, EventArgs e)
        {
            Games gamesForm = new Games();
            gamesForm.Show();
            this.Hide();
        }

        private void FortniteSpecs_Click(object sender, EventArgs e)
        {
            int fortniteGameID = 1;

            // Call the GetGameSpecs method to fetch system specs for Fortnite
            SystemSpec gameSpecs = dataAccess.GetGameSpecs(fortniteGameID);

            if (gameSpecs != null)
            {
                // Display system specs in a message box
                string specsMessage = $"RAM Requirement: {gameSpecs.RAMRequirement}GB\n" +
                                       $"CPU Requirement: {gameSpecs.CPURequirement}\n" +
                                       $"GPU Requirement: {gameSpecs.GPURequirement}\n" +
                                       $"Storage Requirement: {gameSpecs.StorageRequirement}";

                MessageBox.Show(specsMessage, "Fortnite System Specifications", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("System specifications not found for Fortnite.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FortniteAddtoList_Click(object sender, EventArgs e)
        {
      
        }
    }
}














