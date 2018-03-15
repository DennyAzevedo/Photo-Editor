using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IUP_Lab1
{
    public partial class Form1 : Form
    {
        private Preprocessing imageProcess;

        public Form1()
        {
            InitializeComponent();
            imageProcess = new Preprocessing();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.CurrentDirectory+"\\images";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imageProcess.LoadOriginal(ofd.FileName);
                pb_Original.ImageLocation = "savedOriginalImage.jpg";
            }
        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            imageProcess.ToGrayscale();
            pb_Modified.ImageLocation = "savedGrayImage.jpg";
        }

        private void btnThreshold_Click(object sender, EventArgs e)
        {
            imageProcess.ToThreshold();
            pb_Modified.ImageLocation = "savedThresholdImage.jpg";
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you want Color or Gray Negative? \nNo = Gray Negative\nYes = Color Negative", "Negative Type Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                imageProcess.ToNegative();
            }
            else
            {
                imageProcess.ToGrayNegative();
            }
            pb_Modified.ImageLocation = "savedNegativeImage.jpg";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            imageProcess.dynamicThreshold(trackBar1.Value);
            pb_Modified.ImageLocation = "savedThresholdImage.jpg";
            txtThresh.Text = Convert.ToString(trackBar1.Value);
        }

        private void txtThresh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                imageProcess.dynamicThreshold(Convert.ToInt32(txtThresh.Text));
                pb_Modified.ImageLocation = "savedThresholdImage.jpg";
                trackBar1.Value = Convert.ToInt32(txtThresh.Text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete("savedOriginalImage.jpg");
            File.Delete("savedGrayImage.jpg");
            File.Delete("savedThresholdImage.jpg");
            File.Delete("savedNegativeImage.jpg");
        }
    }
}
