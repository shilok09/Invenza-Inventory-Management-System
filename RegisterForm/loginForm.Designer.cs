namespace RegisterForm
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            panel1 = new Panel();
            checkShowPassword = new CheckBox();
            txtlogin = new Label();
            label11 = new Label();
            registerBtn = new Button();
            textUsername = new TextBox();
            label5 = new Label();
            textPassword = new TextBox();
            label4 = new Label();
            textEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkShowPassword);
            panel1.Controls.Add(txtlogin);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(registerBtn);
            panel1.Controls.Add(textUsername);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(544, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 526);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // checkShowPassword
            // 
            checkShowPassword.AutoSize = true;
            checkShowPassword.Cursor = Cursors.Hand;
            checkShowPassword.FlatStyle = FlatStyle.Flat;
            checkShowPassword.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkShowPassword.ForeColor = Color.Gray;
            checkShowPassword.Location = new Point(232, 350);
            checkShowPassword.Name = "checkShowPassword";
            checkShowPassword.Size = new Size(117, 21);
            checkShowPassword.TabIndex = 14;
            checkShowPassword.Text = "Show Password";
            checkShowPassword.UseVisualStyleBackColor = true;
            // 
            // txtlogin
            // 
            txtlogin.AutoSize = true;
            txtlogin.BackColor = SystemColors.ControlLightLight;
            txtlogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlogin.ForeColor = Color.RoyalBlue;
            txtlogin.Location = new Point(144, 464);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(96, 20);
            txtlogin.TabIndex = 13;
            txtlogin.Text = "Register here";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semilight", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(130, 450);
            label11.Name = "label11";
            label11.Size = new Size(128, 15);
            label11.TabIndex = 12;
            label11.Text = "Dont have an Account?";
            label11.Click += label11_Click;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = SystemColors.ActiveCaptionText;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = SystemColors.ControlLightLight;
            registerBtn.Location = new Point(53, 395);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(297, 41);
            registerBtn.TabIndex = 11;
            registerBtn.Text = "Login";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // textUsername
            // 
            textUsername.AccessibleName = "";
            textUsername.BackColor = SystemColors.ButtonFace;
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Cursor = Cursors.IBeam;
            textUsername.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(52, 150);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(302, 33);
            textUsername.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(50, 122);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 6;
            label5.Text = "Username";
            // 
            // textPassword
            // 
            textPassword.AccessibleName = "";
            textPassword.BackColor = SystemColors.ButtonFace;
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Cursor = Cursors.IBeam;
            textPassword.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(52, 302);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(302, 34);
            textPassword.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(52, 272);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // textEmail
            // 
            textEmail.AccessibleName = "";
            textEmail.BackColor = SystemColors.ButtonFace;
            textEmail.BorderStyle = BorderStyle.None;
            textEmail.Cursor = Cursors.IBeam;
            textEmail.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEmail.Location = new Point(52, 224);
            textEmail.Multiline = true;
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(302, 34);
            textEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(52, 197);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Business Email";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(45, 58);
            label2.Name = "label2";
            label2.Size = new Size(106, 46);
            label2.TabIndex = 1;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(198, 410);
            label10.Name = "label10";
            label10.Size = new Size(279, 20);
            label10.TabIndex = 10;
            label10.Text = "Streamline Your Stock, Power Your Business";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 340);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(188, 339);
            label8.Name = "label8";
            label8.Size = new Size(232, 75);
            label8.TabIndex = 8;
            label8.Text = "invenza";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(335, 739);
            label1.Name = "label1";
            label1.Size = new Size(367, 20);
            label1.TabIndex = 19;
            label1.Text = "Invenza v1.0  © 2025 Invenza, Inc. All rights reserved";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1024, 768);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label txtlogin;
        private Label label11;
        private Button registerBtn;
        private TextBox textUsername;
        private Label label5;
        private TextBox textPassword;
        private Label label4;
        private TextBox textEmail;
        private Label label3;
        private Label label2;
        private Label label10;
        private PictureBox pictureBox1;
        private Label label8;
        private CheckBox checkShowPassword;
        private Label label1;
    }
}