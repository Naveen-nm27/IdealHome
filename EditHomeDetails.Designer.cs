namespace IdealHome
{
    partial class EditHomeDetails
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            txt_title = new TextBox();
            label11 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(0, 192, 192);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txt_title);
            groupBox2.Controls.Add(label11);
            groupBox2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(11, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1069, 507);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "House Info";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1057, 410);
            dataGridView1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(635, 45);
            button1.Name = "button1";
            button1.Size = new Size(428, 27);
            button1.TabIndex = 39;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_title
            // 
            txt_title.Location = new Point(83, 45);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(537, 27);
            txt_title.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 48);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 30;
            label11.Text = "Titles";
            // 
            // EditHomeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 990);
            Controls.Add(groupBox2);
            Name = "EditHomeDetails";
            Text = "EditHomeDetails";
            Load += EditHomeDetails_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txt_title;
        private Label label11;
        private DataGridView dataGridView1;
        private Button button1;
    }
}