namespace IdealHome
{
    partial class AddHome
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
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(774, 211);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "House Info";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(79, 147);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(46, 21);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Sell";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(10, 147);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 21);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Rent";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(144, 106);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(267, 25);
            numericUpDown1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 108);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 17;
            label1.Text = "Number Of Rooms";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(144, 60);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(267, 25);
            textBox6.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 68);
            label10.Name = "label10";
            label10.Size = new Size(104, 17);
            label10.TabIndex = 11;
            label10.Text = "Google Location";
            // 
            // AddHome
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Name = "AddHome";
            Text = "AddHome";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private TextBox textBox6;
        private Label label10;
    }
}