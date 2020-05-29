using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public static class DatabaseInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasData(
                    new Person
                    {
                        Id = 1,
                        Firstname = "Margot",
                        Lastname = "Robbie"
                    },
                    new Person
                    {
                        Id = 2,
                        Firstname = "Leonardo",
                        Lastname = "Dicaprio"
                    },
                    new Person
                    {
                        Id = 3,
                        Firstname = "Brad",
                        Lastname = "Pitt"
                    },
                    new Person
                    {
                        Id = 4,
                        Firstname = "Quentin",
                        Lastname = "Tarantino"
                    }
                );

            modelBuilder.Entity<Genre>()
                .HasData(
                    new Genre
                    {
                        Id=1,
                        Name = "Action"
                    },
                    new Genre
                    {
                        Id = 2,
                        Name = "Adventure"
                    },
                    new Genre
                    {
                        Id = 3,
                        Name = "Comedy"
                    },
                    new Genre
                    {
                        Id = 4,
                        Name = "Crime"
                    },
                    new Genre
                    {
                        Id = 5,
                        Name = "Drama"
                    }
                );
        }
    }
}
