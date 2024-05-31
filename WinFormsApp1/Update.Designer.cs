namespace WinFormsApp1
{
    partial class Update
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 119);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Update Form";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 190);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(293, 226);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(293, 260);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 5;
            label6.Text = "Province:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(293, 295);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 6;
            label7.Text = "District:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(293, 329);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 7;
            label8.Text = "Gender:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(293, 360);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 8;
            label9.Text = "Skill:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(367, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(367, 222);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(39, 23);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Province 1", "Madhesh Pradesh", "Bagmati Province", "Gandaki", "Lumbini", "Karnali", "Sudurpaschim" });
            comboBox1.Location = new Point(367, 257);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Taplejung", "Terhrathum", "Panchthar\tFidim\t", "Sankhuwasabha\t", "Solukhumbu\t", "Bhojpur", "Khotang\t", "Ilam\t", "Udayapur\tGaighat\t", "Okhaldhunga\t", "Jhapa\t", "Dhankuta\t", "Morang\t", "Sunsari", "Parsa", "Bara", "Rautahat", "Sarlahi", "Mahottari", "Dhanusha", "Siraha", "Saptari", "Kathmandu", "Lalitpur", "Bhaktapur", "Kavre", "Sindhupalchowk", "Dolakha", "Dhading", "Nuwakot", "Makwanpur", "Rasuwa", "Ramechhap", "Chitwan", "Sindhuli", "Kaski", "Gorkha", "Nawalparasi", "Parbhat", "Tanahu", "Baglung", "Myagdi", "Lamjung", "Syangja", "Manang", "Mustang", "Parasi", "Dang", "Gulmi", "Kapilvastu", "Arghakharchi", "Palpa", "Rukum East", "Pyuthan", "Banke", "Bardiya", "Rupandehi", "Rolpa", "Rukum West", "Mugu", "Dailekh", "Dolpa", "Jumla", "Jajarkot", "Kalikot", "Salyan", "Surkhet", "Humla", "Kailali", "Kanchanpur", "Achham", "Dadeldhura", "Doti", "Darchula", "Bajhang", "Bajura", "Baitadi" });
            comboBox2.Location = new Point(367, 292);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 12;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(367, 331);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(424, 331);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(493, 331);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 19);
            radioButton3.TabIndex = 15;
            radioButton3.TabStop = true;
            radioButton3.Text = "Others";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { ".NET", "Java", "RUST" });
            checkedListBox1.Location = new Point(367, 356);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(63, 58);
            checkedListBox1.TabIndex = 16;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.Location = new Point(438, 415);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 17;
            button6.Text = "Update";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(583, 190);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 18;
            button7.Text = "SEARCH";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(checkedListBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Update";
            Text = "Update";
            Load += Update_Load;
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(numericUpDown1, 0);
            Controls.SetChildIndex(comboBox1, 0);
            Controls.SetChildIndex(comboBox2, 0);
            Controls.SetChildIndex(radioButton1, 0);
            Controls.SetChildIndex(radioButton2, 0);
            Controls.SetChildIndex(radioButton3, 0);
            Controls.SetChildIndex(checkedListBox1, 0);
            Controls.SetChildIndex(button6, 0);
            Controls.SetChildIndex(button7, 0);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private CheckedListBox checkedListBox1;
        private Button button6;
        private Button button7;
    }
}