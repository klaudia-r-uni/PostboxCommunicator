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
            this.messagesGrid = new System.Windows.Forms.TableLayoutPanel();
            this.messageContentField = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.background = new System.Windows.Forms.Panel();
            this.footerPanel.SuspendLayout();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // messagesGrid
            // 
            this.messagesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesGrid.AutoScroll = true;
            this.messagesGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.messagesGrid.BackColor = System.Drawing.Color.White;
            this.messagesGrid.ColumnCount = 1;
            this.messagesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messagesGrid.Location = new System.Drawing.Point(2, 2);
            this.messagesGrid.Margin = new System.Windows.Forms.Padding(2);
            this.messagesGrid.Name = "messagesGrid";
            this.messagesGrid.RowCount = 1;
            this.messagesGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.messagesGrid.Size = new System.Drawing.Size(490, 494);
            this.messagesGrid.TabIndex = 0;
            this.messagesGrid.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ConversationView_Scroll);
            // 
            // messageContentField
            // 
            this.messageContentField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageContentField.Location = new System.Drawing.Point(0, 503);
            this.messageContentField.Name = "messageContentField";
            this.messageContentField.Size = new System.Drawing.Size(498, 95);
            this.messageContentField.TabIndex = 1;
            this.messageContentField.Text = "";
            this.messageContentField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messageContentField_KeyUp);
            // 
            // sendButton
            // 
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendButton.Location = new System.Drawing.Point(388, 2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(108, 26);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footerPanel.Controls.Add(this.sendButton);
            this.footerPanel.Location = new System.Drawing.Point(0, 598);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.footerPanel.Size = new System.Drawing.Size(498, 32);
            this.footerPanel.TabIndex = 3;
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.AutoScroll = true;
            this.background.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.background.Controls.Add(this.messagesGrid);
            this.background.Location = new System.Drawing.Point(2, 2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(494, 495);
            this.background.TabIndex = 1;
            // 
            // ConversationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 630);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.messageContentField);
            this.Controls.Add(this.background);
            this.Name = "ConversationView";
            this.Text = "ConversationView";
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ConversationView_Scroll);
            this.footerPanel.ResumeLayout(false);
            this.background.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox messageContentField;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.TableLayoutPanel messagesGrid;
        private System.Windows.Forms.Panel background;
    }
}