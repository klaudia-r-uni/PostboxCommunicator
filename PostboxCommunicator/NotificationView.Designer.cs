namespace PostboxCommunicator {
    partial class NotificationView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.contactLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contactLabel
            // 
            this.contactLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactLabel.Location = new System.Drawing.Point(0, 0);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(278, 84);
            this.contactLabel.TabIndex = 0;
            this.contactLabel.Text = "Sample Contact";
            this.contactLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotificationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 84);
            this.Controls.Add(this.contactLabel);
            this.Name = "NotificationView";
            this.Text = "NotificationView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label contactLabel;
    }
}