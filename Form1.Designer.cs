namespace ColorModels
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabRGB = new System.Windows.Forms.TabPage();
            this.rgbCubeControl2 = new ColorModels.RGBCubeControl();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tabHSV = new System.Windows.Forms.TabPage();
            this.labelValue = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelSaturation = new System.Windows.Forms.Label();
            this.textBoxSaturation = new System.Windows.Forms.TextBox();
            this.labelHue = new System.Windows.Forms.Label();
            this.textBoxHue = new System.Windows.Forms.TextBox();
            this.tabXYZ = new System.Windows.Forms.TabPage();
            this.labelZ = new System.Windows.Forms.Label();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.rgbCubeControl1 = new ColorModels.RGBCubeControl();
            this.tabController.SuspendLayout();
            this.tabRGB.SuspendLayout();
            this.tabHSV.SuspendLayout();
            this.tabXYZ.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabRGB);
            this.tabController.Controls.Add(this.tabHSV);
            this.tabController.Controls.Add(this.tabXYZ);
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(0, 0);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(642, 429);
            this.tabController.TabIndex = 0;
            // 
            // tabRGB
            // 
            this.tabRGB.Controls.Add(this.rgbCubeControl2);
            this.tabRGB.Controls.Add(this.label4);
            this.tabRGB.Controls.Add(this.textBox6);
            this.tabRGB.Controls.Add(this.label5);
            this.tabRGB.Controls.Add(this.textBox7);
            this.tabRGB.Controls.Add(this.label6);
            this.tabRGB.Controls.Add(this.textBox8);
            this.tabRGB.Location = new System.Drawing.Point(4, 22);
            this.tabRGB.Name = "tabRGB";
            this.tabRGB.Padding = new System.Windows.Forms.Padding(3);
            this.tabRGB.Size = new System.Drawing.Size(634, 403);
            this.tabRGB.TabIndex = 0;
            this.tabRGB.Text = "RGB";
            this.tabRGB.UseVisualStyleBackColor = true;
            // 
            // rgbCubeControl2
            // 
            this.rgbCubeControl2.Location = new System.Drawing.Point(49, 19);
            this.rgbCubeControl2.Name = "rgbCubeControl2";
            this.rgbCubeControl2.Size = new System.Drawing.Size(405, 312);
            this.rgbCubeControl2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Blue (0-255)";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(531, 97);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Green (0-255)";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(531, 58);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Red (0-255)";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(531, 19);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 5;
            // 
            // tabHSV
            // 
            this.tabHSV.Controls.Add(this.labelValue);
            this.tabHSV.Controls.Add(this.textBoxValue);
            this.tabHSV.Controls.Add(this.labelSaturation);
            this.tabHSV.Controls.Add(this.textBoxSaturation);
            this.tabHSV.Controls.Add(this.labelHue);
            this.tabHSV.Controls.Add(this.textBoxHue);
            this.tabHSV.Location = new System.Drawing.Point(4, 22);
            this.tabHSV.Name = "tabHSV";
            this.tabHSV.Padding = new System.Windows.Forms.Padding(3);
            this.tabHSV.Size = new System.Drawing.Size(634, 403);
            this.tabHSV.TabIndex = 1;
            this.tabHSV.Text = "HSV";
            this.tabHSV.UseVisualStyleBackColor = true;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(529, 81);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(70, 13);
            this.labelValue.TabIndex = 6;
            this.labelValue.Text = "Value (0-100)";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(532, 97);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxValue.TabIndex = 4;
            // 
            // labelSaturation
            // 
            this.labelSaturation.AutoSize = true;
            this.labelSaturation.Location = new System.Drawing.Point(529, 42);
            this.labelSaturation.Name = "labelSaturation";
            this.labelSaturation.Size = new System.Drawing.Size(91, 13);
            this.labelSaturation.TabIndex = 8;
            this.labelSaturation.Text = "Saturation (0-100)";
            // 
            // textBoxSaturation
            // 
            this.textBoxSaturation.Location = new System.Drawing.Point(532, 58);
            this.textBoxSaturation.Name = "textBoxSaturation";
            this.textBoxSaturation.Size = new System.Drawing.Size(100, 20);
            this.textBoxSaturation.TabIndex = 3;
            this.textBoxSaturation.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelHue
            // 
            this.labelHue.AutoSize = true;
            this.labelHue.Location = new System.Drawing.Point(529, 3);
            this.labelHue.Name = "labelHue";
            this.labelHue.Size = new System.Drawing.Size(63, 13);
            this.labelHue.TabIndex = 7;
            this.labelHue.Text = "Hue (0-359)";
            this.labelHue.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxHue
            // 
            this.textBoxHue.Location = new System.Drawing.Point(532, 19);
            this.textBoxHue.Name = "textBoxHue";
            this.textBoxHue.Size = new System.Drawing.Size(100, 20);
            this.textBoxHue.TabIndex = 5;
            // 
            // tabXYZ
            // 
            this.tabXYZ.Controls.Add(this.labelZ);
            this.tabXYZ.Controls.Add(this.textBoxZ);
            this.tabXYZ.Controls.Add(this.labelY);
            this.tabXYZ.Controls.Add(this.textBoxY);
            this.tabXYZ.Controls.Add(this.labelX);
            this.tabXYZ.Controls.Add(this.textBoxX);
            this.tabXYZ.Location = new System.Drawing.Point(4, 22);
            this.tabXYZ.Name = "tabXYZ";
            this.tabXYZ.Padding = new System.Windows.Forms.Padding(3);
            this.tabXYZ.Size = new System.Drawing.Size(634, 403);
            this.tabXYZ.TabIndex = 2;
            this.tabXYZ.Text = "XYZ";
            this.tabXYZ.UseVisualStyleBackColor = true;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(528, 81);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(50, 13);
            this.labelZ.TabIndex = 2;
            this.labelZ.Text = "Z ( 0 - 1 )";
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(531, 97);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxZ.TabIndex = 1;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(528, 42);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(50, 13);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Y ( 0 - 1 )";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(531, 58);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 1;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(528, 3);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(50, 13);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X ( 0 - 1 )";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(531, 19);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 1;
            // 
            // rgbCubeControl1
            // 
            this.rgbCubeControl1.Location = new System.Drawing.Point(17, 19);
            this.rgbCubeControl1.Name = "rgbCubeControl1";
            this.rgbCubeControl1.Size = new System.Drawing.Size(483, 341);
            this.rgbCubeControl1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 429);
            this.Controls.Add(this.tabController);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabController.ResumeLayout(false);
            this.tabRGB.ResumeLayout(false);
            this.tabRGB.PerformLayout();
            this.tabHSV.ResumeLayout(false);
            this.tabHSV.PerformLayout();
            this.tabXYZ.ResumeLayout(false);
            this.tabXYZ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage tabRGB;
        private System.Windows.Forms.TabPage tabHSV;
        private System.Windows.Forms.TabPage tabXYZ;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label labelSaturation;
        private System.Windows.Forms.TextBox textBoxSaturation;
        private System.Windows.Forms.Label labelHue;
        private System.Windows.Forms.TextBox textBoxHue;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxY;
        private RGBCubeControl rgbCubeControl1;
        private RGBCubeControl rgbCubeControl2;
    }
}

