using System;
using Bank_Aldi.Models;
using Microsoft.EntityFrameworkCore;

namespace Bank_Aldi.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Customer> Customers { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
	}
}

