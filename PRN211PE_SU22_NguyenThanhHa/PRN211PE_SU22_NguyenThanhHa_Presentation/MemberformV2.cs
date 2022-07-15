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
            gridMember.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void formMemberV2_Load(object sender, EventArgs e)
        {
            btnClose.Enabled = true;
            btnDelete.Enabled = true;
            btnNew.Enabled = true;
            tblMemberBindingSource.DataSource = _memberRepository.GetList();
        }

        public void loadMemberForm()
        {
            tblMemberBindingSource.DataSource = _memberRepository.GetList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form newMemberForm = new NewMemberForm(_loginMember, this);
            newMemberForm.ShowDialog();
            //this.Show();
        }

        private void gridMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            TblMember editMember = new TblMember();
            editMember.MemberId = Convert.ToInt32(gridMember.Rows[rowindex].Cells["MemberIdColumn"].Value.ToString());
            editMember.Password = gridMember.Rows[rowindex].Cells["PasswordColumn"].Value.ToString();
            editMember.Email = gridMember.Rows[rowindex].Cells["EmailColumn"].Value.ToString();
            editMember.CompanyName = gridMember.Rows[rowindex].Cells["CompanyNameColumn"].Value.ToString();
            editMember.City = gridMember.Rows[rowindex].Cells["CityColumn"].Value.ToString();
            editMember.Country = gridMember.Rows[rowindex].Cells["CountryColumn"].Value.ToString();
            Form editMemberForm = new EditMemberForm(_loginMember, editMember);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                int indexSelectedRow = gridMember.SelectedRows[0].Index;
                int deletedMemberId = Convert.ToInt32(gridMember.Rows[indexSelectedRow].Cells["MemberIdColumn"].Value.ToString());
                TblMember deletedMember = _memberRepository.GetById(deletedMemberId);
                _memberRepository.Delete(deletedMember);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please choose a row!", "Notification");
            }
            finally
            {
                loadMemberForm();
            }
            
        }
    }
}
