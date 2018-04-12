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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
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
            this.menuPanel.Controls.Add(this.label2);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.helpButton);
            this.menuPanel.Controls.Add(this.panel2);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(6);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(754, 77);
            this.menuPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(24, 17);
            this.helpButton.Margin = new System.Windows.Forms.Padding(6);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(150, 44);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 1008);
            this.panel2.TabIndex = 1;
            // 
            // contactListPanel
            // 
            this.contactListPanel.BackColor = System.Drawing.Color.LightGray;
            this.contactListPanel.Controls.Add(this.contactFlowPanel);
            this.contactListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactListPanel.Location = new System.Drawing.Point(0, 77);
            this.contactListPanel.Margin = new System.Windows.Forms.Padding(6);
            this.contactListPanel.Name = "contactListPanel";
            this.contactListPanel.Size = new System.Drawing.Size(754, 1056);
            this.contactListPanel.TabIndex = 1;
            // 
            // contactFlowPanel
            // 
            this.contactFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.contactFlowPanel.Margin = new System.Windows.Forms.Padding(6);
            this.contactFlowPanel.Name = "contactFlowPanel";
            this.contactFlowPanel.Padding = new System.Windows.Forms.Padding(10, 19, 10, 0);
            this.contactFlowPanel.Size = new System.Drawing.Size(754, 1056);
            this.contactFlowPanel.TabIndex = 0;
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.logOutButton);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.footerPanel.Location = new System.Drawing.Point(0, 1133);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(6);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(754, 73);
            this.footerPanel.TabIndex = 2;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(598, 6);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(6);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(150, 44);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Log out!";
            this.logOutButton.UseVisualStyleBackColor = true;

            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(754, 1212);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.contactListPanel);
            this.Controls.Add(this.menuPanel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ContactListView";
            this.Text = "Secure Messaging System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContactListView_FormClosed);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
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
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.FlowLayoutPanel contactFlowPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

