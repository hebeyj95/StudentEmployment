using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaconsaleMovieCollection.Models
{
    public class TaContext : DbContext
    {
        public TaContext(DbContextOptions<TaContext> options) : base(options)
        {

        }
        public DbSet<TA> tas { get; set; }
    }
}
