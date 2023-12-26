using BlazorSozluk.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Infrastructure.Persistence.EntityConfigurations
{
    public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity  //BsseEntity'deki 
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);                                  //Id Key olsun
            builder.Property(i => i.Id).ValueGeneratedOnAdd();         //Save işlemi olmadan önce id generate edilsin 
            builder.Property(i=> i.CreateDate).ValueGeneratedOnAdd();
        }
    }
}
