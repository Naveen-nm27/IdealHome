namespace IdealHome
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(128, 78);
            button1.TabIndex = 0;
            button1.Text = "For Rent";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(162, 12);
            button2.Name = "button2";
            button2.Size = new Size(128, 78);
            button2.TabIndex = 1;
            button2.Text = "For Purchase";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 18);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);
            label1.TabIndex = 2;
            label1.Text = "Location";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(395, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 25);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(395, 65);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(199, 25);
            comboBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 71);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 4;
            label2.Text = "Location";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSalmon;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1074, 381);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.PaleGoldenrod;
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(6, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1062, 142);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Gold;
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(167, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(886, 102);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 31);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 7;
            label3.Text = "Details";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1098, 500);
            Controls.Add(groupBox1);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainPage";
            Text = "MainPage";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private PictureBox pictureBox1;
    }
}