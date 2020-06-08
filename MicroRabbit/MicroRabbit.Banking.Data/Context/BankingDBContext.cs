using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Context
{
	public class BankingDBContext : DbContext
	{
		public BankingDBContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Account> Accounts { get; set; }
	}

	public class BankingFactory : IDesignTimeDbContextFactory<BankingDBContext>
	{
		public BankingDBContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<BankingDBContext>();
			optionsBuilder.UseSqlServer("Server= LAPTOP-DEAN8LG7\\SQLEXPRESS; Database = BankingDB;Trusted_Connection=true; MultipleActiveResultSets= true");

			return new BankingDBContext(optionsBuilder.Options);
		}
	}
}
