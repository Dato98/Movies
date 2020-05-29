using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Repositories
{
    public class MovieRepository : RepositoryBase<Movie>,IMovieRepository
    {

        public MovieRepository(MovieDBContext context)
            : base(context) { }

        public Movie GetMovieWithDirector()
        {
            return Context.Movies.Include(x => x.Director).FirstOrDefault();
        }
    }
}
