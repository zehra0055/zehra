using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace il_ve_listbox_çalışması
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            List<string> liste = new List<string>();


            foreach (var item in listBox1.SelectedItems)
            {
                liste.Add(item.ToString());
            }

            foreach (var item in liste)
            {
                listBox2.Items.Add(item);
                listBox1.Items.Remove(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> liste = new List<string>();

            
            foreach (var item in listBox2.SelectedItems) 
            {
                liste.Add(item.ToString());
            }

            foreach (var item in liste)
            {
                listBox1.Items.Add(item);
                listBox2.Items.Remove(item);
            }
        }
    }
}
