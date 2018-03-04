namespace PostboxCommunicator {
    partial class LogInView {
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
            this.logInBackgroundPanel = new System.Windows.Forms.Panel();
            this.sendButton = new System.Windows.Forms.Button();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.logInBackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInBackgroundPanel
            // 
            this.logInBackgroundPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logInBackgroundPanel.Controls.Add(this.sendButton);
            this.logInBackgroundPanel.Controls.Add(this.passwordInput);
            this.logInBackgroundPanel.Controls.Add(this.loginInput);
            this.logInBackgroundPanel.Controls.Add(this.passwordLabel);
            this.logInBackgroundPanel.Controls.Add(this.loginLabel);
            this.logInBackgroundPanel.Location = new System.Drawing.Point(22, 22);
            this.logInBackgroundPanel.Name = "logInBackgroundPanel";
            this.logInBackgroundPanel.Size = new System.Drawing.Size(409, 175);
            this.logInBackgroundPanel.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(294, 120);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(140, 75);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(230, 20);
            this.passwordInput.TabIndex = 3;
            // 
            // loginInput
            // 
            this.loginInput.Location = new System.Drawing.Point(140, 39);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(230, 20);
            this.loginInput.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.Location = new System.Drawing.Point(56, 78);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(77, 17);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel.Location = new System.Drawing.Point(85, 39);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(48, 17);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // LogInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 218);
            this.Controls.Add(this.logInBackgroundPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(478, 257);
            this.MinimumSize = new System.Drawing.Size(478, 257);
            this.Name = "LogInView";
            this.Text = "Log in! ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogInView_FormClosed);
            this.logInBackgroundPanel.ResumeLayout(false);
            this.logInBackgroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logInBackgroundPanel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox loginInput;
    }
}