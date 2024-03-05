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
    public partial class ActionRPGCat : Form
    {
        public ActionRPGCat()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ActionRPGReturn_Click(object sender, EventArgs e)
        {
            Form2 form2Form = new Form2();
            form2Form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssassiansCreed assassiansCreedForm = new AssassiansCreed();
            assassiansCreedForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cyberpunk2077 cyberpunk2077form = new Cyberpunk2077();
            cyberpunk2077form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MinecraftDungeons minecraftDungeonsform = new MinecraftDungeons();
            minecraftDungeonsform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TheWitcher3 theWitcher3form = new TheWitcher3();
            theWitcher3form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
