using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using COMP2084_Lab2.Models;

namespace COMP2084_Lab2.Data
{
    public class COMP2084_Lab2Context : DbContext
    {
        public COMP2084_Lab2Context (DbContextOptions<COMP2084_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<COMP2084_Lab2.Models.Categories>? Categories { get; set; }
    }
}
