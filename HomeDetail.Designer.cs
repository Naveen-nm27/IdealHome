namespace IdealHome
{
    partial class HomeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeDetail));
            groupBox2 = new GroupBox();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            button5 = new Button();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(0, 192, 192);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(8, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1069, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold);
            label9.Location = new Point(15, 174);
            label9.Name = "label9";
            label9.Size = new Size(92, 20);
            label9.TabIndex = 9;
            label9.Text = "Buy/Rent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(15, 136);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 9;
            label4.Text = "Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(15, 101);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 8;
            label3.Text = "Rooms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(15, 66);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Owner";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(732, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(331, 334);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // button5
            // 
            button5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(15, 363);
            button5.Name = "button5";
            button5.Size = new Size(1054, 48);
            button5.TabIndex = 3;
            button5.Text = "Add To List";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Address";
            label1.Click += label1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(8, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(111, 68);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(125, 53);
            label5.Name = "label5";
            label5.Size = new Size(349, 25);
            label5.TabIndex = 45;
            label5.Text = "Your ideal home is just a tap away....";
            label5.MouseClick += logo_click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(122, 6);
            label6.Name = "label6";
            label6.Size = new Size(193, 47);
            label6.TabIndex = 44;
            label6.Text = "idealhome";
            label6.MouseClick += logo_click;
            // 
            // HomeDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 516);
            Controls.Add(pictureBox4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Name = "HomeDetail";
            Text = "HomeDetail";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private PictureBox pictureBox3;
        private Button button5;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label9;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label6;
    }
}