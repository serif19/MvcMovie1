using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = (localdb)\\MSSQLLocalDB ; database = MvcMovieContext-e4c420c3-89f9-44d3-b941-2023000c6b91 ; integrated security = true ; ");


        }
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options) : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
