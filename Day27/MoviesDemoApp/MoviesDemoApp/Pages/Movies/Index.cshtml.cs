using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesDemoApp.Data;
using MoviesDemoApp.Model;

namespace MoviesDemoApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MoviesDemoApp.Data.MoviesDemoAppContext _context;

        public IndexModel(MoviesDemoApp.Data.MoviesDemoAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
