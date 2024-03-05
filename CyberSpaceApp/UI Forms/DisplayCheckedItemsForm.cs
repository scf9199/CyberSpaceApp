using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CyberSpaceApp.UI_Forms
{
    public partial class DisplayCheckedItemsForm : Form
    {
        private List<string> selectedItems = new List<string>();
        private int itemsPrintedSoFar = 0;

        public DisplayCheckedItemsForm(List<string> selectedItems)
        {
            InitializeComponent();
            this.selectedItems = selectedItems;
            textBox1.Text = string.Join(Environment.NewLine, selectedItems);

            
            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
        
            Font printFont = new Font("Arial", 7); // 
            Brush brush = Brushes.Black;

            float yPos = 50; 

          
            float lineHeight = printFont.GetHeight(e.Graphics) * 1.5f; 

            int itemsPerPage = (int)(e.MarginBounds.Height / lineHeight);

            for (int i = itemsPrintedSoFar; i < selectedItems.Count; i++)
            {
                if (i < itemsPrintedSoFar + itemsPerPage)
                {
                    string line = selectedItems[i];
                    e.Graphics.DrawString(line, printFont, brush, 50, yPos); 
                    yPos += lineHeight;
                }
                else
                {
                    itemsPrintedSoFar = i;
                    e.HasMorePages = true;
                    return;
                }
            }

           
            e.HasMorePages = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                itemsPrintedSoFar = 0; // Reset items printed
                printDocument1.Print();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Hide();
        }
    }
}






