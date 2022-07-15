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
    public partial class EditMemberForm : Form
    {
        private TblMember _loginMember;
        private TblMember _editMember;
        private MemberRepository _memberRepository;
        public EditMemberForm(TblMember loginMember, TblMember editMember)
        {
            InitializeComponent();
            _loginMember = loginMember;
            _editMember = editMember;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TblMember member = new TblMember();
            
            member.MemberId = Convert.ToInt32(txtMemberId.Text);
            member.Password = txtPassword.Text.Trim();
            member.Email = txtEmail.Text.Trim();
            member.CompanyName = txtCompanyName.Text.Trim();
            member.City = txtCity.Text.Trim();
            member.Country = txtCountry.Text.Trim();
            _memberRepository.Update(member);
        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            txtMemberId.Text = _editMember.MemberId.ToString();
            txtPassword.Text = _editMember.Password.ToString();
            txtEmail.Text = _editMember.Email.ToString();
            txtCountry.Text = _editMember.Country.ToString();
            txtCompanyName.Text = _editMember.CompanyName.ToString();
            txtCity.Text = _editMember.City.ToString();
            txtPassword.ReadOnly = true;
            txtMemberId.ReadOnly = true;
        }
    }
}
