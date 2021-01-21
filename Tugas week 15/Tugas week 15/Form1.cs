using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_week_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] Makan = new string[11];
        public string[] Minum = new string[11];
        
        private void buttoninput_Click(object sender, EventArgs e)
        {
            int counter = 4;
            int counter1 = 5;
            Makan[0] = "Mie Instan";
            Makan[1] = "Telor";
            Makan[2] = "Roti";
            Makan[3] = "Keju";
            Makan[4] = "Daging Giling";
            Minum[0] = "Susu Sapi";
            Minum[1] = "Kopi";
            Minum[2] = "Teh";
            Minum[3] = "Bir";
            if (radiobuttonMakanan.Checked == true)
            {
                if (textBoxInput.Text == Makan[0] || textBoxInput.Text == Makan[1] || textBoxInput.Text == Makan[2] || textBoxInput.Text == Makan[3] || textBoxInput.Text == Makan[4] || textBoxInput.Text == Makan[5] || textBoxInput.Text == Makan[6] || textBoxInput.Text == Makan[7] || textBoxInput.Text == Makan[8] || textBoxInput.Text == Makan[9] || textBoxInput.Text == Makan[10])
                {
                    MessageBox.Show("ERROR");
                }
                else
                {
                    listBoxSimpan.Items.Add(textBoxInput.Text);
                    Makan[counter1] = textBoxInput.Text;
                    counter1++;
                }
            }
                if (radiobuttonMinuman.Checked == true)
                {
                    if(textBoxInput.Text == Minum[0] || textBoxInput.Text == Minum[1] || textBoxInput.Text == Minum[2] || textBoxInput.Text == Minum[3] || textBoxInput.Text == Minum[4] || textBoxInput.Text == Minum[5] || textBoxInput.Text == Minum[6] || textBoxInput.Text == Minum[7] || textBoxInput.Text == Minum[8] || textBoxInput.Text == Minum[9] || textBoxInput.Text == Minum[10])
                    {
                        MessageBox.Show("ERROR");
                    }
                    else
                    {
                        listBoxSimpan.Items.Add(textBoxInput.Text);
                        Minum[counter] = textBoxInput.Text;
                        counter++;
                    }
                }
                radiobuttonMakanan.Checked = false;
                radiobuttonMinuman.Checked = false;
                textBoxInput.Text = "";
                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttoncopy_Click(object sender, EventArgs e)
        {
            foreach (object beverage in listBoxSimpan.SelectedItems)
            {
                listBoxPilih.Items.Add(beverage.ToString());
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if(listBoxPilih.SelectedIndex > -1)
            {
                for (int i = listBoxPilih.SelectedIndices.Count -1; i >= 0; i--)
                {
                    int d = listBoxPilih.SelectedIndices[i];
                    listBoxPilih.Items.RemoveAt(d);
                }
            }
            else
            {
                listBoxPilih.Items.Clear();
            }
        }

        private void checkBoxMakanan_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void checkBoxMinuman_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
