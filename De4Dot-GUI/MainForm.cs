using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace De4DotGUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
		    InitializeComponent();
		    string environmentVariable = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
		    if (environmentVariable != null)
		        rbt64Bit.Enabled = environmentVariable.Equals("x64");
		}

        private void btnSearchInput_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog())
            {
                of.Filter = "PE files (*.exe, *.dll)|*.exe;*.dll|All Files|*.*";
                of.CheckFileExists = true;
                of.CheckPathExists = true;
                of.ReadOnlyChecked = false;
                of.RestoreDirectory = true;
                of.Multiselect = false;

                if (of.ShowDialog() != DialogResult.OK) return;
                string filename = of.FileName;
                txtInput.Text = filename;
                Regex regex = new Regex(@"(?<filename>.+?)(?<extension>\..+?)$", RegexOptions.CultureInvariant);
                Match match = regex.Match(filename);
                // Bug is if the full path contains some dot other than in the suffix of file extension, such as dot in folder name or file name, the automated path of output file will break. No fix yet, user has to specify it manually.
                txtOutput.Text = match.Groups.Count > 0 ? String.Format("{0}_de4dot{1}", match.Groups["filename"].Value, match.Groups["extension"].Value) : String.Format("{0}_de4dot", filename);
            }
        }

        private void btnSearchOutput_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "All Files|*.*";
                sf.CheckFileExists = false;
                sf.CheckPathExists = true;
                sf.RestoreDirectory = true;
                sf.FileName = txtOutput.Text;

                if (sf.ShowDialog() == DialogResult.OK)
                    txtOutput.Text = sf.FileName;
            }
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtInput.Text))
            {
                MessageBox.Show("输入文件不存在！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtInput.Text == txtOutput.Text)
            {
                MessageBox.Show("输出文件必须与输入文件不一致！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string exeName = "de4dot.exe";
            if (rbt64Bit.Checked)
                exeName = "de4dot-x64.exe";

            if (!File.Exists(exeName))
            {
                MessageBox.Show(exeName + "此文件无法找到！de4dot必须与此图形界面程序在同一文件目录内。", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string arguments = String.Format("-f \"{0}\" -o \"{1}\" {2}", txtInput.Text, txtOutput.Text, txtAdditional.Text);

// ReSharper disable InconsistentNaming
            Process de4dot = new Process
// ReSharper restore InconsistentNaming
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = exeName,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            try
            {
                txtOut.AppendText(String.Format("=== 反混淆开始 ==={0}{0}命令行： {1}{0}输出：{0}", "\r\n", String.Format("{0} {1}", exeName, arguments)));
                de4dot.Start();
                while (!de4dot.StandardOutput.EndOfStream)
                    txtOut.AppendText(String.Format("{0}{1}", de4dot.StandardOutput.ReadLine(), "\r\n"));
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("此程序必须与de4dot在同一个文件夹内！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtOut.AppendText(String.Format("{0}{0}=== 反混淆结束 ==={0}{0}", "\r\n"));
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "https://github.com/Tianjiao/de4dot/blob/master/%E8%87%B4%E4%B8%AD%E5%9B%BD%E5%8C%BA%E7%94%A8%E6%88%B7%E7%9A%84%E4%B8%80%E5%B0%81%E4%BF%A1.md");
        }
    }
}
