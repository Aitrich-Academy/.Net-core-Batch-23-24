using MVC_Exercise_Company.Data;
using MVC_Exercise_Company.Interfaces;
using MVC_Exercise_Company.Models;

namespace MVC_Exercise_Company.Repository
{
    public class CompanyRepository:ICompanyRepository
    {
        private readonly AppDbContext _context;
        public CompanyRepository(AppDbContext context)
        {
            _context = context;
        }
        public Company CreateCompany(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
            return company;
        }
        public Company GetCompanyById(Guid id)
        {
            return _context.Companies.FirstOrDefault(c => c.CompanyId == id);
        }
        public Company GetCompanyByEmail(string email)
        {
            return _context.Companies.FirstOrDefault(c => c.Email == email);
        }
    }
}
