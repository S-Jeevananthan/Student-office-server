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
    public partial class viewStudent : Form
    {
        string conString;
        OracleConnection conn;
        public viewStudent()
        {
            InitializeComponent();
        }

        private void viewStudent_Load(object sender, EventArgs e)
        {
            conString = "Data Source=localhost;User Id=system;Password=harish988";
            conn = new OracleConnection(conString);
            label3.Hide();
            label19.Hide();
            label18.Hide();
            label15.Hide();
            label9.Hide();
            label8.Hide();
            label14.Hide();
            label13.Hide();
            label12.Hide();
            label17.Hide();
            label16.Hide();
            label7.Hide();
            conn.Open();
        }

        private void label16_Click(object sender, EventArgs e)
        {

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
            cmd.CommandText = "select name from student where student_id ='" + textBox1.Text + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            label15.Text = dr.GetString(0);
            cmd.CommandText = "select degree from student where student_id ='" + textBox1.Text + "'";
            dr = cmd.ExecuteReader();
            dr.Read();
            label9.Text = dr.GetString(0);
            cmd.CommandText = "select department from student where student_id ='"+textBox1.Text + "'";
            dr = cmd.ExecuteReader();
            dr.Read();
            label8.Text = dr.GetInt32(0).ToString();
            cmd.CommandText = "select gender from student where student_id ='" + textBox1.Text + "'";
            dr = cmd.ExecuteReader();
            dr.Read();
            label14.Text = dr.GetString(0);
            cmd.CommandText = "select DOB from student where student_id ='" +textBox1.Text + "'";
            dr = cmd.ExecuteReader();
            dr.Read();
            label13.Text = dr.GetString(0);
            cmd.CommandText = "select address from student where student_id ='" + textBox1.Text + "'";
            dr = cmd.ExecuteReader();
            dr.Read();
            label12.Text = dr.GetString(0);
            label3.Show();
            label19.Show();
            label18.Show();
            label15.Show();
            label9.Show();
            label8.Show();
            label14.Show();
            label13.Show();
            label12.Show();
            label17.Show();
            label16.Show();
            label7.Show();
            textBox1.Text = " ";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
