using MVC_Exercise_Company.Interfaces;
using MVC_Exercise_Company.Models;
using System;
using System.Collections.Generic;

namespace MVC_Exercise_Company.Services
{
    public class CompanyMemberService : ICompanyMemberService
    {
        private readonly ICompanyMemberRepository _companyMemberRepository;

        public CompanyMemberService(ICompanyMemberRepository companyMemberRepository)
        {
            _companyMemberRepository = companyMemberRepository;
        }
        public CompanyMember AddMemberToCompany(CompanyMember member)
        {
            return _companyMemberRepository.AddMemberToCompany(member);
        }

        public IEnumerable<CompanyMember> GetMembersByCompanyId(Guid companyId)
        {
            return _companyMemberRepository.GetMembersByCompanyId(companyId);
        }

        public void RemoveMember(Guid memberId)
        {
            _companyMemberRepository.RemoveMember(memberId);
        }
        public CompanyMember GetMemberById(Guid memberId)
        {
            var members = _companyMemberRepository.GetMembersByCompanyId(Guid.Empty); // Fetch all members
            foreach (var member in members)
            {
                if (member.MemberId == memberId)
                    return member;
            }
            return null;
        }
        //public IEnumerable<CompanyMember> GetAllMembers()
        //{
        //    return _companyMemberRepository.GetMembersByCompanyId(Guid.Empty); // Fetch all members
        //}
    }

}
