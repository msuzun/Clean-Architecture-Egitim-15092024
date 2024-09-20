using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecute.Persistance.Configurations
{
    public sealed class ErrorLogConfiguration : IEntityTypeConfiguration<ErrorLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ErrorLog> builder)
        {
            builder.ToTable("ErrorLogs");
        }
    }
}
