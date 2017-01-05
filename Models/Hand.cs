using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations; 

namespace RaiseYourHand.Models {
    public class Hand
    {
        [Key]
        public int HandNo { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }
    }

    public class HandDbContext : DbContext  
    {
        public HandDbContext(DbContextOptions<HandDbContext> options)
            : base(options)
        { }

        public DbSet<Hand> Hands { get; set; }

    }

}