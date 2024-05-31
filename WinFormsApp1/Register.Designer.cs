namespace WinFormsApp1
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            label7 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(656, 140);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "SignUp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(550, 190);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(550, 219);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Age:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(550, 252);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Province:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(550, 281);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 4;
            label5.Text = "District:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 351);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Skills:";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(656, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(656, 216);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(34, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Province 1", "Madhesh Pradesh", "Bagmati Province", "Gandaki", "Lumbini", "Karnali", "Sudurpaschim" });
            comboBox1.Location = new Point(656, 249);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Taplejung", "Terhrathum", "Panchthar\tFidim\t", "Sankhuwasabha\t", "Solukhumbu\t", "Bhojpur", "Khotang\t", "Ilam\t", "Udayapur\tGaighat\t", "Okhaldhunga\t", "Jhapa\t", "Dhankuta\t", "Morang\t", "Sunsari", "Parsa", "Bara", "Rautahat", "Sarlahi", "Mahottari", "Dhanusha", "Siraha", "Saptari", "Kathmandu", "Lalitpur", "Bhaktapur", "Kavre", "Sindhupalchowk", "Dolakha", "Dhading", "Nuwakot", "Makwanpur", "Rasuwa", "Ramechhap", "Chitwan", "Sindhuli", "Kaski", "Gorkha", "Nawalparasi", "Parbhat", "Tanahu", "Baglung", "Myagdi", "Lamjung", "Syangja", "Manang", "Mustang", "Parasi", "Dang", "Gulmi", "Kapilvastu", "Arghakharchi", "Palpa", "Rukum East", "Pyuthan", "Banke", "Bardiya", "Rupandehi", "Rolpa", "Rukum West", "Mugu", "Dailekh", "Dolpa", "Jumla", "Jajarkot", "Kalikot", "Salyan", "Surkhet", "Humla", "Kailali", "Kanchanpur", "Achham", "Dadeldhura", "Doti", "Darchula", "Bajhang", "Bajura", "Baitadi" });
            comboBox2.Location = new Point(656, 278);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(681, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { ".NET", "JAVA", "RUST" });
            checkedListBox1.Location = new Point(656, 351);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 58);
            checkedListBox1.TabIndex = 13;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(550, 322);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 14;
            label7.Text = "Gender:";
            label7.Click += label7_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(657, 319);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(714, 318);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(783, 319);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 19);
            radioButton3.TabIndex = 17;
            radioButton3.TabStop = true;
            radioButton3.Text = "Others";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 450);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label7);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(numericUpDown1, 0);
            Controls.SetChildIndex(comboBox1, 0);
            Controls.SetChildIndex(comboBox2, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(checkedListBox1, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(radioButton1, 0);
            Controls.SetChildIndex(radioButton2, 0);
            Controls.SetChildIndex(radioButton3, 0);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private Label label7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}