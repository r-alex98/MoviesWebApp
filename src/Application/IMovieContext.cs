﻿using System.Threading.Tasks;
using Application.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Application
{
    public interface IMovieContext
    {
        DbSet<Movie> Movies { get; set; }
        DbSet<Person> People { get; set; } 
        DbSet<Genre> Genres { get; set; }
        DbSet<Employee> Crew { get; set; }
        DbSet<Role> Cast { get; set; }
        DbSet<Credit> Credits { get; set; }
        DbSet<Folder> Folders { get; set; }
        DbSet<MovieFolder> MovieFolders { get; set; }   
        DbSet<Vote> Votes { get; set; }
        DbSet<SearchItem> SearchItems { get; set; }

        IDbContextTransaction BeginTransaction();   
        void CommitTransaction();       
        Task<int> SaveChangesAsync();     
    }
}
