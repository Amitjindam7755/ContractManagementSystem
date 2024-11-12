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
    public partial class UC_AssignedWorks : UserControl
    {
        DbConnector db;
        public UC_AssignedWorks()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void UC_AssignedWorks_Load(object sender, EventArgs e)
        {
           db.fillDataGridView("select wa.id,w.title as 'Work Title', c.full_name as 'Contractor Name',wa.ca_cost as 'CA Cost',wa.assigned_date as 'Assigned Date',wa.year from tblWorkAssigned as wa inner join tblWorks as w on wa.Work_id = w.id inner join tblContractors as c ON wa.contractor_id = c.id where w.is_assigned = 1 and wa.is_completed =0", dataGridView1);          
        }

        string workAssignId, title, contractorName, CACost;

        private void button1_Click(object sender, EventArgs e)
        {
            if(workAssignId != null)
            {
                using (Form_AddWorkDone wd = new Form_AddWorkDone())
                {
                    wd.WorkTitle = title;
                    wd.ContractorName = contractorName;
                    wd.CACost = CACost;
                    wd.WorkAssignId = workAssignId;
                    wd.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                workAssignId = item.Cells[0].Value.ToString();
                title = item.Cells[1].Value.ToString();
                contractorName = item.Cells[2].Value.ToString();
                CACost = item.Cells[3].Value.ToString();
            }
        }
    }
}
