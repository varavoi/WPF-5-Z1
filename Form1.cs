using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_5_Z1
{
    public partial class Form1 : Form
    {
        public bool isCreate = false;
        List <string>informData;
        
        public Form1()
        {
            InitializeComponent();
            listBox1.Text = "";
            informData = new List<string>();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int N=listBox1.SelectedIndex;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isCreate = true;
            informData.Add(label1.Text + ": " + textBox1.Text + "\n" + label2.Text +
                ": " + textBox2.Text + "\n" + label3.Text +
                ": " + textBox3.Text + "\n" + label4.Text +
                ": " + textBox4.Text + "\n" + label5.Text +
                ": " + textBox5.Text + "\n" + label6.Text +
                ": " + textBox6.Text + "\n");
            listBox1.Items.Add(textBox1.Text);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int N = listBox1.SelectedIndex;
            MessageBox.Show( informData[N], "Информация");
            
        }
    }
}
