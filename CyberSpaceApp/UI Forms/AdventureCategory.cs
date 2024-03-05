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
    public partial class AdventureCategory : Form
    {
        public AdventureCategory()
        {
            InitializeComponent();
        }

        private void ACReturn_Click(object sender, EventArgs e)
        {
            Form2 form2Form = new Form2();
            form2Form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Minecraft minecraftform = new Minecraft();
            minecraftform.Show();
            this.Hide();
        }
    }
}
