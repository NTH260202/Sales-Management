using BusinessObject;
using DataAccess.Repository;
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
    public partial class formMemberV2 : Form
    {
        private MemberRepository _memberRepository;
        private TblMember _loginMember;
        public formMemberV2(TblMember loginMember)
        {
            InitializeComponent();
            _memberRepository = new MemberRepository();
            _loginMember = loginMember;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void formMemberV2_Load(object sender, EventArgs e)
        {
            tblMemberBindingSource.DataSource = _memberRepository.GetList();
        }
    }
}
