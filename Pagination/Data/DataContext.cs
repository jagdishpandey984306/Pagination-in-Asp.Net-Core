using Microsoft.EntityFrameworkCore;
using Pagination.Models;

namespace Pagination.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
