using BusinessObject;
using DataAccess.IRepository;
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
    public partial class MemberForm : Form
    {
        private TblMember loginMember;
        private IMemberRepository memberRepository;
        private string function;
        public MemberForm(TblMember member)
        {
            InitializeComponent();
            loginMember = member;
            memberRepository = new MemberRepository();
        }

        //tblMemberBindingSource 
        private void MemberForm_Load(object sender, EventArgs e)
        {
            if (loginMember.Email == "admin@fstore.com")
            {

                loadMember();
                FieldAccess(false);
                BtnAccess(false);

            }
            else
            {
                tblMemberBindingSource.DataSource = loginMember;
                FieldAccess(false);
                BtnAccess(false);
            }
        }

        private void FieldAccess(Boolean check)
        {
            txtMemberId.Enabled = check;
            txtPassword.Enabled = check;
            txtEmail.Enabled = check;
            txtCompanyName.Enabled = check;
            txtCity.Enabled = check;
            txtCountry.Enabled = check;
        }

        private void BtnAccess(Boolean check)
        {
            btnEdit.Enabled = check;
            btnSave.Enabled = check;
            btnDelete.Enabled = check;
        }

        private void loadMember()
        {
            tblMemberBindingSource.DataSource = memberRepository.GetList();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FieldAccess(true);
            btnSave.Enabled = true;
            txtEmail.Enabled=false;
            txtMemberId.Enabled=false;
            function = "Edit";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            try
            {
                if (loginMember.Email == txtEmail.Text.Trim())
                {
                    throw new Exception("Admin can not be edited!");
                }
                if (!emailRegex.IsMatch(txtEmail.Text.Trim()))
                {
                    throw new Exception("Invalid email format!");
                }
                TblMember member = new TblMember();
                try
                {
                    member.MemberId = int.Parse(txtMemberId.Text.Trim());
                }
                catch (Exception ex)
                {
                    member.MemberId = 0;
                }

                member.Password = txtPassword.Text.Trim();
                member.Email = txtEmail.Text.Trim();
                member.CompanyName = txtCompanyName.Text.Trim();
                member.City = txtCity.Text.Trim();
                member.Country = txtCountry.Text.Trim();

                switch (function)
                {
                    case "Add":
                        {
                            if (memberRepository.GetByEmail(txtEmail.Text) != null)
                            {
                                throw new Exception("Duplicated Email!");
                            }
                            memberRepository.Create(member);
                            loadMember();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            break;
                        }
                    case "Edit":
                        {

                            memberRepository.Update(member);
                            loadMember();
                            MessageBox.Show("Sửa thành công", "Thông báo");
                            break;
                        }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FieldAccess(true);
            btnSave.Enabled = true;
            txtMemberId.Text = "Auto Generated";
            txtMemberId.ReadOnly = true;
            function = "Add";
        }

        private void memberGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void memberGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex < 0 || rowindex >= memberGridView.Rows.Count)
                {
                    throw new Exception("Chưa chọn đúng thông tin");
                }
                txtMemberId.Text = memberGridView.Rows[rowindex].Cells["MemberIdColumn"].Value.ToString();
                txtPassword.Text = memberGridView.Rows[rowindex].Cells["PasswordColumn"].Value.ToString();
                txtEmail.Text = memberGridView.Rows[rowindex].Cells["EmailColumn"].Value.ToString();
                txtCompanyName.Text = memberGridView.Rows[rowindex].Cells["CompanyNameColumn"].Value.ToString();
                txtCity.Text = memberGridView.Rows[rowindex].Cells["CityColumn"].Value.ToString();
                txtCountry.Text = memberGridView.Rows[rowindex].Cells["CountryColumn"].Value.ToString();

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
