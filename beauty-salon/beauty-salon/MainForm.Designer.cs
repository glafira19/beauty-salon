namespace beauty_salon
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
            this.uiAutorizationButton = new System.Windows.Forms.Button();
            this.uiServicesListBox = new System.Windows.Forms.ListBox();
            this.uiClientServicesListBox = new System.Windows.Forms.ListBox();
            this.uiUserServicesLabel = new System.Windows.Forms.Label();
            this.uiServicesLabel = new System.Windows.Forms.Label();
            this.uiServiceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiClientAddServiceButton = new System.Windows.Forms.Button();
            this.uiClientDeleteServiceButton = new System.Windows.Forms.Button();
            this.uiClientPanel = new System.Windows.Forms.Panel();
            this.uiClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiAutorizationButton
            // 
            this.uiAutorizationButton.Location = new System.Drawing.Point(12, 12);
            this.uiAutorizationButton.Name = "uiAutorizationButton";
            this.uiAutorizationButton.Size = new System.Drawing.Size(123, 23);
            this.uiAutorizationButton.TabIndex = 0;
            this.uiAutorizationButton.Text = "авторизоваться";
            this.uiAutorizationButton.UseVisualStyleBackColor = true;
            this.uiAutorizationButton.Click += new System.EventHandler(this.uiAutorizationButton_Click);
            // 
            // uiServicesListBox
            // 
            this.uiServicesListBox.FormattingEnabled = true;
            this.uiServicesListBox.Location = new System.Drawing.Point(12, 54);
            this.uiServicesListBox.Name = "uiServicesListBox";
            this.uiServicesListBox.Size = new System.Drawing.Size(259, 121);
            this.uiServicesListBox.TabIndex = 1;
            // 
            // uiClientServicesListBox
            // 
            this.uiClientServicesListBox.FormattingEnabled = true;
            this.uiClientServicesListBox.Location = new System.Drawing.Point(175, 42);
            this.uiClientServicesListBox.Name = "uiClientServicesListBox";
            this.uiClientServicesListBox.Size = new System.Drawing.Size(301, 121);
            this.uiClientServicesListBox.TabIndex = 2;
            // 
            // uiUserServicesLabel
            // 
            this.uiUserServicesLabel.AutoSize = true;
            this.uiUserServicesLabel.Location = new System.Drawing.Point(172, 26);
            this.uiUserServicesLabel.Name = "uiUserServicesLabel";
            this.uiUserServicesLabel.Size = new System.Drawing.Size(92, 13);
            this.uiUserServicesLabel.TabIndex = 3;
            this.uiUserServicesLabel.Text = "вы записаны на,";
            // 
            // uiServicesLabel
            // 
            this.uiServicesLabel.AutoSize = true;
            this.uiServicesLabel.Location = new System.Drawing.Point(12, 38);
            this.uiServicesLabel.Name = "uiServicesLabel";
            this.uiServicesLabel.Size = new System.Drawing.Size(69, 13);
            this.uiServicesLabel.TabIndex = 4;
            this.uiServicesLabel.Text = "наши услуги";
            // 
            // uiServiceDateTimePicker
            // 
            this.uiServiceDateTimePicker.CustomFormat = "MM.dd.yyyy hh:mm";
            this.uiServiceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uiServiceDateTimePicker.Location = new System.Drawing.Point(18, 42);
            this.uiServiceDateTimePicker.Name = "uiServiceDateTimePicker";
            this.uiServiceDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.uiServiceDateTimePicker.TabIndex = 5;
            // 
            // uiClientAddServiceButton
            // 
            this.uiClientAddServiceButton.Location = new System.Drawing.Point(18, 68);
            this.uiClientAddServiceButton.Name = "uiClientAddServiceButton";
            this.uiClientAddServiceButton.Size = new System.Drawing.Size(151, 23);
            this.uiClientAddServiceButton.TabIndex = 6;
            this.uiClientAddServiceButton.Text = "записаться ->";
            this.uiClientAddServiceButton.UseVisualStyleBackColor = true;
            this.uiClientAddServiceButton.Click += new System.EventHandler(this.uiClientAddServiceButton_Click);
            // 
            // uiClientDeleteServiceButton
            // 
            this.uiClientDeleteServiceButton.Location = new System.Drawing.Point(18, 97);
            this.uiClientDeleteServiceButton.Name = "uiClientDeleteServiceButton";
            this.uiClientDeleteServiceButton.Size = new System.Drawing.Size(151, 23);
            this.uiClientDeleteServiceButton.TabIndex = 7;
            this.uiClientDeleteServiceButton.Text = "<- отменить приём";
            this.uiClientDeleteServiceButton.UseVisualStyleBackColor = true;
            this.uiClientDeleteServiceButton.Click += new System.EventHandler(this.uiClientDeleteServiceButton_Click);
            // 
            // uiClientPanel
            // 
            this.uiClientPanel.Controls.Add(this.uiClientServicesListBox);
            this.uiClientPanel.Controls.Add(this.uiClientDeleteServiceButton);
            this.uiClientPanel.Controls.Add(this.uiUserServicesLabel);
            this.uiClientPanel.Controls.Add(this.uiClientAddServiceButton);
            this.uiClientPanel.Controls.Add(this.uiServiceDateTimePicker);
            this.uiClientPanel.Location = new System.Drawing.Point(277, 12);
            this.uiClientPanel.Name = "uiClientPanel";
            this.uiClientPanel.Size = new System.Drawing.Size(490, 173);
            this.uiClientPanel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 197);
            this.Controls.Add(this.uiClientPanel);
            this.Controls.Add(this.uiServicesLabel);
            this.Controls.Add(this.uiServicesListBox);
            this.Controls.Add(this.uiAutorizationButton);
            this.Name = "MainForm";
            this.Text = "Салон красоты \"ромашка\"";
            this.uiClientPanel.ResumeLayout(false);
            this.uiClientPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiAutorizationButton;
        private System.Windows.Forms.ListBox uiServicesListBox;
        private System.Windows.Forms.ListBox uiClientServicesListBox;
        private System.Windows.Forms.Label uiUserServicesLabel;
        private System.Windows.Forms.Label uiServicesLabel;
        private System.Windows.Forms.DateTimePicker uiServiceDateTimePicker;
        private System.Windows.Forms.Button uiClientAddServiceButton;
        private System.Windows.Forms.Button uiClientDeleteServiceButton;
        private System.Windows.Forms.Panel uiClientPanel;
    }
}

