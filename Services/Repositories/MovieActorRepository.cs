using DAL.Context;
using DAL.Entities;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class MovieActorRepository :RepositoryBase<MovieActor>,IMovieActorRepository
    {
        public MovieActorRepository(MovieDBContext movieDBContext) : base(movieDBContext) {}
    }
}
