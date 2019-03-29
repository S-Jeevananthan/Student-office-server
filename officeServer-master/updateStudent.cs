using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace officeServer_master
{
    public partial class updateStudent : Form
    {
        string conString;
        OracleConnection conn;
        public updateStudent()
        {
            InitializeComponent();
        }

        private void updateStudent_Load(object sender, EventArgs e)
        {
            conString = "Data Source=localhost;User Id=system;Password=harish988";
            conn = new OracleConnection(conString);
            label2.Hide();
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (textBox7.Text != "")
            {
                if (textBox1.Text != "")
                {
                    cmd.CommandText = "update student set name = '" + textBox1.Text + "' where student_id = '" + textBox7.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    label2.Show();
                }
                if (comboBox1.Text != "")
                {
                    cmd.CommandText = "update student set degree = '" + comboBox1.Text + "' where student_id = '" + textBox7.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    label2.Show();
                }
                if (comboBox2.Text != "")
                {
                    cmd.CommandText = "update student set gender = '" + comboBox2.Text + "' where student_id = '" + textBox7.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    label2.Show();
                }
                if (textBox4.Text != "")
                {
                    cmd.CommandText = "update student set department = " + textBox4.Text + " where student_id = '" + textBox7.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    label2.Show();
                }
                if (textBox3.Text != "")
                {
                    cmd.CommandText = "update student set DOB = '" + textBox3.Text + "' where student_id = '" + textBox7.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    label2.Show();
                }
                if (textBox2.Text != "")
                {
                    cmd.CommandText = "update student set address = '" + textBox2.Text + "' where student_id = '" + textBox7.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    label2.Show();
                }
            }
        }
    }
}
