using DAL.Context;
using DAL.Entities;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class MovieGenreRepository : RepositoryBase<MovieGenre>,IMovieGenreRepository
    {
        public MovieGenre(MovieDBContext movieDBContext) : base(movieDBContext) { }
    }
}
