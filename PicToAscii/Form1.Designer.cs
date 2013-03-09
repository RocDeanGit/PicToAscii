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
            this.KeepAspect = new System.Windows.Forms.CheckBox();
            this.OutSizeY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.OutSizeX = new System.Windows.Forms.NumericUpDown();
            this.customSize = new System.Windows.Forms.RadioButton();
            this.originalSize = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.precision2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PicSizeLabel = new System.Windows.Forms.Label();
            this.ToHtml = new System.Windows.Forms.RadioButton();
            this.ToBmp = new System.Windows.Forms.RadioButton();
            this.ToTxt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precision1)).BeginInit();
            this.OutSizeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutSizeX)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precision2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureView
            // 
            this.pictureView.Location = new System.Drawing.Point(0, -1);
            this.pictureView.Name = "pictureView";
            this.pictureView.Size = new System.Drawing.Size(812, 537);
            this.pictureView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureView.TabIndex = 0;
            this.pictureView.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(820, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // converterButton
            // 
            this.converterButton.Location = new System.Drawing.Point(941, 12);
            this.converterButton.Name = "converterButton";
            this.converterButton.Size = new System.Drawing.Size(75, 23);
            this.converterButton.TabIndex = 3;
            this.converterButton.Text = "converter";
            this.converterButton.UseVisualStyleBackColor = true;
            this.converterButton.Click += new System.EventHandler(this.converterButton_Click);
            // 
            // precision1
            // 
            this.precision1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.precision1.Location = new System.Drawing.Point(134, 12);
            this.precision1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.precision1.Name = "precision1";
            this.precision1.Size = new System.Drawing.Size(42, 21);
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
            this.label2.Location = new System.Drawing.Point(818, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "output Option:";
            // 
            // OutSizeGroup
            // 
            this.OutSizeGroup.Controls.Add(this.KeepAspect);
            this.OutSizeGroup.Controls.Add(this.OutSizeY);
            this.OutSizeGroup.Controls.Add(this.label3);
            this.OutSizeGroup.Controls.Add(this.OutSizeX);
            this.OutSizeGroup.Controls.Add(this.customSize);
            this.OutSizeGroup.Controls.Add(this.originalSize);
            this.OutSizeGroup.Location = new System.Drawing.Point(820, 267);
            this.OutSizeGroup.Name = "OutSizeGroup";
            this.OutSizeGroup.Size = new System.Drawing.Size(196, 91);
            this.OutSizeGroup.TabIndex = 10;
            this.OutSizeGroup.TabStop = false;
            this.OutSizeGroup.Text = "outSize(Just For Bmp)";
            // 
            // KeepAspect
            // 
            this.KeepAspect.AutoSize = true;
            this.KeepAspect.Checked = true;
            this.KeepAspect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KeepAspect.Location = new System.Drawing.Point(89, 39);
            this.KeepAspect.Name = "KeepAspect";
            this.KeepAspect.Size = new System.Drawing.Size(90, 16);
            this.KeepAspect.TabIndex = 5;
            this.KeepAspect.Text = "keep aspect";
            this.KeepAspect.UseVisualStyleBackColor = true;
            // 
            // OutSizeY
            // 
            this.OutSizeY.Location = new System.Drawing.Point(105, 62);
            this.OutSizeY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.OutSizeY.Name = "OutSizeY";
            this.OutSizeY.Size = new System.Drawing.Size(49, 21);
            this.OutSizeY.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            // 
            // OutSizeX
            // 
            this.OutSizeX.Location = new System.Drawing.Point(29, 62);
            this.OutSizeX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.OutSizeX.Name = "OutSizeX";
            this.OutSizeX.Size = new System.Drawing.Size(50, 21);
            this.OutSizeX.TabIndex = 2;
            // 
            // customSize
            // 
            this.customSize.AutoSize = true;
            this.customSize.Location = new System.Drawing.Point(9, 39);
            this.customSize.Name = "customSize";
            this.customSize.Size = new System.Drawing.Size(59, 16);
            this.customSize.TabIndex = 1;
            this.customSize.Text = "custom";
            this.customSize.UseVisualStyleBackColor = true;
            // 
            // originalSize
            // 
            this.originalSize.AutoSize = true;
            this.originalSize.Checked = true;
            this.originalSize.Location = new System.Drawing.Point(9, 17);
            this.originalSize.Name = "originalSize";
            this.originalSize.Size = new System.Drawing.Size(101, 16);
            this.originalSize.TabIndex = 0;
            this.originalSize.TabStop = true;
            this.originalSize.Text = "original size";
            this.originalSize.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.precision2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.precision1);
            this.groupBox3.Location = new System.Drawing.Point(820, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 137);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "outPrecision";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 52);
            this.label6.TabIndex = 7;
            this.label6.Text = "PS:For Txt or Html 1,2,3 maybe can get the best effect;And For Bmp 4,5 are the be" +
    "tter choice";
            // 
            // precision2
            // 
            this.precision2.Location = new System.Drawing.Point(134, 39);
            this.precision2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.precision2.Name = "precision2";
            this.precision2.Size = new System.Drawing.Size(42, 21);
            this.precision2.TabIndex = 6;
            this.precision2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "For Bmp :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "For Txt or Html:";
            // 
            // PicSizeLabel
            // 
            this.PicSizeLabel.AutoSize = true;
            this.PicSizeLabel.Location = new System.Drawing.Point(826, 372);
            this.PicSizeLabel.Name = "PicSizeLabel";
            this.PicSizeLabel.Size = new System.Drawing.Size(89, 12);
            this.PicSizeLabel.TabIndex = 12;
            this.PicSizeLabel.Text = "Picture Size :";
            // 
            // ToHtml
            // 
            this.ToHtml.AutoSize = true;
            this.ToHtml.Location = new System.Drawing.Point(69, 15);
            this.ToHtml.Name = "ToHtml";
            this.ToHtml.Size = new System.Drawing.Size(59, 16);
            this.ToHtml.TabIndex = 7;
            this.ToHtml.Text = "ToHtml";
            this.ToHtml.UseVisualStyleBackColor = true;
            // 
            // ToBmp
            // 
            this.ToBmp.AutoSize = true;
            this.ToBmp.Location = new System.Drawing.Point(134, 15);
            this.ToBmp.Name = "ToBmp";
            this.ToBmp.Size = new System.Drawing.Size(53, 16);
            this.ToBmp.TabIndex = 8;
            this.ToBmp.Text = "ToBmp";
            this.ToBmp.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(820, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 39);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "outType";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1035, 536);
            this.Controls.Add(this.PicSizeLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.OutSizeGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.converterButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.pictureView);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "PicToAscii";
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precision1)).EndInit();
            this.OutSizeGroup.ResumeLayout(false);
            this.OutSizeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutSizeX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precision2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureView;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button converterButton;
        private System.Windows.Forms.NumericUpDown precision1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox OutSizeGroup;
        private System.Windows.Forms.CheckBox KeepAspect;
        private System.Windows.Forms.NumericUpDown OutSizeY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown OutSizeX;
        private System.Windows.Forms.RadioButton customSize;
        private System.Windows.Forms.RadioButton originalSize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown precision2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PicSizeLabel;
        private System.Windows.Forms.RadioButton ToHtml;
        private System.Windows.Forms.RadioButton ToBmp;
        private System.Windows.Forms.RadioButton ToTxt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

