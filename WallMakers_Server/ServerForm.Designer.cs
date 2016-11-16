namespace WallMakers_Server
{
    partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(457, 238);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(218, 193);
            this.btnShutdown.TabIndex = 0;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(70, 238);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(218, 193);
            this.btnStartServer.TabIndex = 1;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 594);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.btnShutdown);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerForm_FormClosed);
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnStartServer;
    }
}

