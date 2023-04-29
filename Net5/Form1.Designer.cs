﻿using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Net5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button4 = new Button();
            label11 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBoxAll = new CheckBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(424, 28);
            button1.Name = "button1";
            button1.Size = new Size(120, 35);
            button1.TabIndex = 0;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 144);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 10;
            label3.Text = "symbol3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 173);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 9;
            label4.Text = "symbol4";
            label4.Click += label4_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 114);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 8;
            label2.Text = "symbol2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 85);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 7;
            label1.Text = "symbol1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 206);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 14;
            label5.Text = "symbol5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 237);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 13;
            label6.Text = "symbol6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 265);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 12;
            label7.Text = "symbol7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 298);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 11;
            label8.Text = "symbol8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 331);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 16;
            label9.Text = "symbol9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 364);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 15;
            label10.Text = "symbol10";
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(424, 446);
            button4.Name = "button4";
            button4.Size = new Size(120, 35);
            button4.TabIndex = 17;
            button4.Text = "Run";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(51, 33);
            label11.Name = "label11";
            label11.Size = new Size(186, 24);
            label11.TabIndex = 18;
            label11.Text = "Locate Master Folder";
            label11.Click += label11_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(477, 84);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 19;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(477, 117);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 20;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(477, 147);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(18, 17);
            checkBox3.TabIndex = 21;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(477, 176);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(18, 17);
            checkBox4.TabIndex = 22;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(477, 209);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(18, 17);
            checkBox5.TabIndex = 23;
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(477, 240);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(18, 17);
            checkBox6.TabIndex = 24;
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(477, 268);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(18, 17);
            checkBox7.TabIndex = 25;
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(477, 301);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(18, 17);
            checkBox8.TabIndex = 26;
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(477, 334);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(18, 17);
            checkBox9.TabIndex = 27;
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(477, 367);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(18, 17);
            checkBox10.TabIndex = 28;
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBoxAll
            // 
            checkBoxAll.AutoSize = true;
            checkBoxAll.Location = new Point(477, 402);
            checkBoxAll.Name = "checkBoxAll";
            checkBoxAll.Size = new Size(18, 17);
            checkBoxAll.TabIndex = 29;
            checkBoxAll.UseVisualStyleBackColor = true;
            checkBoxAll.CheckedChanged += checkBoxAll_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(51, 395);
            label12.Name = "label12";
            label12.Size = new Size(94, 24);
            label12.TabIndex = 30;
            label12.Text = "Enable All";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 526);
            Controls.Add(label12);
            Controls.Add(checkBoxAll);
            Controls.Add(checkBox10);
            Controls.Add(checkBox9);
            Controls.Add(checkBox8);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label11);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button4;
        private Label label11;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBoxAll;
        private Label label12;
    }
}