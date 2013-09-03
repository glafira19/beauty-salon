namespace beauty_salon
{
    partial class AutorizationForm
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
            this.uiLoginTextBox = new System.Windows.Forms.TextBox();
            this.uiPasswordTextBox = new System.Windows.Forms.TextBox();
            this.uiLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiLoginTextBox
            // 
            this.uiLoginTextBox.Location = new System.Drawing.Point(12, 12);
            this.uiLoginTextBox.Name = "uiLoginTextBox";
            this.uiLoginTextBox.Size = new System.Drawing.Size(192, 20);
            this.uiLoginTextBox.TabIndex = 0;
            // 
            // uiPasswordTextBox
            // 
            this.uiPasswordTextBox.Location = new System.Drawing.Point(12, 38);
            this.uiPasswordTextBox.Name = "uiPasswordTextBox";
            this.uiPasswordTextBox.Size = new System.Drawing.Size(192, 20);
            this.uiPasswordTextBox.TabIndex = 1;
            // 
            // uiLoginButton
            // 
            this.uiLoginButton.Location = new System.Drawing.Point(12, 64);
            this.uiLoginButton.Name = "uiLoginButton";
            this.uiLoginButton.Size = new System.Drawing.Size(192, 23);
            this.uiLoginButton.TabIndex = 2;
            this.uiLoginButton.Text = "авторизоваться";
            this.uiLoginButton.UseVisualStyleBackColor = true;
            this.uiLoginButton.Click += new System.EventHandler(this.uiLoginButton_Click);
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 98);
            this.Controls.Add(this.uiLoginButton);
            this.Controls.Add(this.uiPasswordTextBox);
            this.Controls.Add(this.uiLoginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutorizationForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AutorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiLoginTextBox;
        private System.Windows.Forms.TextBox uiPasswordTextBox;
        private System.Windows.Forms.Button uiLoginButton;
    }
}

