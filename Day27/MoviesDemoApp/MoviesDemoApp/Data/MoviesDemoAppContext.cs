using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesDemoApp.Model;

namespace MoviesDemoApp.Data
{
    public class MoviesDemoAppContext : DbContext
    {
        public MoviesDemoAppContext (DbContextOptions<MoviesDemoAppContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesDemoApp.Model.Movie> Movie { get; set; } = default!;
    }
}
