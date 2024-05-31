namespace WinFormsApp1
{
    partial class Delete
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
            textBox1 = new TextBox();
            button6 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 148);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Delete Form";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 222);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(373, 219);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 4;
            // 
            // button6
            // 
            button6.Location = new Point(406, 260);
            button6.Name = "button6";
            button6.Size = new Size(59, 23);
            button6.TabIndex = 5;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 450);
            Controls.Add(button6);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Delete";
            Text = "Delete";
            Load += Delete_Load;
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(button6, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button6;
    }
}