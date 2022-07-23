using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projeto_FourTask.Areas.Identity.Data;
using Projeto_FourTask.Models;

namespace Projeto_FourTask.Areas.Identity.Data;

public class Projeto_FourTaskContext : IdentityDbContext<Usuario>
{
    //Criando as tabelas no BD
    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Equipe> Equipes { get; set; }

    public DbSet<Tarefa> Tarefas { get; set; }

    public Projeto_FourTaskContext(DbContextOptions<Projeto_FourTaskContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
