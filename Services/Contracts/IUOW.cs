using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IUOW :IDisposable
    {
        IMovieRepository Movie { get;}
        IGenreRepository Genre { get; }
        IMovieActorRepository MovieActor { get; }
        IMovieGenreRepository MovieGenre { get; }
        IPersonRepository Person { get; }
        IUserRatesRepository UserRates { get; }
        IUserRepository User { get; }
        void Commit();
    }
}
