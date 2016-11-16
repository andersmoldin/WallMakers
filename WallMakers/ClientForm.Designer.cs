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
            this.textBoxIPadress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCoupleUp
            // 
            this.btnCoupleUp.Location = new System.Drawing.Point(394, 362);
            this.btnCoupleUp.Name = "btnCoupleUp";
            this.btnCoupleUp.Size = new System.Drawing.Size(182, 37);
            this.btnCoupleUp.TabIndex = 0;
            this.btnCoupleUp.Text = "Couple Up";
            this.btnCoupleUp.UseVisualStyleBackColor = true;
            this.btnCoupleUp.Click += new System.EventHandler(this.btnCoupleUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(126, 476);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(123, 66);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "Pretend to move LEFT";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // textBoxIPadress
            // 
            this.textBoxIPadress.Location = new System.Drawing.Point(172, 377);
            this.textBoxIPadress.Name = "textBoxIPadress";
            this.textBoxIPadress.Size = new System.Drawing.Size(196, 22);
            this.textBoxIPadress.TabIndex = 2;
            this.textBoxIPadress.TextChanged += new System.EventHandler(this.textBoxIPadress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP adress";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 431);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1045);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIPadress);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnCoupleUp);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCoupleUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.TextBox textBoxIPadress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

