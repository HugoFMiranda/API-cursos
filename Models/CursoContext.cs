using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;


namespace CursosApi.Models
{
    public class CursoContext : DbContext
    {
        public CursoContext(DbContextOptions<CursoContext> options) : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }

    }
}