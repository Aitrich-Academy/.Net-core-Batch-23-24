using MVC_Exercise_Company.Interfaces;
using MVC_Exercise_Company.Models;

namespace MVC_Exercise_Company.Services
{
    public class CompanyService:ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public Company CreateCompany(Company company)
        {
            return _companyRepository.CreateCompany(company);
        }
        public Company GetCompanyById(Guid id)
        {
            return _companyRepository.GetCompanyById(id);
        }
        public Company GetCompanyByEmail(string email)
        {
          
            return _companyRepository.GetCompanyByEmail(email);
        }
    }
}
