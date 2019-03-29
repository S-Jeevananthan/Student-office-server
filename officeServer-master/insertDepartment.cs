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
    public partial class insertDepartment : Form
    {
        string conString;
        OracleConnection conn;
        public insertDepartment()
        {
            InitializeComponent();
        }

        private void insertDepartment_Load(object sender, EventArgs e)
        {
            conString = "Data Source=localhost;User Id=system;Password=harish988";
            conn = new OracleConnection(conString);
            label2.Hide();
            conn.Open();
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
            cmd.CommandText = "insert into department(dept_id,name,hod_name,office_no) values(" + textBox2.Text + ",'" + textBox1.Text + "','" + textBox3.Text + "'," + textBox4.Text +")";
            cmd.CommandType = CommandType.Text;
            viewDepartment f = new viewDepartment();
            String a = textBox1.Text;
            f.comboBox1.Items.Add(item: a);
            f.AddDept(a);
            cmd.ExecuteNonQuery();
            label2.Show();
        }
    }
}
