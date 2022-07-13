using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211PE_SU22_NguyenThanhHa_Presentation
{
    public partial class MainNotMDIForm : Form
    {
        TblMember loginMember;
        public MainNotMDIForm(TblMember member)
        {
            InitializeComponent();
            loginMember = member;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelEmail.Text = $"Account {loginMember.Email}";
        }

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new MemberForm(loginMember);
            form.ShowDialog();
            this.Close();
        }
    }
}
