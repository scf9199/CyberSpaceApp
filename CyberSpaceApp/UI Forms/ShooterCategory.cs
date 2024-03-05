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
    public partial class ShooterCategory : Form
    {
        public ShooterCategory()
        {
            InitializeComponent();
        }

        private void ShootReturn_Click(object sender, EventArgs e)
        {
            Form2 form2Form = new Form2();
            form2Form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BattlefieldV battleFieldform = new BattlefieldV();
            battleFieldform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COD cODform = new COD();
            cODform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Overwatch overwatchform = new Overwatch();
            overwatchform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Valorant valorantform = new Valorant();
            valorantform.Show();
            this.Hide();
        }
    }
}
