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

        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<TaskResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; } // lets us reference categories in the controller

        //internal void Update(TaskResponse mfr)
        //{
        //    throw new NotImplementedException();
        //}

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Home" },
                new Category { CategoryID = 2, CategoryName = "School" },
                new Category { CategoryID = 3, CategoryName = "Work" },
                new Category { CategoryID = 4, CategoryName = "Church" }
            );

            mb.Entity<TaskResponse>().HasData(
                new TaskResponse
                {
                    TaskId = 1,
                    CategoryID = 1,
                    Task = "Buy Food",
                    dueDate = new DateTime(2023, 2, 23),
                    quadrant = 2,
                    completed = false
                }
            );
        }
    }
}
