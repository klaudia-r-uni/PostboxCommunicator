namespace PostboxCommunicator {
    partial class HelpView {
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
            this.helpWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // helpWebBrowser
            // 
            this.helpWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.helpWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.helpWebBrowser.Name = "helpWebBrowser";
            this.helpWebBrowser.Size = new System.Drawing.Size(1288, 1157);
            this.helpWebBrowser.TabIndex = 0;
           
            // 
            // HelpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 1157);
            this.Controls.Add(this.helpWebBrowser);
            this.Name = "HelpView";
            this.Text = "HelpView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser helpWebBrowser;
    }
}