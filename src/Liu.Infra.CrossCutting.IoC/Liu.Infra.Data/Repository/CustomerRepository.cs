using System.Linq;
using Liu.Domain.Interfaces;
using Liu.Domain.Models;
using Liu.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Liu.Infra.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(EquinoxContext context)
            : base(context)
        {

        }

        public Customer GetByEmail(string email)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Email == email);
        }
    }
}
