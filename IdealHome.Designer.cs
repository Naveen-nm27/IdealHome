namespace IdealHome
{
    partial class IdealHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdealHome));
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button7 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 192, 192);
            button5.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold);
            button5.Location = new Point(12, 164);
            button5.Name = "button5";
            button5.Size = new Size(518, 63);
            button5.TabIndex = 12;
            button5.Text = "Log in";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 192, 192);
            button6.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold);
            button6.Location = new Point(12, 95);
            button6.Name = "button6";
            button6.Size = new Size(518, 63);
            button6.TabIndex = 13;
            button6.Text = "Sign Up";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(1004, 29);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(43, 43);
            button3.TabIndex = 17;
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(349, 25);
            label2.TabIndex = 25;
            label2.Text = "Your ideal home is just a tap away....";
            label2.MouseClick += Logo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(12, 0);
            label3.Name = "label3";
            label3.Size = new Size(193, 47);
            label3.TabIndex = 24;
            label3.Text = "idealhome";
            label3.Click += label3_Click;
            label3.MouseClick += Logo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1094, 659);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(922, 32);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(35, 36);
            button4.TabIndex = 28;
            button4.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.Transparent;
            button7.Location = new Point(963, 32);
            button7.Name = "button7";
            button7.RightToLeft = RightToLeft.No;
            button7.Size = new Size(35, 36);
            button7.TabIndex = 29;
            button7.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Transparent;
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Cursor = Cursors.Hand;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.Transparent;
            button9.Location = new Point(1053, 29);
            button9.Name = "button9";
            button9.RightToLeft = RightToLeft.No;
            button9.Size = new Size(40, 43);
            button9.TabIndex = 31;
            button9.UseVisualStyleBackColor = false;
            // 
            // IdealHome
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1098, 749);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Name = "IdealHome";
            RightToLeft = RightToLeft.No;
            Text = "IdealHome";
            Load += IdealHome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button5;
        private Button button6;
        private Button button3;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button7;
        private Button button9;

        public static object Properties { get; private set; }
    }
}