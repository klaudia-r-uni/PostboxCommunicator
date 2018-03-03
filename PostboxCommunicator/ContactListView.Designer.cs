namespace PostboxCommunicator {
    partial class ContactListView {
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.archiveButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contactListPanel = new System.Windows.Forms.Panel();
            this.contactFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.contactListPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.archiveButton);
            this.menuPanel.Controls.Add(this.panel2);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(503, 49);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // archiveButton
            // 
            this.archiveButton.Location = new System.Drawing.Point(16, 11);
            this.archiveButton.Margin = new System.Windows.Forms.Padding(4);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(100, 28);
            this.archiveButton.TabIndex = 1;
            this.archiveButton.Text = "Archive";
            this.archiveButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 645);
            this.panel2.TabIndex = 1;
            // 
            // contactListPanel
            // 
            this.contactListPanel.BackColor = System.Drawing.Color.LightGray;
            this.contactListPanel.Controls.Add(this.contactFlowPanel);
            this.contactListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactListPanel.Location = new System.Drawing.Point(0, 49);
            this.contactListPanel.Margin = new System.Windows.Forms.Padding(4);
            this.contactListPanel.Name = "contactListPanel";
            this.contactListPanel.Size = new System.Drawing.Size(503, 676);
            this.contactListPanel.TabIndex = 1;
            // 
            // contactFlowPanel
            // 
            this.contactFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.contactFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.contactFlowPanel.Name = "contactFlowPanel";
            this.contactFlowPanel.Padding = new System.Windows.Forms.Padding(7, 12, 7, 0);
            this.contactFlowPanel.Size = new System.Drawing.Size(503, 676);
            this.contactFlowPanel.TabIndex = 0;
            this.contactFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contactFlowPanel_Paint);
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.logOutButton);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.footerPanel.Location = new System.Drawing.Point(0, 725);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(503, 47);
            this.footerPanel.TabIndex = 2;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(399, 4);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(100, 28);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Log out!";
            this.logOutButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(503, 775);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.contactListPanel);
            this.Controls.Add(this.menuPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Secure Messaging System";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuPanel.ResumeLayout(false);
            this.contactListPanel.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel contactListPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.FlowLayoutPanel contactFlowPanel;
    }
}

