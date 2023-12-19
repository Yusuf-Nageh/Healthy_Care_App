namespace WinFormsApp11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rb1 = new rb();
            rb2 = new rb();
            rb3 = new rb();
            SuspendLayout();
            // 
            // rb1
            // 
            rb1.BackColor = Color.Ivory;
            rb1.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            rb1.Location = new Point(858, 45);
            rb1.Margin = new Padding(5);
            rb1.Name = "rb1";
            rb1.Size = new Size(215, 158);
            rb1.TabIndex = 3;
            rb1.Text = "In Body";
            rb1.UseVisualStyleBackColor = false;
            rb1.Click += rb1_Click;
            // 
            // rb2
            // 
            rb2.BackColor = Color.Ivory;
            rb2.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            rb2.Location = new Point(959, 222);
            rb2.Margin = new Padding(5);
            rb2.Name = "rb2";
            rb2.Size = new Size(215, 158);
            rb2.TabIndex = 4;
            rb2.Text = "perfect weight";
            rb2.UseVisualStyleBackColor = false;
            rb2.Click += rb2_Click;
            // 
            // rb3
            // 
            rb3.BackColor = Color.Ivory;
            rb3.FlatAppearance.BorderColor = Color.Black;
            rb3.FlatAppearance.BorderSize = 0;
            rb3.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            rb3.Location = new Point(1078, 406);
            rb3.Margin = new Padding(5);
            rb3.Name = "rb3";
            rb3.Size = new Size(215, 158);
            rb3.TabIndex = 5;
            rb3.Text = "Calories";
            rb3.UseVisualStyleBackColor = false;
            rb3.Click += rb3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1356, 607);
            Controls.Add(rb3);
            Controls.Add(rb2);
            Controls.Add(rb1);
            Font = new Font("Calibri Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion
        private rb rb1;
        private rb rb2;
        private rb rb3;
    }
}