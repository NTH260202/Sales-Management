using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IMemberRepository
    {
        List<TblMember> GetList();
        TblMember? GetByEmail(string email);
        TblMember? GetById(int memberId);
        void Delete(TblMember member);
        void Update(TblMember member);
        void Create(TblMember member); 
    }
}
