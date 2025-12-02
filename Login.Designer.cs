namespace IdealHome
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            button8 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 50);
            label1.Name = "label1";
            label1.Size = new Size(349, 25);
            label1.TabIndex = 16;
            label1.Text = "Your ideal home is just a tap away....";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 3);
            label2.Name = "label2";
            label2.Size = new Size(193, 47);
            label2.TabIndex = 15;
            label2.Text = "idealhome";
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(0, 192, 192);
            button8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button8.Location = new Point(254, 214);
            button8.Name = "button8";
            button8.Size = new Size(210, 60);
            button8.TabIndex = 17;
            button8.Text = "Login";
            button8.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button1.Location = new Point(24, 214);
            button1.Name = "button1";
            button1.Size = new Size(210, 60);
            button1.TabIndex = 18;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold);
            textBox1.Location = new Point(24, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(440, 31);
            textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold);
            textBox2.Location = new Point(24, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(440, 31);
            textBox2.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 82);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 23;
            label5.Text = "User Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 141);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 24;
            label6.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(496, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(585, 262);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(9, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(111, 68);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 43;
            pictureBox4.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1093, 292);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button8);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button8;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
    }
}
