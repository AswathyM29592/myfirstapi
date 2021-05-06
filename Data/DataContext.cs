using Microsoft.EntityFrameworkCore;
using myfirstapi.Models;

namespace myfirstapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Character> Characters { get; set;}

        public DbSet<CharUser> CharUsers { get; set;}
    }
}