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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 377);
            this.Controls.Add(this.uiAutorizationButton);
            this.Name = "MainForm";
            this.Text = "Салон красоты \"ромашка\"";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiAutorizationButton;
    }
}

