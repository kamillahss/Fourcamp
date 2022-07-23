﻿using FourBlog.Areas.Identity.Data;
using FourBlog.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FourBlog.Areas.Identity.Data;

public class FourBlogContext : IdentityDbContext<Usuario>
{

    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Tag> Tags { get; set; }

    public DbSet<Comentario> Comentarios { get; set; }

    public DbSet<Postagem> Postagens { get; set; }

    public FourBlogContext(DbContextOptions<FourBlogContext> options)
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
