namespace WinFormsApp11
{
    partial class In_Body
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(In_Body));
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(129, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 34);
            comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(370, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(129, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 33);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(370, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 33);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 108);
            label1.Name = "label1";
            label1.Size = new Size(169, 26);
            label1.TabIndex = 4;
            label1.Text = "enter your gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(357, 108);
            label2.Name = "label2";
            label2.Size = new Size(139, 26);
            label2.TabIndex = 5;
            label2.Text = "enter your age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 181);
            label3.Name = "label3";
            label3.Size = new Size(168, 26);
            label3.TabIndex = 6;
            label3.Text = "enter your weight";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(364, 181);
            label4.Name = "label4";
            label4.Size = new Size(163, 26);
            label4.TabIndex = 7;
            label4.Text = "enter your height";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(129, 389);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 33);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(368, 389);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 33);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(129, 455);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 33);
            textBox6.TabIndex = 10;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(357, 455);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(126, 33);
            textBox7.TabIndex = 11;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(238, 281);
            button1.Name = "button1";
            button1.Size = new Size(121, 66);
            button1.TabIndex = 12;
            button1.Text = "Check your body";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(-1, -1);
            button2.Name = "button2";
            button2.Size = new Size(77, 25);
            button2.TabIndex = 13;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(113, 360);
            label5.Name = "label5";
            label5.Size = new Size(140, 26);
            label5.TabIndex = 14;
            label5.Text = "Fat percantage";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(341, 360);
            label6.Name = "label6";
            label6.Size = new Size(155, 26);
            label6.TabIndex = 15;
            label6.Text = "water percantge";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(113, 437);
            label7.Name = "label7";
            label7.Size = new Size(212, 26);
            label7.TabIndex = 16;
            label7.Text = "Body mass index (BMI)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(347, 437);
            label8.Name = "label8";
            label8.Size = new Size(250, 26);
            label8.TabIndex = 17;
            label8.Text = "Basal Metabolic Rate(BMR)";
            // 
            // In_Body
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1017, 563);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "In_Body";
            Text = "In_Body";
            WindowState = FormWindowState.Maximized;
            Load += In_Body_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}