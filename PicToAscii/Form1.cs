﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PicToAscii
{
    public partial class Form1 : Form
    {
        Converter converter;
        public Form1()
        {
            InitializeComponent();

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图像文件|*.bmp;*.jpg;*.jpeg;*.gif;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                converter = new Converter(new Bitmap(ofd.FileName));
                PicSizeLabel.Text = "Picture Size : " + converter.Bmp.Width
                    + "X" + converter.Bmp.Height;     
                pictureView.Image = converter.Bmp;
                if (converter.Bmp.Width > pictureView.Width  ||
                    converter.Bmp.Height > pictureView.Height)
                {
                    pictureView.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else { pictureView.SizeMode = PictureBoxSizeMode.CenterImage; }
            }
        }

        private void converterButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd=new SaveFileDialog();
            if (ToBmp.Checked)
            {
                converter.Precision = (int)precision1.Value;
                converter.Scale = (int)scaleUpDown.Value;
                sfd.Filter="bmp文件|*.bmp";
                if(sfd.ShowDialog()==DialogResult.OK) converter.writePic(sfd.FileName);
            }else {
                converter.Precision = (int)precision1.Value;
                if (ToTxt.Checked)
                {
                    sfd.Filter = "txt文件|*.txt";
                    if (sfd.ShowDialog() == DialogResult.OK) converter.writeTxt(sfd.FileName);
                }
                else
                {
                    sfd.Filter = "Html文件|*.html;*.htm";
                    if (sfd.ShowDialog() == DialogResult.OK) converter.writeHtml(sfd.FileName);
                }
            }
        }

        private void ToBmp_CheckedChanged(object sender, EventArgs e)
        {
            if (ToBmp.Checked) OutSizeGroup.Visible = true;
            else OutSizeGroup.Visible = false;
        }

        private void pictureView_SizeChanged(object sender, EventArgs e)
        {
            if (converter.Bmp.Width > pictureView.Width ||
                    converter.Bmp.Height > pictureView.Height)
            {
                pictureView.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else { pictureView.SizeMode = PictureBoxSizeMode.CenterImage; }
        }
    }
}
