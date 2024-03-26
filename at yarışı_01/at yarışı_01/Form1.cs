using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarışı_01
{
    public partial class Form1 : Form
    {
        Random rst = new Random();
        int mesafe1, mesafe2, mesafe3;
        public Form1()
            
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        double saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label2.Text = "Süre: " + (saniye/10).ToString();
            if (pictureBox1.Left < pictureBox2.Left && pictureBox2.Left > pictureBox3.Left)
            {
                label1.Text = "2. at önde";
            }
            if (pictureBox3.Left > pictureBox2.Left && pictureBox3.Left > pictureBox1.Left)
            {
                label1.Text = "karakaçan önde";
               
            }
            if (pictureBox1.Left > pictureBox2.Left && pictureBox1.Left > pictureBox3.Left)
            {
                label1.Text = "1. at önde";
             }
            pictureBox1.Left += rst.Next(16);
            pictureBox2.Left += rst.Next(16);
            pictureBox3.Left += rst.Next(16);



            if (pictureBox1.Left > pictureBox4.Left )
            {
                timer1.Stop();
               MessageBox.Show("1. at kazandı");
                listBox1.Items.Add("1.at şampiyon");
                label1.Text = "1. at önde bitirerek kazandı";
               
                
            }
            if (pictureBox2.Left > pictureBox4.Left )
            {
                timer1.Stop();
                MessageBox.Show("2. at kazandı ");
                listBox1.Items.Add("2.at şampiyon");
                label1.Text = "2. at önde bitirerek kazandı";
                
            }
            if (pictureBox3.Left > pictureBox4.Left )
            {
                timer1.Stop();
                MessageBox.Show("karakaçan  kazandı");
                listBox1.Items.Add("karakaçan kazandı");
                label1.Text = "karakaçan önde bitirerek kazandı";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(13, pictureBox1.Location.Y);
            pictureBox2.Location = new Point(13, pictureBox2.Location.Y);
            pictureBox3.Location = new Point(13, pictureBox3.Location.Y);
            listBox1.Items.Clear();
            label2.Text = "0";
            label1.Text = "0";
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
