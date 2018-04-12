namespace PostboxCommunicator {
    partial class FeedbackView {
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.messageContent = new System.Windows.Forms.RichTextBox();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.messageContent);
            this.contentPanel.Location = new System.Drawing.Point(12, 12);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(389, 149);
            this.contentPanel.TabIndex = 0;
            // 
            // messageContent
            // 
            this.messageContent.Location = new System.Drawing.Point(23, 14);
            this.messageContent.Name = "messageContent";
            this.messageContent.Size = new System.Drawing.Size(344, 117);
            this.messageContent.TabIndex = 0;
            this.messageContent.Text = "";
            // 
            // FeedbackView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 177);
            this.Controls.Add(this.contentPanel);
            this.Name = "FeedbackView";
            this.Text = "FeedbackView";
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.RichTextBox messageContent;
    }
}