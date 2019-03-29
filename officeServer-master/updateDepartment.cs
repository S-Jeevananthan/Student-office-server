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
    public partial class updateDepartment : Form
    {
        string conString;
        OracleConnection conn;
        public updateDepartment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateDepartment_Load(object sender, EventArgs e)
        {
            conString = "Data Source=localhost;User Id=system;Password=harish988";
            conn = new OracleConnection(conString);
            label2.Hide();
            conn.Open();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (textBox2.Text != "")
            {
                if (textBox1.Text != "")
                {
                    cmd.CommandText = "update department set name = '" + textBox1.Text + "' where dept_id = " + textBox2.Text + "";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    label2.Show();
                }
                if (textBox4.Text != "")
                {
                    cmd.CommandText = "update department set office_no = " + textBox4.Text + " where dept_id = " + textBox2.Text + "";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    label2.Show();
                }
                if (textBox3.Text != "")
                {
                    cmd.CommandText = "update department set hod_name = '" + textBox3.Text + "' where dept_id = " + textBox2.Text + "";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    label2.Show();
                }
            }
            conn.Dispose();
        }
    }
}
