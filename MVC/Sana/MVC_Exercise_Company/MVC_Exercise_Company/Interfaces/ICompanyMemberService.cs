using MVC_Exercise_Company.Migrations;
using MVC_Exercise_Company.Models;

namespace MVC_Exercise_Company.Interfaces
{
    public interface ICompanyMemberService
    {
        CompanyMember AddMemberToCompany(CompanyMember member);
        IEnumerable<CompanyMember> GetMembersByCompanyId(Guid companyId);
        void RemoveMember(Guid memberId);
        CompanyMember GetMemberById(Guid memberId);
        //IEnumerable<CompanyMember> GetAllMembers();

    }

    
}
