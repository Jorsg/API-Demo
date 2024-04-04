using System;
using System.Collections.Generic;
using DemoAPI.Common.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Common.Data;

public partial class AgendaDbContext : DbContext
{
    public AgendaDbContext()
    {
    }

    public AgendaDbContext(DbContextOptions<AgendaDbContext> options)
        : base(options)
    {
    }

	public DbSet<User> User { get; set; }
	public DbSet<Event> Agenda { get; set; }
	public DbSet<Model.Task> Task { get; set; }
	protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("User");
        modelBuilder.Entity<Event>().ToTable("Event");
        modelBuilder.Entity<Model.Task>().ToTable("Task");
    }


   
}
