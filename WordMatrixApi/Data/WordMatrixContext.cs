using Microsoft.EntityFrameworkCore;
using WordMatrixApi.Models;

namespace WordMatrixApi.Data
{
    public class WordMatrixContext : DbContext
    {
        public WordMatrixContext(DbContextOptions<WordMatrixContext> options)
        : base(options)
        {
        }

        public DbSet<Glossary> Glossary { get; set; }
    }
}
