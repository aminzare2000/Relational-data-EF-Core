using Microsoft.EntityFrameworkCore;
using RelationalDataEFCore.Models;
using System.Collections.Generic;

namespace RelationalDataEFCore.Data;

public class JournalEnvDbContext : DbContext
{
    public JournalEnvDbContext(DbContextOptions<JournalEnvDbContext> options)
    : base(options)
    {
    }

    public DbSet<Journal> Journals => Set<Journal>();
    public DbSet<NumberIssue> NumberIssues => Set<NumberIssue>();
    public DbSet<Article> Articles => Set<Article>();

    public DbSet<Author> Authors => Set<Author>();

    public DbSet<Organ> Organs => Set<Organ>();
}