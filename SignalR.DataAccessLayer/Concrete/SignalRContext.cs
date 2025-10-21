using Microsoft.EntityFrameworkCore;
using SignalR.EntityLayer.DAL.Entities;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Concrete
{
    public class SignalRContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=LAPTOP-KIO0LAGV\\SQLEXPRESS;Initial Catalog=SignalRDb;Integrated Security=true;TrustServerCertificate=true");
            optionsBuilder.UseSqlServer("Server=DESKTOP-ECFLAF2;Initial Catalog=SignalRDb;Integrated Security=true;TrustServerCertificate=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
