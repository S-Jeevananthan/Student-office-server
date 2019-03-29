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
    public partial class updateCourse : Form
    {
        string conString;
        OracleConnection conn;
        public updateCourse()
        {
            InitializeComponent();
        }

        private void updateCourse_Load(object sender, EventArgs e)
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
            if (textBox2.Text != "")
            {
                if (textBox1.Text != "")
                {
                    cmd.CommandText = "update course set course_name = '" + textBox1.Text + "' where course_code = '" + textBox2.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    label2.Show();
                }
                if (textBox3.Text != "")
                {
                    cmd.CommandText = "update course set offered_by = '" + textBox3.Text + "' where course_code = '" + textBox2.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    label2.Show();
                }
                if (textBox4.Text != "")
                {
                    cmd.CommandText = "update course set credits = '" + textBox4.Text + "' where course_code = '" + textBox2.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    label2.Show();
                }
            }
        }
    }
}