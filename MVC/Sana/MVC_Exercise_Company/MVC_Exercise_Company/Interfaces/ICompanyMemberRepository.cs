using MVC_Exercise_Company.Models;

namespace MVC_Exercise_Company.Interfaces
{
    public interface ICompanyMemberRepository
    {
        CompanyMember AddMemberToCompany(CompanyMember member);
        IEnumerable<CompanyMember> GetMembersByCompanyId(Guid companyId);
        void RemoveMember(Guid memberId);
        CompanyMember GetMemberById(Guid memberId);
        //IEnumerable<CompanyMember> GetAllMembers();
    }
}
