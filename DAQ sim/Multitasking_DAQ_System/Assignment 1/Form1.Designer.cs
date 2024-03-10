namespace Assignment_1
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtValues = new System.Windows.Forms.TextBox();
            this.lblSensors = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLogFile = new System.Windows.Forms.Label();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.lblLogCount = new System.Windows.Forms.Label();
            this.txtLogCount = new System.Windows.Forms.TextBox();
            this.lblLogTime = new System.Windows.Forms.Label();
            this.lblLogStatus = new System.Windows.Forms.Label();
            this.txtStatusLog = new System.Windows.Forms.TextBox();
            this.txtNextLog = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.btnStopLog = new System.Windows.Forms.Button();
            this.btnStartLog = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSampleTime = new System.Windows.Forms.Label();
            this.lblSampleStatus = new System.Windows.Forms.Label();
            this.txtStatusSample = new System.Windows.Forms.TextBox();
            this.txtNextSample = new System.Windows.Forms.TextBox();
            this.lblSample = new System.Windows.Forms.Label();
            this.btnStopSample = new System.Windows.Forms.Button();
            this.btnStartSample = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(30, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 464);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.lblSensors);
            this.panel4.Location = new System.Drawing.Point(256, 13);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(603, 434);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.txtValues);
            this.panel6.Location = new System.Drawing.Point(15, 32);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(575, 383);
            this.panel6.TabIndex = 6;
            // 
            // txtValues
            // 
            this.txtValues.Location = new System.Drawing.Point(5, 17);
            this.txtValues.Multiline = true;
            this.txtValues.Name = "txtValues";
            this.txtValues.Size = new System.Drawing.Size(567, 363);
            this.txtValues.TabIndex = 9;
            // 
            // lblSensors
            // 
            this.lblSensors.AutoSize = true;
            this.lblSensors.Location = new System.Drawing.Point(119, 0);
            this.lblSensors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSensors.Name = "lblSensors";
            this.lblSensors.Size = new System.Drawing.Size(45, 13);
            this.lblSensors.TabIndex = 4;
            this.lblSensors.Text = "Sensors";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.lblLogFile);
            this.panel3.Controls.Add(this.txtLogFile);
            this.panel3.Controls.Add(this.lblLogCount);
            this.panel3.Controls.Add(this.txtLogCount);
            this.panel3.Controls.Add(this.lblLogTime);
            this.panel3.Controls.Add(this.lblLogStatus);
            this.panel3.Controls.Add(this.txtStatusLog);
            this.panel3.Controls.Add(this.txtNextLog);
            this.panel3.Controls.Add(this.lblLog);
            this.panel3.Controls.Add(this.btnStopLog);
            this.panel3.Controls.Add(this.btnStartLog);
            this.panel3.Location = new System.Drawing.Point(13, 162);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 145);
            this.panel3.TabIndex = 2;
            // 
            // lblLogFile
            // 
            this.lblLogFile.AutoSize = true;
            this.lblLogFile.Location = new System.Drawing.Point(46, 86);
            this.lblLogFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogFile.Name = "lblLogFile";
            this.lblLogFile.Size = new System.Drawing.Size(73, 13);
            this.lblLogFile.TabIndex = 14;
            this.lblLogFile.Text = "Log file name:";
            // 
            // txtLogFile
            // 
            this.txtLogFile.Location = new System.Drawing.Point(118, 84);
            this.txtLogFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.Size = new System.Drawing.Size(76, 20);
            this.txtLogFile.TabIndex = 13;
            this.txtLogFile.Text = "Logs";
            // 
            // lblLogCount
            // 
            this.lblLogCount.AutoSize = true;
            this.lblLogCount.Location = new System.Drawing.Point(54, 63);
            this.lblLogCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogCount.Name = "lblLogCount";
            this.lblLogCount.Size = new System.Drawing.Size(67, 13);
            this.lblLogCount.TabIndex = 12;
            this.lblLogCount.Text = "Log counter:";
            // 
            // txtLogCount
            // 
            this.txtLogCount.Location = new System.Drawing.Point(118, 61);
            this.txtLogCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogCount.Name = "txtLogCount";
            this.txtLogCount.ReadOnly = true;
            this.txtLogCount.Size = new System.Drawing.Size(76, 20);
            this.txtLogCount.TabIndex = 11;
            // 
            // lblLogTime
            // 
            this.lblLogTime.AutoSize = true;
            this.lblLogTime.Location = new System.Drawing.Point(50, 41);
            this.lblLogTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogTime.Name = "lblLogTime";
            this.lblLogTime.Size = new System.Drawing.Size(69, 13);
            this.lblLogTime.TabIndex = 10;
            this.lblLogTime.Text = "Next logging:";
            // 
            // lblLogStatus
            // 
            this.lblLogStatus.AutoSize = true;
            this.lblLogStatus.Location = new System.Drawing.Point(79, 18);
            this.lblLogStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogStatus.Name = "lblLogStatus";
            this.lblLogStatus.Size = new System.Drawing.Size(40, 13);
            this.lblLogStatus.TabIndex = 9;
            this.lblLogStatus.Text = "Status:";
            // 
            // txtStatusLog
            // 
            this.txtStatusLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtStatusLog.Location = new System.Drawing.Point(118, 15);
            this.txtStatusLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatusLog.Name = "txtStatusLog";
            this.txtStatusLog.ReadOnly = true;
            this.txtStatusLog.Size = new System.Drawing.Size(76, 20);
            this.txtStatusLog.TabIndex = 8;
            this.txtStatusLog.Text = "Not logging";
            // 
            // txtNextLog
            // 
            this.txtNextLog.Location = new System.Drawing.Point(118, 38);
            this.txtNextLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtNextLog.Name = "txtNextLog";
            this.txtNextLog.ReadOnly = true;
            this.txtNextLog.Size = new System.Drawing.Size(76, 20);
            this.txtNextLog.TabIndex = 7;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(98, 0);
            this.lblLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(45, 13);
            this.lblLog.TabIndex = 3;
            this.lblLog.Text = "Logging";
            // 
            // btnStopLog
            // 
            this.btnStopLog.Location = new System.Drawing.Point(118, 114);
            this.btnStopLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopLog.Name = "btnStopLog";
            this.btnStopLog.Size = new System.Drawing.Size(92, 30);
            this.btnStopLog.TabIndex = 3;
            this.btnStopLog.Text = "Stop logging";
            this.btnStopLog.UseVisualStyleBackColor = true;
            this.btnStopLog.Click += new System.EventHandler(this.btnStopLog_Click);
            // 
            // btnStartLog
            // 
            this.btnStartLog.Location = new System.Drawing.Point(11, 114);
            this.btnStartLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartLog.Name = "btnStartLog";
            this.btnStartLog.Size = new System.Drawing.Size(92, 30);
            this.btnStartLog.TabIndex = 2;
            this.btnStartLog.Text = "Start logging";
            this.btnStartLog.UseVisualStyleBackColor = true;
            this.btnStartLog.Click += new System.EventHandler(this.btnStartLog_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.lblSampleTime);
            this.panel2.Controls.Add(this.lblSampleStatus);
            this.panel2.Controls.Add(this.txtStatusSample);
            this.panel2.Controls.Add(this.txtNextSample);
            this.panel2.Controls.Add(this.lblSample);
            this.panel2.Controls.Add(this.btnStopSample);
            this.panel2.Controls.Add(this.btnStartSample);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 145);
            this.panel2.TabIndex = 1;
            // 
            // lblSampleTime
            // 
            this.lblSampleTime.AutoSize = true;
            this.lblSampleTime.Location = new System.Drawing.Point(50, 73);
            this.lblSampleTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSampleTime.Name = "lblSampleTime";
            this.lblSampleTime.Size = new System.Drawing.Size(68, 13);
            this.lblSampleTime.TabIndex = 6;
            this.lblSampleTime.Text = "Next sample:";
            // 
            // lblSampleStatus
            // 
            this.lblSampleStatus.AutoSize = true;
            this.lblSampleStatus.Location = new System.Drawing.Point(79, 48);
            this.lblSampleStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSampleStatus.Name = "lblSampleStatus";
            this.lblSampleStatus.Size = new System.Drawing.Size(40, 13);
            this.lblSampleStatus.TabIndex = 5;
            this.lblSampleStatus.Text = "Status:";
            // 
            // txtStatusSample
            // 
            this.txtStatusSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtStatusSample.Location = new System.Drawing.Point(118, 46);
            this.txtStatusSample.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatusSample.Name = "txtStatusSample";
            this.txtStatusSample.ReadOnly = true;
            this.txtStatusSample.Size = new System.Drawing.Size(76, 20);
            this.txtStatusSample.TabIndex = 4;
            this.txtStatusSample.Text = "Not sampling";
            // 
            // txtNextSample
            // 
            this.txtNextSample.Location = new System.Drawing.Point(118, 68);
            this.txtNextSample.Margin = new System.Windows.Forms.Padding(2);
            this.txtNextSample.Name = "txtNextSample";
            this.txtNextSample.ReadOnly = true;
            this.txtNextSample.Size = new System.Drawing.Size(76, 20);
            this.txtNextSample.TabIndex = 3;
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Location = new System.Drawing.Point(98, 0);
            this.lblSample.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(50, 13);
            this.lblSample.TabIndex = 2;
            this.lblSample.Text = "Sampling";
            // 
            // btnStopSample
            // 
            this.btnStopSample.Location = new System.Drawing.Point(118, 112);
            this.btnStopSample.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopSample.Name = "btnStopSample";
            this.btnStopSample.Size = new System.Drawing.Size(92, 30);
            this.btnStopSample.TabIndex = 1;
            this.btnStopSample.Text = "Stop sampling";
            this.btnStopSample.UseVisualStyleBackColor = true;
            this.btnStopSample.Click += new System.EventHandler(this.btnStopSample_Click);
            // 
            // btnStartSample
            // 
            this.btnStartSample.Location = new System.Drawing.Point(11, 112);
            this.btnStartSample.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartSample.Name = "btnStartSample";
            this.btnStartSample.Size = new System.Drawing.Size(92, 30);
            this.btnStartSample.TabIndex = 0;
            this.btnStartSample.Text = "Start sampling";
            this.btnStartSample.UseVisualStyleBackColor = true;
            this.btnStartSample.Click += new System.EventHandler(this.btnStartSample_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSensors;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button btnStopLog;
        private System.Windows.Forms.Button btnStartLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.Button btnStopSample;
        private System.Windows.Forms.Button btnStartSample;
        private System.Windows.Forms.Label lblLogTime;
        private System.Windows.Forms.Label lblLogStatus;
        private System.Windows.Forms.TextBox txtStatusLog;
        private System.Windows.Forms.TextBox txtNextLog;
        private System.Windows.Forms.Label lblSampleTime;
        private System.Windows.Forms.Label lblSampleStatus;
        private System.Windows.Forms.TextBox txtStatusSample;
        private System.Windows.Forms.TextBox txtNextSample;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblLogFile;
        private System.Windows.Forms.TextBox txtLogFile;
        private System.Windows.Forms.Label lblLogCount;
        private System.Windows.Forms.TextBox txtLogCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtValues;
    }
}

