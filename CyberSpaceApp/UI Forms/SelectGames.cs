using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberSpaceApp.UI_Forms
{
    public partial class SelectGames : Form
    {
        public SelectGames()
        {
            InitializeComponent();
        }

        private void DisplayCheckedItemsButton_Click(object sender, EventArgs e)
        {

            List<string> checkedItems = new List<string>();

            foreach (var item in checkListBox1.CheckedItems)
            {
                checkedItems.Add(item.ToString());
            }

            // Open the DisplayCheckedItemsForm and pass the checked items
            DisplayCheckedItemsForm checkItemForm = new DisplayCheckedItemsForm(checkedItems);
            checkItemForm.Show();
            this.Hide(); 
        }

        private void checkListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
