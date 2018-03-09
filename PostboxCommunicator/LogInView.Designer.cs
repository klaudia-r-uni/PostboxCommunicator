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
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.logInBackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInBackgroundPanel
            // 
            this.logInBackgroundPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logInBackgroundPanel.Controls.Add(this.labelLoginError);
            this.logInBackgroundPanel.Controls.Add(this.labelError2);
            this.logInBackgroundPanel.Controls.Add(this.sendButton);
            this.logInBackgroundPanel.Controls.Add(this.textBox2);
            this.logInBackgroundPanel.Controls.Add(this.textBox1);
            this.logInBackgroundPanel.Controls.Add(this.passwordLabel);
            this.logInBackgroundPanel.Controls.Add(this.loginLabel);
            this.logInBackgroundPanel.Location = new System.Drawing.Point(29, 27);
            this.logInBackgroundPanel.Margin = new System.Windows.Forms.Padding(4);
            this.logInBackgroundPanel.Name = "logInBackgroundPanel";
            this.logInBackgroundPanel.Size = new System.Drawing.Size(545, 215);
            this.logInBackgroundPanel.TabIndex = 0;
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
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.Location = new System.Drawing.Point(39, 148);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(0, 17);
            this.lblLoginError.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 2;
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.Location = new System.Drawing.Point(79, 183);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(46, 17);
            this.labelError2.TabIndex = 5;
            this.labelError2.Text = "label1";
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 20);
            this.textBox2.TabIndex = 3;
            // 
            // loginLabel
            // 
            this.sendButton.Location = new System.Drawing.Point(294, 120);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // LogInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 258);
            this.Controls.Add(this.logInBackgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(631, 305);
            this.MinimumSize = new System.Drawing.Size(631, 305);
            this.Name = "LogInView";
            this.Text = "Log in! ";
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
        private System.Windows.Forms.TextBox textBox1;
    }
}