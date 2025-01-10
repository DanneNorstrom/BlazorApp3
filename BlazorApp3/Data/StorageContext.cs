
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp3.Models;

    namespace BlazorApp3.Data
    {
        public class StorageContext : DbContext
        {
            public StorageContext(DbContextOptions<StorageContext> options)
                : base(options)
            {
            }

            public DbSet<Machine> Machine { get; set; } = default!;
            //public DbSet<Storage.Models.ProductViewModel> ProductViewModel { get; set; } = default!;
        }
    }

