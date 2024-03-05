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
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }

        private void ActionCateg_Click(object sender, EventArgs e)
        {
            Fortnite fortniteForm = new Fortnite();
            fortniteForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TheSims4 thesims4Form = new TheSims4();
            thesims4Form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Apex apexForm = new Apex();
            apexForm.Show();    
            this.Hide();
        }

        private void ReturnHomeGame_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Hide();
        }

        private void ContinuetoMoreGame_Click(object sender, EventArgs e)
        {
            Games2 games2Form = new Games2();
            games2Form.Show();
            this.Hide();
        }

        private void ValorantGame_Click(object sender, EventArgs e)
        {
            Valorant valorantForm = new Valorant();
            valorantForm.Show();
            this.Hide();    
        }

        private void MinecraftGame_Click(object sender, EventArgs e)
        {
            Minecraft minecraftForm = new Minecraft();
            minecraftForm.Show();
            this.Hide();
        }

        private void BattlefieldVGame_Click(object sender, EventArgs e)
        {
            BattlefieldV battlefieldvForm = new BattlefieldV();
            battlefieldvForm.Show();
            this.Hide();

        }

        private void CitesSkyGame_Click(object sender, EventArgs e)
        {
            CitiesSkylines citiesskylinesForm = new CitiesSkylines();
            citiesskylinesForm.Show();
            this.Hide();
        }

        private void RedDeadGame_Click(object sender, EventArgs e)
        {
            RedDeadRedemption reddeadredemptionForm = new RedDeadRedemption();
            reddeadredemptionForm.Show();
            this.Hide();
        }

        private void FIFA22Game_Click(object sender, EventArgs e)
        {
            FIFA22 fIFA22Form = new FIFA22();
            fIFA22Form.Show();
            this.Hide();
        }

        private void TheWitcher3Game_Click(object sender, EventArgs e)
        {
            TheWitcher3 thewitcher3Form = new TheWitcher3();
            thewitcher3Form.Show();
            this.Hide();
        }
    }
}
