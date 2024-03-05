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
    public partial class SportsCategory : Form
    {
        public SportsCategory()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SCReturn_Click(object sender, EventArgs e)
        {
            Form2 form2Form = new Form2();
            form2Form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FIFA22 fifa22form = new FIFA22();
            fifa22form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RocketLeague rocketLeagueform = new RocketLeague();
            rocketLeagueform.Show();
            this.Hide();
        }
    }
}
