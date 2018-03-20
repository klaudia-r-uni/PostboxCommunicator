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
            this.contentPanel.Location = new System.Drawing.Point(25, 18);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(519, 183);
            this.contentPanel.TabIndex = 1;
            // 
            // messageContent
            // 
            this.messageContent.Location = new System.Drawing.Point(31, 17);
            this.messageContent.Margin = new System.Windows.Forms.Padding(4);
            this.messageContent.Name = "messageContent";
            this.messageContent.ReadOnly = true;
            this.messageContent.Size = new System.Drawing.Size(457, 143);
            this.messageContent.TabIndex = 0;
            this.messageContent.Text = "";
            // 
            // FeedbackView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 219);
            this.Controls.Add(this.contentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FeedbackView";
            this.Text = "FeedbackView";
            this.Load += new System.EventHandler(this.FeedbackView_Load);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.RichTextBox messageContent;
    }
}