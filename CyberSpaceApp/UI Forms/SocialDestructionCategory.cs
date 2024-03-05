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
    public partial class SocialDestructionCategory : Form
    {
        public SocialDestructionCategory()
        {
            InitializeComponent();
        }

        private void SDReturn_Click(object sender, EventArgs e)
        {
            Form2 form2Form = new Form2();
            form2Form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AmongUs amongUsform = new AmongUs();
           amongUsform.Show();
            this.Hide();
        }
    }
}
