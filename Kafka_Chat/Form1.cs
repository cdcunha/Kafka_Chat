using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafka_Chat
{
    public partial class Form1 : Form
    {
        private StringBuilder sbZookeeperOutput = new StringBuilder("");
        private StringBuilder sbKafkaOutput = new StringBuilder("");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lbKafkaPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        #region Zookeeper
        private void DoOutZookprToForm(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (edLogZookeeper.InvokeRequired)
            {
                edLogZookeeper.BeginInvoke(new DataReceivedEventHandler(DoOutZookprToForm), new[] { sendingProcess, outLine });
            }
            else
            {
                sbZookeeperOutput.Append(Environment.NewLine + outLine.Data);
                edLogZookeeper.AppendText(sbZookeeperOutput.ToString());
            }
        }

        private void DoErrOutZookprToForm(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!string.IsNullOrEmpty(outLine.Data))
            {
                if (edLogZookeeper.InvokeRequired)
                {
                    edLogZookeeper.BeginInvoke(new DataReceivedEventHandler(DoErrOutZookprToForm), new[] { sendingProcess, outLine });
                }
                else
                {
                    sbZookeeperOutput.Append(Environment.NewLine + outLine.Data);
                    edLogZookeeper.AppendText(sbZookeeperOutput.ToString());
                }
            }
        }

        private void ExitedZookpr(object sendingProcess, EventArgs e)
        {
            string text = "# # # END OF PROCESS # # #";
            if (edLogZookeeper.InvokeRequired)
            {
                edLogZookeeper.BeginInvoke(new EventHandler(ExitedZookpr), new[] { sendingProcess, e });
            }
            else
            {
                sbZookeeperOutput.Append(Environment.NewLine + text);
                edLogZookeeper.AppendText(sbZookeeperOutput.ToString());
            }
        }
        #endregion

        #region Kafka Server
        private void DoOutKafkaToForm(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (edLogKafka.InvokeRequired)
            {
                edLogKafka.BeginInvoke(new DataReceivedEventHandler(DoOutKafkaToForm), new[] { sendingProcess, outLine });
            }
            else
            {
                sbKafkaOutput.Append(Environment.NewLine + outLine.Data);
                edLogKafka.AppendText(sbKafkaOutput.ToString());
            }
        }

        private void DoErrOutKafkaToForm(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!string.IsNullOrEmpty(outLine.Data))
            {
                if (edLogKafka.InvokeRequired)
                {
                    edLogKafka.BeginInvoke(new DataReceivedEventHandler(DoErrOutKafkaToForm), new[] { sendingProcess, outLine });
                }
                else
                {
                    sbKafkaOutput.Append(Environment.NewLine + outLine.Data);
                    edLogKafka.AppendText(sbKafkaOutput.ToString());
                }
            }
        }

        private void ExitedKafka(object sendingProcess, EventArgs e)
        {
            string text = "# # # END OF PROCESS # # #";
            if (edLogKafka.InvokeRequired)
            {
                edLogKafka.BeginInvoke(new EventHandler(ExitedKafka), new[] { sendingProcess, e });
            }
            else
            {
                sbKafkaOutput.Append(Environment.NewLine + text);
                edLogKafka.AppendText(sbKafkaOutput.ToString());
            }
        }
        #endregion

        private bool KafkaPathValidateOk()
        {
            if (string.IsNullOrEmpty(lbKafkaPath.Text))
            {
                MessageBox.Show("Enter the Kafka Path");
                btZookeeperStart.Focus();
                return false;
            }
            else
                return true;
        }

        private Process CreateAndGetProcess(string commandStr, string argumentsStr, string workingDir)
        {   
            // create the ProcessStartInfo using "cmd" as the program to be run, and "/c " as the parameters.
            // Incidentally, /c tells cmd that we want it to execute the command that follows, and then exit.
            ProcessStartInfo procStartInfo = new ProcessStartInfo(commandStr, argumentsStr);

            procStartInfo.WorkingDirectory = workingDir;

            //This means that it will be redirected to the Process.StandardOutput StreamReader.
            procStartInfo.RedirectStandardOutput = true;
            //This means that it will be redirected to the Process.StandardError StreamReader. (same as StdOutput)
            procStartInfo.RedirectStandardError = true;

            procStartInfo.UseShellExecute = false;
            // Do not create the black window.
            procStartInfo.CreateNoWindow = true;
            // Now we create a process, assign its ProcessStartInfo and start it
            Process proc = new Process();

            //This is importend, else some Events will not fire!
            proc.EnableRaisingEvents = true;

            // passing the Startinfo to the process
            proc.StartInfo = procStartInfo;

            return proc;
        }

        private void RunProcess(Process proc)
        {
            proc.Start();

            proc.BeginOutputReadLine();
            proc.BeginErrorReadLine();

            DisableEnableZookprBtns(true);

            //proc.WaitForExit();
            while (!proc.HasExited)
            {
                Application.DoEvents(); // This keeps your form responsive by processing events
            }
        }

        private void DisableEnableZookprBtns(bool value)
        {
            btZookeeperStart.Enabled = value;
            btZookeeperStop.Enabled = value;
        }

        private void btZookeeperStart_Click(object sender, EventArgs e)
        {
            sbZookeeperOutput.Clear();
            edLogZookeeper.Clear();

            DisableEnableZookprBtns(false);
            if (!KafkaPathValidateOk())
                return;
            
            string commandStr = lbKafkaPath.Text + "\\bin\\windows\\zookeeper-server-start.bat";
            string argumentsStr = lbKafkaPath.Text + "\\config\\zookeeper.properties";

            Process proc = CreateAndGetProcess(commandStr, argumentsStr, lbKafkaPath.Text);

            // The given Funktion will be raised if the Process wants to print an output to consol                    
            proc.OutputDataReceived += DoOutZookprToForm;
            
            // Std Error
            proc.ErrorDataReceived += DoErrOutZookprToForm;
            
            // If Batch File is finished this Event will be raised
            proc.Exited += ExitedZookpr;

            RunProcess(proc);
        }

        private void btZookeeperStop_Click(object sender, EventArgs e)
        {
            DisableEnableZookprBtns(false);
            if (!KafkaPathValidateOk())
                return;

            string commandStr = lbKafkaPath.Text + "\\bin\\windows\\zookeeper-server-stop.bat";
            //string argumentsStr = lbKafkaPath.Text + "\\config\\zookeeper.properties";

            Process proc = CreateAndGetProcess(commandStr, "", lbKafkaPath.Text);

            proc.OutputDataReceived += DoOutZookprToForm;
            proc.ErrorDataReceived += DoErrOutZookprToForm;
            proc.Exited += ExitedZookpr;
            
            RunProcess(proc);
        }

        private void btStartKafka_Click(object sender, EventArgs e)
        {
            sbKafkaOutput.Clear();
            edLogKafka.Clear();

            if (!KafkaPathValidateOk())
                return;

            string commandStr = lbKafkaPath.Text + "\\bin\\windows\\kafka-server-start.bat";
            string argumentsStr = lbKafkaPath.Text + "\\config\\server.properties";

            Process proc = CreateAndGetProcess(commandStr, argumentsStr, lbKafkaPath.Text);

            proc.OutputDataReceived += DoOutKafkaToForm;
            proc.ErrorDataReceived += DoErrOutKafkaToForm;
            proc.Exited += ExitedKafka;

            RunProcess(proc);
        }
    }
}
