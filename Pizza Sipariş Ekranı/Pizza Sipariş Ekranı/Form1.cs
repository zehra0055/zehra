using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Sipariş_Ekranı
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbladet_Click(object sender, EventArgs e)
        {

        }

        private void lbltoplam_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxsucuk_CheckedChanged(object sender, EventArgs e)
        {

        }
        int fiyat = 0;
        int adet = 0;

        private void btnsiparişver_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                fiyat += 30;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                fiyat += 50;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                fiyat += 70;
            }

            //--------------------------------------------------------------------------------------------

            if (listBox1.SelectedIndex == 0)
            {
                fiyat += 90;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                fiyat += 110;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                fiyat += 130;
            }
            else if (listBox1.SelectedIndex == 3)
            {
                fiyat += 115;
            }
            else if (listBox1.SelectedIndex == 4)
            {
                fiyat += 120;
            }


            //--------------------------------------------------------------------------------------------

            if (radioButton1.Checked == true) 
            {
                fiyat += 15;
            }
            else if (radioButton2.Checked == true)
            {
                fiyat += 25;
            }
            //-----------------------------------------------------------------------------------------


            if(checkBoxdana.Checked == true)
            {
                fiyat += 35;
            }
            if (checkBoxsosis.Checked == true)
            {
                fiyat += 20;
            }
            if (checkBoxmısır.Checked == true)
            {
                fiyat += 15;
            }
            if (checkBoxançuez.Checked == true)
            {
                fiyat += 40;
            }
            if (checkBoxzeytin.Checked == true)
            {
                fiyat += 10;
            }
            if (checkBoxsalam.Checked == true)
            {
                fiyat += 35;
            }
            if (checkBoxsucuk.Checked == true)
            {
                fiyat += 22;
            }
            if (checkBoxmantar.Checked == true)
            {
                fiyat += 25;
            }
            if (checkBoxbalık.Checked == true)
            {
                fiyat += 33;
            }
            if (checkBoxpeynir.Checked == true)
            {
                fiyat += 5;
            }

            adet = Convert.ToInt32(textBox1.Text);
            fiyat = fiyat * adet;
            textBox2.Text = fiyat.ToString() + "TL";




        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
