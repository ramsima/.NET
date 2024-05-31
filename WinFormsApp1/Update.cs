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

namespace WinFormsApp1
{
    public partial class Update : child1
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
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


            MessageBox.Show("Update Successful!");
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=hello;Database=postgres");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "UPDATE \"test\" SET \"stu_name\" = @name, \"stu_age\" = @age, \"stu_gender\" = @gender, \"stu_province\" = @province, \"stu_district\" = @district, \"stu_skills\" = @skills WHERE \"stu_name\" = @name";
            comm.Parameters.AddWithValue("@name", textBox1.Text);
            comm.Parameters.AddWithValue("@age", (int)numericUpDown1.Value);
            comm.Parameters.AddWithValue("@gender", radioButton1.Checked ? "Male" : "Female");
            comm.Parameters.AddWithValue("@province", comboBox1.SelectedItem.ToString());
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


        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Validate name
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter your name.");
                textBox1.Focus();
                return;
            }




            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=hello;Database=postgres");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM \"test\" WHERE (stu_name = @name)";
            comm.Parameters.AddWithValue("@name", textBox1.Text);
            //comm.Parameters.AddWithValue("@age", (int)numericUpDown1.Value);
            //comm.Parameters.AddWithValue("@gender", radioButton1.Checked ? "Male" : "Female");
            //comm.Parameters.AddWithValue("@province", comboBox1.SelectedItem.ToString());
            //comm.Parameters.AddWithValue("@district", comboBox2.SelectedItem.ToString());

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

            //Read from database
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["stu_name"].ToString();
                numericUpDown1.Value = Convert.ToInt32(dr["stu_age"]);
                if (dr["stu_gender"].ToString() == "Male")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                comboBox1.SelectedItem = dr["stu_province"].ToString();
                comboBox2.SelectedItem = dr["stu_district"].ToString();

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
                // Check the skills
                string[] skillss = dr["stu_skills"].ToString().Split(new[] { ", " }, StringSplitOptions.None);
                foreach (string skill in skillss)
                {
                    int index = checkedListBox1.Items.IndexOf(skill);
                    if (index != -1)
                    {
                        checkedListBox1.SetItemChecked(index, true);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Name.");

            }

            //comm.ExecuteNonQuery();


        }
    }
}
