using BusinessObject;
using DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private ManagementContext _managementContext = new ManagementContext();
        public void InitAdmin()
        {
            TblMember admin = _managementContext.GetDefaultUser();
            TblMember flag = GetByEmail(admin.Email);
            if (flag == null)
            {
                Create(admin);

            }
        }
        public void Create(TblMember member)
        {
            var list = GetList();
            if (list.Count > 0)
            {
                var last = list[list.Count - 1];
                member.MemberId = last.MemberId + 1;
            }
            else
            {
                member.MemberId = 1;
            }
            _managementContext.TblMembers.Add(member);
            _managementContext.SaveChanges();

        }

        public void Delete(TblMember member)
        {
            _managementContext.TblMembers.Remove(member);
            _managementContext.SaveChanges();
        }

        public TblMember? GetByEmail(string email)
        {
            TblMember member = _managementContext.TblMembers.FirstOrDefault(x => email.Equals(x.Email));
            return member;
        }

        public TblMember? GetById(int memberId)
        {
            TblMember member = _managementContext.TblMembers.FirstOrDefault(x => x.MemberId == memberId);
            return member;
        }

        public List<TblMember> GetList()
        {
            List<TblMember> list = _managementContext.TblMembers.ToList();
            return list;
        }

        public void Update(TblMember member)
        {
            int memberId = member.MemberId;
            TblMember newMember = GetById(memberId);
            if (newMember != null)
            {
                newMember.Email = member.Email;
                newMember.City = member.City;
                newMember.Country = member.Country; 
                newMember.Password = member.Password;
                newMember.CompanyName = member.CompanyName;

                _managementContext.SaveChanges();
            }

        }
    }
}
