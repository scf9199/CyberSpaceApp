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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public partial class Form2 : Form

        {

            private Button button1; // Declare button1 as a private member variable
            private Form2 form2; // Declare an instance of Form2

            public Form2()
            {


                // Initialize button1 and assign properties
                button1 = new Button();
                button1.Text = "Click Me"; // Set button text
                button1.Click += button1_Click; // Wire up the click event handler for button1

                // Set button1 as the accept button for the form
                this.AcceptButton = button1;

                // Initialize the Form2 instance
                form2 = new Form2();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                // Code to handle the button1 click event

                // Show or navigate to Form2 when button1 is clicked
                form2.Show(); // Use Show() to display the form as a modeless dialog
                              // OR
                              // form2.ShowDialog(); // Use ShowDialog() to display the form as a modal dialog
            }

            // Rest of your code
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void Categories_Click(object sender, EventArgs e)
        { }
    }
}
       
  






