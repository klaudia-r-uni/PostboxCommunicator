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
            this.messagesGrid = new System.Windows.Forms.TableLayoutPanel();
            this.messageContentField = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.background.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.AutoScroll = true;
            this.background.Controls.Add(this.messagesGrid);
            this.background.Dock = System.Windows.Forms.DockStyle.Top;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(996, 967);
            this.background.TabIndex = 0;
            this.background.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ConversationView_Scroll);
            // 
            // messagesGrid
            // 
            this.messagesGrid.AutoSize = true;
            this.messagesGrid.ColumnCount = 1;
            this.messagesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.messagesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.messagesGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.messagesGrid.Location = new System.Drawing.Point(4, 4);
            this.messagesGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messagesGrid.Name = "messagesGrid";
            this.messagesGrid.RowCount = 1;
            this.messagesGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.messagesGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.messagesGrid.Size = new System.Drawing.Size(0, 0);
            this.messagesGrid.TabIndex = 0;
            // 
            // messageContentField
            // 
            this.messageContentField.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageContentField.Location = new System.Drawing.Point(0, 967);
            this.messageContentField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.messageContentField.Name = "messageContentField";
            this.messageContentField.Size = new System.Drawing.Size(996, 179);
            this.messageContentField.TabIndex = 1;
            this.messageContentField.Text = "";
            this.messageContentField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messageContentField_KeyUp);
            // 
            // sendButton
            // 
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendButton.Location = new System.Drawing.Point(776, 4);
            this.sendButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(216, 50);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.button1);
            this.footerPanel.Controls.Add(this.sendButton);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.footerPanel.Location = new System.Drawing.Point(0, 1146);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.footerPanel.Size = new System.Drawing.Size(996, 62);
            this.footerPanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Archive";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ConversationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 1212);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.messageContentField);
            this.Controls.Add(this.background);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ConversationView";
            this.Text = "ConversationView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConversationView_FormClosed);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ConversationView_Scroll);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel background;
        private System.Windows.Forms.RichTextBox messageContentField;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel messagesGrid;
    }
}