using Interns_Gate.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Interns_Gate.Data;

public class ApplicationDbContext : IdentityDbContext
{



    public virtual DbSet<Clinical_case> Clinical_case { get; set; }
    public virtual DbSet<Clinical_status> clinical_status { get; set; }
    
    public virtual DbSet<Intern_cases> Intern_cases { get; set; }
     public virtual DbSet<Quality> quality { get; set; }
         public virtual DbSet<Quality_detials> quality_detials { get; set; }
             public virtual DbSet<Quantity> quantity { get; set; }
       public virtual DbSet<Rotation> Rotation { get; set; }    
           public virtual DbSet<Teeth> Teeth { get; set; }    

           public virtual DbSet<Supervisor_intern> supervisor_intern { get; set; }
  
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);
    


        //modelBuilder.Entity<quality_detials>()
        //      .HasKey(m => new { m.m_type, m.M_ID });
    }
}

