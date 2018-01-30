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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.logInBackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInBackgroundPanel
            // 
            this.logInBackgroundPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logInBackgroundPanel.Controls.Add(this.sendButton);
            this.logInBackgroundPanel.Controls.Add(this.textBox2);
            this.logInBackgroundPanel.Controls.Add(this.textLogin);
            this.logInBackgroundPanel.Controls.Add(this.passwordLabel);
            this.logInBackgroundPanel.Controls.Add(this.loginLabel);
            this.logInBackgroundPanel.Location = new System.Drawing.Point(29, 27);
            this.logInBackgroundPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logInBackgroundPanel.Name = "logInBackgroundPanel";
            this.logInBackgroundPanel.Size = new System.Drawing.Size(545, 215);
            this.logInBackgroundPanel.TabIndex = 0;
          //  this.logInBackgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.logInBackgroundPanel_Paint);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(392, 148);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(100, 28);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 92);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(305, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(187, 48);
            this.textLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(305, 22);
            this.textLogin.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.Location = new System.Drawing.Point(75, 96);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(97, 22);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel.Location = new System.Drawing.Point(113, 48);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(59, 22);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // LogInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 258);
            this.Controls.Add(this.logInBackgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(631, 305);
            this.MinimumSize = new System.Drawing.Size(631, 305);
            this.Name = "LogInView";
            this.Text = "Log in! ";
            this.Load += new System.EventHandler(this.LogInView_Load);
            this.logInBackgroundPanel.ResumeLayout(false);
            this.logInBackgroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logInBackgroundPanel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textLogin;
    }
}