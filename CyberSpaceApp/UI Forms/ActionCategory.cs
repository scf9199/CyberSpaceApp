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
    public partial class ActionCategory : Form
    {
        public ActionCategory()
        {
            InitializeComponent();
            
        }

        private void ActionReturn_Click(object sender, EventArgs e)
        {
            Form2 form2Form = new Form2();
            form2Form.Show();
            this.Hide();
        }

        private void ActionCateg_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RedDeadRedemption readDeadRedemptionform = new RedDeadRedemption();
            readDeadRedemptionform.Show();
            this.Hide();
        }
    }


            





            }

