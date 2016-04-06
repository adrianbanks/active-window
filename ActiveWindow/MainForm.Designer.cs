namespace ActiveWindow
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.GroupBox groupBox3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.writeTokenTextBox = new System.Windows.Forms.TextBox();
            this.streamIdTextBox = new System.Windows.Forms.TextBox();
            this.pollingIntervalPanel = new System.Windows.Forms.Panel();
            this.pollingIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sendActiveWindowEventsCheckBox = new System.Windows.Forms.CheckBox();
            this.sendLockEventsCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            this.pollingIntervalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pollingIntervalNumericUpDown)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(2, 4);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 13);
            label1.TabIndex = 0;
            label1.Text = "Poll active window every";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(171, 4);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 13);
            label2.TabIndex = 2;
            label2.Text = "seconds";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(this.writeTokenTextBox);
            groupBox2.Controls.Add(this.streamIdTextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new System.Drawing.Point(9, 10);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(362, 72);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "1self Settings";
            // 
            // writeTokenTextBox
            // 
            this.writeTokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writeTokenTextBox.Location = new System.Drawing.Point(73, 43);
            this.writeTokenTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.writeTokenTextBox.Name = "writeTokenTextBox";
            this.writeTokenTextBox.Size = new System.Drawing.Size(286, 20);
            this.writeTokenTextBox.TabIndex = 1;
            // 
            // streamIdTextBox
            // 
            this.streamIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streamIdTextBox.Location = new System.Drawing.Point(73, 20);
            this.streamIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.streamIdTextBox.Name = "streamIdTextBox";
            this.streamIdTextBox.Size = new System.Drawing.Size(286, 20);
            this.streamIdTextBox.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(4, 46);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(66, 13);
            label4.TabIndex = 1;
            label4.Text = "Write Token";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 23);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 13);
            label3.TabIndex = 0;
            label3.Text = "Stream Id";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox3.Controls.Add(this.pollingIntervalPanel);
            groupBox3.Controls.Add(this.sendActiveWindowEventsCheckBox);
            groupBox3.Controls.Add(this.sendLockEventsCheckBox);
            groupBox3.Location = new System.Drawing.Point(9, 87);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(359, 89);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Settings";
            // 
            // pollingIntervalPanel
            // 
            this.pollingIntervalPanel.Controls.Add(label2);
            this.pollingIntervalPanel.Controls.Add(label1);
            this.pollingIntervalPanel.Controls.Add(this.pollingIntervalNumericUpDown);
            this.pollingIntervalPanel.Location = new System.Drawing.Point(34, 59);
            this.pollingIntervalPanel.Name = "pollingIntervalPanel";
            this.pollingIntervalPanel.Size = new System.Drawing.Size(229, 24);
            this.pollingIntervalPanel.TabIndex = 6;
            // 
            // pollingIntervalNumericUpDown
            // 
            this.pollingIntervalNumericUpDown.Location = new System.Drawing.Point(127, 2);
            this.pollingIntervalNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.pollingIntervalNumericUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.pollingIntervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pollingIntervalNumericUpDown.Name = "pollingIntervalNumericUpDown";
            this.pollingIntervalNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.pollingIntervalNumericUpDown.TabIndex = 0;
            this.pollingIntervalNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // sendActiveWindowEventsCheckBox
            // 
            this.sendActiveWindowEventsCheckBox.AutoSize = true;
            this.sendActiveWindowEventsCheckBox.Location = new System.Drawing.Point(6, 42);
            this.sendActiveWindowEventsCheckBox.Name = "sendActiveWindowEventsCheckBox";
            this.sendActiveWindowEventsCheckBox.Size = new System.Drawing.Size(157, 17);
            this.sendActiveWindowEventsCheckBox.TabIndex = 5;
            this.sendActiveWindowEventsCheckBox.Text = "Send active window events";
            this.sendActiveWindowEventsCheckBox.UseVisualStyleBackColor = true;
            // 
            // sendLockEventsCheckBox
            // 
            this.sendLockEventsCheckBox.AutoSize = true;
            this.sendLockEventsCheckBox.Location = new System.Drawing.Point(6, 19);
            this.sendLockEventsCheckBox.Name = "sendLockEventsCheckBox";
            this.sendLockEventsCheckBox.Size = new System.Drawing.Size(156, 17);
            this.sendLockEventsCheckBox.TabIndex = 4;
            this.sendLockEventsCheckBox.Text = "Send computer lock events";
            this.sendLockEventsCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(294, 183);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsMenuItem,
            this.exitMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 48);
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Name = "optionsMenuItem";
            this.optionsMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsMenuItem.Text = "Options";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitMenuItem.Text = "Exit";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 217);
            this.Controls.Add(groupBox3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "1self Active Window Poller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            this.pollingIntervalPanel.ResumeLayout(false);
            this.pollingIntervalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pollingIntervalNumericUpDown)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pollingIntervalNumericUpDown;
        private System.Windows.Forms.TextBox writeTokenTextBox;
        private System.Windows.Forms.TextBox streamIdTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox sendLockEventsCheckBox;
        private System.Windows.Forms.CheckBox sendActiveWindowEventsCheckBox;
        private System.Windows.Forms.Panel pollingIntervalPanel;
    }
}

