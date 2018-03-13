namespace Kafka_Chat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbKafkaPath = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.edLogZookeeper = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btZookeeperStop = new System.Windows.Forms.Button();
            this.btZookeeperStart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.edLogKafka = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btStartKafka = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbKafkaPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 100);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kafka path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbKafkaPath
            // 
            this.lbKafkaPath.AutoSize = true;
            this.lbKafkaPath.Location = new System.Drawing.Point(93, 14);
            this.lbKafkaPath.Name = "lbKafkaPath";
            this.lbKafkaPath.Size = new System.Drawing.Size(0, 13);
            this.lbKafkaPath.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 337);
            this.panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1146, 337);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1138, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zookeeper";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.edLogZookeeper);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1132, 259);
            this.panel4.TabIndex = 3;
            // 
            // edLogZookeeper
            // 
            this.edLogZookeeper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edLogZookeeper.Location = new System.Drawing.Point(0, 0);
            this.edLogZookeeper.Multiline = true;
            this.edLogZookeeper.Name = "edLogZookeeper";
            this.edLogZookeeper.ReadOnly = true;
            this.edLogZookeeper.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.edLogZookeeper.Size = new System.Drawing.Size(1132, 259);
            this.edLogZookeeper.TabIndex = 0;
            this.edLogZookeeper.WordWrap = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btZookeeperStop);
            this.panel3.Controls.Add(this.btZookeeperStart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1132, 46);
            this.panel3.TabIndex = 2;
            // 
            // btZookeeperStop
            // 
            this.btZookeeperStop.Location = new System.Drawing.Point(135, 12);
            this.btZookeeperStop.Name = "btZookeeperStop";
            this.btZookeeperStop.Size = new System.Drawing.Size(119, 23);
            this.btZookeeperStop.TabIndex = 3;
            this.btZookeeperStop.Text = "Stop Zookeeper";
            this.btZookeeperStop.UseVisualStyleBackColor = true;
            this.btZookeeperStop.Click += new System.EventHandler(this.btZookeeperStop_Click);
            // 
            // btZookeeperStart
            // 
            this.btZookeeperStart.Location = new System.Drawing.Point(10, 12);
            this.btZookeeperStart.Name = "btZookeeperStart";
            this.btZookeeperStart.Size = new System.Drawing.Size(119, 23);
            this.btZookeeperStart.TabIndex = 2;
            this.btZookeeperStart.Text = "Start Zookeeper";
            this.btZookeeperStart.UseVisualStyleBackColor = true;
            this.btZookeeperStart.Click += new System.EventHandler(this.btZookeeperStart_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.edLogKafka);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1138, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kafka Server";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1138, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consumer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1138, 311);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Producer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Kafka path";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // edLogKafka
            // 
            this.edLogKafka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edLogKafka.Location = new System.Drawing.Point(3, 49);
            this.edLogKafka.Multiline = true;
            this.edLogKafka.Name = "edLogKafka";
            this.edLogKafka.ReadOnly = true;
            this.edLogKafka.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.edLogKafka.Size = new System.Drawing.Size(1132, 259);
            this.edLogKafka.TabIndex = 3;
            this.edLogKafka.WordWrap = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btStartKafka);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1132, 46);
            this.panel5.TabIndex = 4;
            // 
            // btStartKafka
            // 
            this.btStartKafka.Location = new System.Drawing.Point(10, 12);
            this.btStartKafka.Name = "btStartKafka";
            this.btStartKafka.Size = new System.Drawing.Size(119, 23);
            this.btStartKafka.TabIndex = 2;
            this.btStartKafka.Text = "Start Kafka";
            this.btStartKafka.UseVisualStyleBackColor = true;
            this.btStartKafka.Click += new System.EventHandler(this.btStartKafka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 437);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Chat using Kafka";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbKafkaPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox edLogZookeeper;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btZookeeperStop;
        private System.Windows.Forms.Button btZookeeperStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox edLogKafka;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btStartKafka;
    }
}

