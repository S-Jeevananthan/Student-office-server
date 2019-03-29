using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace officeServer_master
{
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void delete_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteStudent ds = new deleteStudent();
            ds.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteDepartment dd = new deleteDepartment();
            dd.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteCourse dc = new deleteCourse();
            dc.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
