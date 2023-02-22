using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mission8_covey.Models
{
    public class TaskContext : DbContext
    {
        // constructor

        public TaskContext (DbContextOptions<TaskContext> options) : base (options)
        {
            // leave blank for now
        }

        public DbSet<TaskResponse> Responses { get; set; }

        internal void Update(TaskResponse mfr)
        {
            throw new NotImplementedException();
        }

        //protected override void OnModelCreating(ModelBuilder mb)
        //{
        //    mb.Entity<TaskResponse>().Has
        //}
    }
}
