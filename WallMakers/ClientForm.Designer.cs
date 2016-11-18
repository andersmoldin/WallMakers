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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.btnCoupleUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.textBoxIPadress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.btnLeft.Location = new System.Drawing.Point(231, 713);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(80, 66);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "LEFT";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Visible = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // textBoxIPadress
            // 
            this.textBoxIPadress.Location = new System.Drawing.Point(172, 377);
            this.textBoxIPadress.Name = "textBoxIPadress";
            this.textBoxIPadress.Size = new System.Drawing.Size(196, 22);
            this.textBoxIPadress.TabIndex = 2;
            this.textBoxIPadress.Text = "192.168.25.";
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
            this.textBox1.Location = new System.Drawing.Point(172, 577);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            this.label2.Visible = false;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(387, 713);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(80, 66);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "RIGHT";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Visible = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(309, 649);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(80, 66);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Visible = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(309, 777);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(80, 66);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Visible = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Amanda");
            this.imageList1.Images.SetKeyName(1, "Anders");
            this.imageList1.Images.SetKeyName(2, "Andreas");
            this.imageList1.Images.SetKeyName(3, "Arvid");
            this.imageList1.Images.SetKeyName(4, "Asim");
            this.imageList1.Images.SetKeyName(5, "Axel");
            this.imageList1.Images.SetKeyName(6, "Basel");
            this.imageList1.Images.SetKeyName(7, "Carl");
            this.imageList1.Images.SetKeyName(8, "Damir");
            this.imageList1.Images.SetKeyName(9, "Daniel");
            this.imageList1.Images.SetKeyName(10, "Jesper");
            this.imageList1.Images.SetKeyName(11, "Johan");
            this.imageList1.Images.SetKeyName(12, "Johanna");
            this.imageList1.Images.SetKeyName(13, "Kristoffer");
            this.imageList1.Images.SetKeyName(14, "Lars");
            this.imageList1.Images.SetKeyName(15, "Lina");
            this.imageList1.Images.SetKeyName(16, "Linn");
            this.imageList1.Images.SetKeyName(17, "Malin A");
            this.imageList1.Images.SetKeyName(18, "Malin U");
            this.imageList1.Images.SetKeyName(19, "Martin");
            this.imageList1.Images.SetKeyName(20, "Nathaniel");
            this.imageList1.Images.SetKeyName(21, "Nils C");
            this.imageList1.Images.SetKeyName(22, "Nils G");
            this.imageList1.Images.SetKeyName(23, "Rickard");
            this.imageList1.Images.SetKeyName(24, "Robert");
            this.imageList1.Images.SetKeyName(25, "Robin");
            this.imageList1.Images.SetKeyName(26, "Sebastian");
            this.imageList1.Images.SetKeyName(27, "Viktor");
            this.imageList1.Images.SetKeyName(28, "Weronika");
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 432);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 1045);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIPadress);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnCoupleUp);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientForm_KeyDown);
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
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

