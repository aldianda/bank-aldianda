using System;
using Bank_Aldi.Data;
using Bank_Aldi.Models;

namespace Bank_Aldi.Repositories
{
	public class CustomerRepository : IRepository<Customer, string>
	{
        private readonly ApplicationDbContext _context;
		public CustomerRepository(ApplicationDbContext context) 
		{
            _context = context;
		}

        public int Delete(string key)
        {
            var result = _context.Customers.Find(key);
            if (result != null)
            {
                result.isDelete = true;
                _context.Entry(result).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            }
            return _context.SaveChanges();
        }

        public IEnumerable<Customer> Get()
        {
            return _context.Customers.Where(x=>x.isDelete == false).ToList();
        }

        public IEnumerable<Customer> History()
        {
            return _context.Customers.ToList();
        }

        public Customer Get(string key)
        {
            var result = _context.Customers.Find(key);
            if(result != null)
            {
                return result;
            }
            throw new Exception("Not Found");
        }

        public int Insert(Customer entity)
        {
            _context.Customers.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(String Key, Customer entity)
        {
            var result = Get(Key);
            if(result != null)
            {
                result.PhoneNumber = entity.PhoneNumber;
                result.FirstName = entity.FirstName;
                result.LastName = entity.LastName;
                _context.Entry(result).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            return _context.SaveChanges();
        }
    }
}

