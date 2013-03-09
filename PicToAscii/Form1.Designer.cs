namespace PicToAscii
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureView = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.converterButton = new System.Windows.Forms.Button();
            this.precision1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.OutSizeGroup = new System.Windows.Forms.GroupBox();
            this.scaleUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PicSizeLabel = new System.Windows.Forms.Label();
            this.ToHtml = new System.Windows.Forms.RadioButton();
            this.ToBmp = new System.Windows.Forms.RadioButton();
            this.ToTxt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precision1)).BeginInit();
            this.OutSizeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureView
            // 
            this.pictureView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureView.Location = new System.Drawing.Point(3, 17);
            this.pictureView.Name = "pictureView";
            this.pictureView.Size = new System.Drawing.Size(620, 469);
            this.pictureView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureView.TabIndex = 0;
            this.pictureView.TabStop = false;
            this.pictureView.SizeChanged += new System.EventHandler(this.pictureView_SizeChanged);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(6, 20);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(95, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // converterButton
            // 
            this.converterButton.Location = new System.Drawing.Point(6, 49);
            this.converterButton.Name = "converterButton";
            this.converterButton.Size = new System.Drawing.Size(95, 23);
            this.converterButton.TabIndex = 3;
            this.converterButton.Text = "converter";
            this.converterButton.UseVisualStyleBackColor = true;
            this.converterButton.Click += new System.EventHandler(this.converterButton_Click);
            // 
            // precision1
            // 
            this.precision1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.precision1.Location = new System.Drawing.Point(9, 20);
            this.precision1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.precision1.Name = "precision1";
            this.precision1.Size = new System.Drawing.Size(66, 21);
            this.precision1.TabIndex = 4;
            this.precision1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "output Option:";
            // 
            // OutSizeGroup
            // 
            this.OutSizeGroup.Controls.Add(this.scaleUpDown);
            this.OutSizeGroup.Controls.Add(this.label1);
            this.OutSizeGroup.Location = new System.Drawing.Point(6, 259);
            this.OutSizeGroup.Name = "OutSizeGroup";
            this.OutSizeGroup.Size = new System.Drawing.Size(95, 72);
            this.OutSizeGroup.TabIndex = 10;
            this.OutSizeGroup.TabStop = false;
            this.OutSizeGroup.Text = "outSize";
            this.OutSizeGroup.Visible = false;
            // 
            // scaleUpDown
            // 
            this.scaleUpDown.Location = new System.Drawing.Point(9, 45);
            this.scaleUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scaleUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scaleUpDown.Name = "scaleUpDown";
            this.scaleUpDown.Size = new System.Drawing.Size(66, 21);
            this.scaleUpDown.TabIndex = 1;
            this.scaleUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "scale:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.precision1);
            this.groupBox3.Location = new System.Drawing.Point(6, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 52);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "outPrecision";
            // 
            // PicSizeLabel
            // 
            this.PicSizeLabel.AutoSize = true;
            this.PicSizeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PicSizeLabel.Location = new System.Drawing.Point(3, 486);
            this.PicSizeLabel.Name = "PicSizeLabel";
            this.PicSizeLabel.Size = new System.Drawing.Size(89, 12);
            this.PicSizeLabel.TabIndex = 12;
            this.PicSizeLabel.Text = "Picture Size :";
            // 
            // ToHtml
            // 
            this.ToHtml.AutoSize = true;
            this.ToHtml.Location = new System.Drawing.Point(9, 37);
            this.ToHtml.Name = "ToHtml";
            this.ToHtml.Size = new System.Drawing.Size(59, 16);
            this.ToHtml.TabIndex = 7;
            this.ToHtml.Text = "ToHtml";
            this.ToHtml.UseVisualStyleBackColor = true;
            // 
            // ToBmp
            // 
            this.ToBmp.AutoSize = true;
            this.ToBmp.Location = new System.Drawing.Point(9, 59);
            this.ToBmp.Name = "ToBmp";
            this.ToBmp.Size = new System.Drawing.Size(53, 16);
            this.ToBmp.TabIndex = 8;
            this.ToBmp.Text = "ToBmp";
            this.ToBmp.UseVisualStyleBackColor = true;
            this.ToBmp.CheckedChanged += new System.EventHandler(this.ToBmp_CheckedChanged);
            // 
            // ToTxt
            // 
            this.ToTxt.AutoSize = true;
            this.ToTxt.Checked = true;
            this.ToTxt.Location = new System.Drawing.Point(9, 15);
            this.ToTxt.Name = "ToTxt";
            this.ToTxt.Size = new System.Drawing.Size(53, 16);
            this.ToTxt.TabIndex = 6;
            this.ToTxt.TabStop = true;
            this.ToTxt.Text = "ToTxt";
            this.ToTxt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToTxt);
            this.groupBox1.Controls.Add(this.ToBmp);
            this.groupBox1.Controls.Add(this.ToHtml);
            this.groupBox1.Location = new System.Drawing.Point(6, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 82);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "outType";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.openButton);
            this.groupBox2.Controls.Add(this.converterButton);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.OutSizeGroup);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(626, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 501);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureView);
            this.groupBox4.Controls.Add(this.PicSizeLabel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(626, 501);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(738, 501);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "PicToAscii";
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precision1)).EndInit();
            this.OutSizeGroup.ResumeLayout(false);
            this.OutSizeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureView;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button converterButton;
        private System.Windows.Forms.NumericUpDown precision1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox OutSizeGroup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label PicSizeLabel;
        private System.Windows.Forms.RadioButton ToHtml;
        private System.Windows.Forms.RadioButton ToBmp;
        private System.Windows.Forms.RadioButton ToTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown scaleUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

