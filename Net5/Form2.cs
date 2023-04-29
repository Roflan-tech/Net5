using Net5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace Net5
{
    public partial class Form2 : Form
    {
        List<CheckBox> specifiedCheckBoxes = new List<CheckBox>();

        public Form2()
        {
            InitializeComponent();

            specifiedCheckBoxes.Add(checkBox1);
            specifiedCheckBoxes.Add(checkBox2);
            specifiedCheckBoxes.Add(checkBox3);
            specifiedCheckBoxes.Add(checkBox4);
            specifiedCheckBoxes.Add(checkBox5);
            specifiedCheckBoxes.Add(checkBox6);
            specifiedCheckBoxes.Add(checkBox7);
            specifiedCheckBoxes.Add(checkBox8);
            specifiedCheckBoxes.Add(checkBox9);
            specifiedCheckBoxes.Add(checkBox10);
            try
            {
                label1.Text = Form1.labels[0];
                label2.Text = Form1.labels[1];
                label3.Text = Form1.labels[2];
                label4.Text = Form1.labels[3];
                label5.Text = Form1.labels[4];
                label6.Text = Form1.labels[5];
                label7.Text = Form1.labels[6];
                label8.Text = Form1.labels[7];
                label9.Text = Form1.labels[8];
                label10.Text = Form1.labels[9];
            }
            catch { }
        }

        void WriteFlags(System.Diagnostics.Process process, int f1, int f2, int f3, int f4)
        {
            string? path = Path.GetDirectoryName(process.MainModule.FileName);
            string? flagPath = Path.Combine(path, "TmpFlags.txt");
            try
            {
                using (StreamWriter writer = new StreamWriter(new FileStream(flagPath, FileMode.Open, FileAccess.Write)))
                {
                    writer.WriteLine(f1.ToString());
                    writer.WriteLine(f2.ToString());
                    writer.WriteLine(f3.ToString());
                    writer.WriteLine(f4.ToString());
                    writer.Flush();
                    writer.Close();
                }
            }
            catch { }
        }

        private void btnPrepareBot1_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[0], 1, 0, 0, 0);
            }
            catch { }
        }

        private void btnPrepareBot2_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[1], 1, 0, 0, 0);
            }
            catch { }
        }

        private void btnPrepareBot3_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[2], 1, 0, 0, 0);
            }
            catch { }
        }

        private void btnPrepareBot4_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[3], 1, 0, 0, 0);
            }
            catch { }
        }

        private void btnPrepareBot5_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[4], 1, 0, 0, 0);
            }
            catch { }
        }

        private void btnPrepareBot6_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[5], 1, 0, 0, 0);
            }
            catch { }
        }

        private void btnPrepareBot7_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[6], 1, 0, 0, 0);
            }
            catch { }
        }

        private void btnPrepareBot8_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[7], 1, 0, 0, 0);
            }
            catch { }
        }

        private void btnPrepareBot9_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[8], 1, 0, 0, 0);
            }
            catch { }
        }

        private void btnPrepareBot10_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[9], 1, 0, 0, 0);
            }
            catch { }
        }

        private void btnStartWatching1_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[0], 0, 1, 0, 0);
            }
            catch { }
        }

        private void btnStartWatching2_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[1], 0, 1, 0, 0);
            }
            catch { }
        }

        private void btnStartWatching3_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[2], 0, 1, 0, 0);
            }
            catch { }
        }

        private void btnStartWatching4_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[3], 0, 1, 0, 0);
            }
            catch { }
        }

        private void btnStartWatching5_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[4], 0, 1, 0, 0);
            }
            catch { }
        }

        private void btnStartWatching6_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[5], 0, 1, 0, 0);
            }
            catch { }
        }

        private void btnStartWatching7_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[6], 0, 1, 0, 0);
            }
            catch { }
        }

        private void btnStartWatching8_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[7], 0, 1, 0, 0);
            }
            catch { }
        }

        private void btnStartWatching9_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[8], 0, 1, 0, 0);
            }
            catch { }
        }

        private void btnStartWatching10_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[9], 0, 1, 0, 0);
            }
            catch { }
        }

        private void btnStopWatching1_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[0], 0, 0, 1, 0);
            }
            catch { }
        }

        private void btnStopWatching2_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[1], 0, 0, 1, 0);
            }
            catch { }
        }
        private void btnStopWatching3_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[2], 0, 0, 1, 0);
            }
            catch { }
        }
        private void btnStopWatching4_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[3], 0, 0, 1, 0);
            }
            catch { }
        }

        private void btnStopWatching5_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[4], 0, 0, 1, 0);
            }
            catch { }
        }

        private void btnStopWatching6_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[5], 0, 0, 1, 0);
            }
            catch { }
        }

        private void btnStopWatching7_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[6], 0, 0, 1, 0);
            }
            catch { }
        }

        private void btnStopWatching8_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[7], 0, 0, 1, 0);
            }
            catch { }
        }

        private void btnStopWatching9_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[8], 0, 0, 1, 0);
            }
            catch { }
        }

        private void btnStopWatching10_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[9], 0, 0, 1, 0);
            }
            catch { }
        }

        private void btnSellNow1_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[0], 0, 0, 0, 1);
            }
            catch { }
        }

        private void btnSellNow2_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[1], 0, 0, 0, 1);
            }
            catch { }
        }

        private void btnSellNow3_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[2], 0, 0, 0, 1);
            }
            catch { }
        }

        private void btnSellNow4_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[3], 0, 0, 0, 1);
            }
            catch { }
        }

        private void btnSellNow5_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[4], 0, 0, 0, 1);
            }
            catch { }
        }

        private void btnSellNow6_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[5], 0, 0, 0, 1);
            }
            catch { }
        }

        private void btnSellNow7_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[6], 0, 0, 0, 1);
            }
            catch { }
        }

        private void btnSellNow8_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[7], 0, 0, 0, 1);
            }
            catch { }
        }

        private void btnSellNow9_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[8], 0, 0, 0, 1);
            }
            catch { }
        }

        private void btnSellNow10_Click(object sender, EventArgs e)
        {
            try
            {
                WriteFlags(Form1.runningProcesses[9], 0, 0, 0, 1);
            }
            catch { }
        }

        private void btnSellNowAll_Click(object sender, EventArgs e)
        {
            if (specifiedCheckBoxes[0].Checked == true)
                btnSellNow1_Click(null, null);

            if (specifiedCheckBoxes[1].Checked == true)
                btnSellNow2_Click(null, null);

            if (specifiedCheckBoxes[2].Checked == true)
                btnSellNow3_Click(null, null);

            if (specifiedCheckBoxes[3].Checked == true)
                btnSellNow4_Click(null, null);

            if (specifiedCheckBoxes[4].Checked == true)
                btnSellNow5_Click(null, null);

            if (specifiedCheckBoxes[5].Checked == true)
                btnSellNow6_Click(null, null);

            if (specifiedCheckBoxes[6].Checked == true)
                btnSellNow7_Click(null, null);

            if (specifiedCheckBoxes[7].Checked == true)
                btnSellNow8_Click(null, null);

            if (specifiedCheckBoxes[8].Checked == true)
                btnSellNow9_Click(null, null);

            if (specifiedCheckBoxes[9].Checked == true)
                btnSellNow10_Click(null, null);

        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            // Get the trigger checkbox that was checked/unchecked
            CheckBox triggerCheckBox = (CheckBox)sender;

            // Loop through the other specified checkboxes and set their Checked property to be the same as the trigger checkbox
            foreach (CheckBox otherCheckBox in specifiedCheckBoxes)
            {
                if (otherCheckBox != triggerCheckBox) // Make sure not to check/uncheck the trigger checkbox again
                {
                    otherCheckBox.Checked = triggerCheckBox.Checked;
                }
            }
        }
    }
}
