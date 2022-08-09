using Microsoft.EntityFrameworkCore;


namespace FuncionariosCRUD.Models
{
    public class FuncDbContext : DbContext
    {
        public FuncDbContext(DbContextOptions<FuncDbContext> options) : base(options)
        {

        }
        public DbSet<Funcionario> funcionarios { get; set; } = null!;
    }
}
