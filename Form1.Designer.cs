namespace DellFanController
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
            this.ToggleFanButton = new System.Windows.Forms.Button();
            this.preventSpeedChangeBox = new System.Windows.Forms.CheckBox();
            this.SetSpeedButton = new System.Windows.Forms.Button();
            this.AlternateMethodBox = new System.Windows.Forms.CheckBox();
            this.Fan1Speeds = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fan2Speeds = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // ToggleFanButton
            // 
            this.ToggleFanButton.Location = new System.Drawing.Point(13, 12);
            this.ToggleFanButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ToggleFanButton.Name = "ToggleFanButton";
            this.ToggleFanButton.Size = new System.Drawing.Size(135, 23);
            this.ToggleFanButton.TabIndex = 0;
            this.ToggleFanButton.Text = "Disable fan control";
            this.ToggleFanButton.UseVisualStyleBackColor = true;
            this.ToggleFanButton.Click +=
                new System.EventHandler(this.ToggleFanControlClick);
            // 
            // preventSpeedChangeBox
            // 
            this.preventSpeedChangeBox.Location = new System.Drawing.Point(13, 42);
            this.preventSpeedChangeBox.Margin =
                new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.preventSpeedChangeBox.Name = "preventSpeedChangeBox";
            this.preventSpeedChangeBox.Size = new System.Drawing.Size(142, 24);
            this.preventSpeedChangeBox.TabIndex = 1;
            this.preventSpeedChangeBox.Text = "Don\'t change speed";
            this.preventSpeedChangeBox.UseVisualStyleBackColor = true;
            this.preventSpeedChangeBox.CheckedChanged +=
                new System.EventHandler(this.ChangeFanSpeedBox);
            // 
            // SetSpeedButton
            // 
            this.SetSpeedButton.Location = new System.Drawing.Point(156, 12);
            this.SetSpeedButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SetSpeedButton.Name = "SetSpeedButton";
            this.SetSpeedButton.Size = new System.Drawing.Size(135, 23);
            this.SetSpeedButton.TabIndex = 2;
            this.SetSpeedButton.Text = "Set Fan Speed";
            this.SetSpeedButton.UseVisualStyleBackColor = true;
            this.SetSpeedButton.Click +=
                new System.EventHandler(this.SetSpeedButton_Click);
            // 
            // AlternateMethodBox
            // 
            this.AlternateMethodBox.Location = new System.Drawing.Point(13, 72);
            this.AlternateMethodBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AlternateMethodBox.Name = "AlternateMethodBox";
            this.AlternateMethodBox.Size = new System.Drawing.Size(142, 24);
            this.AlternateMethodBox.TabIndex = 3;
            this.AlternateMethodBox.Text = "Alternate method";
            this.AlternateMethodBox.UseVisualStyleBackColor = true;
            this.AlternateMethodBox.CheckedChanged +=
                new System.EventHandler(this.AlternateMethodBox_CheckedChanged);
            // 
            // Fan1Speeds
            // 
            this.Fan1Speeds.Items.Add("2");
            this.Fan1Speeds.Items.Add("1");
            this.Fan1Speeds.Items.Add("0");
            this.Fan1Speeds.Location = new System.Drawing.Point(234, 43);
            this.Fan1Speeds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Fan1Speeds.Name = "Fan1Speeds";
            this.Fan1Speeds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Fan1Speeds.Size = new System.Drawing.Size(57, 23);
            this.Fan1Speeds.TabIndex = 4;
            this.Fan1Speeds.Text = "1";
            this.Fan1Speeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Fan1Speeds.SelectedIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(156, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fan 1: ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(156, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fan 2: ";
            // 
            // Fan2Speeds
            // 
            this.Fan2Speeds.Items.Add("2");
            this.Fan2Speeds.Items.Add("1");
            this.Fan2Speeds.Items.Add("0");
            this.Fan2Speeds.Location = new System.Drawing.Point(234, 74);
            this.Fan2Speeds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Fan2Speeds.Name = "Fan2Speeds";
            this.Fan2Speeds.Size = new System.Drawing.Size(56, 23);
            this.Fan2Speeds.TabIndex = 7;
            this.Fan2Speeds.Text = "1";
            this.Fan2Speeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Fan2Speeds.SelectedIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(303, 107);
            this.Controls.Add(this.Fan2Speeds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fan1Speeds);
            this.Controls.Add(this.AlternateMethodBox);
            this.Controls.Add(this.SetSpeedButton);
            this.Controls.Add(this.preventSpeedChangeBox);
            this.Controls.Add(this.ToggleFanButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DellFanControl";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.CheckBox preventSpeedChangeBox;
        private System.Windows.Forms.Button SetSpeedButton;
        private System.Windows.Forms.CheckBox AlternateMethodBox;
        private System.Windows.Forms.DomainUpDown Fan1Speeds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown Fan2Speeds;
        private System.Windows.Forms.Button ToggleFanButton;
    }
}