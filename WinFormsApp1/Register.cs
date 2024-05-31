using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Register : child1
    {
        public Register()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate name
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter your name.");
                textBox1.Focus();
                return;
            }

            // Validate age
            if (numericUpDown1.Value < 15 || numericUpDown1.Value > 81)
            {
                MessageBox.Show("Please enter a valid age.");
                numericUpDown1.Focus();
                return;
            }

            // Validate province
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a province.");
                comboBox1.Focus();
                return;
            }
            // Validate district
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a district.");
                comboBox2.Focus();
                return;
            }
            // Validate skills
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a skill.");
                checkedListBox1.Focus();
                return;
            }


            MessageBox.Show("Registration Successful!");

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=hello;Database=postgres");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "INSERT INTO \"test\" (stu_name, stu_age, stu_province, stu_district,stu_gender, stu_skills) VALUES(@name, @age,@province, @district,@gender, @skills)";
            comm.Parameters.AddWithValue("@name", textBox1.Text);
            comm.Parameters.AddWithValue("@age",(int)numericUpDown1.Value);
            comm.Parameters.AddWithValue("@gender",radioButton1.Checked ? "Male" : "Female");
            comm.Parameters.AddWithValue("@province",comboBox1.SelectedItem.ToString());
            comm.Parameters.AddWithValue("@district", comboBox2.SelectedItem.ToString());

            StringBuilder skills = new StringBuilder();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                skills.Append(item.ToString() + ", ");
            }
            if (skills.Length > 0)
            {
                skills.Length -= 2;
            }

            comm.Parameters.AddWithValue("@skills", skills.ToString());
            comm.ExecuteNonQuery();

            textBox1.Clear();
            numericUpDown1.Value = numericUpDown1.Minimum;
            comboBox1.SelectedIndex = -1;
            comboBox2.Items.Clear();
            checkedListBox1.ClearSelected();
            // Clear all checked items in the CheckedListBox
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null)
            {
                comboBox2.Items.Clear();
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Province 1":
                        comboBox2.Items.AddRange(new string[] {
                    "Bhojpur", "Dhankuta", "Ilam", "Jhapa", "Khotang", "Morang", "Okhaldhunga", "Panchthar", "Sankhuwasabha",
                    "Solukhumbu", "Sunsari", "Taplejung", "Terhathum", "Udayapur"
                });
                        break;




                    case "Madhesh Pradesh":
                        comboBox2.Items.AddRange(new string[] {
                    "Bara", "Dhanusha", "Mahottari", "Parsa", "Rautahat", "Saptari", "Sarlahi", "Siraha"
                });
                        break;

                    case "Bagmati Province":
                        comboBox2.Items.AddRange(new string[] {
                    "Bhaktapur", "Chitwan", "Dhading", "Dolakha", "Kathmandu", "Kavrepalanchok", "Lalitpur", "Makwanpur",
                    "Nuwakot", "Ramechhap", "Rasuwa", "Sindhuli", "Sindhupalchok"
                });
                        break;

                    case "Gandaki":
                        comboBox2.Items.AddRange(new string[] {
                    "Baglung", "Gorkha", "Kaski", "Lamjung", "Manang", "Mustang", "Myagdi", "Nawalpur", "Parbat",
                    "Syangja", "Tanahun"
                });
                        break;

                    case "Lumbini":
                        comboBox2.Items.AddRange(new string[] {
                    "Arghakhanchi", "Banke", "Bardiya", "Dang", "Gulmi", "Kapilvastu", "Parasi", "Palpa", "Pyuthan",
                    "Rolpa", "Rupandehi"
                });
                        break;


                    case "Karnali":
                        comboBox2.Items.AddRange(new string[] {
                    "Dailekh", "Dolpa", "Humla", "Jajarkot", "Jumla", "Kalikot", "Mugu", "Rukum West", "Salyan", "Surkhet"
                });
                        break;

                    case "Sudurpashchim":
                        comboBox2.Items.AddRange(new string[] {
                    "Achham", "Baitadi", "Bajhang", "Bajura", "Dadeldhura", "Darchula", "Doti", "Kailali", "Kanchanpur"
                });
                        break;
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
