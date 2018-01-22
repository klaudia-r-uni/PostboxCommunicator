namespace PostboxCommunicator {
    partial class ArchiveView {
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
            this.contactListArchivePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.messageArchiveBackgroundPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.informationMessagesArchivePanel = new System.Windows.Forms.Panel();
            this.conversationBetweenLabel = new System.Windows.Forms.Label();
            this.dateOneLabel = new System.Windows.Forms.Label();
            this.dateAndLabel = new System.Windows.Forms.Label();
            this.dateTwoLabel = new System.Windows.Forms.Label();
            this.messageContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.messageArchiveBackgroundPanel.SuspendLayout();
            this.informationMessagesArchivePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactListArchivePanel
            // 
            this.contactListArchivePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactListArchivePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.contactListArchivePanel.Location = new System.Drawing.Point(0, 0);
            this.contactListArchivePanel.Name = "contactListArchivePanel";
            this.contactListArchivePanel.Padding = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.contactListArchivePanel.Size = new System.Drawing.Size(167, 636);
            this.contactListArchivePanel.TabIndex = 0;
            // 
            // messageArchiveBackgroundPanel
            // 
            this.messageArchiveBackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageArchiveBackgroundPanel.Controls.Add(this.informationMessagesArchivePanel);
            this.messageArchiveBackgroundPanel.Controls.Add(this.messageContentPanel);
            this.messageArchiveBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageArchiveBackgroundPanel.Location = new System.Drawing.Point(167, 0);
            this.messageArchiveBackgroundPanel.Name = "messageArchiveBackgroundPanel";
            this.messageArchiveBackgroundPanel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.messageArchiveBackgroundPanel.Size = new System.Drawing.Size(626, 636);
            this.messageArchiveBackgroundPanel.TabIndex = 1;
            // 
            // informationMessagesArchivePanel
            // 
            this.informationMessagesArchivePanel.Controls.Add(this.dateTwoLabel);
            this.informationMessagesArchivePanel.Controls.Add(this.dateAndLabel);
            this.informationMessagesArchivePanel.Controls.Add(this.dateOneLabel);
            this.informationMessagesArchivePanel.Controls.Add(this.conversationBetweenLabel);
            this.informationMessagesArchivePanel.Location = new System.Drawing.Point(8, 3);
            this.informationMessagesArchivePanel.Name = "informationMessagesArchivePanel";
            this.informationMessagesArchivePanel.Size = new System.Drawing.Size(605, 41);
            this.informationMessagesArchivePanel.TabIndex = 2;
            // 
            // conversationBetweenLabel
            // 
            this.conversationBetweenLabel.AutoSize = true;
            this.conversationBetweenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.conversationBetweenLabel.Location = new System.Drawing.Point(85, 13);
            this.conversationBetweenLabel.Name = "conversationBetweenLabel";
            this.conversationBetweenLabel.Size = new System.Drawing.Size(186, 17);
            this.conversationBetweenLabel.TabIndex = 0;
            this.conversationBetweenLabel.Text = "Conversations between: ";
            // 
            // dateOneLabel
            // 
            this.dateOneLabel.AutoSize = true;
            this.dateOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateOneLabel.Location = new System.Drawing.Point(268, 13);
            this.dateOneLabel.Name = "dateOneLabel";
            this.dateOneLabel.Size = new System.Drawing.Size(92, 17);
            this.dateOneLabel.TabIndex = 1;
            this.dateOneLabel.Text = "0000-00-00";
            // 
            // dateAndLabel
            // 
            this.dateAndLabel.AutoSize = true;
            this.dateAndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateAndLabel.Location = new System.Drawing.Point(356, 13);
            this.dateAndLabel.Name = "dateAndLabel";
            this.dateAndLabel.Size = new System.Drawing.Size(35, 17);
            this.dateAndLabel.TabIndex = 2;
            this.dateAndLabel.Text = "and";
            // 
            // dateTwoLabel
            // 
            this.dateTwoLabel.AutoSize = true;
            this.dateTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTwoLabel.Location = new System.Drawing.Point(394, 13);
            this.dateTwoLabel.Name = "dateTwoLabel";
            this.dateTwoLabel.Size = new System.Drawing.Size(92, 17);
            this.dateTwoLabel.TabIndex = 3;
            this.dateTwoLabel.Text = "0000-00-00";
            // 
            // messageContentPanel
            // 
            this.messageContentPanel.Location = new System.Drawing.Point(8, 50);
            this.messageContentPanel.Name = "messageContentPanel";
            this.messageContentPanel.Size = new System.Drawing.Size(605, 558);
            this.messageContentPanel.TabIndex = 3;
            // 
            // ArchiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 636);
            this.Controls.Add(this.messageArchiveBackgroundPanel);
            this.Controls.Add(this.contactListArchivePanel);
            this.Name = "ArchiveView";
            this.Text = "ArchiveView";
            this.messageArchiveBackgroundPanel.ResumeLayout(false);
            this.informationMessagesArchivePanel.ResumeLayout(false);
            this.informationMessagesArchivePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel contactListArchivePanel;
        private System.Windows.Forms.FlowLayoutPanel messageArchiveBackgroundPanel;
        private System.Windows.Forms.Panel informationMessagesArchivePanel;
        private System.Windows.Forms.Label dateTwoLabel;
        private System.Windows.Forms.Label dateAndLabel;
        private System.Windows.Forms.Label dateOneLabel;
        private System.Windows.Forms.Label conversationBetweenLabel;
        private System.Windows.Forms.FlowLayoutPanel messageContentPanel;
    }
}