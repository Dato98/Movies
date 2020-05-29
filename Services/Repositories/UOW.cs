using DAL.Context;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repositories
{
    public class UOW : IUOW
    {
        private MovieDBContext Context;
        private IMovieRepository movieRepository;
        private IGenreRepository genreRepository;
        private IMovieActorRepository movieActorRepository;
        private IMovieGenreRepository movieGenreRepository;
        private IPersonRepository personRepository;
        private IUserRatesRepository userRatesRepository;
        private IUserRepository userRepository;
        public UOW(MovieDBContext context)
        {
            Context = context;
        }

        public IMovieRepository Movie
        {
            get
            {
                if (movieRepository == null)
                    movieRepository = new MovieRepository(Context);
                return movieRepository;
            }
        }

        public IGenreRepository Genre
        {
            get
            {
                if (genreRepository == null)
                    genreRepository = new GenreRepository(Context);
                return genreRepository;
            }
        }

        public IMovieActorRepository MovieActor
        {
            get
            {
                if (movieActorRepository == null)
                    movieActorRepository = new MovieActorRepository(Context);
                return movieActorRepository;
            }
        }

        public IMovieGenreRepository MovieGenre
        {
            get
            {
                if (movieGenreRepository == null)
                    movieGenreRepository = new MovieGenreRepository(Context);
                return movieGenreRepository;
            }
        }

        public IPersonRepository Person
        {
            get
            {
                if (personRepository == null)
                    personRepository = new PersonRepository(Context);
                return personRepository;
            }
        }

        public IUserRatesRepository UserRates
        {
            get
            {
                if (userRatesRepository == null)
                    userRatesRepository = new UserRatesRepository(Context);
                return userRatesRepository;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(Context);
                return userRepository;
            }
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
