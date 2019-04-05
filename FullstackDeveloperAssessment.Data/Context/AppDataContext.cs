using FullstackDeveloperAssessment.Data.Mapping;
using FullstackDeveloperAssessment.Domain.Entyties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Data.Context
{
	public class AppDataContext : DbContext
	{
		public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
		{

		}

		public DbSet<PersonType> PersonTypes { get; set; }
		public DbSet<PersonAddress> PersonAddresses { get; set; }
		public DbSet<Person> Persons { get; set; }		

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new PersonTypeMapping());
			modelBuilder.ApplyConfiguration(new PersonAddressMapping());
			modelBuilder.ApplyConfiguration(new PersonMapping());

			base.OnModelCreating(modelBuilder);
		}
	}
}
