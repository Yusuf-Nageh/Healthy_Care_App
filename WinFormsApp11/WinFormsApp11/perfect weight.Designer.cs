namespace WinFormsApp11
{
    partial class perfect_weight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perfect_weight));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rb1 = new rb();
            textBox6 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(160, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(346, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 33);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(175, 15);
            label2.Name = "label2";
            label2.Size = new Size(67, 26);
            label2.TabIndex = 3;
            label2.Text = "height";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(360, 15);
            label3.Name = "label3";
            label3.Size = new Size(72, 26);
            label3.TabIndex = 4;
            label3.Text = "weight";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(74, 308);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 33);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(259, 371);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 33);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(429, 308);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(100, 33);
            textBox5.TabIndex = 7;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 279);
            label4.Name = "label4";
            label4.Size = new Size(180, 26);
            label4.TabIndex = 8;
            label4.Text = "your body condtion";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(209, 342);
            label5.Name = "label5";
            label5.Size = new Size(198, 26);
            label5.TabIndex = 9;
            label5.Text = "range weight for you ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(418, 279);
            label6.Name = "label6";
            label6.Size = new Size(120, 26);
            label6.TabIndex = 10;
            label6.Text = "Ideal weight";
            label6.Click += label6_Click;
            // 
            // rb1
            // 
            rb1.Anchor = AnchorStyles.None;
            rb1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            rb1.Location = new Point(259, 125);
            rb1.Name = "rb1";
            rb1.Size = new Size(100, 96);
            rb1.TabIndex = 11;
            rb1.Text = "result";
            rb1.UseVisualStyleBackColor = true;
            rb1.Click += rb1_Click;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(259, 264);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(100, 33);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(192, 235);
            label7.Name = "label7";
            label7.Size = new Size(240, 26);
            label7.TabIndex = 13;
            label7.Text = "the body mass index(BMI)";
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.Location = new Point(-1, -1);
            button2.Name = "button2";
            button2.Size = new Size(44, 25);
            button2.TabIndex = 14;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // perfect_weight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 406);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(rb1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "perfect_weight";
            Text = "perfect_weight";
            WindowState = FormWindowState.Maximized;
            Load += perfect_weight_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private rb rb1;
        private TextBox textBox6;
        private Label label7;
        private Button button2;
    }
}