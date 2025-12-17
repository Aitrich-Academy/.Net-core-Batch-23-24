using MVC_Exercise_Company.Data;
using MVC_Exercise_Company.Interfaces;
using MVC_Exercise_Company.Models;

namespace MVC_Exercise_Company.Repository
{
    public class CompanyMemberRepository: ICompanyMemberRepository
    {
        private readonly AppDbContext _context;
        public CompanyMemberRepository(AppDbContext context)
        {
            _context = context;
        }
        public CompanyMember AddMemberToCompany(CompanyMember member)
        {
            if (member == null)
                throw new ArgumentNullException(nameof(member));

            _context.CompanyMembers.Add(member);
            _context.SaveChanges();

            return member; // return the added member
        }

        public IEnumerable<CompanyMember> GetMembersByCompanyId(Guid companyId)
        {
            return _context.CompanyMembers.Where(m => m.CompanyId == companyId).ToList();
        }
        public void RemoveMember(Guid memberId)
        {
            var member = _context.CompanyMembers.Find(memberId);
            if (member != null)
            {
                _context.CompanyMembers.Remove(member);
                _context.SaveChanges();
            }
        }
        public CompanyMember GetMemberById(Guid memberId)
        {
            return _context.CompanyMembers.Find(memberId);
        }
        //public IEnumerable<CompanyMember> GetAllMembers()
        //{
        //    return _context.CompanyMembers.ToList();
        //}

    }
}
