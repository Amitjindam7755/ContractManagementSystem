using ContractManagementSystem.UserControls;
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
    public partial class Form_Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public Form_Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;

        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addControls(UserControl uc)
        {
            panelControls.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelControls.Controls.Add(uc);
            uc.BringToFront();
        }
        private void btnAssigned_Click(object sender, EventArgs e)
        {
            UC_AssignedWorks uw = new UC_AssignedWorks();
            addControls(uw);
        }

        private void btnDashb_Click(object sender, EventArgs e)
        {
            UC_Dashboard ud = new UC_Dashboard();
            addControls(ud);
        }

        private void btnContractors_Click(object sender, EventArgs e)
        {
            UC_Contractors uc = new UC_Contractors();
            addControls(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_Works uw = new UC_Works();
            addControls(uw);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
