namespace IdealHome
{
    partial class Form1
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
            panel1 = new Panel();
            panel2 = new Panel();
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            button8 = new Button();
            groupBox1 = new GroupBox();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(112, 519);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources._634158c5fb352d2d7f76b1816a5ef6b3;
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button6);
            panel2.Location = new Point(287, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(956, 77);
            panel2.TabIndex = 1;
            // 
            // button6
            // 
            button6.Location = new Point(757, 18);
            button6.Name = "button6";
            button6.Size = new Size(148, 46);
            button6.TabIndex = 7;
            button6.Text = "Exit App";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(557, 183);
            button2.Name = "button2";
            button2.Size = new Size(110, 138);
            button2.TabIndex = 3;
            button2.Text = "Find Rental House";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(255, 183);
            button1.Name = "button1";
            button1.Size = new Size(110, 138);
            button1.TabIndex = 2;
            button1.Text = "  Buy a House";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 44);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(628, 192);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // button3
            // 
            button3.Location = new Point(374, 19);
            button3.Name = "button3";
            button3.Size = new Size(148, 46);
            button3.TabIndex = 8;
            button3.Text = "Become a Seller";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(199, 19);
            button4.Name = "button4";
            button4.Size = new Size(148, 46);
            button4.TabIndex = 9;
            button4.Text = "Sign In";
            button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(573, 19);
            button7.Name = "button7";
            button7.Size = new Size(148, 46);
            button7.TabIndex = 10;
            button7.Text = "Contact";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(23, 18);
            button8.Name = "button8";
            button8.Size = new Size(148, 46);
            button8.TabIndex = 11;
            button8.Text = "Sign Up";
            button8.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(142, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1101, 519);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 647);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button6;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button8;
        private Button button7;
        private Button button4;
        private Button button3;
        private GroupBox groupBox1;
    }
}