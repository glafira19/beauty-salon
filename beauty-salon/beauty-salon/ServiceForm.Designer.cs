namespace beauty_salon
{
    partial class ServiceForm
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
            this.uiNameTextBox = new System.Windows.Forms.TextBox();
            this.uiCostTextBox = new System.Windows.Forms.TextBox();
            this.uiNameLabel = new System.Windows.Forms.Label();
            this.uiCostLabel = new System.Windows.Forms.Label();
            this.uiConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiNameTextBox
            // 
            this.uiNameTextBox.Location = new System.Drawing.Point(101, 12);
            this.uiNameTextBox.Name = "uiNameTextBox";
            this.uiNameTextBox.Size = new System.Drawing.Size(259, 20);
            this.uiNameTextBox.TabIndex = 0;
            // 
            // uiCostTextBox
            // 
            this.uiCostTextBox.Location = new System.Drawing.Point(101, 38);
            this.uiCostTextBox.Name = "uiCostTextBox";
            this.uiCostTextBox.Size = new System.Drawing.Size(259, 20);
            this.uiCostTextBox.TabIndex = 1;
            // 
            // uiNameLabel
            // 
            this.uiNameLabel.AutoSize = true;
            this.uiNameLabel.Location = new System.Drawing.Point(12, 15);
            this.uiNameLabel.Name = "uiNameLabel";
            this.uiNameLabel.Size = new System.Drawing.Size(83, 13);
            this.uiNameLabel.TabIndex = 2;
            this.uiNameLabel.Text = "Наименование";
            // 
            // uiCostLabel
            // 
            this.uiCostLabel.AutoSize = true;
            this.uiCostLabel.Location = new System.Drawing.Point(12, 41);
            this.uiCostLabel.Name = "uiCostLabel";
            this.uiCostLabel.Size = new System.Drawing.Size(62, 13);
            this.uiCostLabel.TabIndex = 3;
            this.uiCostLabel.Text = "Стоимость";
            // 
            // uiConfirmButton
            // 
            this.uiConfirmButton.Location = new System.Drawing.Point(12, 64);
            this.uiConfirmButton.Name = "uiConfirmButton";
            this.uiConfirmButton.Size = new System.Drawing.Size(348, 23);
            this.uiConfirmButton.TabIndex = 4;
            this.uiConfirmButton.Text = "Подтвердить";
            this.uiConfirmButton.UseVisualStyleBackColor = true;
            this.uiConfirmButton.Click += new System.EventHandler(this.uiConfirmButton_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 93);
            this.Controls.Add(this.uiConfirmButton);
            this.Controls.Add(this.uiCostLabel);
            this.Controls.Add(this.uiNameLabel);
            this.Controls.Add(this.uiCostTextBox);
            this.Controls.Add(this.uiNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ServiceForm";
            this.Text = "Услуга";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiNameTextBox;
        private System.Windows.Forms.TextBox uiCostTextBox;
        private System.Windows.Forms.Label uiNameLabel;
        private System.Windows.Forms.Label uiCostLabel;
        private System.Windows.Forms.Button uiConfirmButton;
    }
}

