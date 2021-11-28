using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SqlProvider.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlProvider.Config
{
    public class RequestConfiguration: IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.Property(I => I.RequestId).IsRequired();
            builder.Property(P => P.MobileNumber).IsRequired();
            builder.Property(D => D.RequestDate).IsRequired();
        }
    }
}
