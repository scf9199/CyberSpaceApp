using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberSpaceApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BattleRoyale battleRoyaleForm = new BattleRoyale();
            battleRoyaleForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SocialDestructionCategory socialDestructionCategoryForm = new SocialDestructionCategory();
            socialDestructionCategoryForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Hide();
        }

        private void ActionCateg_Click(object sender, EventArgs e)
        {
            ActionCategory actionCategoryForm = new ActionCategory();
            actionCategoryForm.Show();
            this.Hide();    
        }

        private void ActionCat_Click(object sender, EventArgs e)
        {
            ActionRPGCat actionRPGCatForm = new ActionRPGCat();
            actionRPGCatForm.Show();
            this.Hide();
        }

        private void AdventureCat_Click(object sender, EventArgs e)
        {
            AdventureCategory adventureCategoryForm = new AdventureCategory();
            adventureCategoryForm.Show();
            this.Hide();
        }

        private void MOBACat_Click(object sender, EventArgs e)
        {
            MOBACategory mobaCategoryForm = new MOBACategory();
            mobaCategoryForm.Show();
            this.Hide();
        }

        private void MMORPGCat_Click(object sender, EventArgs e)
        {
            MMORPGCategory mmorpgCategoryForm = new MMORPGCategory();
            mmorpgCategoryForm.Show();
            this.Hide();
        }

        private void ShooterCat_Click(object sender, EventArgs e)
        {
            ShooterCategory shooterCategoryForm = new ShooterCategory();
            shooterCategoryForm.Show();
            this.Hide();
        }

        private void SimulationCat_Click(object sender, EventArgs e)
        {
            SimulationCategory simulationCategoryForm = new SimulationCategory();
            simulationCategoryForm.Show();
            this.Hide();
        }

        private void SportsCat_Click(object sender, EventArgs e)
        {
            SportsCategory sportsCategoryForm = new SportsCategory();
            sportsCategoryForm.Show();
            this.Hide();
        }
    }
}
