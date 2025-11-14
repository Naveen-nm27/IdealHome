namespace IdealHome
{
    partial class SellerDashboard
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button9 = new Button();
            button8 = new Button();
            button2 = new Button();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 11);
            button1.Name = "button1";
            button1.Size = new Size(187, 47);
            button1.TabIndex = 3;
            button1.Text = "Add New Property";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(779, 392);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Properties";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(18, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(755, 113);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "House 1";
            // 
            // button9
            // 
            button9.Location = new Point(111, 79);
            button9.Name = "button9";
            button9.Size = new Size(90, 26);
            button9.TabIndex = 10;
            button9.Text = "Remove";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(15, 79);
            button8.Name = "button8";
            button8.Size = new Size(90, 26);
            button8.TabIndex = 9;
            button8.Text = "Edit";
            button8.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(537, 14);
            button2.Name = "button2";
            button2.Size = new Size(90, 42);
            button2.TabIndex = 7;
            button2.Text = "Details";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(360, 26);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 6;
            label8.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 54);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Owner";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Address";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(640, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 95);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SellerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "SellerDashboard";
            Text = "SellerDashboard";
            Load += this.SellerDashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button9;
        private Button button8;
        private Button button2;
        private Label label8;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}