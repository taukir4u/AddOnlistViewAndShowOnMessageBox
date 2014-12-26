using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddOnlistViewAndShowOnMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int value;
        private void addButton_Click(object sender, EventArgs e)
        {
            value = Convert.ToInt16(takeValueText.Text);
            for (int i =0 ; i <= value; i++)
            {
                showListView.Items.Add(i.ToString());
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            var selectedItems = showListView.SelectedItems;
            if (selectedItems.Count > 0)
            {
                // Display text of first item selected.
                MessageBox.Show(selectedItems[0].Text);
            }

        }


    }
}
