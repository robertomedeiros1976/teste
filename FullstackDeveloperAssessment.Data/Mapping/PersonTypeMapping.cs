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

			builder.HasMany(p => p.PersonPersonTypes)
				.WithOne(p => p.PersonType)
				.HasForeignKey(p => p.PersonTypeId);

			builder.Property(p => p.Description)
				.IsRequired()
				.HasMaxLength(30);
		}
	}
}
