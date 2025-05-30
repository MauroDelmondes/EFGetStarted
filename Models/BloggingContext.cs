using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    
    public string DbPath { get; set; }

    public BloggingContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "Blogging.db");
    }

    //The following configures EF to create a Sqlite database file in the special "local" folder for your platform.

    protected override void OnConfiguring(DbContextOptionBuilder options)
        => options.UseSqlite($"Data source={DbPath}");    
}