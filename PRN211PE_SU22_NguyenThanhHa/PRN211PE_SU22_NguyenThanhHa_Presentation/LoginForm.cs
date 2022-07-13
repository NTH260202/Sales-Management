using BusinessObject;
using DataAccess.IRepository;
using DataAccess.Repository;

namespace PRN211PE_SU22_NguyenThanhHa_Presentation
{
    public partial class LoginForm : Form
    {
        private ManagementContext _managementContext;
        //private IMemberRepository memberRepository;
        public LoginForm()
        {
            InitializeComponent();
            _managementContext = new ManagementContext();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                TblMember member = _managementContext.TblMembers.Where(m => m.Email == username).FirstOrDefault();
                if (member == null || member.Password != password)
                {
                    throw new Exception("Username or Password is wrong!");
                }
                this.Hide();
                Form frmmain = new MainNotMDIForm(member);
                frmmain.ShowDialog();
                this.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }
    }
}