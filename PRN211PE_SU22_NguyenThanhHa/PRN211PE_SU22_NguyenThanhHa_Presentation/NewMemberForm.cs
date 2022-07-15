using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211PE_SU22_NguyenThanhHa_Presentation
{
    public partial class NewMemberForm : Form
    {
        private TblMember _loginMember;
        private MemberRepository _memberRepository;
        private formMemberV2 _memberV2;
        public NewMemberForm(TblMember loginMember, formMemberV2 formMemberV2)
        {
            InitializeComponent();
            _loginMember = loginMember;
            _memberRepository = new MemberRepository();
            _memberV2 = formMemberV2;
        }

        private void NewMemberForm_Load(object sender, EventArgs e)
        {
            txtMemberId.Text = "Auto Generated";
            txtMemberId.ReadOnly = true;

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            TblMember member = new TblMember();

            member.Password = txtPassword.Text.Trim();
            member.Email = txtEmail.Text.Trim();
            member.CompanyName = txtCompanyName.Text.Trim();
            member.City = txtCity.Text.Trim();
            member.Country = txtCountry.Text.Trim();

            try
            {
                if (_memberRepository.GetByEmail(member.Email) != null)
                {
                    throw new ArgumentException("Email is duplicated!");
                }
                _memberRepository.Create(member);
                _memberV2.loadMemberForm();
                this.DialogResult = DialogResult.OK;
            } catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Notification");
            }
        }
    }
}
