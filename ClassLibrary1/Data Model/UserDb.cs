namespace ClassLibrary1
{
    using Data_Model;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public partial class UserDb : DbContext
    {
        public UserDb()
            : base("UserDb")
        {
        }

        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
