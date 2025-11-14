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
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button8 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(7, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(87, 498);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(203, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(956, 87);
            panel2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(563, 20);
            button2.Name = "button2";
            button2.Size = new Size(130, 52);
            button2.TabIndex = 13;
            button2.Text = "Orders";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(205, 20);
            button3.Name = "button3";
            button3.Size = new Size(148, 52);
            button3.TabIndex = 12;
            button3.Text = "Messages";
            button3.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(23, 20);
            button8.Name = "button8";
            button8.Size = new Size(148, 52);
            button8.TabIndex = 11;
            button8.Text = "Notification";
            button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(405, 20);
            button4.Name = "button4";
            button4.Size = new Size(130, 52);
            button4.TabIndex = 9;
            button4.Text = "Orders";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(108, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1051, 498);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(390, 155);
            button1.Name = "button1";
            button1.Size = new Size(148, 52);
            button1.TabIndex = 9;
            button1.Text = "Become a Seller";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(446, 135);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // IdealHome
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 632);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Name = "IdealHome";
            Text = "IdealHome";
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button button8;
        private Button button4;
        private GroupBox groupBox1;
        private Button button1;
        private Label label1;
    }
}