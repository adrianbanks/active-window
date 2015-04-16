﻿namespace ActiveWindow
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.GroupBox groupBox3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.pollingIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.writeTokenTextBox = new System.Windows.Forms.TextBox();
            this.streamIdTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.locateButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pollingIntervalNumericUpDown)).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 17);
            label1.TabIndex = 0;
            label1.Text = "Poll active window every";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(this.pollingIntervalNumericUpDown);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(12, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(297, 52);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Polling Interval";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(231, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 17);
            label2.TabIndex = 2;
            label2.Text = "seconds";
            // 
            // pollingIntervalNumericUpDown
            // 
            this.pollingIntervalNumericUpDown.Location = new System.Drawing.Point(172, 21);
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
            this.pollingIntervalNumericUpDown.Size = new System.Drawing.Size(53, 22);
            this.pollingIntervalNumericUpDown.TabIndex = 1;
            this.pollingIntervalNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.writeTokenTextBox);
            groupBox2.Controls.Add(this.streamIdTextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new System.Drawing.Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(519, 88);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "1self Settings";
            // 
            // writeTokenTextBox
            // 
            this.writeTokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writeTokenTextBox.Location = new System.Drawing.Point(97, 53);
            this.writeTokenTextBox.Name = "writeTokenTextBox";
            this.writeTokenTextBox.Size = new System.Drawing.Size(416, 22);
            this.writeTokenTextBox.TabIndex = 3;
            // 
            // streamIdTextBox
            // 
            this.streamIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streamIdTextBox.Location = new System.Drawing.Point(97, 25);
            this.streamIdTextBox.Name = "streamIdTextBox";
            this.streamIdTextBox.Size = new System.Drawing.Size(416, 22);
            this.streamIdTextBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 56);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 17);
            label4.TabIndex = 1;
            label4.Text = "Write Token";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 17);
            label3.TabIndex = 0;
            label3.Text = "Stream Id";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(426, 126);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(this.locateButton);
            groupBox3.Controls.Add(this.longitudeTextBox);
            groupBox3.Controls.Add(this.latitudeTextBox);
            groupBox3.Location = new System.Drawing.Point(12, 164);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(327, 84);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Location";
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.Location = new System.Drawing.Point(83, 21);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(150, 22);
            this.latitudeTextBox.TabIndex = 0;
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.Location = new System.Drawing.Point(83, 49);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(150, 22);
            this.longitudeTextBox.TabIndex = 0;
            // 
            // locateButton
            // 
            this.locateButton.Location = new System.Drawing.Point(239, 46);
            this.locateButton.Name = "locateButton";
            this.locateButton.Size = new System.Drawing.Size(75, 23);
            this.locateButton.TabIndex = 1;
            this.locateButton.Text = "Locate";
            this.locateButton.UseVisualStyleBackColor = true;
            this.locateButton.Click += new System.EventHandler(this.locateButton_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 24);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 17);
            label5.TabIndex = 2;
            label5.Text = "Latitude";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 52);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(71, 17);
            label6.TabIndex = 2;
            label6.Text = "Longitude";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 357);
            this.Controls.Add(groupBox3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "1self Active Window Poller";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pollingIntervalNumericUpDown)).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pollingIntervalNumericUpDown;
        private System.Windows.Forms.TextBox writeTokenTextBox;
        private System.Windows.Forms.TextBox streamIdTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button locateButton;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private System.Windows.Forms.TextBox latitudeTextBox;
    }
}
