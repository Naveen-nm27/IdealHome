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
            button8 = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem2 = new ToolStripMenuItem();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(7, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(62, 439);
            panel1.TabIndex = 7;
            // 
            // button8
            // 
            button8.Location = new Point(145, 12);
            button8.Name = "button8";
            button8.Size = new Size(148, 46);
            button8.TabIndex = 11;
            button8.Text = "Student";
            button8.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(108, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1051, 439);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(299, 12);
            button1.Name = "button1";
            button1.Size = new Size(148, 46);
            button1.TabIndex = 9;
            button1.Text = "Become a Seller";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 122);
            label1.Name = "label1";
            label1.Size = new Size(297, 25);
            label1.TabIndex = 0;
            label1.Text = "Your ideal home is just a tap away";
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            menuStrip2.Location = new Point(964, 9);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(49, 40);
            menuStrip2.TabIndex = 9;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(41, 36);
            toolStripMenuItem2.Text = "A";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 24);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 10;
            label2.Text = "idealhome logo";
            // 
            // button5
            // 
            button5.Location = new Point(467, 12);
            button5.Name = "button5";
            button5.Size = new Size(148, 46);
            button5.TabIndex = 12;
            button5.Text = "Sign In";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(636, 12);
            button6.Name = "button6";
            button6.Size = new Size(148, 46);
            button6.TabIndex = 13;
            button6.Text = "Sign Up";
            button6.UseVisualStyleBackColor = true;
            // 
            // IdealHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 558);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(menuStrip2);
            Controls.Add(button8);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "IdealHome";
            Text = "IdealHome";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button8;
        private GroupBox groupBox1;
        private Button button1;
        private Label label1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem2;
        private Label label2;
        private Button button5;
        private Button button6;
    }
}