﻿using SLRDbConnector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractManagementSystem.UserControls
{
    public partial class UC_Contractors : UserControl
    {
        DbConnector db;
        public UC_Contractors()
        {
            InitializeComponent();
            db = new DbConnector();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                DialogResult dialog = MessageBox.Show("Are you sure want to add this Contractor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    db.performCRUD("insert into tblContractors(full_name,address) values('" + txtFullName.Text + "','" + txtAddress.Text + "')");
                    MessageBox.Show("contractor added successfully... :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtFullName.Clear();
                    txtAddress.Clear();
                    this.OnLoad(e);
                }
            }
        }

        private bool isFormValid()
        {
            if (txtFullName.Text.Trim() == string.Empty || label6.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill All Required Fields", "Required fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }


        private void UC_Contractors_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * from tblContractors", dataGridView1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            if (cmbSearchBy.SelectedItem.ToString().Equals("ID"))
            {
                query = "select * from tblContractors where id = '" + txtSearch.Text + "'";
            }
            else if (cmbSearchBy.SelectedValue.Equals("Name")) 
                {
                    query = "select * from tblContractors where full_name like '%" + txtSearch.Text + "%'";
                }
            else if (cmbSearchBy.SelectedValue.Equals("Address"))
            {
                query = "select * from tblContractors where address like '%" + txtSearch.Text + "%'";
            }
            db.fillDataGridView(query,dataGridView1);

            if (txtSearch.Text =="")
            {
                this.OnLoad(e);
            }
        }

        string contractorId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                contractorId = item.Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure want to delete this Contractor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (!contractorId.Equals(string.Empty))
                {
                    db.performCRUD("delete from tblContractors where id = '" + contractorId + "'");
                    MessageBox.Show("Contractor deleted successfully");
                    this.OnLoad(e);
                }
            }
            
        }
    }
}
