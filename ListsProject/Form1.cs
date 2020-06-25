using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            listBox1.Items.AddRange(new Object[] { "one", "two", "three", "four", "five" }); ;
            checkedListBox1.Items.AddRange(new Object[] { "one", "two", "three", "four", "five" }); ;
            comboBox1.Items.AddRange(new Object[] { "one", "two", "three", "four", "five" }); ;
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!((string.IsNullOrWhiteSpace(textBox1.Text)
                || listBox1.Items.Contains(textBox1.Text.Trim()))))
            {
                listBox1.Items.Add(textBox1.Text.Trim());
                textBox1.Text = "";
            }
        }

        private void BtnTrans_Click(object sender, EventArgs e)
        {
            //foreach (var item in listBox1.SelectedItems)
            //{
            //    listBox2.Items.Add(item);
            //}
            string[] arr = new string[listBox1.SelectedItems.Count];
            listBox1.SelectedItems.CopyTo(arr, 0);
            listBox2.Items.AddRange(arr);

        }

        private void BtnRmv_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.SelectedItems.Count-1; i >=0 ; i--)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
            }
        }

        private void BtnClr_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            if (!(char.IsNumber(e.KeyChar)||e.KeyChar=='\b'))
                e.Handled = true;
        }
    }
}
