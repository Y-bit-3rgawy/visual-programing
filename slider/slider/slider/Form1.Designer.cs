namespace slider
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth24Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "air15.jpg");
            imageList1.Images.SetKeyName(1, "air12.jpeg");
            imageList1.Images.SetKeyName(2, "air11.jpeg");
            imageList1.Images.SetKeyName(3, "air10.jpeg");
            imageList1.Images.SetKeyName(4, "air9.jpeg");
            imageList1.Images.SetKeyName(5, "air8.jpeg");
            imageList1.Images.SetKeyName(6, "air7.jpeg");
            imageList1.Images.SetKeyName(7, "air6.jpeg");
            imageList1.Images.SetKeyName(8, "air5.jpeg");
            imageList1.Images.SetKeyName(9, "air4.jpeg");
            imageList1.Images.SetKeyName(10, "air3.jpeg");
            imageList1.Images.SetKeyName(11, "air2.jpeg");
            imageList1.Images.SetKeyName(12, "air1.jpeg");
            imageList1.Images.SetKeyName(13, "ico.png");
            imageList1.Images.SetKeyName(14, "client-1.jpg");
            imageList1.Images.SetKeyName(15, "client-2.jpg");
            imageList1.Images.SetKeyName(16, "client-3.jpg");
            imageList1.Images.SetKeyName(17, "client-4.jpg");
            imageList1.Images.SetKeyName(18, "header.jpg");
            imageList1.Images.SetKeyName(19, "lounge-1.jpg");
            imageList1.Images.SetKeyName(20, "lounge-2.jpg");
            imageList1.Images.SetKeyName(21, "plan-1.jpg");
            imageList1.Images.SetKeyName(22, "plan-2.jpg");
            imageList1.Images.SetKeyName(23, "plan-3.jpg");
            imageList1.Images.SetKeyName(24, "traveller-1.jpg");
            imageList1.Images.SetKeyName(25, "traveller-2.jpg");
            imageList1.Images.SetKeyName(26, "traveller-3.jpg");
            imageList1.Images.SetKeyName(27, "traveller-4.jpg");
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(221, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 355);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(509, 376);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(221, 376);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "prev";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 376);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 4;
            label2.Text = "image index ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 409);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "number";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}