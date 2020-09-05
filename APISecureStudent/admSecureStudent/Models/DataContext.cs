namespace admSecureStudent.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<admSecureStudent.Models.Student> Students { get; set; }
    }
}