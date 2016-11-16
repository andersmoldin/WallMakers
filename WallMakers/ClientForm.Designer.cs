namespace WallMakers
{
    partial class ClientForm
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
            this.btnCoupleUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCoupleUp
            // 
            this.btnCoupleUp.Location = new System.Drawing.Point(429, 416);
            this.btnCoupleUp.Name = "btnCoupleUp";
            this.btnCoupleUp.Size = new System.Drawing.Size(182, 154);
            this.btnCoupleUp.TabIndex = 0;
            this.btnCoupleUp.Text = "Couple Up";
            this.btnCoupleUp.UseVisualStyleBackColor = true;
            this.btnCoupleUp.Click += new System.EventHandler(this.btnCoupleUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(94, 55);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(191, 155);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "Pretend to move LEFT";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 582);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnCoupleUp);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCoupleUp;
        private System.Windows.Forms.Button btnLeft;
    }
}

