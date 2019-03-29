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
    public partial class deleteDepartment : Form
    {
        string conString;
        OracleConnection conn;
        public deleteDepartment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (textBox7.Text != "")
            {
                cmd.CommandText = "update student set department = '' where department = "+textBox7.Text+"";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                label2.Hide();
                cmd.CommandText = "update course set offered_by = '' where offered_by = " + textBox7.Text + "";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                label2.Hide();
                cmd.CommandText = "delete department where dept_id = " + textBox7.Text + "";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                label2.Show();
            }
        }

        private void deleteDepartment_Load(object sender, EventArgs e)
        {
            conString = "Data Source=localhost;User Id=system;Password=harish988";
            conn = new OracleConnection(conString);
            label2.Hide();
            conn.Open();
        }
    }
}
