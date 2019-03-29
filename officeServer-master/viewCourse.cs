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
    public partial class viewCourse : Form
    {
        string conString;
        OracleConnection conn;
        public viewCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewCourse_Load(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            conString = "Data Source=localhost;User Id=system;Password=harish988";
            conn = new OracleConnection(conString);
            conn.Open();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select course_name from course where course_code ='" + textBox1.Text + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            label5.Text = dr.GetString(0);
            cmd.CommandText = "select credits from course where course_code ='" + textBox1.Text + "'";
            dr = cmd.ExecuteReader();
            dr.Read();
            label4.Text = dr.GetInt32(0).ToString();
            cmd.CommandText = "select offered_by from course where course_code ='" + textBox1.Text + "'";
            dr = cmd.ExecuteReader();
            dr.Read();
            label3.Text = dr.GetInt32(0).ToString();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            dr.Close();
        }
    }
}
