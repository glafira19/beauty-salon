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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uiAutorizationButton = new System.Windows.Forms.Button();
            this.uiServicesListBox = new System.Windows.Forms.ListBox();
            this.uiClientServicesListBox = new System.Windows.Forms.ListBox();
            this.uiUserServicesLabel = new System.Windows.Forms.Label();
            this.uiServicesLabel = new System.Windows.Forms.Label();
            this.uiServiceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiClientAddServiceButton = new System.Windows.Forms.Button();
            this.uiClientDeleteServiceButton = new System.Windows.Forms.Button();
            this.uiClientPanel = new System.Windows.Forms.Panel();
            this.uiClientsComboBox = new System.Windows.Forms.ComboBox();
            this.uiEditServicesButton = new System.Windows.Forms.Button();
            this.uiRemoveServicesButton = new System.Windows.Forms.Button();
            this.uAddServicesButton = new System.Windows.Forms.Button();
            this.uiAdminPanel = new System.Windows.Forms.Panel();
            this.uiMainPanel = new System.Windows.Forms.Panel();
            this.uiClientPanel.SuspendLayout();
            this.uiAdminPanel.SuspendLayout();
            this.uiMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiAutorizationButton
            // 
            this.uiAutorizationButton.Location = new System.Drawing.Point(3, 3);
            this.uiAutorizationButton.Name = "uiAutorizationButton";
            this.uiAutorizationButton.Size = new System.Drawing.Size(123, 23);
            this.uiAutorizationButton.TabIndex = 0;
            this.uiAutorizationButton.Text = "авторизоваться";
            this.uiAutorizationButton.UseVisualStyleBackColor = true;
            this.uiAutorizationButton.Click += new System.EventHandler(this.uiAutorizationButton_Click);
            // 
            // uiServicesListBox
            // 
            this.uiServicesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uiServicesListBox.FormattingEnabled = true;
            this.uiServicesListBox.Location = new System.Drawing.Point(3, 45);
            this.uiServicesListBox.Name = "uiServicesListBox";
            this.uiServicesListBox.Size = new System.Drawing.Size(259, 290);
            this.uiServicesListBox.TabIndex = 1;
            // 
            // uiClientServicesListBox
            // 
            this.uiClientServicesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiClientServicesListBox.FormattingEnabled = true;
            this.uiClientServicesListBox.Location = new System.Drawing.Point(166, 45);
            this.uiClientServicesListBox.Name = "uiClientServicesListBox";
            this.uiClientServicesListBox.Size = new System.Drawing.Size(434, 290);
            this.uiClientServicesListBox.TabIndex = 2;
            // 
            // uiUserServicesLabel
            // 
            this.uiUserServicesLabel.AutoSize = true;
            this.uiUserServicesLabel.Location = new System.Drawing.Point(163, 26);
            this.uiUserServicesLabel.Name = "uiUserServicesLabel";
            this.uiUserServicesLabel.Size = new System.Drawing.Size(96, 13);
            this.uiUserServicesLabel.TabIndex = 3;
            this.uiUserServicesLabel.Text = "записи на приём:";
            // 
            // uiServicesLabel
            // 
            this.uiServicesLabel.AutoSize = true;
            this.uiServicesLabel.Location = new System.Drawing.Point(3, 29);
            this.uiServicesLabel.Name = "uiServicesLabel";
            this.uiServicesLabel.Size = new System.Drawing.Size(69, 13);
            this.uiServicesLabel.TabIndex = 4;
            this.uiServicesLabel.Text = "наши услуги";
            // 
            // uiServiceDateTimePicker
            // 
            this.uiServiceDateTimePicker.CustomFormat = "MM.dd.yyyy hh:mm";
            this.uiServiceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uiServiceDateTimePicker.Location = new System.Drawing.Point(9, 42);
            this.uiServiceDateTimePicker.Name = "uiServiceDateTimePicker";
            this.uiServiceDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.uiServiceDateTimePicker.TabIndex = 5;
            // 
            // uiClientAddServiceButton
            // 
            this.uiClientAddServiceButton.Location = new System.Drawing.Point(9, 68);
            this.uiClientAddServiceButton.Name = "uiClientAddServiceButton";
            this.uiClientAddServiceButton.Size = new System.Drawing.Size(151, 23);
            this.uiClientAddServiceButton.TabIndex = 6;
            this.uiClientAddServiceButton.Text = "записаться ->";
            this.uiClientAddServiceButton.UseVisualStyleBackColor = true;
            this.uiClientAddServiceButton.Click += new System.EventHandler(this.uiClientAddServiceButton_Click);
            // 
            // uiClientDeleteServiceButton
            // 
            this.uiClientDeleteServiceButton.Location = new System.Drawing.Point(9, 97);
            this.uiClientDeleteServiceButton.Name = "uiClientDeleteServiceButton";
            this.uiClientDeleteServiceButton.Size = new System.Drawing.Size(151, 23);
            this.uiClientDeleteServiceButton.TabIndex = 7;
            this.uiClientDeleteServiceButton.Text = "<- отменить приём";
            this.uiClientDeleteServiceButton.UseVisualStyleBackColor = true;
            this.uiClientDeleteServiceButton.Click += new System.EventHandler(this.uiClientDeleteServiceButton_Click);
            // 
            // uiClientPanel
            // 
            this.uiClientPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiClientPanel.Controls.Add(this.uiClientServicesListBox);
            this.uiClientPanel.Controls.Add(this.uiClientsComboBox);
            this.uiClientPanel.Controls.Add(this.uiClientDeleteServiceButton);
            this.uiClientPanel.Controls.Add(this.uiUserServicesLabel);
            this.uiClientPanel.Controls.Add(this.uiClientAddServiceButton);
            this.uiClientPanel.Controls.Add(this.uiServiceDateTimePicker);
            this.uiClientPanel.Location = new System.Drawing.Point(287, 12);
            this.uiClientPanel.Name = "uiClientPanel";
            this.uiClientPanel.Size = new System.Drawing.Size(611, 351);
            this.uiClientPanel.TabIndex = 8;
            // 
            // uiClientsComboBox
            // 
            this.uiClientsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiClientsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiClientsComboBox.FormattingEnabled = true;
            this.uiClientsComboBox.Location = new System.Drawing.Point(346, 18);
            this.uiClientsComboBox.Name = "uiClientsComboBox";
            this.uiClientsComboBox.Size = new System.Drawing.Size(254, 21);
            this.uiClientsComboBox.TabIndex = 9;
            this.uiClientsComboBox.SelectedIndexChanged += new System.EventHandler(this.uiClientsComboBox_SelectedIndexChanged);
            // 
            // uiEditServicesButton
            // 
            this.uiEditServicesButton.Location = new System.Drawing.Point(3, 34);
            this.uiEditServicesButton.Name = "uiEditServicesButton";
            this.uiEditServicesButton.Size = new System.Drawing.Size(253, 23);
            this.uiEditServicesButton.TabIndex = 10;
            this.uiEditServicesButton.Text = "Редактировать услугу";
            this.uiEditServicesButton.UseVisualStyleBackColor = true;
            this.uiEditServicesButton.Click += new System.EventHandler(this.uiEditServicesButton_Click);
            // 
            // uiRemoveServicesButton
            // 
            this.uiRemoveServicesButton.Location = new System.Drawing.Point(3, 63);
            this.uiRemoveServicesButton.Name = "uiRemoveServicesButton";
            this.uiRemoveServicesButton.Size = new System.Drawing.Size(253, 23);
            this.uiRemoveServicesButton.TabIndex = 11;
            this.uiRemoveServicesButton.Text = "Удалить услугу";
            this.uiRemoveServicesButton.UseVisualStyleBackColor = true;
            this.uiRemoveServicesButton.Click += new System.EventHandler(this.uiRemoveServicesButton_Click);
            // 
            // uAddServicesButton
            // 
            this.uAddServicesButton.Location = new System.Drawing.Point(3, 5);
            this.uAddServicesButton.Name = "uAddServicesButton";
            this.uAddServicesButton.Size = new System.Drawing.Size(253, 23);
            this.uAddServicesButton.TabIndex = 12;
            this.uAddServicesButton.Text = "Добавить услугу";
            this.uAddServicesButton.UseVisualStyleBackColor = true;
            this.uAddServicesButton.Click += new System.EventHandler(this.uAddServicesButton_Click);
            // 
            // uiAdminPanel
            // 
            this.uiAdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiAdminPanel.Controls.Add(this.uiEditServicesButton);
            this.uiAdminPanel.Controls.Add(this.uAddServicesButton);
            this.uiAdminPanel.Controls.Add(this.uiRemoveServicesButton);
            this.uiAdminPanel.Location = new System.Drawing.Point(12, 369);
            this.uiAdminPanel.Name = "uiAdminPanel";
            this.uiAdminPanel.Size = new System.Drawing.Size(269, 91);
            this.uiAdminPanel.TabIndex = 13;
            // 
            // uiMainPanel
            // 
            this.uiMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uiMainPanel.Controls.Add(this.uiAutorizationButton);
            this.uiMainPanel.Controls.Add(this.uiServicesListBox);
            this.uiMainPanel.Controls.Add(this.uiServicesLabel);
            this.uiMainPanel.Location = new System.Drawing.Point(12, 12);
            this.uiMainPanel.Name = "uiMainPanel";
            this.uiMainPanel.Size = new System.Drawing.Size(269, 351);
            this.uiMainPanel.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 460);
            this.Controls.Add(this.uiMainPanel);
            this.Controls.Add(this.uiAdminPanel);
            this.Controls.Add(this.uiClientPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Салон красоты \"ромашка\"";
            this.uiClientPanel.ResumeLayout(false);
            this.uiClientPanel.PerformLayout();
            this.uiAdminPanel.ResumeLayout(false);
            this.uiMainPanel.ResumeLayout(false);
            this.uiMainPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox uiClientsComboBox;
        private System.Windows.Forms.Button uiEditServicesButton;
        private System.Windows.Forms.Button uiRemoveServicesButton;
        private System.Windows.Forms.Button uAddServicesButton;
        private System.Windows.Forms.Panel uiAdminPanel;
        private System.Windows.Forms.Panel uiMainPanel;
    }
}

