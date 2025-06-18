namespace RegisterForm
{
    partial class landingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(landingPage));
            label8 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            getStartBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 52F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(435, 263);
            label8.Name = "label8";
            label8.Size = new Size(337, 110);
            label8.TabIndex = 11;
            label8.Text = "invenza";
            label8.Click += label8_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(449, 354);
            label10.Name = "label10";
            label10.Size = new Size(382, 28);
            label10.TabIndex = 13;
            label10.Text = "Streamline Your Stock, Power Your Business";
            label10.Click += label10_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(185, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // getStartBtn
            // 
            getStartBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            getStartBtn.BackColor = Color.RoyalBlue;
            getStartBtn.Cursor = Cursors.Hand;
            getStartBtn.FlatStyle = FlatStyle.Flat;
            getStartBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            getStartBtn.Location = new Point(660, 418);
            getStartBtn.Name = "getStartBtn";
            getStartBtn.Size = new Size(171, 36);
            getStartBtn.TabIndex = 14;
            getStartBtn.Text = "GET STARTED";
            getStartBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(450, 249);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 15;
            label1.Text = "Welcome to";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 720);
            label2.Name = "label2";
            label2.Size = new Size(390, 20);
            label2.TabIndex = 16;
            label2.Text = "Developed by: Shilok Kumar Ali Asjad and Sameer Khan";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(635, 720);
            label3.Name = "label3";
            label3.Size = new Size(367, 20);
            label3.TabIndex = 17;
            label3.Text = "Invenza v1.0  © 2025 Invenza, Inc. All rights reserved";
            // 
            // landingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1024, 761);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(getStartBtn);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "landingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "landingPage";
            Load += landingPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label10;
        private PictureBox pictureBox1;
        private Button getStartBtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}