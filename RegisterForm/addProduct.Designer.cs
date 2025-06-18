namespace RegisterForm
{
    partial class addProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProduct));
            panel1 = new Panel();
            panel2 = new Panel();
            imgLink = new LinkLabel();
            clickImg = new PictureBox();
            supplierNametxt = new TextBox();
            label11 = new Label();
            productPricetxt = new TextBox();
            productQuantitytxt = new TextBox();
            label9 = new Label();
            label7 = new Label();
            productDesctxt = new TextBox();
            label6 = new Label();
            productCategorytxt = new TextBox();
            label5 = new Label();
            productNametxt = new TextBox();
            label4 = new Label();
            productIDtxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clickImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 17, 18);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(supplierNametxt);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(productPricetxt);
            panel1.Controls.Add(productQuantitytxt);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(productDesctxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(productCategorytxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(productNametxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(productIDtxt);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(28, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 545);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 49, 49);
            panel2.Controls.Add(imgLink);
            panel2.Controls.Add(clickImg);
            panel2.Location = new Point(494, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 295);
            panel2.TabIndex = 34;
            // 
            // imgLink
            // 
            imgLink.AutoSize = true;
            imgLink.LinkColor = Color.FromArgb(0, 58, 158);
            imgLink.Location = new Point(98, 255);
            imgLink.Name = "imgLink";
            imgLink.Size = new Size(222, 20);
            imgLink.TabIndex = 19;
            imgLink.TabStop = true;
            imgLink.Text = "Click here to add Product image";
            // 
            // clickImg
            // 
            clickImg.Image = (Image)resources.GetObject("clickImg.Image");
            clickImg.Location = new Point(108, 47);
            clickImg.Name = "clickImg";
            clickImg.Size = new Size(196, 160);
            clickImg.SizeMode = PictureBoxSizeMode.StretchImage;
            clickImg.TabIndex = 19;
            clickImg.TabStop = false;
            // 
            // supplierNametxt
            // 
            supplierNametxt.BackColor = Color.FromArgb(66, 66, 66);
            supplierNametxt.BorderStyle = BorderStyle.None;
            supplierNametxt.Font = new Font("Segoe UI", 12F);
            supplierNametxt.ForeColor = Color.White;
            supplierNametxt.Location = new Point(34, 475);
            supplierNametxt.Name = "supplierNametxt";
            supplierNametxt.Size = new Size(428, 27);
            supplierNametxt.TabIndex = 33;
            supplierNametxt.TextChanged += textBox7_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(30, 452);
            label11.Name = "label11";
            label11.Size = new Size(108, 20);
            label11.TabIndex = 32;
            label11.Text = "Supplier Name";
            label11.Click += label11_Click;
            // 
            // productPricetxt
            // 
            productPricetxt.BackColor = Color.FromArgb(66, 66, 66);
            productPricetxt.BorderStyle = BorderStyle.None;
            productPricetxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productPricetxt.ForeColor = Color.White;
            productPricetxt.Location = new Point(34, 399);
            productPricetxt.Name = "productPricetxt";
            productPricetxt.Size = new Size(188, 27);
            productPricetxt.TabIndex = 31;
            // 
            // productQuantitytxt
            // 
            productQuantitytxt.BackColor = Color.FromArgb(66, 66, 66);
            productQuantitytxt.BorderStyle = BorderStyle.None;
            productQuantitytxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productQuantitytxt.ForeColor = Color.White;
            productQuantitytxt.Location = new Point(274, 399);
            productQuantitytxt.Name = "productQuantitytxt";
            productQuantitytxt.Size = new Size(188, 27);
            productQuantitytxt.TabIndex = 30;
            productQuantitytxt.TextChanged += textBox6_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(270, 376);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 29;
            label9.Text = "Quantity";
            label9.Click += label9_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(30, 376);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 27;
            label7.Text = "Price";
            label7.Click += label7_Click;
            // 
            // productDesctxt
            // 
            productDesctxt.BackColor = Color.FromArgb(66, 66, 66);
            productDesctxt.BorderStyle = BorderStyle.None;
            productDesctxt.ForeColor = Color.White;
            productDesctxt.Location = new Point(34, 272);
            productDesctxt.Multiline = true;
            productDesctxt.Name = "productDesctxt";
            productDesctxt.Size = new Size(428, 85);
            productDesctxt.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(30, 249);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 25;
            label6.Text = "Description";
            // 
            // productCategorytxt
            // 
            productCategorytxt.BackColor = Color.FromArgb(66, 66, 66);
            productCategorytxt.BorderStyle = BorderStyle.None;
            productCategorytxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productCategorytxt.ForeColor = Color.White;
            productCategorytxt.Location = new Point(34, 200);
            productCategorytxt.Name = "productCategorytxt";
            productCategorytxt.Size = new Size(428, 27);
            productCategorytxt.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(30, 177);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 23;
            label5.Text = "Category";
            label5.Click += label5_Click;
            // 
            // productNametxt
            // 
            productNametxt.BackColor = Color.FromArgb(66, 66, 66);
            productNametxt.BorderStyle = BorderStyle.None;
            productNametxt.Font = new Font("Segoe UI", 12F);
            productNametxt.ForeColor = Color.White;
            productNametxt.Location = new Point(34, 128);
            productNametxt.Name = "productNametxt";
            productNametxt.Size = new Size(428, 27);
            productNametxt.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(30, 105);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 21;
            label4.Text = "Product Name";
            // 
            // productIDtxt
            // 
            productIDtxt.BackColor = Color.FromArgb(66, 66, 66);
            productIDtxt.BorderStyle = BorderStyle.None;
            productIDtxt.Font = new Font("Segoe UI", 12F);
            productIDtxt.ForeColor = Color.White;
            productIDtxt.Location = new Point(34, 62);
            productIDtxt.Name = "productIDtxt";
            productIDtxt.Size = new Size(428, 27);
            productIDtxt.TabIndex = 20;
            productIDtxt.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(30, 39);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 19;
            label2.Text = "Product ID";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(420, 82);
            label1.Name = "label1";
            label1.Size = new Size(198, 31);
            label1.TabIndex = 1;
            label1.Text = "Add New Product";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(114, 13);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 11;
            label8.Text = "invenza";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI Semilight", 7F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(114, 38);
            label10.Name = "label10";
            label10.Size = new Size(231, 15);
            label10.TabIndex = 12;
            label10.Text = "Streamline Your Stock, Power Your Business";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(377, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(329, 685);
            label3.Name = "label3";
            label3.Size = new Size(367, 20);
            label3.TabIndex = 18;
            label3.Text = "Invenza v1.0  © 2025 Invenza, Inc. All rights reserved";
            // 
            // addProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1024, 761);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addProduct";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clickImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label10;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private TextBox productIDtxt;
        private TextBox productNametxt;
        private Label label4;
        private TextBox productDesctxt;
        private Label label6;
        private TextBox productCategorytxt;
        private Label label5;
        private Label label7;
        private TextBox productQuantitytxt;
        private Label label9;
        private TextBox productPricetxt;
        private TextBox supplierNametxt;
        private Label label11;
        private Panel panel2;
        private PictureBox clickImg;
        private LinkLabel imgLink;
    }
}