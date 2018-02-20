namespace PostboxCommunicator {
    partial class ConversationView {
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
            this.background = new System.Windows.Forms.FlowLayoutPanel();
            this.messageContentField = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Top;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(889, 619);
            this.background.TabIndex = 0;
            this.background.Paint += new System.Windows.Forms.PaintEventHandler(this.background_Paint);
            this.background.Resize += new System.EventHandler(this.background_Resize);
            // 
            // messageContentField
            // 
            this.messageContentField.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageContentField.Location = new System.Drawing.Point(0, 619);
            this.messageContentField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageContentField.Name = "messageContentField";
            this.messageContentField.Size = new System.Drawing.Size(889, 116);
            this.messageContentField.TabIndex = 1;
            this.messageContentField.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendButton.Location = new System.Drawing.Point(742, 2);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(144, 32);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.button1);
            this.footerPanel.Controls.Add(this.sendButton);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.footerPanel.Location = new System.Drawing.Point(0, 735);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 5);
            this.footerPanel.Size = new System.Drawing.Size(889, 39);
            this.footerPanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Archive";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ConversationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 775);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.messageContentField);
            this.Controls.Add(this.background);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConversationView";
            this.Text = "ConversationView";
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel background;
        private System.Windows.Forms.RichTextBox messageContentField;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button button1;
    }
}