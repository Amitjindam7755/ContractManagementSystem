using ContractManagementSystem.Forms;
using SLRDbConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractManagementSystem.UserControls
{
    public partial class UC_Works : UserControl
    {
        DbConnector db;
        public UC_Works()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Add_work fw = new Add_work())
            {
                fw.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void UC_Works_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * from tblWorks where is_assigned = 0",dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(workId !=null)
            {
                using (Form_AssignWork fw = new Form_AssignWork())
                {
                    fw.workId = workId;
                    fw.workTitle = title;
                    fw.TsAmount = TsAmount;
                    fw.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }

        private string workId, title, TsAmount;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                workId = item.Cells[0].Value.ToString();
                title = item.Cells[1].Value.ToString();
                TsAmount = item.Cells[2].Value.ToString();
            }
        }
    }
}
