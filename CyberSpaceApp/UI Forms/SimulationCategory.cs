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
    public partial class SimulationCategory : Form
    {
        public SimulationCategory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SimReturn_Click(object sender, EventArgs e)
        {
            Form2 form2Form = new Form2();
            form2Form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CitiesSkylines citiesSkylinesform = new CitiesSkylines();
            citiesSkylinesform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TheSims4 theSims4form = new TheSims4();
            theSims4form.Show();
            this.Hide();
        }
    }
}
