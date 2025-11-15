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
            button8 = new Button();
            button1 = new Button();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(0, 192, 192);
            button8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button8.Location = new Point(399, 99);
            button8.Name = "button8";
            button8.Size = new Size(675, 72);
            button8.TabIndex = 11;
            button8.Text = "Student";
            button8.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button1.Location = new Point(399, 333);
            button1.Name = "button1";
            button1.Size = new Size(675, 72);
            button1.TabIndex = 9;
            button1.Text = "Become a Seller";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 21);
            label2.Name = "label2";
            label2.Size = new Size(193, 47);
            label2.TabIndex = 10;
            label2.Text = "idealhome";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 192, 192);
            button5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button5.Location = new Point(399, 177);
            button5.Name = "button5";
            button5.Size = new Size(675, 72);
            button5.TabIndex = 12;
            button5.Text = "Sign In";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 192, 192);
            button6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button6.Location = new Point(399, 255);
            button6.Name = "button6";
            button6.Size = new Size(675, 72);
            button6.TabIndex = 13;
            button6.Text = "Sign Up";
            button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 68);
            label1.Name = "label1";
            label1.Size = new Size(349, 25);
            label1.TabIndex = 14;
            label1.Text = "Your ideal home is just a tap away....";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = IdealHome.Properties.Resources.back1;
            pictureBox1.Location = new Point(12, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 306);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // IdealHome
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1093, 420);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button8);
            Name = "IdealHome";
            Text = "IdealHome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button8;
        private Button button1;
        private Label label2;
        private Button button5;
        private Button button6;
        private Label label1;
        private PictureBox pictureBox1;
    }
}