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
    public partial class viewDepartment : Form
    {
        string conString;
        OracleConnection conn;
        public viewDepartment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void viewDepartment_Load(object sender, EventArgs e)
        {
            conString = "Data Source=localhost;User Id=system;Password=harish988";
            conn = new OracleConnection(conString);
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            conn.Open();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select dept_id from department where name ='" + comboBox1.Text + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            label5.Text = dr.GetInt32(0).ToString();
            cmd.CommandText = "select office_no from department where name ='" + comboBox1.Text + "'";
            dr = cmd.ExecuteReader();
            dr.Read();
            label4.Text = dr.GetInt32(0).ToString();
            cmd.CommandText = "select hod_name from department where name ='" + comboBox1.Text + "'";
            dr = cmd.ExecuteReader();
            dr.Read();
            label3.Text = dr.GetString(0);
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }
        public void AddDept(String name)
        {
            comboBox1.Items.Add(item: name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
