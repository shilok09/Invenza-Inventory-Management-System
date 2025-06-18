namespace RegisterForm
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label8 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label6 = new Label();
            ConfirmPassword = new TextBox();
            label1 = new Label();
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
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(188, 339);
            label8.Name = "label8";
            label8.Size = new Size(232, 75);
            label8.TabIndex = 12;
            label8.Text = "invenza";
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
            label10.TabIndex = 14;
            label10.Text = "Streamline Your Stock, Power Your Business";
            label10.Click += label10_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 340);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ConfirmPassword);
            panel1.Controls.Add(label1);
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
            panel1.Location = new Point(544, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 579);
            panel1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "";
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(53, 91);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 38);
            textBox1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(51, 63);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 17;
            label6.Text = "Business name";
            label6.Click += label6_Click;
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.AccessibleName = "";
            ConfirmPassword.BackColor = SystemColors.ButtonFace;
            ConfirmPassword.BorderStyle = BorderStyle.None;
            ConfirmPassword.Cursor = Cursors.IBeam;
            ConfirmPassword.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmPassword.Location = new Point(53, 386);
            ConfirmPassword.Multiline = true;
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.Size = new Size(302, 39);
            ConfirmPassword.TabIndex = 16;
            ConfirmPassword.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(53, 356);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 15;
            label1.Text = "Confirm Password";
            label1.Click += label1_Click;
            // 
            // checkShowPassword
            // 
            checkShowPassword.AutoSize = true;
            checkShowPassword.Cursor = Cursors.Hand;
            checkShowPassword.FlatStyle = FlatStyle.Flat;
            checkShowPassword.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkShowPassword.ForeColor = Color.Gray;
            checkShowPassword.Location = new Point(232, 429);
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
            txtlogin.Location = new Point(144, 543);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(79, 20);
            txtlogin.TabIndex = 13;
            txtlogin.Text = "Login here";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semilight", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(130, 529);
            label11.Name = "label11";
            label11.Size = new Size(142, 15);
            label11.TabIndex = 12;
            label11.Text = "Already have an Account?";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = SystemColors.ActiveCaptionText;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = SystemColors.ControlLightLight;
            registerBtn.Location = new Point(53, 474);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(297, 46);
            registerBtn.TabIndex = 11;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            // 
            // textUsername
            // 
            textUsername.AccessibleName = "";
            textUsername.BackColor = SystemColors.ButtonFace;
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Cursor = Cursors.IBeam;
            textUsername.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(52, 160);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(302, 38);
            textUsername.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(50, 132);
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
            textPassword.Location = new Point(52, 312);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(302, 39);
            textPassword.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(52, 282);
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
            textEmail.Location = new Point(52, 234);
            textEmail.Multiline = true;
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(302, 39);
            textEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(52, 207);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Business Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(43, 8);
            label2.Name = "label2";
            label2.Size = new Size(145, 46);
            label2.TabIndex = 1;
            label2.Text = "Register";
            label2.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(335, 739);
            label7.Name = "label7";
            label7.Size = new Size(367, 20);
            label7.TabIndex = 19;
            label7.Text = "Invenza v1.0  © 2025 Invenza, Inc. All rights reserved";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1024, 761);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label10;
        private PictureBox pictureBox1;
        private Panel panel1;
        private CheckBox checkShowPassword;
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
        private TextBox ConfirmPassword;
        private Label label1;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
    }
}