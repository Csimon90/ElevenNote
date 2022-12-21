using ElevenNote.Data.Entities;
using Microsoft.EntityFrameworkCore;
using ElevenNote.Data;

    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }   
    public DbSet<UserEntity> Users {get; set;}
}