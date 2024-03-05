using CyberSpaceApp.UI_Forms;
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
    public partial class Games2 : Form
    {
        public Games2()
        {
            InitializeComponent();
        }

        private void OverwatchGames2Pg_Click(object sender, EventArgs e)
        {
            Overwatch overwatchForm = new Overwatch();
            overwatchForm.Show();
            this.Hide();
        }

        private void BacktoGames1Games2Pg_Click(object sender, EventArgs e)
        {
            Games gamesForm = new Games();
            gamesForm.Show();
            this.Close();
        }

        private void ReturnHomeGames2Pg_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Close();
        }

        private void RocketLeagueGames2Pg_Click(object sender, EventArgs e)
        {
            RocketLeague rocketleagueForm = new RocketLeague();
            rocketleagueForm.Show();
            this.Hide();
        }

        private void WOWGames2Pg_Click(object sender, EventArgs e)
        {
            WOW wowForm = new WOW();
            wowForm.Show();
            this.Hide();
        }

        private void AssassiansCreedGames2Pg_Click(object sender, EventArgs e)
        {
            AssassiansCreed assassianscreedForm = new AssassiansCreed();
            assassianscreedForm.Show();
            this.Hide();
        }

        private void CyberpunkGamesPg_Click(object sender, EventArgs e)
        {
            Cyberpunk2077 cyberpunk2077Form = new Cyberpunk2077();
            cyberpunk2077Form.Show();
            this.Hide();
        }

        private void CODGames2Pg_Click(object sender, EventArgs e)
        {
            COD codForm = new COD();
            codForm.Show();
            this.Hide();
        }

        private void LOLGames2Pg_Click(object sender, EventArgs e)
        {
            LeagueofLegends leagueoflegendsForm = new LeagueofLegends();
            leagueoflegendsForm.Show();
            this.Hide();
        }

        private void AmongUsGames2Pg_Click(object sender, EventArgs e)
        {
            AmongUs amongusForm = new AmongUs();
            amongusForm.Show();
            this.Hide();
        }

        private void MinecraftDunGames2Pg_Click(object sender, EventArgs e)
        {
            MinecraftDungeons minecraftdungeonsForm = new MinecraftDungeons();
            minecraftdungeonsForm.Show();
            this.Hide();
        }

        private void FallGuysGames2Pg_Click(object sender, EventArgs e)
        {
            FallGuys fallguysForm = new FallGuys();
            fallguysForm.Show();
            this.Hide();
        }
    }
}
