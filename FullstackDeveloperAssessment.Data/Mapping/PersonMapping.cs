using FullstackDeveloperAssessment.Domain.Entyties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Data.Mapping
{
	public class PersonMapping : IEntityTypeConfiguration<Person>
	{
		public void Configure(EntityTypeBuilder<Person> builder)
		{
			builder.HasKey(p => p.VAT);							

			builder.Property(p => p.Name)
				.IsRequired()
				.HasMaxLength(50);

			builder.Property(p => p.DateOfBirth)
				.IsRequired();

			builder.Property(p => p.Gender)
				.IsRequired();

			builder.Property(p => p.SecretCode)
				.IsRequired();
		}
	}
}
