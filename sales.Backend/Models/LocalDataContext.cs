namespace sales.Backend.Models
{
    using Domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<sales.Common.Models.Product> Products { get; set; }
    }
}