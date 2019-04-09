using FullstackDeveloperAssessment.Domain.Entyties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullstackDeveloperAssessment.Data.Mapping
{
	public class PersonAddressMapping : IEntityTypeConfiguration<PersonAddress>
	{
		public void Configure(EntityTypeBuilder<PersonAddress> builder)
		{
			builder.HasKey(p => p.Id);

			builder.HasOne(p => p.Person)
				.WithOne(p => p.PersonAddress)				
				.IsRequired();

			builder.Property(p => p.Address)
				.IsRequired()
				.HasMaxLength(50);

			builder.Property(p => p.City)
				.IsRequired()
				.HasMaxLength(30);

			builder.Property(p => p.StateProvinceRegion)
				.IsRequired()
				.HasMaxLength(50);

			builder.Property(p => p.PostalZipCode)
				.IsRequired()
				.HasMaxLength(10);

			builder.Property(p => p.Country)
				.IsRequired()
				.HasMaxLength(30);				
		}
	}
}
