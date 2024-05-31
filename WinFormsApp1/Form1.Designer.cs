namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 34.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(494, 157);
            label1.Name = "label1";
            label1.Size = new Size(386, 96);
            label1.TabIndex = 0;
            label1.Text = "Simple Calculator";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 15.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(378, 298);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 1;
            label2.Text = "Number:";
            label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 15.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(378, 337);
            label3.Name = "label3";
            label3.Size = new Size(94, 30);
            label3.TabIndex = 2;
            label3.Text = "Number:";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(478, 303);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 25);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.AllowDrop = true;
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Location = new Point(478, 344);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 15.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(378, 383);
            label4.Name = "label4";
            label4.Size = new Size(75, 30);
            label4.TabIndex = 6;
            label4.Text = "Result:";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.AllowDrop = true;
            textBox3.BackColor = SystemColors.Menu;
            textBox3.Location = new Point(478, 390);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 23);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.FlatAppearance.BorderColor = Color.RosyBrown;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(732, 268);
            button2.Name = "button2";
            button2.Size = new Size(130, 33);
            button2.TabIndex = 8;
            button2.Text = "Addition";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.FlatAppearance.BorderColor = Color.RosyBrown;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Yu Gothic UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(872, 268);
            button3.Name = "button3";
            button3.Size = new Size(130, 33);
            button3.TabIndex = 9;
            button3.Text = "Subtraction";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.FlatAppearance.BorderColor = Color.RosyBrown;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Yu Gothic UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(732, 322);
            button4.Name = "button4";
            button4.Size = new Size(130, 33);
            button4.TabIndex = 10;
            button4.Text = "Multiplication";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 128);
            button5.FlatAppearance.BorderColor = Color.RosyBrown;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Yu Gothic UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(872, 322);
            button5.Name = "button5";
            button5.Size = new Size(130, 33);
            button5.TabIndex = 11;
            button5.Text = "Division";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 128, 128);
            button6.FlatAppearance.BorderColor = Color.RosyBrown;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Yu Gothic UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(802, 380);
            button6.Name = "button6";
            button6.Size = new Size(130, 33);
            button6.TabIndex = 12;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1000, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += this.Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
