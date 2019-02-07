using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file1Path = maskedTextBox1.Text;
            string file2Path = maskedTextBox2.Text;
            string file3Path = maskedTextBox3.Text;
            string input = inputTextBox.Text;
            string output = "";
            Process proc = new Process {
                StartInfo = new ProcessStartInfo
                {
                    FileName = file1Path,
                    Arguments = input,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                output = proc.StandardOutput.ReadLine();
                // do something with line
            }
            proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = file2Path,
                    Arguments = output,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                output = proc.StandardOutput.ReadLine();
                // do something with line
            }
            proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = file3Path,
                    Arguments = output,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                output = proc.StandardOutput.ReadLine();
                // do something with line
            }
            outputLable.Text += output;



        }
    }
}
