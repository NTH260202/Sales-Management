using DataAccess.Repository;

namespace PRN211PE_SU22_NguyenThanhHa_Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            MemberRepository memberRepository = new MemberRepository();
            memberRepository.InitAdmin();
            Application.Run(new LoginForm());
        }
    }
}