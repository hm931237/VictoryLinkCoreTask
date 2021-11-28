using Microsoft.EntityFrameworkCore;
using SqlProvider.Entities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SqlProvider.Context
{
    public class TaskContext: DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {

        }
        public DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
