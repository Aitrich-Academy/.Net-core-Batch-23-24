using MVC_Exercise_Company.Models;

namespace MVC_Exercise_Company.Interfaces
{
    public interface ICompanyRepository
    {
      Company CreateCompany(Company company);
       Company GetCompanyById(Guid id);
       Company GetCompanyByEmail(string email);
    }
}
