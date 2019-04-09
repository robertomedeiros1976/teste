using FullstackDeveloperAssessment.Domain.Entyties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullstackDeveloperAssessment.Data.Mapping
{
	public class PersonPersonTypeMapping : IEntityTypeConfiguration<PersonPersonType>
	{
		public void Configure(EntityTypeBuilder<PersonPersonType> builder)
		{
			builder.HasKey(p => p.Id);

			//builder.HasOne(p => p.Person)				
			//	.WithMany(p => p.PersonTypes);

			builder.HasOne(p => p.PersonType)
				.WithMany(p => p.PersonPersonTypes);
		}
	}
}
