using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StorageApi.Models;

namespace StorageApi.Data
{
    public class StorageApiContext : DbContext
    {
        public StorageApiContext (DbContextOptions<StorageApiContext> options)
            : base(options)
        {
        }

        public DbSet<StorageApi.Models.Product> Product { get; set; } = default!;
    }
}
