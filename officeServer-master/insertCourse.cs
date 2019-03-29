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
    public partial class insertCourse : Form
    {
        string conString;
        OracleConnection conn;
        public insertCourse()
        {
            InitializeComponent();
        }

        private void insertCourse_Load(object sender, EventArgs e)
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
            cmd.CommandText = "insert into course(course_code,course_name,credits,offered_by) values('" + textBox2.Text + "','" + textBox1.Text + "'," + textBox4.Text + "," + textBox3.Text + ")";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            label2.Show();
        }
    }
}
