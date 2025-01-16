using Education.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.DAL.Configurations
{
    public class NewsConfigurations : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasOne(x=> x.Category)
                .WithMany(x=> x.News)
                .HasForeignKey(x=> x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
