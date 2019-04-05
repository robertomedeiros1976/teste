using FullstackDeveloperAssessment.Domain.Entyties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FullstackDeveloperAssessment.Data.Mapping
{
	public class PersonTypeMapping : IEntityTypeConfiguration<PersonType>
	{
		public void Configure(EntityTypeBuilder<PersonType> builder)
		{
			builder.HasKey(p => p.Id);

			builder.HasOne(p => p.Person)
				.WithMany(p => p.PersonTypes)
				.HasForeignKey(p => p.PersonVAT)
				.IsRequired();

			builder.Property(p => p.Description)
				.IsRequired()
				.HasMaxLength(30);
		}
	}
}
