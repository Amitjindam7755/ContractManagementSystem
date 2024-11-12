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

namespace ContractManagementSystem.Forms
{
    public partial class Form_AddWorkDone : Form
    {
        public string WorkAssignId { get; set; }
        public string WorkTitle { get; set; }
        public string ContractorName { get; set; }
        public string CACost { get; set; }

        DbConnector db;

        public Form_AddWorkDone()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtWorkDone.Text.Trim() == string.Empty || double.Parse(txtWorkDone.Text) == 0)
            {
                MessageBox.Show("Please Add Work Done By the Contractor.", "Work Done Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(double.Parse(txtWorkDone.Text) > double.Parse(lblToBeDone.Text))
            {
                MessageBox.Show("Cannot Add Work Done Greater than Work to be Done..!!", "Work Done is Greater than Work to be Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string WorkDone = db.getSingleValue("select work_done_amount from tblCalculations where work_assign_id ='"+WorkAssignId+"'", out WorkDone, 0);
                double newWorkDone = double.Parse(txtWorkDone.Text) + double.Parse(WorkDone);

                string tobePaid = db.getSingleValue("select payable_amount from tblCalculations where work_assign_id ='" + WorkAssignId + "'", out tobePaid, 0);
                double newPayableAmount = double.Parse(txtWorkDone.Text) + double.Parse(tobePaid);

                double workTobeDone = double.Parse(lblToBeDone.Text) - double.Parse(txtWorkDone.Text);

                db.performCRUD("insert into tblCalculationData(work_assign_id,work_done,payable_amount,work_to_be_done,paid_amount) values('" + WorkAssignId + "','" + newWorkDone + "','" + newPayableAmount + "','" + workTobeDone + "',0)");

                db.performCRUD("update tblCalculations set work_done_amount = '"+newWorkDone+ "',payable_amount = '"+newPayableAmount+ "',WorkToBeDone ='"+workTobeDone+"' where work_assign_id ='" + WorkAssignId + "'");
                MessageBox.Show("Record Added Successfully... :)","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                this.Dispose();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_AddWorkDone_Load(object sender, EventArgs e)
        {
            lblTitle.Text = WorkTitle;
            lblName.Text = ContractorName;
            string workToBeDone = db.getSingleValue("select WorkToBeDone from tblCalculations where work_assign_id ='"+WorkAssignId+"' ", out workToBeDone, 0);
            lblToBeDone.Text = workToBeDone;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
